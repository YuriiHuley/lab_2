using System;
using System.Text;
using System.ComponentModel;
using System.Linq;

namespace lab_2
{
    class Program
    {    
        //1
        
        static bool MyContains(string str1, string str2)
        {
            for (int i = 0; i < str2.Length; i++)
            {
                for (int j = 0; j < str1.Length; j++)
                {
                    if (str2[i] == str1[j])
                    {
                        break;
                    }
                    else if (j == str1.Length-1)
                    {
                        return false;
                    }
                }
            }
            
            return true;
        }

            //2
    //static void Replace(string str1, string str2)
    //   {
    //        bool b = str1.Contains(str2);
    //        if (b)
    //        {
    //            char[] newstr = str2.ToCharArray();
    //            for (int i = 0; i < newstr.Length; i++)
    //            {
    //               str1 = str1.Replace(newstr[i], '#');
    //            }    
    //            Console.WriteLine(str1);
    //        }
    //    }
        static string Replace(string str1, string str2)
        {
            StringBuilder str1builder = new StringBuilder(str1);
            
            for (int i = 0; i < str2.Length; i++)
            {
                for (int j = 0; j < str1builder.Length; j++)
                {
                    if (str2[i] == str1[j])
                    {
                        str1builder[j] = '#';
                    }
                }
            }

            return str1builder.ToString();
        }
        //3
        public static int Amount(string str1, string str2)
        {
            int count = 0, index = 0;
            while ((index = str1.IndexOf(str2, index) + 1) != 0) count++;
            return count;
        }

        static void Main(string[] args)
        {
            string str1 = "тестуваннятест";
            string str2 = "тест";
            Console.WriteLine(MyContains(str1, str2));
            Replace(str1, str2);
            Console.WriteLine(Amount(str1, str2));

        }
    }
 }