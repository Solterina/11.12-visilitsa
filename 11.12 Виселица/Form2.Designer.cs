namespace _11._12_Виселица
{
    partial class FormPr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPr));
            txtGamePr = new Label();
            SuspendLayout();
            // 
            // txtGamePr
            // 
            txtGamePr.BackColor = Color.Transparent;
            txtGamePr.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtGamePr.Location = new Point(42, 59);
            txtGamePr.Name = "txtGamePr";
            txtGamePr.Size = new Size(503, 100);
            txtGamePr.TabIndex = 0;
            txtGamePr.Text = resources.GetString("txtGamePr.Text");
            // 
            // FormPr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.paper_texture_cells_55327_1920x1080;
            ClientSize = new Size(554, 217);
            Controls.Add(txtGamePr);
            Name = "FormPr";
            Text = "Правила";
            ResumeLayout(false);
        }

        #endregion

        private Label txtGamePr;
    }
}