using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace _13_CS_Encryption
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnEnc_Click(object sender, EventArgs e)
        {
            txtEnc.Text = ToSha256Hash(txtSrc.Text);
        }

        private void btnMd5_Click(object sender, EventArgs e)
        {
            txtEnc.Text = ToMd5Hash(txtSrc.Text);
        }

        public static String ToSha256Hash(String value)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return String.Concat(hash
                  .ComputeHash(Encoding.UTF8.GetBytes(value))
                  .Select(item => item.ToString("X2")));
            }
        }

        public static String ToMd5Hash(String value)
        {
            using (MD5 md5 = MD5.Create())
            {
                return String.Concat(md5
                  .ComputeHash(Encoding.UTF8.GetBytes(value))
                  .Select(item => item.ToString("X2")));
            }
        }

        private void btnEnc2_Click(object sender, EventArgs e)
        {
            string keyString = "_+_-_*_/\\_*_-_+_";
            var key = Encoding.UTF8.GetBytes(keyString);//16 bit or 32 bit key string

            using (var aesAlg = Aes.Create())
            {
                using (var encryptor = aesAlg.CreateEncryptor(key, aesAlg.IV))
                {
                    using (var msEncrypt = new MemoryStream())
                    {
                        using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        using (var swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(txtSrc.Text);
                        }

                        var iv = aesAlg.IV;

                        var decryptedContent = msEncrypt.ToArray();

                        var result = new byte[iv.Length + decryptedContent.Length];

                        Buffer.BlockCopy(iv, 0, result, 0, iv.Length);
                        Buffer.BlockCopy(decryptedContent, 0, result, iv.Length, decryptedContent.Length);

                        txtEnc.Text = Convert.ToBase64String(result);
                    }
                }
            }
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            string keyString = "_+_-_*_/\\_*_-_+_";
            var fullCipher = Convert.FromBase64String(txtEnc.Text);

            var iv = new byte[16];
            var cipher = new byte[16];

            Buffer.BlockCopy(fullCipher, 0, iv, 0, iv.Length);
            Buffer.BlockCopy(fullCipher, iv.Length, cipher, 0, iv.Length);
            var key = Encoding.UTF8.GetBytes(keyString);//same key string

            using (var aesAlg = Aes.Create())
            {
                using (var decryptor = aesAlg.CreateDecryptor(key, iv))
                {
                    string result;
                    using (var msDecrypt = new MemoryStream(cipher))
                    {
                        using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (var srDecrypt = new StreamReader(csDecrypt))
                            {
                                result = srDecrypt.ReadToEnd();
                            }
                        }
                    }

                    txtSrc.Text = result;
                }
            }
        }
    }
}
