using Library.Business.Abstract;
using Library.Entity.Concrete;
using Library.MvcWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.MvcWebUI.Controllers
{
    public class BookController : Controller
    {
        IBookServices _bookService;





        public BookController(IBookServices bookService)
        {
            _bookService = bookService;
        }




        public IActionResult GetBooks()
        {
            var bookViewModel = new BookViewModel
            {
                Books = _bookService.GetList()
        
         };
            return View(bookViewModel);
         }



        public IActionResult Add(BookViewModel bookViewModel)
        {
            if (ModelState.IsValid)
            {
                var bookIsValid = _bookService.GetByName(bookViewModel.Book.Name);
                if (bookIsValid != null)
                {
                    return RedirectToAction("GetBooks");
                }
                var bookForAdd = new Book
                {
                    IsActive = true,
                    Name = bookViewModel.Book.Name,
                    CategoryId = bookViewModel.Book.CategoryId,
                    Author = bookViewModel.Book.Author,
                    Pages = bookViewModel.Book.Pages,
                   

                };
                try
                {
                    _bookService.Add(bookForAdd);
                    return RedirectToAction("GetBooks");
                }
                catch (Exception)
                {

                    return RedirectToAction("GetBooks");
                }
            }
            return RedirectToAction("GetBooks"); 
        }










        public JsonResult Edit(int id)
        {
            if (id > 0)
            {
                var result = _bookService.GetById(id);

                return Json(result);
            }
            return Json(0);
        }








        [HttpPost]
        public IActionResult Edit(BookViewModel bookViewModel)
        {
            if (ModelState.IsValid)
            {
                var bookIsValid = _bookService.GetById(bookViewModel.Book.Id);
                if (bookIsValid == null)
                {
                    return RedirectToAction("GetBooks");
                }
                var bookForUpdate = new Book
                {
                    Id = bookIsValid.Id,
                    Name = bookViewModel.Book.Name,
                    CategoryId = bookViewModel.Book.CategoryId,
                    Author = bookViewModel.Book.Author,
                    Pages = bookViewModel.Book.Pages,
                    IsActive = bookViewModel.Book.IsActive
                    

                };
                try
                {
                    _bookService.Update(bookForUpdate);
                    return RedirectToAction("GetBooks");
                }
                catch (Exception)
                {
                    return RedirectToAction("GetBooks");
                }
            }
            return RedirectToAction("GetBooks");
        }







        public JsonResult Delete(int id)
        {
            if (id > 0)
            {
                var bookIsValid = _bookService.GetById(id);
                if (bookIsValid == null)
                {
                    return Json(0);
                }
                _bookService.Delete(bookIsValid);
                return Json(1);
            }
            return Json(0);
        }










    }
}
