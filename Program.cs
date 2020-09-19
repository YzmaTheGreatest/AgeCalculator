using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Pikachu
{
    class Program
    {
        public static void Main()
        { try
            {
                DateTime thisday = DateTime.Today;
                 int birthday;
                 int birthmonth;
                 int birthyear;
                 int years;
                 int birthyearv;
                 int date = Convert.ToInt32(thisday.ToString("dd"));
                 int month = Convert.ToInt32(thisday.ToString("MM"));
                 int year = Convert.ToInt32(thisday.ToString("yyyy"));
                Console.WriteLine("Привет, меня зовут Пикачу, а как зовут тебя: ");
                string name = Console.ReadLine();
                Console.WriteLine("Какого месяца ты родился: ");
                birthmonth = Convert.ToInt32(Console.ReadLine());
                 if (birthmonth < 0)
                 {
                     birthmonth = birthmonth * -1;
                 }
                  if (birthmonth != 0 && birthmonth <= 12)
                  {
                  }
                  else
                  {
                      Console.WriteLine("Ты меня обманул/а");
                      System.Environment.Exit(0);
                  }
                Console.WriteLine("А какой у тебя день рождения: ");
                birthday = Convert.ToInt32(Console.ReadLine());
                 if (birthday < 0)
                 {
                     birthday = birthday * -1;
                 }
                  if (birthday != 0 && birthday <= 31)
                  {
                  }
                  else
                  {
                      Console.WriteLine("Ты меня обманул/а");
                      System.Environment.Exit(0);
                  }
                Console.WriteLine("А какого года ты родился: ");
                birthyear = Convert.ToInt32(Console.ReadLine());
                 if (birthyear < 0)
                 {
                     birthyear = birthyear * -1;
                 }   
                  if (birthyear < year - 100)
                  {
                          Console.WriteLine("Ты меня обманул/а");
                          System.Environment.Exit(0);
                  }
                   if (birthyear < year)
                   {
                   }
                   else if (birthyear == year && birthmonth <= month && birthday <= date)
                   {
                   }
                   else if (birthyear == 0 && birthmonth == 1 && birthday == 1)
                   {
                          Console.WriteLine("Да ты у нас Иисус оказывается");
                          System.Environment.Exit(0);
                   }
                   else
                   {
                           Console.WriteLine("Ты меня обманул/а");
                           System.Environment.Exit(0);
                   }
                birthyearv = birthyear % 4;
                switch (birthmonth)
                {
                    case 2:
                        if (birthyearv == 0)
                        {
                            if (birthday <= 29)
                            {

                            }
                            else
                            {
                                Console.WriteLine("Ты меня обманул/а");
                                System.Environment.Exit(0);
                            }
                        }
                        else
                        {
                            if (birthday <= 28)
                            {
                            }
                            else
                            {
                                Console.WriteLine("Ты меня обманул/а");
                                System.Environment.Exit(0);
                            }
                        }
                        break;
                    case 4:
                        if (birthday <= 30)
                        {
                        }
                        else
                        {
                            Console.WriteLine("Ты меня обманул/а");
                            System.Environment.Exit(0);
                        }
                        break;
                    case 6:
                        if (birthday <= 30)
                        {
                        }
                        else
                        {
                            Console.WriteLine("Ты меня обманул/а");
                            System.Environment.Exit(0);
                        }
                        break;
                    case 9:
                        if (birthday <= 30)
                        {
                        }
                        else
                        {
                            Console.WriteLine("Ты меня обманул/а");
                            System.Environment.Exit(0);
                        }
                        break;
                    case 11:
                        if (birthday <= 30)
                        {
                        }
                        else
                        {
                            Console.WriteLine("Ты меня обманул/а");
                            System.Environment.Exit(0);
                        }
                        break;
                }
                years = year - birthyear;
                 if (years == 0)
                 {
                     Console.WriteLine("Так значит тебе {0} годиков, хи-хи-хи, приятно познакомится, {1}", years, name);
                 }
                 else if (years >= 1 && birthmonth < month)
                 {
                     Console.WriteLine("Так значит тебе {0} годиков, хи-хи-хи, приятно познакомится, {1}", years, name);
                 }
                 else if (years >= 1 && birthmonth == month && birthday <= date)
                 {
                     Console.WriteLine("Так значит тебе {0} годиков, хи-хи-хи, приятно познакомится, {1}", years, name);
                 }
                 else
                 {
                    years = years - 1;
                    Console.WriteLine("Так значит тебе {0} годиков, хи-хи-хи, приятно познакомится, {1}", years, name);
                 }
            }
            catch (Exception)
            {
                Console.WriteLine("Плохой человек, очень плохой");
                System.Environment.Exit(0);
            }
             }
    }    
}
