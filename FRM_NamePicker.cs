using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNamePicker
{
    public partial class FRM_NamePicker : Form
    {
        public FRM_NamePicker()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(TXT_SelectCount.Text != "" && TXT_Entries.Text != "")
            {

                TXT_Selected.Text = GenerateName(Convert.ToInt32(TXT_SelectCount.Text), TXT_Entries.Lines);
            }
            else
            {
                MessageBox.Show("Missing Information");
            }



            
        }
        public static string GenerateName(int len, string[] Names)
        {
            Random r = new Random();

            string Name = "";
            int b = 0;
            while (b < len)
            {
                Name += Names[r.Next(Names.Length)] + Environment.NewLine;
                b++;
            }

            return Name;


        }

    }
}
