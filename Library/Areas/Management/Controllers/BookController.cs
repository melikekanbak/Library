using Library.Context;
using Library.Dto;
using Library.Enums;
using Library.Models;
using Library.RepositoryPattern.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Library.Areas.Management.Controllers
{
    [Area("Management")]
    [Authorize(Policy = "AdminPolicy")]
    public class BookController : Controller
    {
        MyDbContext _db;
        IBookRepository _repoBook;
        IAuthorRepository _repoAuthor;
        IBookTypeRepository _repoBookType;

        public BookController(MyDbContext db, IBookRepository repoBook,IAuthorRepository repoAuthor,IBookTypeRepository repoBookType)
        {
            _db= db;
            _repoBook= repoBook;
            _repoAuthor= repoAuthor;
            _repoBookType= repoBookType;
        }
        public IActionResult BookList()
        {
            List<Book> books = _repoBook.GetBooks();
            return View(books);
        }

        public IActionResult Create()
        {
            List<AuthorDto> authors = _repoAuthor.SelectAuthorDto();
            List<BookTypeDto> bookTypes= _repoBookType.SelectBookTypeDto();
            return View((new Book(),authors,bookTypes));
        }

        [HttpPost]
        public IActionResult Create([Bind(Prefix ="Item1")] Book book)
        {
            if (!ModelState.IsValid)
            {
                List<AuthorDto> authors = _repoAuthor.SelectAuthorDto();
                List<BookTypeDto> bookTypes = _repoBookType.SelectBookTypeDto();
                return View((book, authors, bookTypes));
            }
            _repoBook.Add(book);
            return RedirectToAction("BookList","Book",new {area="Management"});
        }

        public IActionResult Edit(int id)
        {
            List<AuthorDto> authors = _repoAuthor.SelectAuthorDto();
            List<BookTypeDto> bookTypes = _repoBookType.SelectBookTypeDto();
            Book book= _repoBook.GetById(id);
            return View((book,authors,bookTypes));
        }

        [HttpPost]
        public IActionResult Edit([Bind(Prefix = "Item1")] Book book)
        {
            _repoBook.Update(book);
            return RedirectToAction("BookList");
        }

        public IActionResult Delete(int id)
        {
            _repoBook.Delete(id);
            return RedirectToAction("BookList");
        }
    }
}
