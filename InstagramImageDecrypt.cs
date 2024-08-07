using System;
using System.Text;
using System.Web;

namespace NawafezBlazor
{
    public static class InstagramImageDecrypt
    {
        public static string Decrypt(string url)
        {
            var p = url.Split('/');
            var t = new StringBuilder();

            for (int i = 0; i < p.Length; i++)
            {
                if (i == 2)
                {
                    t.Append(p[i].Replace("-", "--").Replace(".", "-"))
                     .Append(Encoding.UTF8.GetString(Convert.FromBase64String("LnRyYW5zbGF0ZS5nb29n")))
                     .Append('/');
                }
                else
                {
                    if (i != p.Length - 1)
                    {
                        t.Append(p[i]).Append('/');
                    }
                    else
                    {
                        t.Append(p[i]);
                    }
                }
            }

            var encodedUrl = Uri.EscapeUriString(t.ToString());
            return encodedUrl;
        }
    }
}