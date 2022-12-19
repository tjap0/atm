namespace atm
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.labIenakt = new System.Windows.Forms.Label();
            this.labPin = new System.Windows.Forms.Label();
            this.labCipari = new System.Windows.Forms.Label();
            this.textBoxIenakt = new System.Windows.Forms.TextBox();
            this.btnGatavs = new System.Windows.Forms.Button();
            this.btnCita = new System.Windows.Forms.Button();
            this.btnIziet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labIenakt
            // 
            this.labIenakt.AutoSize = true;
            this.labIenakt.BackColor = System.Drawing.Color.Transparent;
            this.labIenakt.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labIenakt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.labIenakt.Location = new System.Drawing.Point(117, 184);
            this.labIenakt.Name = "labIenakt";
            this.labIenakt.Size = new System.Drawing.Size(137, 38);
            this.labIenakt.TabIndex = 0;
            this.labIenakt.Text = "IENĀKT";
            this.labIenakt.Click += new System.EventHandler(this.labIenakt_Click);
            // 
            // labPin
            // 
            this.labPin.AutoSize = true;
            this.labPin.BackColor = System.Drawing.Color.Transparent;
            this.labPin.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.labPin.Location = new System.Drawing.Point(118, 276);
            this.labPin.Name = "labPin";
            this.labPin.Size = new System.Drawing.Size(326, 32);
            this.labPin.TabIndex = 1;
            this.labPin.Text = "Lūdzu, ievadiet PIN kodu";
            this.labPin.Click += new System.EventHandler(this.labPin_Click);
            // 
            // labCipari
            // 
            this.labCipari.AutoSize = true;
            this.labCipari.BackColor = System.Drawing.Color.Transparent;
            this.labCipari.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCipari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.labCipari.Location = new System.Drawing.Point(120, 416);
            this.labCipari.Name = "labCipari";
            this.labCipari.Size = new System.Drawing.Size(64, 19);
            this.labCipari.TabIndex = 2;
            this.labCipari.Text = "4 cipari";
            // 
            // textBoxIenakt
            // 
            this.textBoxIenakt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(212)))), ((int)(((byte)(207)))));
            this.textBoxIenakt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIenakt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxIenakt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIenakt.Location = new System.Drawing.Point(124, 353);
            this.textBoxIenakt.Multiline = true;
            this.textBoxIenakt.Name = "textBoxIenakt";
            this.textBoxIenakt.Size = new System.Drawing.Size(259, 36);
            this.textBoxIenakt.TabIndex = 3;
            this.textBoxIenakt.TextChanged += new System.EventHandler(this.textBoxIenakt_TextChanged);
            this.textBoxIenakt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIenakt_KeyPress);
            // 
            // btnGatavs
            // 
            this.btnGatavs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(90)))));
            this.btnGatavs.FlatAppearance.BorderSize = 0;
            this.btnGatavs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGatavs.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGatavs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnGatavs.Location = new System.Drawing.Point(124, 487);
            this.btnGatavs.Name = "btnGatavs";
            this.btnGatavs.Size = new System.Drawing.Size(360, 71);
            this.btnGatavs.TabIndex = 4;
            this.btnGatavs.Text = "GATAVS";
            this.btnGatavs.UseVisualStyleBackColor = false;
            this.btnGatavs.Click += new System.EventHandler(this.btnGatavs_Click);
            // 
            // btnCita
            // 
            this.btnCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(90)))));
            this.btnCita.FlatAppearance.BorderSize = 0;
            this.btnCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCita.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnCita.Location = new System.Drawing.Point(609, 487);
            this.btnCita.Name = "btnCita";
            this.btnCita.Size = new System.Drawing.Size(360, 71);
            this.btnCita.TabIndex = 5;
            this.btnCita.Text = "CITA OPERACIJA";
            this.btnCita.UseVisualStyleBackColor = false;
            this.btnCita.Click += new System.EventHandler(this.btnCita_Click);
            // 
            // btnIziet
            // 
            this.btnIziet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(90)))));
            this.btnIziet.FlatAppearance.BorderSize = 0;
            this.btnIziet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIziet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIziet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnIziet.Location = new System.Drawing.Point(609, 610);
            this.btnIziet.Name = "btnIziet";
            this.btnIziet.Size = new System.Drawing.Size(360, 71);
            this.btnIziet.TabIndex = 6;
            this.btnIziet.Text = "IZIET";
            this.btnIziet.UseVisualStyleBackColor = false;
            this.btnIziet.Click += new System.EventHandler(this.btnIziet_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 853);
            this.Controls.Add(this.btnIziet);
            this.Controls.Add(this.btnCita);
            this.Controls.Add(this.btnGatavs);
            this.Controls.Add(this.textBoxIenakt);
            this.Controls.Add(this.labCipari);
            this.Controls.Add(this.labPin);
            this.Controls.Add(this.labIenakt);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "atm";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labIenakt;
        private System.Windows.Forms.Label labPin;
        private System.Windows.Forms.Label labCipari;
        private System.Windows.Forms.TextBox textBoxIenakt;
        private System.Windows.Forms.Button btnGatavs;
        private System.Windows.Forms.Button btnCita;
        private System.Windows.Forms.Button btnIziet;
    }
}