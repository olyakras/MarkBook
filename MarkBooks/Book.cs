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
        List<string> _genre = new List<string>();
        string _content = "";


        private Book(string title, List<string> autor, List<string> genres, string content)
        {
            _title = title;
            _autor = autor;
            _genre = genres;
            _content = content;
        }

        public void AddBook(string title, List<string> autor, List<string> genres, string content, List<Book> _booksList)
        {
            Book _item = new Book(title, autor, genres, content);
            if (CheckRepeat(_booksList, title, autor))
                _booksList.Add(_item);
        }

        public void DeleteBook(Book _item, List<Book> _booksList)
        {
        }

        public bool CheckRepeat(List<Book> _booksList, string title, List<string> autor)//дописать
        {
            for (int i = 0; i < _booksList.Count; i++)
            {
                if (_booksList[i]._title == title)
                    for (int j = 0; j < autor.Count; j++)
                    {


                    }
            }
            return true;
        }
    }
}