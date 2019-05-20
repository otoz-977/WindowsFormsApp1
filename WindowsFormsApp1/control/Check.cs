using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.control
{
    class Check
    {
        string linea;
        public Check(string L)
        {
            linea = L;
        }

        public bool special()
        {
            List<char> Char = new List<char>();
            Char.Add('@');//this makes from1, show questions
            Char.Add('&');// this links to a scene;

            char[] test = linea.ToCharArray();
            char tst = test[0];
            bool b = Char.Contains(tst);

            if (b)
            {
                return true;
            }
            else
            {
                return false;
            }    
        }
       
    }
}
