using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.control
{
    class List_Img
    {


        public string Getimg(int _str)
        {
            int str = _str;
            List<string> img = new List<string>();
            img.Add("I0");
            img.Add("I1");
            img.Add("I2");
            img.Add("I3");

            return img[str];

        }

    }
}
