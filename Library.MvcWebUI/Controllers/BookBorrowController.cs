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
    public class BookBorrowController : Controller
    {
        IBookServices _bookService;





        public BookBorrowController(IBookServices bookService)
        {
            _bookService = bookService;
        }




        public IActionResult GetBooksforBorrow()
        {

            var bookViewModel = new BookViewModel
            {
                Books = _bookService.GetList()

            };
            return View(bookViewModel);
        }








        public JsonResult Edit(int id)
        {
            if (id == 0)
            {
                return Json(0);
            }
            var category = _bookService.GetById(id);
            if (category == null)
            {
                return Json(0);
            }
            return Json(category);
        }



        [HttpPost]



        public IActionResult Edit(BookViewModel bookViewModel)
        {
            if (ModelState.IsValid)
            {
                var bookIsValid = _bookService.GetById(bookViewModel.Book.Id);
                if (bookIsValid == null)
                {
                    return RedirectToAction("GetBooksforBorrow");
                }
                try
                {
                    var categoryForAdd = new Book
                    {
                        Id = bookIsValid.Id,
                        IsActive = bookViewModel.Book.IsActive,
                        Name = bookViewModel.Book.Name
                    };
                    _bookService.Update(categoryForAdd);
                    return RedirectToAction("GetBooksforBorrow");
                }
                catch (Exception)
                {
                    return RedirectToAction("GetBooksforBorrow");
                }
            }
            return RedirectToAction("GetBooksforBorrow");
        }












    }
}
