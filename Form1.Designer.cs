namespace Övning4._3
{
    partial class Form1
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
            this.lblFörnamn = new System.Windows.Forms.Label();
            this.lblEfternamn = new System.Windows.Forms.Label();
            this.lblEpost = new System.Windows.Forms.Label();
            this.lblTelefonnummer = new System.Windows.Forms.Label();
            this.tbxFörnamn = new System.Windows.Forms.TextBox();
            this.tbxEfternamn = new System.Windows.Forms.TextBox();
            this.tbxEpost = new System.Windows.Forms.TextBox();
            this.tbxTelefonnummer = new System.Windows.Forms.TextBox();
            this.btnÖppnaFil = new System.Windows.Forms.Button();
            this.btnSparaFil = new System.Windows.Forms.Button();
            this.dlgÖppnaFil = new System.Windows.Forms.OpenFileDialog();
            this.dlgSparaFil = new System.Windows.Forms.SaveFileDialog();
            this.lbxKontakt = new System.Windows.Forms.ListBox();
            this.btnLäggtill = new System.Windows.Forms.Button();
            this.btnTabort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFörnamn
            // 
            this.lblFörnamn.AutoSize = true;
            this.lblFörnamn.Location = new System.Drawing.Point(35, 39);
            this.lblFörnamn.Name = "lblFörnamn";
            this.lblFörnamn.Size = new System.Drawing.Size(73, 20);
            this.lblFörnamn.TabIndex = 0;
            this.lblFörnamn.Text = "Förnamn";
            // 
            // lblEfternamn
            // 
            this.lblEfternamn.AutoSize = true;
            this.lblEfternamn.Location = new System.Drawing.Point(35, 97);
            this.lblEfternamn.Name = "lblEfternamn";
            this.lblEfternamn.Size = new System.Drawing.Size(84, 20);
            this.lblEfternamn.TabIndex = 1;
            this.lblEfternamn.Text = "Efternamn";
            // 
            // lblEpost
            // 
            this.lblEpost.AutoSize = true;
            this.lblEpost.Location = new System.Drawing.Point(35, 164);
            this.lblEpost.Name = "lblEpost";
            this.lblEpost.Size = new System.Drawing.Size(56, 20);
            this.lblEpost.TabIndex = 2;
            this.lblEpost.Text = "E-post";
            // 
            // lblTelefonnummer
            // 
            this.lblTelefonnummer.AutoSize = true;
            this.lblTelefonnummer.Location = new System.Drawing.Point(35, 227);
            this.lblTelefonnummer.Name = "lblTelefonnummer";
            this.lblTelefonnummer.Size = new System.Drawing.Size(120, 20);
            this.lblTelefonnummer.TabIndex = 3;
            this.lblTelefonnummer.Text = "Telefonnummer";
            // 
            // tbxFörnamn
            // 
            this.tbxFörnamn.Location = new System.Drawing.Point(161, 27);
            this.tbxFörnamn.Multiline = true;
            this.tbxFörnamn.Name = "tbxFörnamn";
            this.tbxFörnamn.Size = new System.Drawing.Size(171, 32);
            this.tbxFörnamn.TabIndex = 4;
            // 
            // tbxEfternamn
            // 
            this.tbxEfternamn.Location = new System.Drawing.Point(161, 82);
            this.tbxEfternamn.Multiline = true;
            this.tbxEfternamn.Name = "tbxEfternamn";
            this.tbxEfternamn.Size = new System.Drawing.Size(171, 35);
            this.tbxEfternamn.TabIndex = 5;
            // 
            // tbxEpost
            // 
            this.tbxEpost.Location = new System.Drawing.Point(161, 154);
            this.tbxEpost.Multiline = true;
            this.tbxEpost.Name = "tbxEpost";
            this.tbxEpost.Size = new System.Drawing.Size(171, 30);
            this.tbxEpost.TabIndex = 6;
            // 
            // tbxTelefonnummer
            // 
            this.tbxTelefonnummer.Location = new System.Drawing.Point(161, 224);
            this.tbxTelefonnummer.Multiline = true;
            this.tbxTelefonnummer.Name = "tbxTelefonnummer";
            this.tbxTelefonnummer.Size = new System.Drawing.Size(171, 29);
            this.tbxTelefonnummer.TabIndex = 7;
            // 
            // btnÖppnaFil
            // 
            this.btnÖppnaFil.Location = new System.Drawing.Point(12, 324);
            this.btnÖppnaFil.Name = "btnÖppnaFil";
            this.btnÖppnaFil.Size = new System.Drawing.Size(137, 45);
            this.btnÖppnaFil.TabIndex = 8;
            this.btnÖppnaFil.Text = "Öppna Fil";
            this.btnÖppnaFil.UseVisualStyleBackColor = true;
            this.btnÖppnaFil.Click += new System.EventHandler(this.btnÖppnaFil_Click);
            // 
            // btnSparaFil
            // 
            this.btnSparaFil.Location = new System.Drawing.Point(195, 324);
            this.btnSparaFil.Name = "btnSparaFil";
            this.btnSparaFil.Size = new System.Drawing.Size(137, 45);
            this.btnSparaFil.TabIndex = 9;
            this.btnSparaFil.Text = "Spara som...";
            this.btnSparaFil.UseVisualStyleBackColor = true;
            this.btnSparaFil.Click += new System.EventHandler(this.btnSparaFil_Click);
            // 
            // dlgÖppnaFil
            // 
            this.dlgÖppnaFil.FileName = "openFileDialog1";
            // 
            // lbxKontakt
            // 
            this.lbxKontakt.FormattingEnabled = true;
            this.lbxKontakt.ItemHeight = 20;
            this.lbxKontakt.Location = new System.Drawing.Point(446, 27);
            this.lbxKontakt.Name = "lbxKontakt";
            this.lbxKontakt.Size = new System.Drawing.Size(282, 224);
            this.lbxKontakt.TabIndex = 10;
            this.lbxKontakt.SelectedIndexChanged += new System.EventHandler(this.lbxKontakt_SelectedIndexChanged);
            // 
            // btnLäggtill
            // 
            this.btnLäggtill.Location = new System.Drawing.Point(402, 324);
            this.btnLäggtill.Name = "btnLäggtill";
            this.btnLäggtill.Size = new System.Drawing.Size(122, 45);
            this.btnLäggtill.TabIndex = 11;
            this.btnLäggtill.Text = "Lägg till";
            this.btnLäggtill.UseVisualStyleBackColor = true;
            this.btnLäggtill.Click += new System.EventHandler(this.btnLäggtill_Click);
            // 
            // btnTabort
            // 
            this.btnTabort.Location = new System.Drawing.Point(582, 323);
            this.btnTabort.Name = "btnTabort";
            this.btnTabort.Size = new System.Drawing.Size(121, 46);
            this.btnTabort.TabIndex = 12;
            this.btnTabort.Text = "Ta bort";
            this.btnTabort.UseVisualStyleBackColor = true;
            this.btnTabort.Click += new System.EventHandler(this.btnTabort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTabort);
            this.Controls.Add(this.btnLäggtill);
            this.Controls.Add(this.lbxKontakt);
            this.Controls.Add(this.btnSparaFil);
            this.Controls.Add(this.btnÖppnaFil);
            this.Controls.Add(this.tbxTelefonnummer);
            this.Controls.Add(this.tbxEpost);
            this.Controls.Add(this.tbxEfternamn);
            this.Controls.Add(this.tbxFörnamn);
            this.Controls.Add(this.lblTelefonnummer);
            this.Controls.Add(this.lblEpost);
            this.Controls.Add(this.lblEfternamn);
            this.Controls.Add(this.lblFörnamn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFörnamn;
        private System.Windows.Forms.Label lblEfternamn;
        private System.Windows.Forms.Label lblEpost;
        private System.Windows.Forms.Label lblTelefonnummer;
        private System.Windows.Forms.TextBox tbxFörnamn;
        private System.Windows.Forms.TextBox tbxEfternamn;
        private System.Windows.Forms.TextBox tbxEpost;
        private System.Windows.Forms.TextBox tbxTelefonnummer;
        private System.Windows.Forms.Button btnÖppnaFil;
        private System.Windows.Forms.Button btnSparaFil;
        private System.Windows.Forms.OpenFileDialog dlgÖppnaFil;
        private System.Windows.Forms.SaveFileDialog dlgSparaFil;
        private System.Windows.Forms.ListBox lbxKontakt;
        private System.Windows.Forms.Button btnLäggtill;
        private System.Windows.Forms.Button btnTabort;
    }
}

