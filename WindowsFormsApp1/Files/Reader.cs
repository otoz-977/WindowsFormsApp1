using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;


namespace WindowsFormsApp1.Files
{
    class Reader
    {
        string Scn;
   
     
       public Reader(string _scn)
        {
            Scn = _scn;

        }

        public  string text()
        {
           
            string dialog = WindowsFormsApp1.Properties.Resources.ResourceManager.GetString(Scn);
            
            return dialog;
        }

        
    }

}
