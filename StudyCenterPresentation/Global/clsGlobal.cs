using System;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Win32;
using StudyCenterBuisness;

namespace StudyCenterPresentation
{
    public class clsGlobal
    {
        public static clsuserbusiness LogInUser;
        public static bool RememberUSernameAndPass(string username, string pass)
        {
            try
            {
                string keyname = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run";
                string valuename = "LastLogin";
                string valuedate = Registry.GetValue(keyname, valuename, null) as string;
                if (username == "" && !string.IsNullOrEmpty(valuedate))
                {
                    valuedate = "";
                    Registry.SetValue(keyname, valuename, valuedate, RegistryValueKind.String);
                    return true;
                }
                valuedate = username + "#//#" + pass;
                Registry.SetValue(keyname, valuename, valuedate, RegistryValueKind.String);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool GetStoredcredential(ref string username, ref string pass)
        {
            try
            {
                string keyname = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run";
                string valuename = "LastLogin";
                string value = Registry.GetValue(keyname, valuename, null) as string;
                if (!string.IsNullOrEmpty(value))
                {
                    string[] result = value.Split(new string[] { "#//#" }, StringSplitOptions.None);
                    username = result[0];
                    pass = result[1];
                    return true;
                }
                else
                {
                    username = string.Empty;
                    pass = string.Empty;
                    return false;
                }
            }
            catch (Exception)
            {
                username = string.Empty;
                pass = string.Empty;
                return false;
            }
        }
        public static string Encrypt(string plainText, string key = "02D2E9-830F-4B31-89C6-237F4131BC")
        {
            if (plainText == null)
            {
                return null;
            }

            using (Aes aesAlg = Aes.Create())
            {
                // Set the key and IV for AES encryption
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];
                // Create an encryptor
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                // Encrypt the data
                using (var msEncrypt = new System.IO.MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (var swEncrypt = new System.IO.StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }
                    // Return the encrypted data as a Base64-encoded string
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }
        public static string Decrypt(string cipherText, string key = "02D2E9-830F-4B31-89C6-237F4131BC")
        {
            if (cipherText == null)
            {
                return null;
            }

            using (Aes aesAlg = Aes.Create())
            {
                // Set the key and IV for AES decryption
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];
                // Create a decryptor
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                // Decrypt the data
                using (var msDecrypt = new System.IO.MemoryStream(Convert.FromBase64String(cipherText)))
                using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (var srDecrypt = new System.IO.StreamReader(csDecrypt))
                {
                    // Read the decrypted data from the StreamReader
                    return srDecrypt.ReadToEnd();
                }
            }
        }
    }
}
