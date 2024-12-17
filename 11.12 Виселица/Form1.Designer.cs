namespace _11._12_Виселица
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
            lbl = new Label();
            pictureBox = new PictureBox();
            lblOver = new Label();
            txtTema = new Label();
            txtClue = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 20F);
            lbl.Location = new Point(337, 378);
            lbl.Name = "lbl";
            lbl.Size = new Size(0, 37);
            lbl.TabIndex = 0;
            // 
            // pictureBox
            // 
            pictureBox.BackgroundImageLayout = ImageLayout.None;
            pictureBox.Image = Properties.Resources._00;
            pictureBox.ImageLocation = "";
            pictureBox.Location = new Point(317, 98);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(199, 257);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // lblOver
            // 
            lblOver.AutoSize = true;
            lblOver.Font = new Font("Verdana", 18F, FontStyle.Bold);
            lblOver.Location = new Point(318, 57);
            lblOver.Name = "lblOver";
            lblOver.Size = new Size(0, 29);
            lblOver.TabIndex = 2;
            // 
            // txtTema
            // 
            txtTema.AutoSize = true;
            txtTema.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTema.Location = new Point(12, 386);
            txtTema.Name = "txtTema";
            txtTema.Size = new Size(148, 29);
            txtTema.TabIndex = 3;
            txtTema.Text = "Тема: еда";
            // 
            // txtClue
            // 
            txtClue.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtClue.Location = new Point(217, 9);
            txtClue.Name = "txtClue";
            txtClue.Size = new Size(380, 29);
            txtClue.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(txtClue);
            Controls.Add(txtTema);
            Controls.Add(lblOver);
            Controls.Add(pictureBox);
            Controls.Add(lbl);
            Name = "Form1";
            Text = "Игра виселица";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl;
        private PictureBox pictureBox;
        private Label lblOver;
        private Label txtTema;
        private Label txtClue;
    }
}
