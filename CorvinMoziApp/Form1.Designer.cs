namespace CorvinMoziApp
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
            this.pictureBox_Nevado = new System.Windows.Forms.PictureBox();
            this.button_Balra = new System.Windows.Forms.Button();
            this.button_Jobbra = new System.Windows.Forms.Button();
            this.button_Statisztika = new System.Windows.Forms.Button();
            this.button_Mentes = new System.Windows.Forms.Button();
            this.panel_Terem = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Nevado)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Nevado
            // 
            this.pictureBox_Nevado.Location = new System.Drawing.Point(37, 61);
            this.pictureBox_Nevado.Name = "pictureBox_Nevado";
            this.pictureBox_Nevado.Size = new System.Drawing.Size(100, 144);
            this.pictureBox_Nevado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Nevado.TabIndex = 0;
            this.pictureBox_Nevado.TabStop = false;
            // 
            // button_Balra
            // 
            this.button_Balra.BackColor = System.Drawing.Color.Transparent;
            this.button_Balra.BackgroundImage = global::CorvinMoziApp.Properties.Resources.balra;
            this.button_Balra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Balra.FlatAppearance.BorderSize = 0;
            this.button_Balra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Balra.Location = new System.Drawing.Point(37, 352);
            this.button_Balra.Name = "button_Balra";
            this.button_Balra.Size = new System.Drawing.Size(117, 64);
            this.button_Balra.TabIndex = 2;
            this.button_Balra.UseVisualStyleBackColor = false;
            this.button_Balra.Click += new System.EventHandler(this.button_Balra_Click);
            // 
            // button_Jobbra
            // 
            this.button_Jobbra.BackColor = System.Drawing.Color.Transparent;
            this.button_Jobbra.BackgroundImage = global::CorvinMoziApp.Properties.Resources.jobbra;
            this.button_Jobbra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Jobbra.FlatAppearance.BorderSize = 0;
            this.button_Jobbra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Jobbra.Location = new System.Drawing.Point(325, 352);
            this.button_Jobbra.Name = "button_Jobbra";
            this.button_Jobbra.Size = new System.Drawing.Size(117, 64);
            this.button_Jobbra.TabIndex = 2;
            this.button_Jobbra.UseVisualStyleBackColor = false;
            this.button_Jobbra.Click += new System.EventHandler(this.button_Jobbra_Click);
            // 
            // button_Statisztika
            // 
            this.button_Statisztika.Location = new System.Drawing.Point(251, 303);
            this.button_Statisztika.Name = "button_Statisztika";
            this.button_Statisztika.Size = new System.Drawing.Size(100, 43);
            this.button_Statisztika.TabIndex = 3;
            this.button_Statisztika.Text = "Statisztika";
            this.button_Statisztika.UseVisualStyleBackColor = true;
            this.button_Statisztika.Click += new System.EventHandler(this.button_Statisztika_Click);
            // 
            // button_Mentes
            // 
            this.button_Mentes.Location = new System.Drawing.Point(126, 303);
            this.button_Mentes.Name = "button_Mentes";
            this.button_Mentes.Size = new System.Drawing.Size(100, 43);
            this.button_Mentes.TabIndex = 3;
            this.button_Mentes.Text = "Mentés";
            this.button_Mentes.UseVisualStyleBackColor = true;
            this.button_Mentes.Click += new System.EventHandler(this.button_Mentes_Click);
            // 
            // panel_Terem
            // 
            this.panel_Terem.Location = new System.Drawing.Point(168, 29);
            this.panel_Terem.Name = "panel_Terem";
            this.panel_Terem.Size = new System.Drawing.Size(307, 247);
            this.panel_Terem.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 473);
            this.Controls.Add(this.panel_Terem);
            this.Controls.Add(this.button_Mentes);
            this.Controls.Add(this.button_Statisztika);
            this.Controls.Add(this.button_Jobbra);
            this.Controls.Add(this.button_Balra);
            this.Controls.Add(this.pictureBox_Nevado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Corvin Mozi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Nevado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Nevado;
        private System.Windows.Forms.Button button_Balra;
        private System.Windows.Forms.Button button_Jobbra;
        private System.Windows.Forms.Button button_Statisztika;
        private System.Windows.Forms.Button button_Mentes;
        private System.Windows.Forms.Panel panel_Terem;
    }
}

