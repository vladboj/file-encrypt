namespace FileEncrypt.Forms
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
            TxtFilePath = new TextBox();
            BtnBrowse = new Button();
            TxtPassword = new MaskedTextBox();
            LblStatus = new Label();
            OfdSelectFile = new OpenFileDialog();
            ChkShowPassword = new CheckBox();
            SfdSaveFile = new SaveFileDialog();
            tableLayoutPanel1 = new TableLayoutPanel();
            RbtnDecrypt = new RadioButton();
            RbtnEncrypt = new RadioButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            LblFile = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            LblPassword = new Label();
            BtnExecute = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            BtnSaveFile = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // TxtFilePath
            // 
            TxtFilePath.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtFilePath.BackColor = SystemColors.ControlLight;
            TxtFilePath.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtFilePath.Location = new Point(85, 14);
            TxtFilePath.Name = "TxtFilePath";
            TxtFilePath.ReadOnly = true;
            TxtFilePath.Size = new Size(418, 43);
            TxtFilePath.TabIndex = 1;
            TxtFilePath.TextChanged += TxtFilePath_TextChanged;
            // 
            // BtnBrowse
            // 
            BtnBrowse.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnBrowse.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnBrowse.Location = new Point(509, 10);
            BtnBrowse.Name = "BtnBrowse";
            BtnBrowse.Size = new Size(140, 50);
            BtnBrowse.TabIndex = 2;
            BtnBrowse.Text = "Browse";
            BtnBrowse.UseVisualStyleBackColor = true;
            BtnBrowse.Click += BtnBrowse_Click;
            // 
            // TxtPassword
            // 
            TxtPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtPassword.Font = new Font("Segoe UI", 12F);
            TxtPassword.Location = new Point(169, 10);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(229, 50);
            TxtPassword.TabIndex = 4;
            TxtPassword.UseSystemPasswordChar = true;
            TxtPassword.TextChanged += TxtPassword_TextChanged;
            // 
            // LblStatus
            // 
            LblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            LblStatus.AutoSize = true;
            LblStatus.Font = new Font("Segoe UI", 12F);
            LblStatus.Location = new Point(326, 78);
            LblStatus.Name = "LblStatus";
            LblStatus.Size = new Size(0, 114);
            LblStatus.TabIndex = 8;
            LblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OfdSelectFile
            // 
            OfdSelectFile.DefaultExt = "txt";
            OfdSelectFile.Filter = "Text Files (*.txt)|*.txt";
            // 
            // ChkShowPassword
            // 
            ChkShowPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ChkShowPassword.AutoSize = true;
            ChkShowPassword.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChkShowPassword.Location = new Point(404, 13);
            ChkShowPassword.Name = "ChkShowPassword";
            ChkShowPassword.Size = new Size(245, 44);
            ChkShowPassword.TabIndex = 9;
            ChkShowPassword.Text = "Show Password";
            ChkShowPassword.UseVisualStyleBackColor = true;
            ChkShowPassword.CheckedChanged += ChkShowPassword_CheckedChanged;
            // 
            // SfdSaveFile
            // 
            SfdSaveFile.DefaultExt = "enc";
            SfdSaveFile.FileName = "encrypted_file.enc";
            SfdSaveFile.Filter = "Encrypted Files (*.enc)|*.enc";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(RbtnDecrypt, 1, 0);
            tableLayoutPanel1.Controls.Add(RbtnEncrypt, 0, 0);
            tableLayoutPanel1.Location = new Point(436, 63);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(335, 74);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // RbtnDecrypt
            // 
            RbtnDecrypt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            RbtnDecrypt.AutoSize = true;
            RbtnDecrypt.Font = new Font("Segoe UI", 12F);
            RbtnDecrypt.Location = new Point(170, 12);
            RbtnDecrypt.Name = "RbtnDecrypt";
            RbtnDecrypt.Size = new Size(162, 49);
            RbtnDecrypt.TabIndex = 8;
            RbtnDecrypt.TabStop = true;
            RbtnDecrypt.Text = "Decrypt";
            RbtnDecrypt.TextAlign = ContentAlignment.MiddleCenter;
            RbtnDecrypt.UseVisualStyleBackColor = true;
            // 
            // RbtnEncrypt
            // 
            RbtnEncrypt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            RbtnEncrypt.AutoSize = true;
            RbtnEncrypt.Checked = true;
            RbtnEncrypt.Font = new Font("Segoe UI", 12F);
            RbtnEncrypt.Location = new Point(3, 12);
            RbtnEncrypt.Name = "RbtnEncrypt";
            RbtnEncrypt.Size = new Size(161, 49);
            RbtnEncrypt.TabIndex = 7;
            RbtnEncrypt.TabStop = true;
            RbtnEncrypt.Text = "Encrypt";
            RbtnEncrypt.TextAlign = ContentAlignment.MiddleCenter;
            RbtnEncrypt.UseVisualStyleBackColor = true;
            RbtnEncrypt.CheckedChanged += RbtnEncrypt_CheckedChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.None;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(LblFile, 0, 0);
            tableLayoutPanel2.Controls.Add(BtnBrowse, 2, 0);
            tableLayoutPanel2.Controls.Add(TxtFilePath, 1, 0);
            tableLayoutPanel2.Location = new Point(278, 164);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(652, 71);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // LblFile
            // 
            LblFile.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFile.AutoSize = true;
            LblFile.Font = new Font("Segoe UI", 12F);
            LblFile.Location = new Point(3, 13);
            LblFile.Name = "LblFile";
            LblFile.Size = new Size(76, 45);
            LblFile.TabIndex = 3;
            LblFile.Text = "File:";
            LblFile.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.None;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Controls.Add(LblPassword, 0, 0);
            tableLayoutPanel3.Controls.Add(ChkShowPassword, 2, 0);
            tableLayoutPanel3.Controls.Add(TxtPassword, 1, 0);
            tableLayoutPanel3.Location = new Point(278, 264);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(652, 71);
            tableLayoutPanel3.TabIndex = 12;
            // 
            // LblPassword
            // 
            LblPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblPassword.AutoSize = true;
            LblPassword.Font = new Font("Segoe UI", 12F);
            LblPassword.Location = new Point(3, 13);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(160, 45);
            LblPassword.TabIndex = 10;
            LblPassword.Text = "Password:";
            LblPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnExecute
            // 
            BtnExecute.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            BtnExecute.Enabled = false;
            BtnExecute.Font = new Font("Segoe UI", 12F);
            BtnExecute.Location = new Point(238, 3);
            BtnExecute.Name = "BtnExecute";
            BtnExecute.Size = new Size(176, 72);
            BtnExecute.TabIndex = 7;
            BtnExecute.Text = "Encrypt";
            BtnExecute.UseVisualStyleBackColor = true;
            BtnExecute.Click += BtnExecute_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.None;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(BtnExecute, 0, 0);
            tableLayoutPanel4.Controls.Add(LblStatus, 0, 1);
            tableLayoutPanel4.Controls.Add(BtnSaveFile, 0, 2);
            tableLayoutPanel4.Location = new Point(278, 367);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 30.3501949F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 44.357975F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 24.9027233F));
            tableLayoutPanel4.Size = new Size(652, 257);
            tableLayoutPanel4.TabIndex = 13;
            // 
            // BtnSaveFile
            // 
            BtnSaveFile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            BtnSaveFile.Location = new Point(260, 195);
            BtnSaveFile.Name = "BtnSaveFile";
            BtnSaveFile.Size = new Size(132, 59);
            BtnSaveFile.TabIndex = 9;
            BtnSaveFile.Text = "Save File";
            BtnSaveFile.UseVisualStyleBackColor = true;
            BtnSaveFile.Visible = false;
            BtnSaveFile.Click += BtnSaveFile_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 662);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox TxtFilePath;
        private Button BtnBrowse;
        private MaskedTextBox TxtPassword;
        private Label LblStatus;
        private OpenFileDialog OfdSelectFile;
        private CheckBox ChkShowPassword;
        private SaveFileDialog SfdSaveFile;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button BtnExecute;
        private TableLayoutPanel tableLayoutPanel4;
        private Label LblFile;
        private Label LblPassword;
        private RadioButton RbtnDecrypt;
        private RadioButton RbtnEncrypt;
        private Button BtnSaveFile;
    }
}