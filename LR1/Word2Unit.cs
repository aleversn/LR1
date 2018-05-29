using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LR1分析实验
{
    class Word2Unit
    {
        private string final = "";
        public Word2Unit(string path)
        {
            StreamReader sr = new StreamReader(path, Encoding.UTF8);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                final += line + "\r\n";
            }
            final = final.Replace("\r", " ").Replace("\t", " ").Replace("\n", " ");
        }

        public List<string> Result()
        {
            List<string> rs = new List<string>();
            Regex s = new Regex(@"^\w+$");
            string t = "";
            foreach (char i in final)
            {
                if (s.IsMatch(i.ToString()))
                    t += i;
                else
                {
                    if (t != "")
                        rs.Add(t);
                    if (i != ' ')
                        rs.Add(i.ToString());
                    t = "";
                }
            }
            return rs;
        }
    }
}