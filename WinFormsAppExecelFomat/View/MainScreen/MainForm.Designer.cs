namespace WinFormsAppExecelFomat.View.MainScreen
{
    partial class MainForm
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
            label1 = new Label();
            btn_PersonalTool = new Button();
            btn_ToolExcel = new Button();
            btn_SNOW_UTC = new Button();
            pictureBox_National_flag = new PictureBox();
            btn_ExitApp = new Button();
            cbb_LanguageChoice = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_National_flag).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(529, 19);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Languge";
            // 
            // btn_PersonalTool
            // 
            btn_PersonalTool.Location = new Point(31, 19);
            btn_PersonalTool.Name = "btn_PersonalTool";
            btn_PersonalTool.Size = new Size(443, 66);
            btn_PersonalTool.TabIndex = 2;
            btn_PersonalTool.Text = "Personal Tool";
            btn_PersonalTool.UseVisualStyleBackColor = true;
            // 
            // btn_ToolExcel
            // 
            btn_ToolExcel.Location = new Point(31, 114);
            btn_ToolExcel.Name = "btn_ToolExcel";
            btn_ToolExcel.Size = new Size(443, 66);
            btn_ToolExcel.TabIndex = 3;
            btn_ToolExcel.Text = "Tool Excel";
            btn_ToolExcel.UseVisualStyleBackColor = true;
            // 
            // btn_SNOW_UTC
            // 
            btn_SNOW_UTC.Location = new Point(31, 209);
            btn_SNOW_UTC.Name = "btn_SNOW_UTC";
            btn_SNOW_UTC.Size = new Size(443, 66);
            btn_SNOW_UTC.TabIndex = 4;
            btn_SNOW_UTC.Text = "SNOW UTC Case";
            btn_SNOW_UTC.UseVisualStyleBackColor = true;
            // 
            // pictureBox_National_flag
            // 
            pictureBox_National_flag.Location = new Point(529, 59);
            pictureBox_National_flag.Name = "pictureBox_National_flag";
            pictureBox_National_flag.Size = new Size(171, 132);
            pictureBox_National_flag.TabIndex = 5;
            pictureBox_National_flag.TabStop = false;
            // 
            // btn_ExitApp
            // 
            btn_ExitApp.BackColor = Color.Red;
            btn_ExitApp.Location = new Point(534, 224);
            btn_ExitApp.Name = "btn_ExitApp";
            btn_ExitApp.Size = new Size(166, 51);
            btn_ExitApp.TabIndex = 6;
            btn_ExitApp.Text = " Exit";
            btn_ExitApp.UseVisualStyleBackColor = false;
            btn_ExitApp.Click += btn_ExitApp_Click;
            // 
            // cbb_LanguageChoice
            // 
            cbb_LanguageChoice.FormattingEnabled = true;
            cbb_LanguageChoice.Items.AddRange(new object[] { "en" });
            cbb_LanguageChoice.Location = new Point(615, 22);
            cbb_LanguageChoice.Name = "cbb_LanguageChoice";
            cbb_LanguageChoice.Size = new Size(85, 28);
            cbb_LanguageChoice.TabIndex = 7;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 312);
            Controls.Add(cbb_LanguageChoice);
            Controls.Add(btn_ExitApp);
            Controls.Add(pictureBox_National_flag);
            Controls.Add(btn_SNOW_UTC);
            Controls.Add(btn_ToolExcel);
            Controls.Add(btn_PersonalTool);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox_National_flag).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_PersonalTool;
        private Button btn_ToolExcel;
        private Button btn_SNOW_UTC;
        private PictureBox pictureBox_National_flag;
        private Button btn_ExitApp;
        private ComboBox cbb_LanguageChoice;
    }
}