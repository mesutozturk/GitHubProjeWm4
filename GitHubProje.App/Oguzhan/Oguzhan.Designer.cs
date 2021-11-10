
namespace GitHubProje.App.Oguzhan
{
    partial class Oguzhan
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
            this.lblName = new System.Windows.Forms.Label();
            this.btnOguzhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(324, 91);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(80, 21);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Oguzhans";
            // 
            // btnOguzhan
            // 
            this.btnOguzhan.AutoSize = true;
            this.btnOguzhan.BackColor = System.Drawing.Color.PeachPuff;
            this.btnOguzhan.ForeColor = System.Drawing.Color.Red;
            this.btnOguzhan.Location = new System.Drawing.Point(241, 145);
            this.btnOguzhan.Name = "btnOguzhan";
            this.btnOguzhan.Size = new System.Drawing.Size(297, 25);
            this.btnOguzhan.TabIndex = 1;
            this.btnOguzhan.Text = "Click the Button how many people we have Oguzhan";
            this.btnOguzhan.UseVisualStyleBackColor = false;
            this.btnOguzhan.Click += new System.EventHandler(this.btnOguzhan_Click);
            // 
            // Oguzhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOguzhan);
            this.Controls.Add(this.lblName);
            this.Name = "Oguzhan";
            this.Text = "Oguzhan";
            this.Load += new System.EventHandler(this.Oguzhan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnOguzhan;
    }
}