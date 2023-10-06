namespace SageKiller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ButtnImage = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // ButtnImage
            // 
            ButtnImage.BackgroundImage = (Image)resources.GetObject("ButtnImage.BackgroundImage");
            ButtnImage.BackgroundImageLayout = ImageLayout.Stretch;
            ButtnImage.Location = new Point(335, 128);
            ButtnImage.Name = "ButtnImage";
            ButtnImage.Size = new Size(103, 117);
            ButtnImage.TabIndex = 0;
            ButtnImage.UseVisualStyleBackColor = true;
            ButtnImage.Click += ButtnImage_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 11);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Puntos:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(ButtnImage);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtnImage;
        private Label label1;
    }
}