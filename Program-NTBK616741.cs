using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCSMarking3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //1. production
            Application.Run(new Form1()); //

            //2. Generate files 
            //  Application.Run(new FormReadALl());

            //3. test
            // Application.Run(new Frmtest());

            //4. Num Pattern
           // Application.Run(new FormNumPatrn());


        }
    }
}
