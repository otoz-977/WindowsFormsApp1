using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.control;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int C = 0;
        int S = 0;
        
        
        
        bool special;  
        public Form1()
        {
            InitializeComponent();
        }
        private void Cont_Click(object sender, EventArgs e)
        {
            Master ms = new Master();
            //cheats
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                if(textBox1.Text == "*")
                {
                    S = 0;
                    C = 0;
                    textBox1.Text = string.Empty;
                }
                else 
                {
                    S = Int32.Parse(textBox1.Text);
                    C = 0;
                    textBox1.Text = string.Empty;

                }   
            }
            
            //permite seleccionar
            /*
            if (!String.IsNullOrEmpty(Ans.Text) && (special == true))
            {
                if (Ans.Text == "a")
                {
                    
                    
                }
                if (Ans.Text == "b")
                {
                   // Next(2);
                   
                }
            }
            */
            //escribe el texto
            Diag.Text = ms.Scenery(C,S);
            C++;
            
           //esto hace el panel visible
            special = ms.GS;
            if (special == true)
            {

                Questions.Visible = true;
                Diag.Text = ms.Quest();
                Q1.Text = ms.Q1;
                Q2.Text = ms.Q2;
               
                
            }
            else
            {
                Questions.Visible = false;
                Q1.Text = string.Empty;
                Q2.Text = string.Empty;
                Ans.Text = string.Empty;
                
            }

            //when file over
            
            if (Diag.Text == "...")
            {
                
                S++;
                C = 0;
            }
            
           
          
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
