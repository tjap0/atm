﻿namespace atm
{
    partial class Form13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13));
            this.labTiesi = new System.Windows.Forms.Label();
            this.labIzmaks = new System.Windows.Forms.Label();
            this.btnIziet = new System.Windows.Forms.Button();
            this.btnCita = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labTiesi
            // 
            this.labTiesi.BackColor = System.Drawing.Color.Transparent;
            this.labTiesi.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTiesi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.labTiesi.Location = new System.Drawing.Point(157, 287);
            this.labTiesi.Name = "labTiesi";
            this.labTiesi.Size = new System.Drawing.Size(747, 91);
            this.labTiesi.TabIndex = 10;
            this.labTiesi.Text = "VAI JŪS TIEŠĀM VELĀTIES\r\nIZIET NO BANKOMĀTA?\r\n";
            this.labTiesi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labIzmaks
            // 
            this.labIzmaks.BackColor = System.Drawing.Color.Transparent;
            this.labIzmaks.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labIzmaks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.labIzmaks.Location = new System.Drawing.Point(233, 402);
            this.labIzmaks.Name = "labIzmaks";
            this.labIzmaks.Size = new System.Drawing.Size(592, 98);
            this.labIzmaks.TabIndex = 11;
            this.labIzmaks.Text = "Noklikšķinot uz pogas, programma tiks aizvērta";
            this.labIzmaks.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnIziet
            // 
            this.btnIziet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(90)))));
            this.btnIziet.FlatAppearance.BorderSize = 0;
            this.btnIziet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIziet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIziet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnIziet.Location = new System.Drawing.Point(617, 635);
            this.btnIziet.Name = "btnIziet";
            this.btnIziet.Size = new System.Drawing.Size(361, 71);
            this.btnIziet.TabIndex = 14;
            this.btnIziet.Text = "IZIET";
            this.btnIziet.UseVisualStyleBackColor = false;
            this.btnIziet.Click += new System.EventHandler(this.btnIziet_Click);
            // 
            // btnCita
            // 
            this.btnCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(90)))));
            this.btnCita.FlatAppearance.BorderSize = 0;
            this.btnCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCita.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnCita.Location = new System.Drawing.Point(94, 635);
            this.btnCita.Name = "btnCita";
            this.btnCita.Size = new System.Drawing.Size(361, 71);
            this.btnCita.TabIndex = 13;
            this.btnCita.Text = "ATPAKAĻ";
            this.btnCita.UseVisualStyleBackColor = false;
            this.btnCita.Click += new System.EventHandler(this.btnCita_Click);
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 853);
            this.Controls.Add(this.btnIziet);
            this.Controls.Add(this.btnCita);
            this.Controls.Add(this.labIzmaks);
            this.Controls.Add(this.labTiesi);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form13";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "atm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labTiesi;
        private System.Windows.Forms.Label labIzmaks;
        private System.Windows.Forms.Button btnIziet;
        private System.Windows.Forms.Button btnCita;
    }
}