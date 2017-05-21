using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkBooks
{
    class Book
    {
        string _title = "";
        string _autor = "";
        Genres _genre;

        public string Title
        {
            get { return _title;}
            set { _title = value;}
        }

        public string Autor
        {
            get { return _autor;}
            set { _autor = value;}
        }

        public Genres Genre
        {
            get { return _genre;}
            set { _genre = value;}
        }

        public Book (string title, string autor, Genres genre)
        {
            _title = title;
            _autor = autor;
            _genre = genre;
        }

    }
}