namespace atm
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.labIevadietPin = new System.Windows.Forms.Label();
            this.textBoxPin1 = new System.Windows.Forms.TextBox();
            this.labCipari1 = new System.Windows.Forms.Label();
            this.labJaunuPin = new System.Windows.Forms.Label();
            this.textBoxPin2 = new System.Windows.Forms.TextBox();
            this.labCipari2 = new System.Windows.Forms.Label();
            this.btnGatavs = new System.Windows.Forms.Button();
            this.btnIziet = new System.Windows.Forms.Button();
            this.btnCIta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labIevadietPin
            // 
            this.labIevadietPin.AutoSize = true;
            this.labIevadietPin.BackColor = System.Drawing.Color.Transparent;
            this.labIevadietPin.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labIevadietPin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.labIevadietPin.Location = new System.Drawing.Point(90, 224);
            this.labIevadietPin.Name = "labIevadietPin";
            this.labIevadietPin.Size = new System.Drawing.Size(467, 32);
            this.labIevadietPin.TabIndex = 0;
            this.labIevadietPin.Text = "Lūdzu, ievadiet  pašreizējo PIN kodu";
            this.labIevadietPin.Click += new System.EventHandler(this.labIevadietPin_Click);
            // 
            // textBoxPin1
            // 
            this.textBoxPin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(212)))), ((int)(((byte)(207)))));
            this.textBoxPin1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPin1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPin1.Location = new System.Drawing.Point(102, 294);
            this.textBoxPin1.Multiline = true;
            this.textBoxPin1.Name = "textBoxPin1";
            this.textBoxPin1.Size = new System.Drawing.Size(259, 36);
            this.textBoxPin1.TabIndex = 4;
            this.textBoxPin1.TextChanged += new System.EventHandler(this.textBoxPin1_TextChanged);
            this.textBoxPin1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPin1_KeyPress);
            // 
            // labCipari1
            // 
            this.labCipari1.AutoSize = true;
            this.labCipari1.BackColor = System.Drawing.Color.Transparent;
            this.labCipari1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCipari1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.labCipari1.Location = new System.Drawing.Point(90, 358);
            this.labCipari1.Name = "labCipari1";
            this.labCipari1.Size = new System.Drawing.Size(64, 19);
            this.labCipari1.TabIndex = 5;
            this.labCipari1.Text = "4 cipari";
            // 
            // labJaunuPin
            // 
            this.labJaunuPin.AutoSize = true;
            this.labJaunuPin.BackColor = System.Drawing.Color.Transparent;
            this.labJaunuPin.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labJaunuPin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.labJaunuPin.Location = new System.Drawing.Point(90, 437);
            this.labJaunuPin.Name = "labJaunuPin";
            this.labJaunuPin.Size = new System.Drawing.Size(411, 32);
            this.labJaunuPin.TabIndex = 6;
            this.labJaunuPin.Text = "Lūdzu, ievadiet  jaunu PIN kodu";
            // 
            // textBoxPin2
            // 
            this.textBoxPin2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(212)))), ((int)(((byte)(207)))));
            this.textBoxPin2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPin2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPin2.Location = new System.Drawing.Point(108, 511);
            this.textBoxPin2.Multiline = true;
            this.textBoxPin2.Name = "textBoxPin2";
            this.textBoxPin2.Size = new System.Drawing.Size(259, 36);
            this.textBoxPin2.TabIndex = 7;
            this.textBoxPin2.TextChanged += new System.EventHandler(this.textBoxPin2_TextChanged);
            this.textBoxPin2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPin2_KeyPress);
            // 
            // labCipari2
            // 
            this.labCipari2.AutoSize = true;
            this.labCipari2.BackColor = System.Drawing.Color.Transparent;
            this.labCipari2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCipari2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.labCipari2.Location = new System.Drawing.Point(90, 575);
            this.labCipari2.Name = "labCipari2";
            this.labCipari2.Size = new System.Drawing.Size(64, 19);
            this.labCipari2.TabIndex = 8;
            this.labCipari2.Text = "4 cipari";
            // 
            // btnGatavs
            // 
            this.btnGatavs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(90)))));
            this.btnGatavs.FlatAppearance.BorderSize = 0;
            this.btnGatavs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGatavs.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGatavs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnGatavs.Location = new System.Drawing.Point(96, 662);
            this.btnGatavs.Name = "btnGatavs";
            this.btnGatavs.Size = new System.Drawing.Size(360, 71);
            this.btnGatavs.TabIndex = 9;
            this.btnGatavs.Text = "GATAVS";
            this.btnGatavs.UseVisualStyleBackColor = false;
            this.btnGatavs.Click += new System.EventHandler(this.btnGatavs_Click);
            // 
            // btnIziet
            // 
            this.btnIziet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(90)))));
            this.btnIziet.FlatAppearance.BorderSize = 0;
            this.btnIziet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIziet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIziet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnIziet.Location = new System.Drawing.Point(614, 662);
            this.btnIziet.Name = "btnIziet";
            this.btnIziet.Size = new System.Drawing.Size(360, 71);
            this.btnIziet.TabIndex = 10;
            this.btnIziet.Text = "IZIET";
            this.btnIziet.UseVisualStyleBackColor = false;
            this.btnIziet.Click += new System.EventHandler(this.btnIziet_Click);
            // 
            // btnCIta
            // 
            this.btnCIta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(90)))));
            this.btnCIta.FlatAppearance.BorderSize = 0;
            this.btnCIta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCIta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCIta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnCIta.Location = new System.Drawing.Point(614, 547);
            this.btnCIta.Name = "btnCIta";
            this.btnCIta.Size = new System.Drawing.Size(360, 71);
            this.btnCIta.TabIndex = 11;
            this.btnCIta.Text = "CITA OPERACIJA";
            this.btnCIta.UseVisualStyleBackColor = false;
            this.btnCIta.Click += new System.EventHandler(this.btnCIta_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 853);
            this.Controls.Add(this.btnCIta);
            this.Controls.Add(this.btnIziet);
            this.Controls.Add(this.btnGatavs);
            this.Controls.Add(this.labCipari2);
            this.Controls.Add(this.textBoxPin2);
            this.Controls.Add(this.labJaunuPin);
            this.Controls.Add(this.labCipari1);
            this.Controls.Add(this.textBoxPin1);
            this.Controls.Add(this.labIevadietPin);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "atm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labIevadietPin;
        private System.Windows.Forms.TextBox textBoxPin1;
        private System.Windows.Forms.Label labCipari1;
        private System.Windows.Forms.Label labJaunuPin;
        private System.Windows.Forms.TextBox textBoxPin2;
        private System.Windows.Forms.Label labCipari2;
        private System.Windows.Forms.Button btnGatavs;
        private System.Windows.Forms.Button btnIziet;
        private System.Windows.Forms.Button btnCIta;
    }
}