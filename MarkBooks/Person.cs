using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkBooks
{
    [Serializable]
    class Person
    {
        string _login;
        string _password;


        public Person (string login, string password)
        {
            _login = login;
            _password = password;
        }

        public string Login
        {
            get { return _login;}
            set { _login = value;}
        }

        public string Password
        {
            get { return _password;}
            set { _password = value;}
        }
    }
}
