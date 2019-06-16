using AES.Core;
using System;
using System.Security.Cryptography;
using System.Text;

namespace AES
{
    /*
     * 16位密钥=128位，24位密钥=192位，32位密钥=256位
     * key不能是其他长度
     */
    class AESHelper
    {
        /// <summary>
        /// AES Encrypt
        /// </summary>
        /// <param name="str"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string AesEncrypt_ECB(string str, string key)
        {
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }

            int keyLength = key.Length;
            if (keyLength != 16 && keyLength != 24 && keyLength != 32)
            {
                return null;
            }

            byte[] toEncryptArray = Encoding.UTF8.GetBytes(str);
            RijndaelManaged rijndaelManaged = new RijndaelManaged
            {
                Key = Encoding.UTF8.GetBytes(key),
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };

            ICryptoTransform cTransform = rijndaelManaged.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        /// <summary>
        /// Aes Decrypt
        /// </summary>
        /// <param name="str"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string AesDecrypt_ECB(string str, string key)
        {
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }

            int keyLength = key.Length;
            if (keyLength != 16 && keyLength != 24 && keyLength != 32)
            {
                return null;
            }

            byte[] toDecryptArray = Convert.FromBase64String(str);

            RijndaelManaged rm = new RijndaelManaged
            {
                Key = Encoding.UTF8.GetBytes(key),
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };

            ICryptoTransform cTransform = rm.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toDecryptArray, 0, toDecryptArray.Length);

            return Encoding.UTF8.GetString(resultArray);

        }

        /// <summary>
        /// Generate AES Key
        /// </summary>
        /// <param name="keyType"></param>
        /// <returns></returns>
        public static string GenerateKey(AESKeyTypeEnum keyType)
        {
            char[] constant =
            {
                '0','1','2','3','4','5','6','7','8','9',
                'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
                'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
            };

            StringBuilder newRandom = new StringBuilder();
            Random rd = new Random();
            for (int i = 0; i < Convert.ToInt16(keyType); i++)
            {
                newRandom.Append(constant[rd.Next(62)]);
            }
            return newRandom.ToString();
        }

        /// <summary>AES加密</summary>
        /// <param name="text">明文</param>
        /// <param name="key">密钥,长度为16的字符串</param>
        /// <param name="iv">偏移量,长度为16的字符串</param>
        /// <returns>密文</returns>
        public static string EncodeAES(string text, string key, string iv)
        {
            RijndaelManaged rijndaelCipher = new RijndaelManaged();
            rijndaelCipher.Mode = CipherMode.CBC;
            rijndaelCipher.Padding = PaddingMode.Zeros;
            rijndaelCipher.KeySize = 128;
            rijndaelCipher.BlockSize = 128;
            byte[] pwdBytes = System.Text.Encoding.UTF8.GetBytes(key);
            byte[] keyBytes = new byte[16];
            int len = pwdBytes.Length;
            if (len > keyBytes.Length)
                len = keyBytes.Length;
            System.Array.Copy(pwdBytes, keyBytes, len);
            rijndaelCipher.Key = keyBytes;
            rijndaelCipher.IV = Encoding.UTF8.GetBytes(iv);
            ICryptoTransform transform = rijndaelCipher.CreateEncryptor();
            byte[] plainText = Encoding.UTF8.GetBytes(text);
            byte[] cipherBytes = transform.TransformFinalBlock(plainText, 0, plainText.Length);
            return Convert.ToBase64String(cipherBytes);
        }

        /// <summary>AES解密</summary>
        /// <param name="text">密文</param>
        /// <param name="key">密钥,长度为16的字符串</param>
        /// <param name="iv">偏移量,长度为16的字符串</param>
        /// <returns>明文</returns>
        public static string DecodeAES(string text, string key, string iv)
        {
            RijndaelManaged rijndaelCipher = new RijndaelManaged();
            rijndaelCipher.Mode = CipherMode.CBC;
            rijndaelCipher.Padding = PaddingMode.Zeros;
            rijndaelCipher.KeySize = 128;
            rijndaelCipher.BlockSize = 128;
            byte[] encryptedData = Convert.FromBase64String(text);
            byte[] pwdBytes = System.Text.Encoding.UTF8.GetBytes(key);
            byte[] keyBytes = new byte[16];
            int len = pwdBytes.Length;
            if (len > keyBytes.Length)
                len = keyBytes.Length;
            System.Array.Copy(pwdBytes, keyBytes, len);
            rijndaelCipher.Key = keyBytes;
            rijndaelCipher.IV = Encoding.UTF8.GetBytes(iv);
            ICryptoTransform transform = rijndaelCipher.CreateDecryptor();
            byte[] plainText = transform.TransformFinalBlock(encryptedData, 0, encryptedData.Length);
            return Encoding.UTF8.GetString(plainText);
        }
    }
}
