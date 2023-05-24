namespace DrawingApp
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
            this.panel = new System.Windows.Forms.Panel();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnPen = new System.Windows.Forms.Button();
            this.gallery = new System.Windows.Forms.Panel();
            this.canvasPictureBox = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvasPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btnErase);
            this.panel.Controls.Add(this.btnPen);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1083, 53);
            this.panel.TabIndex = 0;
            // 
            // btnErase
            // 
            this.btnErase.Location = new System.Drawing.Point(61, 16);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(25, 24);
            this.btnErase.TabIndex = 1;
            this.btnErase.UseVisualStyleBackColor = true;
            // 
            // btnPen
            // 
            this.btnPen.Location = new System.Drawing.Point(15, 16);
            this.btnPen.Name = "btnPen";
            this.btnPen.Size = new System.Drawing.Size(25, 24);
            this.btnPen.TabIndex = 0;
            this.btnPen.UseVisualStyleBackColor = true;
            // 
            // gallery
            // 
            this.gallery.Location = new System.Drawing.Point(964, 81);
            this.gallery.Name = "gallery";
            this.gallery.Size = new System.Drawing.Size(130, 512);
            this.gallery.TabIndex = 2;
            // 
            // canvasPictureBox
            // 
            this.canvasPictureBox.Location = new System.Drawing.Point(12, 81);
            this.canvasPictureBox.Name = "canvasPictureBox";
            this.canvasPictureBox.Size = new System.Drawing.Size(946, 512);
            this.canvasPictureBox.TabIndex = 3;
            this.canvasPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 621);
            this.Controls.Add(this.canvasPictureBox);
            this.Controls.Add(this.gallery);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canvasPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnPen;
        private System.Windows.Forms.Panel gallery;
        private System.Windows.Forms.PictureBox canvasPictureBox;
    }
}

