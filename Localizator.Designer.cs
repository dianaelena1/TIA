namespace Localizator
{
    partial class Localizator
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
            this.btnLocalizeaza = new System.Windows.Forms.Button();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.tbTara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbJudet = new System.Windows.Forms.TextBox();
            this.tbOras = new System.Windows.Forms.TextBox();
            this.tbLat = new System.Windows.Forms.TextBox();
            this.tbLong = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLocalizeaza
            // 
            this.btnLocalizeaza.Location = new System.Drawing.Point(206, 168);
            this.btnLocalizeaza.Name = "btnLocalizeaza";
            this.btnLocalizeaza.Size = new System.Drawing.Size(75, 23);
            this.btnLocalizeaza.TabIndex = 0;
            this.btnLocalizeaza.Text = "Localizeaza";
            this.btnLocalizeaza.UseVisualStyleBackColor = true;
            this.btnLocalizeaza.Click += new System.EventHandler(this.btnLocalizeaza_Click);
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(74, 12);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(207, 20);
            this.tbIP.TabIndex = 1;
            // 
            // tbTara
            // 
            this.tbTara.Location = new System.Drawing.Point(74, 38);
            this.tbTara.Name = "tbTara";
            this.tbTara.ReadOnly = true;
            this.tbTara.Size = new System.Drawing.Size(207, 20);
            this.tbTara.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adresa IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cod tara:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stat/judet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Oras:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Lat.:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Long.:";
            // 
            // tbJudet
            // 
            this.tbJudet.Location = new System.Drawing.Point(74, 64);
            this.tbJudet.Name = "tbJudet";
            this.tbJudet.ReadOnly = true;
            this.tbJudet.Size = new System.Drawing.Size(207, 20);
            this.tbJudet.TabIndex = 2;
            // 
            // tbOras
            // 
            this.tbOras.Location = new System.Drawing.Point(74, 90);
            this.tbOras.Name = "tbOras";
            this.tbOras.ReadOnly = true;
            this.tbOras.Size = new System.Drawing.Size(207, 20);
            this.tbOras.TabIndex = 2;
            // 
            // tbLat
            // 
            this.tbLat.Location = new System.Drawing.Point(74, 116);
            this.tbLat.Name = "tbLat";
            this.tbLat.ReadOnly = true;
            this.tbLat.Size = new System.Drawing.Size(207, 20);
            this.tbLat.TabIndex = 2;
            // 
            // tbLong
            // 
            this.tbLong.Location = new System.Drawing.Point(74, 142);
            this.tbLong.Name = "tbLong";
            this.tbLong.ReadOnly = true;
            this.tbLong.Size = new System.Drawing.Size(207, 20);
            this.tbLong.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 201);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLong);
            this.Controls.Add(this.tbLat);
            this.Controls.Add(this.tbOras);
            this.Controls.Add(this.tbJudet);
            this.Controls.Add(this.tbTara);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.btnLocalizeaza);
            this.Name = "Form1";
            this.Text = "Localizator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLocalizeaza;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.TextBox tbTara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbJudet;
        private System.Windows.Forms.TextBox tbOras;
        private System.Windows.Forms.TextBox tbLat;
        private System.Windows.Forms.TextBox tbLong;
    }
}

