namespace atm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labLabdien = new System.Windows.Forms.Label();
            this.labLaipni = new System.Windows.Forms.Label();
            this.labNixmoney = new System.Windows.Forms.Label();
            this.labBankomata = new System.Windows.Forms.Label();
            this.labIzvelieties = new System.Windows.Forms.Label();
            this.btnIenakt = new System.Windows.Forms.Button();
            this.btnRegistreties = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labLabdien
            // 
            this.labLabdien.AutoSize = true;
            this.labLabdien.BackColor = System.Drawing.Color.Transparent;
            this.labLabdien.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLabdien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.labLabdien.Location = new System.Drawing.Point(90, 171);
            this.labLabdien.Name = "labLabdien";
            this.labLabdien.Size = new System.Drawing.Size(173, 45);
            this.labLabdien.TabIndex = 0;
            this.labLabdien.Text = "Labdien!";
            this.labLabdien.Click += new System.EventHandler(this.labLabdien_Click);
            // 
            // labLaipni
            // 
            this.labLaipni.AutoSize = true;
            this.labLaipni.BackColor = System.Drawing.Color.Transparent;
            this.labLaipni.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLaipni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.labLaipni.Location = new System.Drawing.Point(90, 235);
            this.labLaipni.Name = "labLaipni";
            this.labLaipni.Size = new System.Drawing.Size(196, 32);
            this.labLaipni.TabIndex = 1;
            this.labLaipni.Text = "Laipni lūdzam ";
            // 
            // labNixmoney
            // 
            this.labNixmoney.AutoSize = true;
            this.labNixmoney.BackColor = System.Drawing.Color.Transparent;
            this.labNixmoney.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNixmoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.labNixmoney.Location = new System.Drawing.Point(90, 267);
            this.labNixmoney.Name = "labNixmoney";
            this.labNixmoney.Size = new System.Drawing.Size(151, 33);
            this.labNixmoney.TabIndex = 2;
            this.labNixmoney.Text = "Nikmoney";
            // 
            // labBankomata
            // 
            this.labBankomata.AutoSize = true;
            this.labBankomata.BackColor = System.Drawing.Color.Transparent;
            this.labBankomata.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBankomata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.labBankomata.Location = new System.Drawing.Point(231, 268);
            this.labBankomata.Name = "labBankomata";
            this.labBankomata.Size = new System.Drawing.Size(152, 32);
            this.labBankomata.TabIndex = 3;
            this.labBankomata.Text = "bankomātā";
            // 
            // labIzvelieties
            // 
            this.labIzvelieties.BackColor = System.Drawing.Color.Transparent;
            this.labIzvelieties.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labIzvelieties.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.labIzvelieties.Location = new System.Drawing.Point(88, 425);
            this.labIzvelieties.Name = "labIzvelieties";
            this.labIzvelieties.Size = new System.Drawing.Size(879, 34);
            this.labIzvelieties.TabIndex = 4;
            this.labIzvelieties.Text = "IZVĒLIETIES  DARBĪBU:";
            this.labIzvelieties.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnIenakt
            // 
            this.btnIenakt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(90)))));
            this.btnIenakt.FlatAppearance.BorderSize = 0;
            this.btnIenakt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIenakt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIenakt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnIenakt.Location = new System.Drawing.Point(149, 528);
            this.btnIenakt.Name = "btnIenakt";
            this.btnIenakt.Size = new System.Drawing.Size(334, 71);
            this.btnIenakt.TabIndex = 5;
            this.btnIenakt.Text = "IENĀKT";
            this.btnIenakt.UseVisualStyleBackColor = false;
            this.btnIenakt.Click += new System.EventHandler(this.btnIenakt_Click);
            // 
            // btnRegistreties
            // 
            this.btnRegistreties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(90)))));
            this.btnRegistreties.FlatAppearance.BorderSize = 0;
            this.btnRegistreties.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistreties.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistreties.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnRegistreties.Location = new System.Drawing.Point(550, 528);
            this.btnRegistreties.Name = "btnRegistreties";
            this.btnRegistreties.Size = new System.Drawing.Size(334, 71);
            this.btnRegistreties.TabIndex = 6;
            this.btnRegistreties.Text = "REĢISTRĒTIES";
            this.btnRegistreties.UseVisualStyleBackColor = false;
            this.btnRegistreties.Click += new System.EventHandler(this.btnRegistreties_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 853);
            this.Controls.Add(this.btnRegistreties);
            this.Controls.Add(this.btnIenakt);
            this.Controls.Add(this.labIzvelieties);
            this.Controls.Add(this.labBankomata);
            this.Controls.Add(this.labNixmoney);
            this.Controls.Add(this.labLaipni);
            this.Controls.Add(this.labLabdien);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "atm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labLabdien;
        private System.Windows.Forms.Label labLaipni;
        private System.Windows.Forms.Label labNixmoney;
        private System.Windows.Forms.Label labBankomata;
        private System.Windows.Forms.Label labIzvelieties;
        private System.Windows.Forms.Button btnIenakt;
        private System.Windows.Forms.Button btnRegistreties;
    }
}

