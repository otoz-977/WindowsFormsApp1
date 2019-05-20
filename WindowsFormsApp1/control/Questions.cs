using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Files;

namespace WindowsFormsApp1.control
{
    class Questions
    {
        string fix;
        string Quest, Q1, Q2;
       
      

        public Questions(string L)
        {
            fix = L;
        }

        public string trim()
        {
            fix.Trim('@');
            string[] f =fix.Split('/');
            
            
            Q1 = f[0];
            Q2 = f[1];
            Quest = Q1 + " "+Q2;
            /*
            R1 = f[2];
            R2 = f[3];
            */


            return f[0] +f[1];
        }
        public string GetQ
        {
            get { return Q1 + Q2; }
        }
        public string GetQ1
        {
            get { return Q1; }
        }
        public string GetQ2
        {
            get { return Q2; }
        }
        
    }
}
