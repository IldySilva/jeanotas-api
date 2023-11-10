using System.Security.Cryptography;
using System.Text;

namespace Infraestructure.Infra_CryptoUtilites;


    public class CryptoUtility : ICryptoUtility
    {
        private const string Key = "is4s#com"; 
        private const string Iv = "abcdefghijklmnopqrstuvwxyz012345678912"; 

        public string Encrypt(string text)
        {
            using Aes aesAlg = Aes.Create();
            aesAlg.Key = GenerateAesKey(Key); 
            aesAlg.IV = GenerateAesIV(Iv); 

            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

            using MemoryStream msEncrypt = new MemoryStream();
            using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
            {
                using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                {
                    swEncrypt.Write(text);
                }
            }

            return Convert.ToBase64String(msEncrypt.ToArray());
        }

        public string Decrypt(string cipherText)
        {
            using Aes aesAlg = Aes.Create();
            aesAlg.Key = GenerateAesKey(Key); 
            aesAlg.IV = GenerateAesIV(Iv); 
            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

            using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText)))
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                    {
                        return srDecrypt.ReadToEnd();
                    }
                }
            }
        }
        public static byte[] GenerateAesKey(string key)
        {
            
            using (var sha256 = SHA256.Create())
            {
                byte[] keyBytes = Encoding.UTF8.GetBytes(key);
                return sha256.ComputeHash(keyBytes);
            }
        }
        public static byte[] GenerateAesIV(string iv)
        {
            // Use uma função de derivação de chave para garantir que o IV tenha o tamanho correto.
            // Esta é apenas uma abordagem simples. Para fins de produção, use uma biblioteca de derivação de IV adequada.
            using (var sha256 = SHA256.Create())
            {
                byte[] ivBytes = Encoding.UTF8.GetBytes(iv);
                return sha256.ComputeHash(ivBytes).Take(16).ToArray(); // Pegue os primeiros 16 bytes.
            }
        }
    }
