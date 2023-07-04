using OCSMarkingDLL;
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
    public partial class Form1 : Form
    {
        private static String NEW_LINE = Environment.NewLine;// "\n";

        private static String App_version = "v1.4.8";
        public Form1()
        {
            InitializeComponent();
            cboMachine.SelectedIndex = 0;
            cboSizes.SelectedIndex = 0;

           lblMainTitle.Text = "In-Machine Marking Program Generator ["+ App_version + "] [API:"+ Marking.Version+"]";
        }

        private static string prefix_GC_prod_ord = "M ";
        private static string prefix_prod_ord = "P:";
        private static string prefix_part_num = "M:";
        private static string prefix_batch_num = "B:";


        private bool doGen(bool onlyPreview)
        {        

            string bu = string.Empty;

            if (txtMaterialNum.Text.Length < 1)
            {
                MessageBox.Show("Please enter material number ");
                txtMaterialNum.Focus();
                return false;
            }

            if (txtProdNumber.Text.Length < 1)
            {
                MessageBox.Show("Please enter production order number ");
                txtProdNumber.Focus();
                return false;
            }

            if (txtOldMaterialNum.Text.Length < 1)
            {
                MessageBox.Show("Please enter Old material number ");
                txtOldMaterialNum.Focus();
                return false;
            }

            if (txtBatchNum.Text.Length < 1)
            {
                MessageBox.Show("Please enter batch number ");
                txtBatchNum.Focus();
                return false;
            } 
            

            if (rdoGCLH.Checked || rdoLH.Checked)
            {
                if (txtOldMaterialNum.Text.Length < 1)
                {
                    MessageBox.Show("Please enter old material number ");
                    return false;
                }

                bu = Marking.BU_GC;
            }
            else
            {
                bu = Marking.BU_IC;
                
            }

            //public static String GetMarkingInfo(String machine_id,  string char_size, string bu, string material_number, 
            //string old_material_number, string drawing_rev, string batch_number, string customs, string thread1, string thread2)

            //0.250
            //0.125

            string size = string.Empty;
            
            if (cboSizes.Text.Equals("0.250 (ES-MM-51-2)"))
            {
                size =  Marking.Marking_size_0_25inch;
            }
            else if (cboSizes.Text.Equals("0.125 (ES-MM-51-1)"))
            {
                size = Marking.Marking_size_0_125inch;
            }
            else if (cboSizes.Text.Equals("0.19 (ES-MM-51-2)"))
            {
                size = Marking.Marking_size_0_19inch;
            }
            else if (cboSizes.Text.Equals("0.090 (ES-MM-51-1)"))
            {
                size = Marking.Marking_size_0_090inch;
            }


            string machine = string.Empty;
            if (cboMachine.Text.Equals(Marking.MAC_GC035300))
            {
                machine = Marking.MAC_GC035300;
            }

            Console.WriteLine("size = " + size +", machine="+ cboMachine.Text);

            if (!onlyPreview)
            {
                String res = Marking.GetMarkingInfo(cboMachine.Text, size, bu,
               txtProdNumber.Text, txtMaterialNum.Text, txtOldMaterialNum.Text, txtBatchNum.Text, txtCustomsOrigin.Text,
               txtThreadingDesc1.Text, txtThreadingDesc2.Text);

                txtResult.Text = res;
                Console.WriteLine("Res = " + res);
            }
         

            txtPreview.Text = Marking.GetMarkingPreview ( cboMachine.Text, size, bu,  txtProdNumber.Text , txtMaterialNum.Text, 
                txtOldMaterialNum.Text , txtBatchNum.Text,txtThreadingDesc1.Text, txtThreadingDesc2.Text);
            
            return false;
        }

        

        private void btnGen_Click(object sender, EventArgs e)
        {
            clearOutput();
            doGen(false);
        }




        private void reset()
        {
            txtBatchNum.Text = "";
            txtMaterialNum.Text = "";
            txtOldMaterialNum.Text = "";
            txtProdNumber.Text = "";
            txtThreadingDesc1.Text = "";
            txtThreadingDesc2.Text = "";
            txtResult.Text = "";
            txtPreview.Text = "";
        }

        private void doMachine()
        {
            string mac = cboMachine.Text;
            if (mac.Contains("GC"))
            {
                rdoGCLH.Checked = true;
            }
            else if (mac.Contains("LH"))
            {
                rdoLH.Checked = true;
            }
            else if (mac.Contains("IC"))
            {
                rdoICI.Checked = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("yyyy-MMM-dd");
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void rdoICI_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cboMachine_SelectedIndexChanged(object sender, EventArgs e)
        {
            doMachine();
            //reset();
        }

        private void rdoGCLH_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnGenPreview_Click(object sender, EventArgs e)
        {
            clearOutput();
            doGen(true);
        }

        private void clearOutput()
        {
            txtPreview.Text = "";
            txtResult.Text = "";
        }
        private void btnClearOutput_Click(object sender, EventArgs e)
        {
            clearOutput();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearOutput();
        }
    }
}
