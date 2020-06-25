using lap2_TranQuangDuy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lap2_TranQuangDuy.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public string HelloTeacher(string university)
        {
            return "hello Teacher" + university;
        }
        public ActionResult ListBook()
        {
            var books = new List<string>();
            books.Add("HTML5&CSS3");
            books.Add("HTML5&CSS3");
            books.Add(" ASP.NET MVC5");
            ViewBag.Books = books;
            return View();

        }
        public ActionResult ListBookModel()
        {
            var books = new List<Book>();
            books.Add(new Book(1, "HTML5&CSS3", "Author name book 1", "/Content/images/1.jpg"));
            books.Add(new Book(2, "HTML5&CSS", "Author name book 2", "/Content/images/2.png"));
            books.Add(new Book(3, " ASP.NET MVC5", "Author name book 3", "/Content/images/3.jpg"));
            return View(books);
        }
        public ActionResult EditBook(int id)
        {
            var books = new List<Book>();
            books.Add(new Book(1, "HTML5&CSS3", "Author name book 1", "/Content/images/1.jpg"));
            books.Add(new Book(2, "HTML5&CSS", "Author name book 2", "/Content/images/2.png"));
            books.Add(new Book(3, " ASP.NET MVC5", "Author name book 3", "/Content/images/3.jpg"));
            Book book = new Models.Book();
            foreach (Book b in books)
            {
                if (b.Id == id)
                {
                    book = b;
                    break;

                }

            }
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        [HttpPost, ActionName("EditBook")]
        [ValidateAntiForgeryToken]
        public ActionResult EditBook(int id, string title, string author, string image_cover)
        {
            var books = new List<Book>();
            books.Add(new Book(1, "HTML5&CSS3", "Author name book 1", "/Content/images/1.jpg"));
            books.Add(new Book(2, "HTML5&CSS", "Author name book 2", "/Content/images/2.png"));
            books.Add(new Book(3, " ASP.NET MVC5", "Author name book 3", "/Content/images/3.jpg"));
            if (id == null)
            {
                return HttpNotFound();
            }
            foreach (Book b in books)
            {
                if (b.Id == id)
                {
                    b.Title = title;
                    b.Author = author;
                    b.ImageCover = image_cover;
                    break;
                }
            }
            return View("ListBookModel", books);

        }

        public ActionResult CreateBook()
        {
            return View();
        }
    }
}