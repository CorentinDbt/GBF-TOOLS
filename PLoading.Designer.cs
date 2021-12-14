namespace KPI_Tools
{
    partial class PLoading
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Load1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Pource1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Load1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Load1
            // 
            this.Load1.BackColor = System.Drawing.Color.Transparent;
            this.Load1.Controls.Add(this.Pource1);
            this.Load1.FillColor = System.Drawing.Color.White;
            this.Load1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Load1.ForeColor = System.Drawing.Color.White;
            this.Load1.InnerColor = System.Drawing.Color.Transparent;
            this.Load1.Location = new System.Drawing.Point(144, 68);
            this.Load1.Minimum = 0;
            this.Load1.Name = "Load1";
            this.Load1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.Load1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(68)))), ((int)(((byte)(84)))));
            this.Load1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Load1.ShadowDecoration.Parent = this.Load1;
            this.Load1.Size = new System.Drawing.Size(130, 130);
            this.Load1.TabIndex = 0;
            this.Load1.Text = "Load1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Pource1
            // 
            this.Pource1.AutoSize = true;
            this.Pource1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pource1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(68)))), ((int)(((byte)(84)))));
            this.Pource1.Location = new System.Drawing.Point(44, 55);
            this.Pource1.Name = "Pource1";
            this.Pource1.Size = new System.Drawing.Size(25, 19);
            this.Pource1.TabIndex = 0;
            this.Pource1.Text = "%";
            this.Pource1.Click += new System.EventHandler(this.Pource1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(68)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(127, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "KPI\'Tools";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(207)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(421, 236);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Load1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PLoading_Load);
            this.Load1.ResumeLayout(false);
            this.Load1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleProgressBar Load1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Pource1;
        private System.Windows.Forms.Label label1;
    }
}

