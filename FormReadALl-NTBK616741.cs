using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

 //change file name
namespace OCSMarking3
{
    public partial class FormReadALl : Form
    {

        //private String _test = "C:\\temp\\0-MINE\\Marking3App\\Apr-17-FontsWithDot\\test";
        //private String _019 = "C:\\temp\\0-MINE\\Marking3App\\Apr-17-FontsWithDot\\019C";

        private String _090 = "C:\\Users\\h238397\\OneDrive - Halliburton\\0-MINE\\Marking3App\\FONTS\\July-17-2022\\09C";
        private String _019 = "C:\\Users\\h238397\\OneDrive - Halliburton\\0-MINE\\Marking3App\\FONTS\\July-17-2022\\019C";
        private String _025 = "C:\\Users\\h238397\\OneDrive - Halliburton\\0-MINE\\Marking3App\\FONTS\\July-17-2022\\025C";
        private String _0125 = "C:\\Users\\h238397\\OneDrive - Halliburton\\0-MINE\\Marking3App\\FONTS\\July-17-2022\\0125C";

        public FormReadALl()
        {
            InitializeComponent();

            //txtPath.Text = _test;
            //change file name to generate files
            //replace it in the DLL cr folder
            txtPath.Text = _025;
        }

        // sb.AppendLine("G00 Z[#26+0.05]");

        string pre = "sb.AppendLine(\"";
        string postf = "\");";

        private void readAll()
        {

            string replaced_err_1 = string.Empty;
            string replaced_err_2 = string.Empty;
            string replaced_err_3 = string.Empty;
            string replaced_err_4 = string.Empty;

            int err_1_count = 0;
            int err_2_count = 0;
            int err_3_count = 0;
            int err_4_count = 0;

            String dirPath = txtPath.Text;
           String[] files =  Directory.GetFiles(dirPath, "*", SearchOption.AllDirectories);
            for(int x = 0; x < files.Length; x++)
            {
                String f = (String)files[x];
                
                //FileInfo fi = new FileInfo(@".\a\bb\file.txt");

                FileVersionInfo myFileVersionInfo = FileVersionInfo.GetVersionInfo(f);
                FileInfo fvi = new FileInfo(f);
                Console.WriteLine("Path = " + f +", filename="+fvi.Name +", header ="+ getHeader(fvi.Name));

                txtRes.AppendText( Environment.NewLine);
                txtRes.AppendText(getHeader(fvi.Name));

                foreach (string line in System.IO.File.ReadLines(@""+f))
                {
                    String ln = line;

                    if (ln.Contains("C-[#6]"))
                    {
                        ln = ln.Replace("C-[#6]", "C[#6]");
                        err_1_count = err_1_count + 1;
                        replaced_err_1 = replaced_err_1 + "C-[#6] Found in \t"+ fvi.Name +", count ="+ err_1_count +"\n";
                    }

                    if (ln.Contains("#6 = #3 * 3"))
                    {
                        ln = ln.Replace("#6 = #3 * 3", "#6 = #3 * #177");                        
                        err_2_count = err_2_count + 1;
                        replaced_err_2 = replaced_err_2 + "#6 = #3 * 3 Found in \t" + fvi.Name + ", count =" + err_2_count + "\n";
                    }

                    if (ln.Contains("#5 = #5 - 0.9"))
                    {
                        ln = ln.Replace("#5 = #5 - 0.9", "#5 = #5 - 0.09");
                        err_3_count = err_3_count + 1;
                        replaced_err_3 = replaced_err_3 + "5 = #5 - 0.9 Found in \t" + fvi.Name + ", count =" + err_3_count + "\n";
                    }

                    if (ln.Contains("F25.0"))
                    {
                        //ln = ln.Replace("F25.0", "F35.0");//#178
                        ln = ln.Replace("F25.0", "F[#178]");
                        err_4_count = err_4_count + 1;
                        replaced_err_4 = replaced_err_4 + "F25.0 Found in \t" + fvi.Name + ", count =" + err_4_count + "\n";
                    }


                    System.Console.WriteLine(ln);
                    txtRes.AppendText(pre + ln + postf + Environment.NewLine);
                }

                txtRes.AppendText(getEnd());
                System.Console.WriteLine("------------------------------");
            }//

            Console.WriteLine(replaced_err_1 + "\n===============\n");
            Console.WriteLine(replaced_err_2 + "\n===============\n");
            Console.WriteLine(replaced_err_3 + "\n===============\n");
            Console.WriteLine(replaced_err_4 + "\n===============\n");
        }

        private static String getEnd()
        {
            return "return sb.ToString(); "
                + Environment.NewLine + "  }" 
                + Environment.NewLine ;
        }


