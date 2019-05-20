using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Files
{
    class Sep 
    {
        public  string separar(int _C, string L,char ch)
        {
            string[] D = L.Split(ch);

            if(_C < D.Length)
            {
                return D[_C];
            }
            else
            {
                return "";
            }
        }
    }
}
