namespace GepiLatasDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.greyButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.canny = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            // 
            // greyButton
            // 
            this.greyButton.Location = new System.Drawing.Point(25, 43);
            this.greyButton.Name = "greyButton";
            this.greyButton.Size = new System.Drawing.Size(75, 23);
            this.greyButton.TabIndex = 0;
            this.greyButton.Text = "Grayscale";
            this.greyButton.UseVisualStyleBackColor = true;
            this.greyButton.Click += new System.EventHandler(this.grayButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(187, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.SizeChanged += new System.EventHandler(this.pictureBox1_SizeChanged);
            // 
            // canny
            // 
            this.canny.Location = new System.Drawing.Point(25, 72);
            this.canny.Name = "canny";
            this.canny.Size = new System.Drawing.Size(75, 23);
            this.canny.TabIndex = 2;
            this.canny.Text = "Canny";
            this.canny.UseVisualStyleBackColor = true;
            this.canny.Click += new System.EventHandler(this.canny_Click);
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(25, 14);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(75, 23);
            this.load.TabIndex = 3;
            this.load.Text = "Load image";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 598);
            this.Controls.Add(this.load);
            this.Controls.Add(this.canny);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.greyButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();

        }

        #endregion

        private System.Windows.Forms.Button greyButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button canny;
        private System.Windows.Forms.Button load;
    }
}

