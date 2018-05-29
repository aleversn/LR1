using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LR1分析实验
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> status = new Stack<int>();
            string arch = "";
            Processer pr = new Processer();
            List<string> standby = new Word2Unit(@"1.txt").Result();
            standby.Add("$");
            status.Push(0);
            for (int i = 0; i < standby.Count; i++)
            {
                standby[i] = UnitRegex(standby[i]);
            }
            Console.WriteLine("栈\t当前\t操作说明\t待移入");
            while (pr.Action[status.Peek()][standby[0]].num != -1)
            {
                ActionResponse ac = pr.Action[status.Peek()][standby[0]];
                bool Return = ac.Return;
                //移入//
                if (!Return)
                {
                    status.Push(ac.num);
                    string ts = standby[0];
                    if (standby[0] != "$")
                    {
                        arch = arch + standby[0];
                        standby.RemoveAt(0);
                    }
                    Console.WriteLine($"{OutStack(status)}\t{arch}\t移入{ts}进入{ac.num.ToString()}状态\t{OutList(standby)}");
                }
                else//规约//
                {
                    string g = Grammar(ac.num, arch)[1];
                    int popNum = int.Parse(Grammar(ac.num, arch)[2]);
                    arch = Grammar(ac.num, arch)[0];
                    for (int i = 0; i < popNum; i++)
                    {
                        status.Pop();
                    }
                    //Goto//
                    status.Push(pr.Goto[status.Peek()][g]);
                    Console.WriteLine($"{OutStack(status)}\t{arch}\t规约回退为{status.Peek()}状态\t{OutList(standby)}");
                }
            }
        }

        /// <summary>
        /// 输入格式化///
        /// </summary>
        /// <param name="unit"></param>
        /// <returns></returns>
        public static string UnitRegex(string unit)
        {
            Regex id = new Regex(@"^\w+$");
            Regex num = new Regex(@"^\d+$");
            string[] keybasic = { "int", "float", "char", "double", "bool" };
            string[] keys = { "call", "if", "else", "while", "do" };
            foreach (string i in keybasic)
            {
                if (unit == i)
                    return "basic";
            }
            foreach (string i in keys)
            {
                if (unit == i)
                    return unit;
            }
            if (num.IsMatch(unit))
                return "num";
            if (id.IsMatch(unit))
                return "id";
            return unit;
        }

        /// <summary>
        /// 文法归约///
        /// </summary>
        /// <param name="i"></param>
        /// <param name="str"></param>
        /// <returns>第1个为字符串///第2个为归约符</returns>
        public static List<string> Grammar(int i,string str)
        {
            string t = str;
            List<string> ri = new List<string>();
            string[] val = { "", "B", "DS", "basicH;", "", "id", "H,id", "id=X", "call(id)", "if(R)SelseS", "while(R)doS", "X>X", "T", "X+T", "T*F", "F", "id", "num", "(X)" };
            string[] equal = { "", "P", "B", "D", "D", "H", "H", "S", "S", "S", "S", "R", "X", "X", "T", "T", "F", "F", "F" };
            int[] popNum = { 0, 1, 2, 3, 1, 1, 3, 3, 4, 7, 6, 3, 1, 3, 3, 1, 1, 1, 3 };
            try
            {
                if (str.Substring(str.LastIndexOf(val[i]), str.Length - str.LastIndexOf(val[i])) == val[i])
                {
                    t = str.Substring(0, str.LastIndexOf(val[i]));
                    t = t + equal[i];
                    ri.Add(t);
                    ri.Add(equal[i]);
                    ri.Add(popNum[i].ToString());
                    return ri;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        public static string OutStack(Stack<int>s)
        {
            string r = "";
            foreach (int i in s)
            {
                r = i.ToString() + " " + r;
            }
            return r;
        }

        public static string OutList(List<string> s)
        {
            string r = "";
            foreach (string i in s)
            {
                r += i.ToString() + " ";
            }
            return r;
        }

        public static void Test()
        {
            Word2Unit w = new Word2Unit(@"1.txt");
            foreach (string i in w.Result())
            {
                Console.WriteLine(UnitRegex(i));
            }
        }
    }
}