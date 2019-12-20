using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 例2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] CharNum = new int[26];
            int Other;
            int i;
            char temp;
            string strTest;
            for (i = 0; i < 26; i++)
                CharNum[i] = 0;
            Other = 0;
            Console.Write("请输入要统计的字符串：");
            strTest = Console.ReadLine();
            strTest = strTest.ToUpper();
            Console.WriteLine("字符出现次数");
            for (i = 0; i < strTest.Length; i++)
            {
                temp = strTest[i];
                if (temp >= 'A' && temp <= 'Z')
                    CharNum[temp - 'A']++;
                else
                    Other++;
            }
            for (i = 0; i < 26; i++)
                if (CharNum[i] != 0)
                    Console.WriteLine("   {0}    {1}", (char)(i + 'a'), CharNum[i]);
            Console.WriteLine("Other   {0}", Other);
        }
    }
}
