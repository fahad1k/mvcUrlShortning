using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcUrlShortning.Models
{
    public static class staticModel
    {

        public static int NextSerial { get {return urlList.Max(a => a.Srno) + 1; } }
        public static List<urlDetails> urlList
        {

            set {

                HttpContext current = HttpContext.Current;


                current.Application["urlList"] = value;

              
            }

            get
            {
                HttpContext current = HttpContext.Current;


                if (current.Application["urlList"] != null) return (current.Application["urlList"] as List<urlDetails>);

                return (current.Application["urlList"] as List<urlDetails>);
            }
        }


        public static string GenerateString(int size)
        {
            char[] chars = new char[size];
            bool rein= true;
            string rString=String.Empty;
            while (rein)
            {
                for (int i = 0; i < size; i++)
                {
                    chars[i] = Alphabet[rand.Next(Alphabet.Length)];
                }
                rString  = new string(chars);

                rein = urlList.Count<urlDetails>(a => a.uniqueID == rString) > 0;
            }

            return rString;
        }

       static Random rand = new Random();

        public const string Alphabet =
        "abcdefghijklmnopqrstuvwyxzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    }
}