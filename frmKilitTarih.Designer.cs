﻿namespace BakimTakipProgrami
{
    partial class frmKilitTarih
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnKilit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(23, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(223, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btnKilit
            // 
            this.btnKilit.Location = new System.Drawing.Point(23, 69);
            this.btnKilit.Name = "btnKilit";
            this.btnKilit.Size = new System.Drawing.Size(223, 42);
            this.btnKilit.TabIndex = 1;
            this.btnKilit.Text = "Tarihe kadar kiltle";
            this.btnKilit.UseVisualStyleBackColor = true;
            this.btnKilit.Click += new System.EventHandler(this.btnKilit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKilit);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 142);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // frmKilitTarih
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 177);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKilitTarih";
            this.Text = "Tarih Kilitle";
            this.Load += new System.EventHandler(this.frmKilitTarih_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnKilit;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}