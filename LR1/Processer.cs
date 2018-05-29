using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1分析实验
{
    class Processer
    {
        public List<Dictionary<string, ActionResponse>> Action = new List<Dictionary<string, ActionResponse>>();
        public List<Dictionary<string, int>> Goto = new List<Dictionary<string, int>>();
        public Processer()
        {
            Dictionary<string, ActionResponse> tA = new Dictionary<string, ActionResponse>();
            Dictionary<string, int> tG = new Dictionary<string, int>();
            #region Action 0
            tA.Add("basic", new ActionResponse { Return = false, num = 3 });
            tA.Add("$", new ActionResponse { Return = true, num = 4 });
            Action.Add(tA);
            //1
            tA = new Dictionary<string, ActionResponse>();
            tA.Add("$", new ActionResponse { Return = true, num = -1 });
            Action.Add(tA);
            //2
            tA = new Dictionary<string, ActionResponse>();
            tA.Add("id", new ActionResponse { Return = false, num = 5 });
            tA.Add("call", new ActionResponse { Return = false, num = 6 });
            tA.Add("if", new ActionResponse { Return = false, num = 7 });
            tA.Add("while", new ActionResponse { Return = false, num = 8 });
            Action.Add(tA);
            //3
            tA = new Dictionary<string, ActionResponse>();
            tA.Add("id", new ActionResponse { Return = false, num = 10 });
            Action.Add(tA);
            //4
            tA = new Dictionary<string, ActionResponse>();
            tA.Add("$", new ActionResponse { Return = true, num = 2 });
            Action.Add(tA);
            //5
            tA = new Dictionary<string, ActionResponse>();
            tA.Add("=", new ActionResponse { Return = false, num = 11 });
            Action.Add(tA);
            //6
            tA = new Dictionary<string, ActionResponse>();
            tA.Add("(", new ActionResponse { Return = false, num = 12 });
            Action.Add(tA);
            //7
            tA = new Dictionary<string, ActionResponse>();
            tA.Add("(", new ActionResponse { Return = false, num = 13 });
            Action.Add(tA);
            //8
            tA = new Dictionary<string, ActionResponse>();
            tA.Add("(", new ActionResponse { Return = false, num = 14 });
            Action.Add(tA);
            //9
            tA = new Dictionary<string, ActionResponse>();
            tA.Add(",", new ActionResponse { Return = false, num = 15 });
            tA.Add(";", new ActionResponse { Return = false, num = 28 });
            Action.Add(tA);
            //10
            tA = new Dictionary<string, ActionResponse>();
            tA.Add(",", new ActionResponse { Return = true, num = 5 });
            tA.Add(";", new ActionResponse { Return = true, num = 5 });
            Action.Add(tA);
            //11
            tA = new Dictionary<string, ActionResponse>();
            tA.Add("id", new ActionResponse { Return = false, num = 20 });
            tA.Add("num", new ActionResponse { Return = false, num = 21 });
            tA.Add("(", new ActionResponse { Return = false, num = 22 });
            Action.Add(tA);
            //12
            tA = new Dictionary<string, ActionResponse>();
            tA.Add("id", new ActionResponse { Return = false, num = 23 });
            Action.Add(tA);
            //13
            tA = new Dictionary<string, ActionResponse>();
            tA.Add("id", new ActionResponse { Return = false, num = 20 });
            tA.Add("num", new ActionResponse { Return = false, num = 21 });
            tA.Add("(", new ActionResponse { Return = false, num = 22 });
            Action.Add(tA);
            //14
            tA = new Dictionary<string, ActionResponse>();
            tA.Add("id", new ActionResponse { Return = false, num = 20 });
            tA.Add("num", new ActionResponse { Return = false, num = 21 });
            tA.Add("(", new ActionResponse { Return = false, num = 22 });
            Action.Add(tA);
            //15
            tA = new Dictionary<string, ActionResponse>();
            tA.Add("id", new ActionResponse { Return = false, num = 16 });
            Action.Add(tA);
            //16
            tA = new Dictionary<string, ActionResponse>();
            tA.Add(",", new ActionResponse { Return = true, num = 6 });
            tA.Add(";", new ActionResponse { Return = true, num = 6 });
            Action.Add(tA);
            //17
            tA = new Dictionary<string, ActionResponse>();
            tA.Add("else", new ActionResponse { Return = true, num = 7 });
            tA.Add("+", new ActionResponse { Return = false, num = 37 });
            tA.Add("$", new ActionResponse { Return = true, num = 7 });
            Action.Add(tA);
            //18
            tA = new Dictionary<string, ActionResponse>();
            tA.Add("else", new ActionResponse { Return = true, num = 12 });
            tA.Add("*", new ActionResponse { Return = false, num = 39 });
            tA.Add("+", new ActionResponse { Return = true, num = 12 });
            tA.Add(">", new ActionResponse { Return = true, num = 12 });
            tA.Add(")", new ActionResponse { Return = true, num = 12 });
            tA.Add("$", new ActionResponse { Return = true, num = 12 });
            Action.Add(tA);
            //19
            tA = new Dictionary<string, ActionResponse>();
            tA.Add("else", new ActionResponse { Return = true, num = 15 });
            tA.Add("*", new ActionResponse { Return = true, num = 15 });
            tA.Add("+", new ActionResponse { Return = true, num = 15 });
            tA.Add(">", new ActionResponse { Return = true, num = 15 });
            tA.Add(")", new ActionResponse { Return = true, num = 15 });
            tA.Add("$", new ActionResponse { Return = true, num = 15 });
            Action.Add(tA);
            //20
            tA = new Dictionary<string, ActionResponse>();
            tA.Add("else", new ActionResponse { Return = true, num = 16 });
            tA.Add("*", new ActionResponse { Return = true, num = 16 });
            tA.Add("+", new ActionResponse { Return = true, num = 16 });
            tA.Add(">", new ActionResponse { Return = true, num = 16 });
            tA.Add(")", new ActionResponse { Return = true, num = 16 });
            tA.Add("$", new ActionResponse { Return = true, num = 16 });
            Action.Add(tA);
            //21
            tA = new Dictionary<string, ActionResponse>();
            tA.Add("else", new ActionResponse { Return = true, num = 17 });
            tA.Add("*", new ActionResponse { Return = true, num = 17 });
            tA.Add("+", new ActionResponse { Return = true, num = 17 });
            tA.Add(">", new ActionResponse { Return = true, num = 17 });
            tA.Add(")", new ActionResponse { Return = true, num = 17 });
            tA.Add("$", new ActionResponse { Return = true, num = 17 });
            Action.Add(tA);
            //22
            tA = new Dictionary<string, ActionResponse>();
            tA.Add("id", new ActionResponse { Return = false, num = 20 });
            tA.Add("num", new ActionResponse { Return = false, num = 21 });
            Action.Add(tA);
            //23
            tA = new Dictionary<string, ActionResponse>();
            tA.Add(")", new ActionResponse { Return = false, num = 24 });
            Action.Add(tA);
            //24
            tA = new Dictionary<string, ActionResponse>();
            tA.Add("else", new ActionResponse { Return = true, num = 8 });
            tA.Add("$", new ActionResponse { Return = true, num = 8 });
            Action.Add(tA);
            //25
            tA = new Dictionary<string, ActionResponse>();
            tA.Add(")", new ActionResponse { Return = false, num = 26 });
            Action.Add(tA);
            //26
            tA = new Dictionary<string, ActionResponse>();
            tA.Add("do", new ActionResponse { Return = false, num = 27 });
            Action.Add(tA);
            //27
            tA = new Dictionary<string, ActionResponse>();
            tA.Add("id", new ActionResponse { Return = false, num = 5 });
            tA.Add("call", new ActionResponse { Return = false, num = 6 });
            tA.Add("if", new ActionResponse { Return = false, num = 7 });
            tA.Add("while", new ActionResponse { Return = false, num = 8 });
            Action.Add(tA);
            //28
            tA = new Dictionary<string, ActionResponse>();
            tA.Add("id", new ActionResponse { Return = true, num = 3 });
            tA.Add("call", new ActionResponse { Return = true, num = 3 });
            tA.Add("if", new ActionResponse { Return = true, num = 3 });
            tA.Add("while", new ActionResponse { Return = true, num = 3 });
            tA.Add("basic", new ActionResponse { Return = true, num = 3 });
            tA.Add("$", new ActionResponse { Return = true, num = 3 });
            Action.Add(tA);
            //29
            tA = new Dictionary<string, ActionResponse>();
            tA.Add("id", new ActionResponse { Return = false, num = 5 });
            tA.Add("call", new ActionResponse { Return = false, num = 6 });
            tA.Add("if", new ActionResponse { Return = false, num = 7 });
            tA.Add("else", new ActionResponse { Return = true, num = 10 });
            tA.Add("while", new ActionResponse { Return = false, num = 8 });
            tA.Add("$", new ActionResponse { Return = true, num = 10 });
            Action.Add(tA);
            //30
            tA = new Dictionary<string, ActionResponse>();
            tA.Add(")", new ActionResponse { Return = false, num = 43 });
            Action.Add(tA);
            //31
            tA = new Dictionary<string, ActionResponse>();
            tA.Add("else", new ActionResponse { Return = false, num = 32 });
            Action.Add(tA);
            //32
            tA = new Dictionary<string, ActionResponse>();
            tA.Add("id", new ActionResponse { Return = false, num = 5 });
            tA.Add("call", new ActionResponse { Return = false, num = 6 });
            tA.Add("if", new ActionResponse { Return = false, num = 7 });
            tA.Add("while", new ActionResponse { Return = false, num = 8 });
            Action.Add(tA);
            //33
            tA = new Dictionary<string, ActionResponse>();
            tA.Add("else", new ActionResponse { Return = true, num = 9 });
            tA.Add("$", new ActionResponse { Return = true, num = 9 });
            Action.Add(tA);
            //34
            tA = new Dictionary<string, ActionResponse>();
            tA.Add(">", new ActionResponse { Return = false, num = 35 });
            Action.Add(tA);
            //35
            tA = new Dictionary<string, ActionResponse>();
            tA.Add("id", new ActionResponse { Return = false, num = 20 });
            tA.Add("num", new ActionResponse { Return = false, num = 21 });
            tA.Add("(", new ActionResponse { Return = false, num = 22 });
            Action.Add(tA);
            //36
            tA = new Dictionary<string, ActionResponse>();
            tA.Add("+", new ActionResponse { Return = false, num = 37 });
            tA.Add(")", new ActionResponse { Return = true, num = 11 });
            Action.Add(tA);
            //37
            tA = new Dictionary<string, ActionResponse>();
            tA.Add("id", new ActionResponse { Return = false, num = 20 });
            tA.Add("num", new ActionResponse { Return = false, num = 21 });
            tA.Add("(", new ActionResponse { Return = false, num = 22 });
            Action.Add(tA);
            //38
            tA = new Dictionary<string, ActionResponse>();
            tA.Add("else", new ActionResponse { Return = true, num = 13 });
            tA.Add("*", new ActionResponse { Return = false, num = 39 });
            tA.Add("+", new ActionResponse { Return = true, num = 13 });
            tA.Add(">", new ActionResponse { Return = true, num = 13 });
            tA.Add(")", new ActionResponse { Return = true, num = 13 });
            tA.Add("$", new ActionResponse { Return = true, num = 13 });
            Action.Add(tA);
            //39
            tA = new Dictionary<string, ActionResponse>();
            tA.Add("id", new ActionResponse { Return = false, num = 20 });
            tA.Add("num", new ActionResponse { Return = false, num = 21 });
            Action.Add(tA);
            //40
            tA = new Dictionary<string, ActionResponse>();
            tA.Add("+", new ActionResponse { Return = false, num = 37 });
            tA.Add(")", new ActionResponse { Return = false, num = 41 });
            Action.Add(tA);
            //41
            tA = new Dictionary<string, ActionResponse>();
            tA.Add("else", new ActionResponse { Return = true, num = 18 });
            tA.Add("*", new ActionResponse { Return = true, num = 18 });
            tA.Add("+", new ActionResponse { Return = true, num = 18 });
            tA.Add(">", new ActionResponse { Return = true, num = 18 });
            tA.Add(")", new ActionResponse { Return = true, num = 18 });
            tA.Add("$", new ActionResponse { Return = true, num = 18 });
            Action.Add(tA);
            //42
            tA = new Dictionary<string, ActionResponse>();
            tA.Add("else", new ActionResponse { Return = true, num = 14 });
            tA.Add("*", new ActionResponse { Return = true, num = 14 });
            tA.Add("+", new ActionResponse { Return = true, num = 14 });
            tA.Add(">", new ActionResponse { Return = true, num = 14 });
            tA.Add(")", new ActionResponse { Return = true, num = 14 });
            tA.Add("$", new ActionResponse { Return = true, num = 14 });
            Action.Add(tA);
            //43
            tA = new Dictionary<string, ActionResponse>();
            tA.Add("id", new ActionResponse { Return = false, num = 5 });
            tA.Add("call", new ActionResponse { Return = false, num = 6 });
            tA.Add("while", new ActionResponse { Return = false, num = 8 });
            Action.Add(tA);
            #endregion

            #region Goto 0
            tG.Add("B", 1);
            tG.Add("D", 2);
            Goto.Add(tG);
            //1
            tG = new Dictionary<string, int>();
            Goto.Add(tG);
            //2
            tG = new Dictionary<string, int>();
            tG.Add("S", 4);
            Goto.Add(tG);
            //3
            tG = new Dictionary<string, int>();
            tG.Add("H", 9);
            Goto.Add(tG);
            //4
            tG = new Dictionary<string, int>();
            Goto.Add(tG);
            //5
            tG = new Dictionary<string, int>();
            Goto.Add(tG);
            //6
            tG = new Dictionary<string, int>();
            Goto.Add(tG);
            //7
            tG = new Dictionary<string, int>();
            Goto.Add(tG);
            //8
            tG = new Dictionary<string, int>();
            Goto.Add(tG);
            //9
            tG = new Dictionary<string, int>();
            Goto.Add(tG);
            //10
            tG = new Dictionary<string, int>();
            Goto.Add(tG);
            //11
            tG = new Dictionary<string, int>();
            tG.Add("X", 17);
            tG.Add("T", 18);
            tG.Add("F", 19);
            Goto.Add(tG);
            //12
            tG = new Dictionary<string, int>();
            Goto.Add(tG);
            //13
            tG = new Dictionary<string, int>();
            tG.Add("R", 30);
            tG.Add("X", 34);
            tG.Add("T", 18);
            tG.Add("F", 19);
            Goto.Add(tG);
            //14
            tG = new Dictionary<string, int>();
            tG.Add("R", 25);
            tG.Add("X", 34);
            tG.Add("T", 18);
            tG.Add("F", 19);
            Goto.Add(tG);
            //15
            tG = new Dictionary<string, int>();
            Goto.Add(tG);
            //16
            tG = new Dictionary<string, int>();
            Goto.Add(tG);
            //17
            tG = new Dictionary<string, int>();
            Goto.Add(tG);
            //18
            tG = new Dictionary<string, int>();
            Goto.Add(tG);
            //19
            tG = new Dictionary<string, int>();
            Goto.Add(tG);
            //20
            tG = new Dictionary<string, int>();
            Goto.Add(tG);
            //21
            tG = new Dictionary<string, int>();
            Goto.Add(tG);
            //22
            tG = new Dictionary<string, int>();
            tG.Add("X", 40);
            tG.Add("T", 18);
            tG.Add("F", 19);
            Goto.Add(tG);
            //23
            tG = new Dictionary<string, int>();
            Goto.Add(tG);
            //24
            tG = new Dictionary<string, int>();
            Goto.Add(tG);
            //25
            tG = new Dictionary<string, int>();
            Goto.Add(tG);
            //26
            tG = new Dictionary<string, int>();
            Goto.Add(tG);
            //27
            tG = new Dictionary<string, int>();
            tG.Add("S", 29);
            Goto.Add(tG);
            //28
            tG = new Dictionary<string, int>();
            Goto.Add(tG);
            //29
            tG = new Dictionary<string, int>();
            Goto.Add(tG);
            //30
            tG = new Dictionary<string, int>();
            Goto.Add(tG);
            //31
            tG = new Dictionary<string, int>();
            Goto.Add(tG);
            //32
            tG = new Dictionary<string, int>();
            tG.Add("S", 33);
            Goto.Add(tG);
            //33
            tG = new Dictionary<string, int>();
            Goto.Add(tG);
            //34
            tG = new Dictionary<string, int>();
            Goto.Add(tG);
            //35
            tG = new Dictionary<string, int>();
            tG.Add("X", 36);
            tG.Add("T", 18);
            tG.Add("F", 19);
            Goto.Add(tG);
            //36
            tG = new Dictionary<string, int>();
            Goto.Add(tG);
            //37
            tG = new Dictionary<string, int>();
            tG.Add("T", 38);
            tG.Add("F", 19);
            Goto.Add(tG);
            //38
            tG = new Dictionary<string, int>();
            Goto.Add(tG);
            //39
            tG = new Dictionary<string, int>();
            tG.Add("F", 42);
            Goto.Add(tG);
            //40
            tG = new Dictionary<string, int>();
            Goto.Add(tG);
            //41
            tG = new Dictionary<string, int>();
            Goto.Add(tG);
            //42
            tG = new Dictionary<string, int>();
            Goto.Add(tG);
            //43
            tG = new Dictionary<string, int>();
            tG.Add("S", 31);
            Goto.Add(tG);
            #endregion
        }
    }

    public class ActionResponse
    {
        /// <summary>
        /// 移进或归约///
        /// </summary>
        public bool Return { get; set; }
        public int num { get; set; }
    }
}
