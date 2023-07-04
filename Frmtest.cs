using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCSMarking3
{
    public partial class Frmtest : Form
    {
        public Frmtest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string ss = "0000000";
            string myStr = ss.TrimStart(new Char[] { '0' });
            myStr = myStr.Length > 0 ? myStr : "0";
            Console.WriteLine("num = " + myStr);*/

            double final_size = 1.3600008 ;// 17 * (0.090 * 0.8);
            Console.WriteLine("final size " + final_size.ToString("0.#"));
            ;        
        }

        private int findHighest()
        {
            var list = new List<int> { 21, 2, 3, 4, 5, 6, 7, 16, 17 };
            Console.WriteLine("MAX=>" + list.Max(z => z));
            Console.WriteLine("MIN=>" + list.Min(z => z));
            return 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            findHighest();
        }
    }
}
