using AES.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CopyKeyBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(keyTextBox.Text);
            MessageBox.Show("Key已复制到剪贴板！");
        }

        private void GenerateKeyBtn_Click(object sender, EventArgs e)
        {
            string key = string.Empty;
            AESKeyTypeEnum keyType = AESKeyTypeEnum.KEY128;
            if (aes192btn.Checked)
            {
                keyType = AESKeyTypeEnum.KEY192;
            }
            else if (aes256btn.Checked)
            {
                keyType = AESKeyTypeEnum.KEY256;
            }

            key = AESHelper.GenerateKey(keyType);

            keyTextBox.Text = key;
            CopyKeyBtn.Enabled = true;
        }

        private void EcbEncrypt_Click(object sender, EventArgs e)
        {
            string key = ecbKeyTextBox.Text;
            string plaintext = ecbPlaintext.Text;
            string ciphertext = AESHelper.AesEncrypt_ECB(plaintext, key);
            ecbCiphertext.Text = ciphertext;
        }

        private void EcbDecrypt_Click(object sender, EventArgs e)
        {
            string key = ecbKeyTextBox.Text;
            string ciphertext = ecbCiphertext.Text;
            string plaintext = AESHelper.AesDecrypt_ECB(ciphertext, key);
            ecbPlaintext.Text = plaintext;
        }
    }
}
