using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarjimon.Ro_yhatlar;


namespace Tarjimon.Functions
{
    public  class EmployClass :UzbSozlar
    {
        
        public void Started()
        {
            Console.WriteLine($"  QANDAY AMAL BAJARMOQCHISIZ ? :");
            Console.WriteLine("1. O'zbekcha qidirish");
            Console.WriteLine("2. Inglizcha qidirish");
            Console.WriteLine("3. Ruscha qidirish");
            Console.WriteLine("4. Yangi so'z qoshish");
            Console.WriteLine("5. Keraksiz so'zlarni o'chirish");
            int son; string str,str2,str3;
            son = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (son)
            {
                case 1:
                    Console.Write(" So'zni kiriting :");
                    str = Console.ReadLine();
                    SearchUzbekText(str.ToLower());
                    break;
                case 2:
                    Console.Write(" Enter Text :");
                    str = Console.ReadLine();
                    SearchWordsEnglish(str.ToLower());
                    break;
                case 3:
                    Console.Write(" So'zni kiriting :");
                    str = Console.ReadLine();
                    SearchWordsRus(str.ToLower());
                    break;
                
                case 4:
                    Console.WriteLine(" O'zbekcha So'zni kiriting :");str= Console.ReadLine(); Console.WriteLine(" Ruscha So'zni kiriting :"); str2 = Console.ReadLine(); Console.WriteLine(" Inglizcha So'zni kiriting :"); str3 = Console.ReadLine();
                    AddWord(str.ToLower(), str2.ToLower(), str3.ToLower());
                    break;
                case 5:
                    Console.WriteLine(" O'zbekcha So'zni kiriting :"); str = Console.ReadLine(); Console.WriteLine(" Ruscha So'zni kiriting :"); str2 = Console.ReadLine(); Console.WriteLine(" Inglizcha So'zni kiriting :"); str3 = Console.ReadLine();
                    RemoveWord(str.ToLower(), str2.ToLower(), str3.ToLower());
                    break;
                default:
                    Console.WriteLine("Xatolik kuzatildi : "); Thread.Sleep(3000);Started(); break;
            }

        }
        public void SearchWordsEnglish(string wordd)
        {
            if (wordd == "")
            {
                Console.WriteLine("Xatolik kuzatildi : "); Thread.Sleep(3000); Started();
            }
           foreach (var s in list1)
           {
                if(s.Item3 == wordd)
                {
                    Console.WriteLine("Translate Uzbek  >>>  "+s.Item1+"   ||"+ "  Translate Rus  >>>  "+s.Item2);
                }
           }
           Restart();
        }
        public void SearchUzbekText(string wordd)
        {
            if (wordd == "")
            {
                Console.WriteLine("Xatolik kuzatildi : "); Thread.Sleep(3000); Started();
            }
            foreach (var s in list1)
            {
                if (s.Item1 == wordd)
                {
                    Console.WriteLine("Translate Rus  >>>  " + s.Item2 + "  ||" + "  Translate English  >>>  " + s.Item3);
                }
            }
            Restart();
        }

        public void SearchWordsRus(string wordd)
        {
            if (wordd == "")
            {
                Console.WriteLine("Xatolik kuzatildi : "); Thread.Sleep(3000); Started();
            }
            foreach (var s in list1)
            {
                if (s.Item2 == wordd)
                {
                    Console.WriteLine("Translate Uzbek  >>>  " + s.Item1 + "  ||" + "  Translate English  >>>  " + s.Item3);
                }
            }
            Restart();
        }
        public void AddWord(string word, string word2, string word3)
        {
            foreach(var s in list1)
            {
                if (s.Item1 == word && s.Item2==word2 && s.Item3==word3)
                {
                    Console.WriteLine(" Allaqachon elementlar fazosida bu element mavjud !");
                    break;
                }
            }
            list1.Add((word, word2, word3));
            Restart();
        }
        public void RemoveWord(string word,string word2, string word3)
        {            
            list1.Remove((word, word2, word3));                
            Restart();
        }
        public void Restart()
        {
            Console.WriteLine("Yana amal bajarishni hohlaysizmi");
            Console.WriteLine("1. Xa");
            Console.WriteLine("2. Yoq");
            int num; num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.Clear(); Started(); break;
                case 2:
                    Console.WriteLine("Tamom"); break;
            }
        }




       






    }


   
}
