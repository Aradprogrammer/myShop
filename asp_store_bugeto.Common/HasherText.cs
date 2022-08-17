using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XSystem.Security.Cryptography;

namespace asp_store_bugeto.Common
{
    public class HasherText
    {
        public static string  Hash(string input)
        {
            UTF8Encoding ue = new ();
            byte[] bytes = ue.GetBytes(input);
            MD5CryptoServiceProvider md5 = new ();
            byte[] hashBytes = md5.ComputeHash(bytes);
            // Bytes to string
            return System.Text.RegularExpressions.Regex.Replace(BitConverter.ToString(hashBytes), "-", "").ToLower();
        }
        public static bool CheckVerifyHashText(string Hashtext,string input)
        {
            if (Hashtext.Equals(Hash(input)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
