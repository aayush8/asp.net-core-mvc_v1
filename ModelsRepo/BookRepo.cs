using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication13.DataContext;
using WebApplication13.Models;

namespace WebApplication13.ModelsRepo
{
    public class BookRepo
    {

        BookDataContext _bookDataContext;

        public BookRepo(BookDataContext bookDataContext)
        {
            _bookDataContext = bookDataContext;
        }


        public List<BookModel> GetAllBooks()
        {
            var bookmodel = new List<BookModel>();
            var allbooks = _bookDataContext.Books.ToList<Books>();
            if (allbooks.Count>0)
            {
                foreach(var books in allbooks)
                {
                    bookmodel.Add(new BookModel() { 
                        Author = books.Author,
                        Description = books.Description,
                        Id = books.Id,
                        Name = books.Name,
                        PublishedYear = books.PublishedYear
                    });
                }
                return bookmodel;
            }
            else
                return new List<BookModel>() { new BookModel() {Name="No Books", Author="No Books", Description="No Books", PublishedYear=1111 } };
        }

        public BookModel GetBookById(int id)
        {
            return new BookModel() { };
        }


        //started working
        public int AddBookToModel(BookModel book)
        {
            var NewBook = new Books() {
                Author = book.Author,
                Description = book.Description,
                Name = book.Name,
                PublishedYear = book.PublishedYear,
                CreatedOn = DateTime.UtcNow,
                UpdatedOn = DateTime.UtcNow
            };
            _bookDataContext.Books.Add(NewBook);
            _bookDataContext.SaveChanges();

            return NewBook.Id;
        }


    }
}
