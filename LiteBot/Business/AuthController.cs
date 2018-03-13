using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using LiteBot.Models;
using Newtonsoft.Json;

namespace LiteBot.Business
{
    public class AuthController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public AuthController()
        {
            _appDbContext = new AppDbContext();
        }

        public bool CheckLogin(HttpRequestBase request)
        {
            return true;
        }

        /// <summary>
        /// status = 0 > error
        /// > statusCode = 0 > fullname error
        /// > statusCode = 1 > email error
        /// > statusCode = 2 > username error
        /// > statusCode = 3 > password error
        /// > statusCode = 4 > email existed
        /// > statusCode = 5 > username existed
        /// status = 1 > success
        /// </summary>
        /// <param name="fullname"></param>
        /// <param name="email"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [HttpPost]
        public String Register(string fullname, string email, string username, string password)
        {
            Object result = new { };
            if (string.IsNullOrEmpty(fullname))
            {
                result = new { status = 0, message = "Error", statusCode = 0 };
            }
            else if (!IsValidEmail(email))
            {
                result = new { status = 0, message = "Error", statusCode = 1 };
            }
            else if (string.IsNullOrEmpty(username) || username.Length < 6)
            {
                result = new { status = 0, message = "Error", statusCode = 2 };
            }
            else if (string.IsNullOrEmpty(password) || password.Length < 8)
            {
                result = new { status = 0, message = "Error", statusCode = 3 };
            }
            else if (_appDbContext.Accounts.FirstOrDefault(x => x.Email.Equals(email)) != null)
            {
                result = new { status = 0, message = "Error", statusCode = 4 };
            }
            else if (_appDbContext.Accounts.FirstOrDefault(x => x.Username.Equals(username.ToLower().Trim())) != null)
            {
                result = new {status = 0, message = "Error", statusCode = 5};
            }
            else
            {
                _appDbContext.Accounts.Add(new Account()
                {
                    Email = email,
                    Username = username.ToLower().Trim(),
                    Fullname = fullname,
                    Password = Encrypt(password),
                    Type = "Normal",
                    Status = "Active"
                });
            }

            return JsonConvert.SerializeObject(result);
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static string Encrypt(string clearText)
        {
            string EncryptionKey = "LITEBOT";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                if (encryptor != null)
                {
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(),
                            CryptoStreamMode.Write))
                        {
                            cs.Write(clearBytes, 0, clearBytes.Length);
                            cs.Close();
                        }
                        clearText = Convert.ToBase64String(ms.ToArray());
                    }
                }
            }
            return clearText;
        }

        public static string Decrypt(string cipherText)
        {
            string EncryptionKey = "LITEBOT";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                if (encryptor != null)
                {
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(),
                            CryptoStreamMode.Write))
                        {
                            cs.Write(cipherBytes, 0, cipherBytes.Length);
                            cs.Close();
                        }
                        cipherText = Encoding.Unicode.GetString(ms.ToArray());
                    }
                }
            }
            return cipherText;
        }
    }



}