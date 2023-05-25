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
            this.red = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvasPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.red);
            this.panel.Controls.Add(this.btnErase);
            this.panel.Controls.Add(this.btnPen);
            this.panel.Location = new System.Drawing.Point(9, 10);
            this.panel.Margin = new System.Windows.Forms.Padding(2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(812, 43);
            this.panel.TabIndex = 0;
            // 
            // btnErase
            // 
            this.btnErase.Location = new System.Drawing.Point(46, 13);
            this.btnErase.Margin = new System.Windows.Forms.Padding(2);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(19, 20);
            this.btnErase.TabIndex = 1;
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.BtnErase_Click);
            // 
            // btnPen
            // 
            this.btnPen.Location = new System.Drawing.Point(11, 13);
            this.btnPen.Margin = new System.Windows.Forms.Padding(2);
            this.btnPen.Name = "btnPen";
            this.btnPen.Size = new System.Drawing.Size(19, 20);
            this.btnPen.TabIndex = 0;
            this.btnPen.UseVisualStyleBackColor = true;
            // 
            // gallery
            // 
            this.gallery.Location = new System.Drawing.Point(723, 66);
            this.gallery.Margin = new System.Windows.Forms.Padding(2);
            this.gallery.Name = "gallery";
            this.gallery.Size = new System.Drawing.Size(98, 416);
            this.gallery.TabIndex = 2;
            // 
            // canvasPictureBox
            // 
            this.canvasPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvasPictureBox.Location = new System.Drawing.Point(9, 66);
            this.canvasPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.canvasPictureBox.Name = "canvasPictureBox";
            this.canvasPictureBox.Size = new System.Drawing.Size(710, 416);
            this.canvasPictureBox.TabIndex = 3;
            this.canvasPictureBox.TabStop = false;
            // 
            // red
            // 
            this.red.Location = new System.Drawing.Point(86, 13);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(49, 23);
            this.red.TabIndex = 2;
            this.red.Text = "red";
            this.red.UseVisualStyleBackColor = true;
            this.red.Click += new System.EventHandler(this.Red_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 505);
            this.Controls.Add(this.canvasPictureBox);
            this.Controls.Add(this.gallery);
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button red;
    }
}

