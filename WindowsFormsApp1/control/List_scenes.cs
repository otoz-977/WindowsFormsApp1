using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.control
{
     class List_scenes
    {
       

        
        public  string Getscene(int _str)
        {
            int str = _str;
            List<string> scene = new List<string>();
            scene.Add("S1");
            scene.Add("S2");
            scene.Add("S3");
            scene.Add("S4");
            scene.Add("S5");
            scene.Add("S6");

            return scene[str];

        }
    }
}
