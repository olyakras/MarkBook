using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkBooks
{
    class Pages
    {
        private static BeginPage _beginPage = new BeginPage();
        private static RegisterPage _registerPage = new RegisterPage();
        private static MainPage _mainPage = new MainPage();
        private static AddingPage _addingPage = new AddingPage();

        public static BeginPage BeginPage
        {
            get
            {
                return _beginPage;
            }
        }

        public static RegisterPage RegisterPage
        {
            get
            {
                return _registerPage;
            }
        }

        public static MainPage MainPage
        {
            get
            {
                return _mainPage;
            }
        }

        public static AddingPage AddingPage
        {
            get
            {
                return _addingPage;
            }
        }
    }
}
