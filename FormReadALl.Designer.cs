
namespace OCSMarking3
{
    partial class FormReadALl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnReadALl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(153, 52);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(426, 22);
            this.txtPath.TabIndex = 0;
            this.txtPath.Text = "C:\\temp\\0-MINE\\Marking3App\\Apr-3rd\\test";
            // 
            // btnReadALl
            // 
            this.btnReadALl.Location = new System.Drawing.Point(594, 32);
            this.btnReadALl.Name = "btnReadALl";
            this.btnReadALl.Size = new System.Drawing.Size(111, 41);
            this.btnReadALl.TabIndex = 1;
            this.btnReadALl.Text = "Read All";
            this.btnReadALl.UseVisualStyleBackColor = true;
            this.btnReadALl.Click += new System.EventHandler(this.btnReadALl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Raw Folder";
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(42, 114);
            this.txtRes.Multiline = true;
            this.txtRes.Name = "txtRes";
            this.txtRes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRes.Size = new System.Drawing.Size(662, 465);
            this.txtRes.TabIndex = 3;
            this.txtRes.Text = "C:\\temp\\0-MINE\\Marking3App\\Apr-3rd\\test";
            // 
            // FormReadALl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 638);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReadALl);
            this.Controls.Add(this.txtPath);
            this.Name = "FormReadALl";
            this.Text = "FormReadALl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnReadALl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRes;
    }
}