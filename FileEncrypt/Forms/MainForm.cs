using FileEncrypt.Services;
using System.Text;

namespace FileEncrypt.Forms
{
    public partial class MainForm : Form
    {
        private MemoryStream? msExecutionOutput;

        public MainForm()
        {
            InitializeComponent();
        }

        #region Open/Save File Dialog Utility Functions

        private void SetEncryptFileFilters()
        {
            OfdSelectFile.FileName = "";
            OfdSelectFile.DefaultExt = ".txt";
            OfdSelectFile.Filter = "Text Files (*.txt)|*.txt";

            SfdSaveFile.FileName = "encrypted_file.enc";
            SfdSaveFile.DefaultExt = ".enc";
            SfdSaveFile.Filter = "Encrypted Files (*.enc)|*.enc";
        }

        private void SetDecryptFileFilters()
        {
            OfdSelectFile.FileName = "";
            OfdSelectFile.DefaultExt = ".enc";
            OfdSelectFile.Filter = "Encrypted Files (*.enc)|*.enc";

            SfdSaveFile.FileName = "decrypted_file.txt";
            SfdSaveFile.DefaultExt = ".txt";
            SfdSaveFile.Filter = "Text Files (*.txt)|*.txt";
        }

        #endregion

        #region File Utility Functions

        private void UpdateFilePath(string filePath)
        {
            TxtFilePath.Text = filePath;
        }

        #endregion

        #region Password Utility Functions

        private void ShowPassword()
        {
            TxtPassword.UseSystemPasswordChar = false;
        }

        private void HidePassword()
        {
            TxtPassword.UseSystemPasswordChar = true;
        }

        private void TogglePasswordVisibility()
        {
            if (TxtPassword.UseSystemPasswordChar == true)
            {
                ShowPassword();
            }
            else
            {
                HidePassword();
            }
        }

        private void ClearTxtPassword()
        {
            TxtPassword.Text = "";
        }

        private void UncheckChkShowPassword()
        {
            if (ChkShowPassword.Checked == true)
            {
                ChkShowPassword.Checked = false;
            }
        }

        private void ResetTxtPassword()
        {
            ClearTxtPassword();
            UncheckChkShowPassword();
        }

        #endregion

        #region Execute Button Utility Functions

        private void ChangeExecuteBtn()
        {
            BtnExecute.Text = BtnExecute.Text == "Encrypt" ? "Decrypt" : "Encrypt";
        }

        private void UpdateBtnExecuteStatus()
        {
            if (TxtFilePath.Text != "" && TxtPassword.Text != "")
            {
                BtnExecute.Enabled = true;
            }
            else
            {
                BtnExecute.Enabled = false;
            }
        }

        #endregion

        #region Status Label Utility Functions

        private void SetLblStatusSuccessMessage()
        {
            LblStatus.Text = "Operation completed successfully!";
            LblStatus.ForeColor = Color.Green;
            LblStatus.Refresh();
        }

        private void SetLblStatusErrorMessage()
        {
            LblStatus.Text = "Wrong password!";
            LblStatus.ForeColor = Color.Red;
            LblStatus.Refresh();
        }

        private void ResetLblStatusMessage()
        {
            LblStatus.Text = "";
            LblStatus.ForeColor = SystemColors.ControlText;
        }

        #endregion

        #region Save File Button Utility Functions

        private void ShowBtnSaveFile()
        {
            BtnSaveFile.Visible = true;
        }

        private void HideBtnSaveFile()
        {
            BtnSaveFile.Visible = false;
        }

        #endregion

        #region Common Utility Functions

        private void ResetForm()
        {
            UpdateFilePath("");
            ResetTxtPassword();
            ResetLblStatusMessage();
            HideBtnSaveFile();
        }

        #endregion

        #region Event Handlers

        private void RbtnEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            ChangeExecuteBtn();
            if (RbtnEncrypt.Checked)
            {
                SetEncryptFileFilters();
            }
            else
            {
                SetDecryptFileFilters();
            }
            ResetForm();
        }

        private void TxtFilePath_TextChanged(object sender, EventArgs e)
        {
            UpdateBtnExecuteStatus();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            if (OfdSelectFile.ShowDialog() == DialogResult.OK)
            {
                UpdateFilePath(OfdSelectFile.FileName);
            }
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            UpdateBtnExecuteStatus();
        }

        private void ChkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            TogglePasswordVisibility();
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            if (RbtnEncrypt.Checked)
            {
                byte[] cipherText = EncryptionService.EncryptFile(OfdSelectFile.FileName, TxtPassword.Text);
                msExecutionOutput = new MemoryStream(cipherText);
                SetLblStatusSuccessMessage();
                ShowBtnSaveFile();
            }
            else
            {
                try
                {
                    string plainText = EncryptionService.DecryptFile(OfdSelectFile.FileName, TxtPassword.Text);
                    msExecutionOutput = new MemoryStream(Encoding.UTF8.GetBytes(plainText));
                    SetLblStatusSuccessMessage();
                    ShowBtnSaveFile();
                }
                catch (Exception)
                {
                    SetLblStatusErrorMessage();
                    return;
                }
            }
        }

        private void BtnSaveFile_Click(object sender, EventArgs e)
        {
            if (msExecutionOutput == null)
            {
                MessageBox.Show("Something went wrong! Resetting form...");
            }
            else if (SfdSaveFile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fileStream = new FileStream(SfdSaveFile.FileName, FileMode.Create, FileAccess.Write))
                {
                    msExecutionOutput.WriteTo(fileStream);
                }

                msExecutionOutput.Close();
                msExecutionOutput = null;
            }
            ResetForm();
        }

        #endregion
    }
}
