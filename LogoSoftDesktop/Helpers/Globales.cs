using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogoSoftDesktop
{
    static class Globales
    {
        private static string _urlAPI = "";

        public static string Url_API
        {
            get { return _urlAPI; }
            set { _urlAPI = value; }
        }
    }
}
