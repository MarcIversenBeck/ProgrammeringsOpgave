
namespace MarcIversenBecl191200
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateDato = new System.Windows.Forms.DateTimePicker();
            this.txtnavn = new System.Windows.Forms.TextBox();
            this.txtmbnr = new System.Windows.Forms.TextBox();
            this.txtmedarb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbservice = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dato";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kunde Navn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mobilnummer";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Foretages af";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dateDato
            // 
            this.dateDato.CustomFormat = "dd/MM/yyyy";
            this.dateDato.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDato.Location = new System.Drawing.Point(136, 19);
            this.dateDato.Name = "dateDato";
            this.dateDato.Size = new System.Drawing.Size(249, 20);
            this.dateDato.TabIndex = 4;
            this.dateDato.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtnavn
            // 
            this.txtnavn.Location = new System.Drawing.Point(136, 50);
            this.txtnavn.Name = "txtnavn";
            this.txtnavn.Size = new System.Drawing.Size(249, 20);
            this.txtnavn.TabIndex = 5;
            this.txtnavn.TextChanged += new System.EventHandler(this.txtnavn_TextChanged);
            // 
            // txtmbnr
            // 
            this.txtmbnr.Location = new System.Drawing.Point(136, 79);
            this.txtmbnr.Name = "txtmbnr";
            this.txtmbnr.Size = new System.Drawing.Size(249, 20);
            this.txtmbnr.TabIndex = 6;
            // 
            // txtmedarb
            // 
            this.txtmedarb.Location = new System.Drawing.Point(136, 105);
            this.txtmedarb.Name = "txtmedarb";
            this.txtmedarb.Size = new System.Drawing.Size(249, 20);
            this.txtmedarb.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Reserver tid";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Afslut (gemmer ikke)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Service";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cmbservice
            // 
            this.cmbservice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbservice.FormattingEnabled = true;
            this.cmbservice.Items.AddRange(new object[] {
            "Frisør",
            "Massør",
            "Fysioterapeut"});
            this.cmbservice.Location = new System.Drawing.Point(136, 131);
            this.cmbservice.Name = "cmbservice";
            this.cmbservice.Size = new System.Drawing.Size(249, 21);
            this.cmbservice.TabIndex = 11;
            this.cmbservice.SelectedIndexChanged += new System.EventHandler(this.cmbservice_SelectedIndexChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 225);
            this.Controls.Add(this.cmbservice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtmedarb);
            this.Controls.Add(this.txtmbnr);
            this.Controls.Add(this.txtnavn);
            this.Controls.Add(this.dateDato);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateDato;
        private System.Windows.Forms.TextBox txtnavn;
        private System.Windows.Forms.TextBox txtmbnr;
        private System.Windows.Forms.TextBox txtmedarb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbservice;
    }
}
