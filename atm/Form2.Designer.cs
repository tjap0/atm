namespace atm
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.labAtvainojiet = new System.Windows.Forms.Label();
            this.labPinIzmainits = new System.Windows.Forms.Label();
            this.btnCita = new System.Windows.Forms.Button();
            this.btnIziet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labAtvainojiet
            // 
            this.labAtvainojiet.BackColor = System.Drawing.Color.Transparent;
            this.labAtvainojiet.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAtvainojiet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.labAtvainojiet.Location = new System.Drawing.Point(155, 291);
            this.labAtvainojiet.Name = "labAtvainojiet";
            this.labAtvainojiet.Size = new System.Drawing.Size(747, 43);
            this.labAtvainojiet.TabIndex = 1;
            this.labAtvainojiet.Text = "PALDIES!";
            this.labAtvainojiet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labAtvainojiet.Click += new System.EventHandler(this.labAtvainojiet_Click);
            // 
            // labPinIzmainits
            // 
            this.labPinIzmainits.BackColor = System.Drawing.Color.Transparent;
            this.labPinIzmainits.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPinIzmainits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.labPinIzmainits.Location = new System.Drawing.Point(155, 397);
            this.labPinIzmainits.Name = "labPinIzmainits";
            this.labPinIzmainits.Size = new System.Drawing.Size(747, 49);
            this.labPinIzmainits.TabIndex = 2;
            this.labPinIzmainits.Text = "PIN kods ir izmainīts!";
            this.labPinIzmainits.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCita
            // 
            this.btnCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(90)))));
            this.btnCita.FlatAppearance.BorderSize = 0;
            this.btnCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCita.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnCita.Location = new System.Drawing.Point(85, 626);
            this.btnCita.Name = "btnCita";
            this.btnCita.Size = new System.Drawing.Size(361, 71);
            this.btnCita.TabIndex = 3;
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
            this.btnIziet.Location = new System.Drawing.Point(608, 626);
            this.btnIziet.Name = "btnIziet";
            this.btnIziet.Size = new System.Drawing.Size(361, 71);
            this.btnIziet.TabIndex = 4;
            this.btnIziet.Text = "IZIET";
            this.btnIziet.UseVisualStyleBackColor = false;
            this.btnIziet.Click += new System.EventHandler(this.btnIziet_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 853);
            this.Controls.Add(this.btnIziet);
            this.Controls.Add(this.btnCita);
            this.Controls.Add(this.labPinIzmainits);
            this.Controls.Add(this.labAtvainojiet);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "atm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labAtvainojiet;
        private System.Windows.Forms.Label labPinIzmainits;
        private System.Windows.Forms.Button btnCita;
        private System.Windows.Forms.Button btnIziet;
    }
}