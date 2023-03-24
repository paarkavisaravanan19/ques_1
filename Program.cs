using System.Collections;
using System.Linq.Expressions;

namespace question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 or 2");
            int opt = Convert.ToInt32(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    Console.WriteLine("answer the following");
                    string ques1 = "how jovial you are? rate yourself out of 100";
                    Console.WriteLine(ques1);
                    int ans1 = Convert.ToInt32(Console.ReadLine());

                    int sts = 0;
                    if (ans1 > 50)
                    {
                        sts = sts + 1;

                    }


                    string ques2 = "how patient you are! rate yourself out 0f 100";
                    Console.WriteLine(ques2);
                    int ans2 = Convert.ToInt32(Console.ReadLine());

                    if (ans1 > 50)
                    {
                        sts = sts + 1;

                    }

                    if (sts > 0)
                    {
                        Console.WriteLine("you have a very good personality");

                    }
                    else if (sts == 0)
                    {
                        Console.WriteLine("improve your inner peace");
                    }
                    else
                    {

                    }


                    break;
                case 2:
                    Hashtable hashtable = new Hashtable();

                    // Add key-value pairs
                    hashtable.Add("Aries", "Powerstar");
                    hashtable.Add("Taurus", "Batman");
                    hashtable.Add("Gemini", "Doreamon");
                    hashtable.Add("Leo", "Spiderman");
                    hashtable.Add("Scorpio", "JeemBoomBoi");
                    Console.WriteLine("The month number : 5");
                    string Key;
                    //printing the key and values
                    foreach (DictionaryEntry element in hashtable)
                    {
                        Console.WriteLine("The value at key {0} is {1}", element.Key, element.Value);
                    }
                    break;
                case 3:
                    Console.WriteLine("enter the year");
                    int year = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter the month");
                    int month = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter the year");
                    int day = Convert.ToInt32(Console.ReadLine());
                    var birthday = new DateTime(year, month, day);
                    int age = (int)((DateTime.Now - birthday).TotalDays / 365.242199);
                    Console.WriteLine(age);

                    break;
            }

        }
    }
}