        private static String getHeader(String filename)
        {

            if (filename.Equals("0.nc"))
            {
                return "public static String getCR0() " 
                    + Environment.NewLine + "  { " 
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); " 
                    + Environment.NewLine + " ";
            }


            if (filename.Equals("1.nc"))
            {
                return "public static String getCR1() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }

            if (filename.Equals("2.nc"))
            {
                return "public static String getCR2() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }

            if (filename.Equals("3.nc"))
            {
                return "public static String getCR3() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }

            if (filename.Equals("4.nc"))
            {
                return "public static String getCR4() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }

            if (filename.Equals("5.nc"))
            {
                return "public static String getCR5() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }


            if (filename.Equals("6.nc"))
            {
                return "public static String getCR6() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }


            if (filename.Equals("7.nc"))
            {
                return "public static String getCR7() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }


            if (filename.Equals("8.nc"))
            {
                return "public static String getCR8() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }

            if (filename.Equals("9.nc"))
            {
                return "public static String getCR9() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }

            if (filename.Equals("A.nc"))
            {
                return "public static String getCRA() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }


            if (filename.Equals("B.nc"))
            {
                return "public static String getCRB() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }

            if (filename.Equals("C.nc"))
            {
                return "public static String getCRC() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }


            if (filename.Equals("D.nc"))
            {
                return "public static String getCRD() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }

            if (filename.Equals("E.nc"))
            {
                return "public static String getCRE() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }

            if (filename.Equals("F.nc"))
            {
                return "public static String getCRF() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }


            if (filename.Equals("G.nc"))
            {
                return "public static String getCRG() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }

            if (filename.Equals("H.nc"))
            {
                return "public static String getCRH() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }

            if (filename.Equals("I.nc"))
            {
                return "public static String getCRI() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }

            if (filename.Equals("J.nc"))
            {
                return "public static String getCRJ() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }

            if (filename.Equals("K.nc"))
            {
                return "public static String getCRK() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }


            if (filename.Equals("L.nc"))
            {
                return "public static String getCRL() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }

            if (filename.Equals("M.nc"))
            {
                return "public static String getCRM() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }


            if (filename.Equals("N.nc"))
            {
                return "public static String getCRN() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }

            if (filename.Equals("O.nc"))
            {
                return "public static String getCRO() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }


            if (filename.Equals("P.nc"))
            {
                return "public static String getCRP() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }


            if (filename.Equals("Q.nc"))
            {
                return "public static String getCRQ() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }


            if (filename.Equals("R.nc"))
            {
                return "public static String getCRR() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }


            if (filename.Equals("S.nc"))
            {
                return "public static String getCRS() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }


            if (filename.Equals("T.nc"))
            {
                return "public static String getCRT() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }

            if (filename.Equals("U.nc"))
            {
                return "public static String getCRU() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }

            if (filename.Equals("V.nc"))
            {
                return "public static String getCRV() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }

            if (filename.Equals("W.nc"))
            {
                return "public static String getCRW() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }

            if (filename.Equals("X.nc"))
            {
                return "public static String getCRX() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }

            if (filename.Equals("Y.nc"))
            {
                return "public static String getCRY() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }

            if (filename.Equals("Z.nc"))
            {
                return "public static String getCRZ() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }

            if (filename.Equals("Ampersand.nc"))
            {
                return "public static String getCRAMP() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }

            if (filename.Equals("Colon.nc"))
            {
                return "public static String getCRCOLON() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }

            if (filename.Equals("Comma.nc"))
            {
                return "public static String getCRCOMMA() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }

            if (filename.Equals("C-Return.nc"))
            {
                return "public static String getCRCR() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }

            if (filename.Equals("Dot.nc"))
            {
                return "public static String getCRDOT() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }

            if (filename.Equals("Footer.nc"))
            {
                return "public static String getCRFOOTER() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }


            if (filename.Equals("Hash.nc"))
            {
                return "public static String getCRHASH() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }

            if (filename.Equals("Header.nc"))
            {
                return "public static String getCRHEADER() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";

            }

            if (filename.Equals("Hyphen.nc"))
            {
                return "public static String getCRHYPHEN() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }

            if (filename.Equals("Slash.nc"))
            {
                return "public static String getCRSLASH() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }

            if (filename.Equals("Space.nc"))
            {
                return "public static String getCRSPACE() "
                    + Environment.NewLine + "  { "
                    + Environment.NewLine + " StringBuilder sb = new StringBuilder(); "
                    + Environment.NewLine + " ";
            }



            return "";
        }

        private void btnReadALl_Click(object sender, EventArgs e)
        {
            readAll();
        }
    }
}
