namespace atm
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.labGaidisim = new System.Windows.Forms.Label();
            this.labPaldies = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labGaidisim
            // 
            this.labGaidisim.BackColor = System.Drawing.Color.Transparent;
            this.labGaidisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGaidisim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.labGaidisim.Location = new System.Drawing.Point(159, 418);
            this.labGaidisim.Name = "labGaidisim";
            this.labGaidisim.Size = new System.Drawing.Size(747, 49);
            this.labGaidisim.TabIndex = 8;
            this.labGaidisim.Text = "Gaidīsim Jūs atpakaļ!";
            this.labGaidisim.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labPaldies
            // 
            this.labPaldies.BackColor = System.Drawing.Color.Transparent;
            this.labPaldies.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPaldies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.labPaldies.Location = new System.Drawing.Point(159, 312);
            this.labPaldies.Name = "labPaldies";
            this.labPaldies.Size = new System.Drawing.Size(747, 43);
            this.labPaldies.TabIndex = 7;
            this.labPaldies.Text = "PALDIES!";
            this.labPaldies.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 853);
            this.Controls.Add(this.labGaidisim);
            this.Controls.Add(this.labPaldies);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form12";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "atm";
            this.Load += new System.EventHandler(this.Form12_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labGaidisim;
        private System.Windows.Forms.Label labPaldies;
    }
}