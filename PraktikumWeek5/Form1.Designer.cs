
namespace PraktikumWeek5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelData = new System.Windows.Forms.Label();
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.chckAktif = new System.Windows.Forms.CheckBox();
            this.radButtMerah = new System.Windows.Forms.RadioButton();
            this.labelSetting = new System.Windows.Forms.Label();
            this.radButtBiru = new System.Windows.Forms.RadioButton();
            this.labelKoleksi = new System.Windows.Forms.Label();
            this.listBoxInput = new System.Windows.Forms.ListBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelOutputBeneran = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(22, 30);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(37, 15);
            this.labelData.TabIndex = 0;
            this.labelData.Text = "Data :";
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Location = new System.Drawing.Point(76, 22);
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(354, 23);
            this.txtBoxInput.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(436, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // chckAktif
            // 
            this.chckAktif.AutoSize = true;
            this.chckAktif.Location = new System.Drawing.Point(347, 70);
            this.chckAktif.Name = "chckAktif";
            this.chckAktif.Size = new System.Drawing.Size(51, 19);
            this.chckAktif.TabIndex = 3;
            this.chckAktif.Text = "Aktif";
            this.chckAktif.UseVisualStyleBackColor = true;
            this.chckAktif.CheckedChanged += new System.EventHandler(this.chckAktif_CheckedChanged);
            // 
            // radButtMerah
            // 
            this.radButtMerah.AutoSize = true;
            this.radButtMerah.Location = new System.Drawing.Point(315, 95);
            this.radButtMerah.Name = "radButtMerah";
            this.radButtMerah.Size = new System.Drawing.Size(96, 19);
            this.radButtMerah.TabIndex = 4;
            this.radButtMerah.TabStop = true;
            this.radButtMerah.Text = "Warna Merah";
            this.radButtMerah.UseVisualStyleBackColor = true;
            this.radButtMerah.CheckedChanged += new System.EventHandler(this.radButtMerah_CheckedChanged);
            // 
            // labelSetting
            // 
            this.labelSetting.AutoSize = true;
            this.labelSetting.Location = new System.Drawing.Point(279, 70);
            this.labelSetting.Name = "labelSetting";
            this.labelSetting.Size = new System.Drawing.Size(50, 15);
            this.labelSetting.TabIndex = 5;
            this.labelSetting.Text = "Setting :";
            // 
            // radButtBiru
            // 
            this.radButtBiru.AutoSize = true;
            this.radButtBiru.Location = new System.Drawing.Point(315, 120);
            this.radButtBiru.Name = "radButtBiru";
            this.radButtBiru.Size = new System.Drawing.Size(83, 19);
            this.radButtBiru.TabIndex = 6;
            this.radButtBiru.TabStop = true;
            this.radButtBiru.Text = "Warna Biru";
            this.radButtBiru.UseVisualStyleBackColor = true;
            this.radButtBiru.CheckedChanged += new System.EventHandler(this.radButtBiru_CheckedChanged);
            // 
            // labelKoleksi
            // 
            this.labelKoleksi.AutoSize = true;
            this.labelKoleksi.Location = new System.Drawing.Point(22, 70);
            this.labelKoleksi.Name = "labelKoleksi";
            this.labelKoleksi.Size = new System.Drawing.Size(50, 15);
            this.labelKoleksi.TabIndex = 7;
            this.labelKoleksi.Text = "Koleksi :";
            // 
            // listBoxInput
            // 
            this.listBoxInput.FormattingEnabled = true;
            this.listBoxInput.ItemHeight = 15;
            this.listBoxInput.Location = new System.Drawing.Point(22, 95);
            this.listBoxInput.Name = "listBoxInput";
            this.listBoxInput.Size = new System.Drawing.Size(232, 214);
            this.listBoxInput.TabIndex = 8;
            this.listBoxInput.Click += new System.EventHandler(this.listBoxInput_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(279, 157);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(51, 15);
            this.labelOutput.TabIndex = 9;
            this.labelOutput.Text = "Output :";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(279, 286);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(232, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 11;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelOutputBeneran
            // 
            this.labelOutputBeneran.AutoSize = true;
            this.labelOutputBeneran.Location = new System.Drawing.Point(366, 218);
            this.labelOutputBeneran.Name = "labelOutputBeneran";
            this.labelOutputBeneran.Size = new System.Drawing.Size(28, 15);
            this.labelOutputBeneran.TabIndex = 12;
            this.labelOutputBeneran.Text = "Text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 330);
            this.Controls.Add(this.labelOutputBeneran);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.listBoxInput);
            this.Controls.Add(this.labelKoleksi);
            this.Controls.Add(this.radButtBiru);
            this.Controls.Add(this.labelSetting);
            this.Controls.Add(this.radButtMerah);
            this.Controls.Add(this.chckAktif);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBoxInput);
            this.Controls.Add(this.labelData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox chckAktif;
        private System.Windows.Forms.RadioButton radButtMerah;
        private System.Windows.Forms.Label labelSetting;
        private System.Windows.Forms.RadioButton radButtBiru;
        private System.Windows.Forms.Label labelKoleksi;
        private System.Windows.Forms.ListBox listBoxInput;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelOutputBeneran;
    }
}

