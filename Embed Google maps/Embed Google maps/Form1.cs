using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Embed_Google_maps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string district = textBox1.Text;
            string province = textBox2.Text;
            string country = textBox3.Text;
            string zip = textBox4.Text;
            webBrowser1.ScriptErrorsSuppressed = true; 
            StringBuilder location = new StringBuilder("http://google.com/maps?q=");
            if (district !=""){location.Append(district + "," + "+");}
            if (province != "") { location.Append(province + "," + "+"); }
            if (country != "") { location.Append(country + "," + "+"); }
            if (zip != "") { location.Append(zip + "," + "+"); }
            webBrowser1.Navigate(location.ToString());
        }
    }
}
