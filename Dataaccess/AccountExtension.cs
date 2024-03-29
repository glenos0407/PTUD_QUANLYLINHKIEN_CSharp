﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dataaccess
{
    public class AccountExtension
    {
        private const int SaltSize = 13;
        private const int HashSize = 94;
        private static string Hash(string password, int iterations)
        {
            //create salt
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[SaltSize]);
            //create hash
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            var hash = pbkdf2.GetBytes(HashSize);
            //combine salt and hash
            var hashBytes = new byte[SaltSize + HashSize];
            Array.Copy(salt, 0, hashBytes, 0, SaltSize);
            Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);
            //convert to base64
            var base64Hash = Convert.ToBase64String(hashBytes);
            //format hash with extra information
            return string.Format("$QLLKNHOM17$V1${0}${1}", iterations, base64Hash);
        }

        public string Hash(string password)
        {
            return Hash(password, 10000);
        }

        private static bool IsHashSupported(string hashString)
        {
            return hashString.Contains("$QLLKNHOM17$V1$");
        }

        public bool Verify(string password, string hashedPassword)
        {
            //check hash
            if (!IsHashSupported(hashedPassword))
            {
                throw new NotSupportedException("The hashtype is not supported");
            }
            //extract iteration and Base64 string
            var splittedHashString = hashedPassword.Replace("$QLLKNHOM17$V1$", "").Split('$');
            var iterations = int.Parse(splittedHashString[0]);
            var base64Hash = splittedHashString[1];
            //get hashbytes
            var hashBytes = Convert.FromBase64String(base64Hash);
            //get salt
            var salt = new byte[SaltSize];
            Array.Copy(hashBytes, 0, salt, 0, SaltSize);
            //create hash with given salt
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            byte[] hash = pbkdf2.GetBytes(HashSize);
            //get result
            for (var i = 0; i < HashSize; i++)
            {
                if (hashBytes[i + SaltSize] != hash[i])
                {
                    return false;
                }
            }
            return true;
        }
        //public string UnHash(string hashedPassword)
        //{
        //    check hash
        //    if (!IsHashSupported(hashedPassword))
        //    {
        //        throw new NotSupportedException("The hashtype is not supported");
        //    }
        //    extract iteration and Base64 string
        //    var splittedHashString = hashedPassword.Replace("$QLLKNHOM17$V1$", "").Split('$');
        //    var iterations = int.Parse(splittedHashString[0]);
        //    var base64Hash = splittedHashString[1];
        //    get hashbytes
        //    var hashBytes = Convert.FromBase64String(base64Hash);
        //    get salt
        //    var salt = new byte[SaltSize];
        //}
    }
}
