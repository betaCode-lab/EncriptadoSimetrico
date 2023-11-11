using System.Security.Cryptography;
using System.Text;

namespace EncriptationMethods.Resources
{
    public class Utility
    {

        public static string EncryptPassword(string password)
        {
            StringBuilder sb = new StringBuilder();

            using(SHA256 hash = SHA256.Create())
            {
                Encoding enc = Encoding.UTF8;
                byte[] result = hash.ComputeHash(enc.GetBytes(password));

                foreach (byte bite in result)
                {
                    sb.Append(bite.ToString("x2"));
                }

                return sb.ToString();
            }
        }
    }
}
