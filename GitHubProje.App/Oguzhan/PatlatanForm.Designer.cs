
namespace GitHubProje.App.Oguzhan
{
    partial class PatlatanForm
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
            this.btnPatlamaButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPatlamaButon
            // 
            this.btnPatlamaButon.Location = new System.Drawing.Point(225, 116);
            this.btnPatlamaButon.Name = "btnPatlamaButon";
            this.btnPatlamaButon.Size = new System.Drawing.Size(291, 179);
            this.btnPatlamaButon.TabIndex = 0;
            this.btnPatlamaButon.Text = "Patlayacak";
            this.btnPatlamaButon.UseVisualStyleBackColor = true;
            // 
            // PatlatanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPatlamaButon);
            this.Name = "PatlatanForm";
            this.Text = "PatlatanForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPatlamaButon;
    }
}