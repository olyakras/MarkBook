using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMarks_kdz
{
    class Book
    {
        string _title = "";
        List<string> _autor = new List<string>();
        string _genre;


        private Book(string title, List<string> autor, string genres)
        {
            _title = title;
            _autor = autor;
            _genre = genres;
        }

        public void AddBook(string title, List<string> autor, string genres, List<Book> _booksList)
        {
            Book _item = new Book(title, autor, genres);
            if (CheckRepeat(_booksList, title, autor))
                _booksList.Add(_item);
        }

        public void DeleteBook(Book _item, List<Book> _booksList)
        {
        }

    }
}