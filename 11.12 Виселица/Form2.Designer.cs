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
            txtGamePr.Font = new Font("Verdana", 10F, FontStyle.Bold);
            txtGamePr.Location = new Point(56, 89);
            txtGamePr.Name = "txtGamePr";
            txtGamePr.Size = new Size(503, 146);
            txtGamePr.TabIndex = 0;
            txtGamePr.Text = resources.GetString("txtGamePr.Text");
            // 
            // FormPr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 287);
            Controls.Add(txtGamePr);
            Name = "FormPr";
            Text = "Правила";
            ResumeLayout(false);
        }

        #endregion

        private Label txtGamePr;
    }
}