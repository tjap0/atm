namespace atm
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.labIevadit = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.btnGatavs = new System.Windows.Forms.Button();
            this.btnCIta = new System.Windows.Forms.Button();
            this.btnIziet = new System.Windows.Forms.Button();
            this.labMaks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labIevadit
            // 
            this.labIevadit.AutoSize = true;
            this.labIevadit.BackColor = System.Drawing.Color.Transparent;
            this.labIevadit.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labIevadit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.labIevadit.Location = new System.Drawing.Point(90, 262);
            this.labIevadit.Name = "labIevadit";
            this.labIevadit.Size = new System.Drawing.Size(361, 32);
            this.labIevadit.TabIndex = 0;
            this.labIevadit.Text = "LŪDZU, IEVADIET SUMMU";
            // 
            // textBoxSum
            // 
            this.textBoxSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(212)))), ((int)(((byte)(207)))));
            this.textBoxSum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSum.Location = new System.Drawing.Point(110, 366);
            this.textBoxSum.Multiline = true;
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(226, 36);
            this.textBoxSum.TabIndex = 5;
            this.textBoxSum.TextChanged += new System.EventHandler(this.textBoxSum_TextChanged);
            this.textBoxSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSum_KeyPress);
            // 
            // btnGatavs
            // 
            this.btnGatavs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(90)))));
            this.btnGatavs.FlatAppearance.BorderSize = 0;
            this.btnGatavs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGatavs.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGatavs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnGatavs.Location = new System.Drawing.Point(90, 488);
            this.btnGatavs.Name = "btnGatavs";
            this.btnGatavs.Size = new System.Drawing.Size(360, 71);
            this.btnGatavs.TabIndex = 10;
            this.btnGatavs.Text = "GATAVS";
            this.btnGatavs.UseVisualStyleBackColor = false;
            this.btnGatavs.Click += new System.EventHandler(this.btnGatavs_Click);
            // 
            // btnCIta
            // 
            this.btnCIta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(90)))));
            this.btnCIta.FlatAppearance.BorderSize = 0;
            this.btnCIta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCIta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCIta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnCIta.Location = new System.Drawing.Point(606, 488);
            this.btnCIta.Name = "btnCIta";
            this.btnCIta.Size = new System.Drawing.Size(360, 71);
            this.btnCIta.TabIndex = 12;
            this.btnCIta.Text = "CITA OPERACIJA";
            this.btnCIta.UseVisualStyleBackColor = false;
            this.btnCIta.Click += new System.EventHandler(this.btnCIta_Click);
            // 
            // btnIziet
            // 
            this.btnIziet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(90)))));
            this.btnIziet.FlatAppearance.BorderSize = 0;
            this.btnIziet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIziet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIziet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnIziet.Location = new System.Drawing.Point(606, 621);
            this.btnIziet.Name = "btnIziet";
            this.btnIziet.Size = new System.Drawing.Size(360, 71);
            this.btnIziet.TabIndex = 13;
            this.btnIziet.Text = "IZIET";
            this.btnIziet.UseVisualStyleBackColor = false;
            this.btnIziet.Click += new System.EventHandler(this.btnIziet_Click);
            // 
            // labMaks
            // 
            this.labMaks.AutoSize = true;
            this.labMaks.BackColor = System.Drawing.Color.Transparent;
            this.labMaks.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMaks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.labMaks.Location = new System.Drawing.Point(92, 429);
            this.labMaks.Name = "labMaks";
            this.labMaks.Size = new System.Drawing.Size(211, 19);
            this.labMaks.TabIndex = 20;
            this.labMaks.Text = "maksimālā summa 10 000 €";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 853);
            this.Controls.Add(this.labMaks);
            this.Controls.Add(this.btnIziet);
            this.Controls.Add(this.btnCIta);
            this.Controls.Add(this.btnGatavs);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.labIevadit);
            this.DoubleBuffered = true;
            this.Name = "Form7";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "atm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labIevadit;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Button btnGatavs;
        private System.Windows.Forms.Button btnCIta;
        private System.Windows.Forms.Button btnIziet;
        private System.Windows.Forms.Label labMaks;
    }
}