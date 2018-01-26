using System;
using System.IO;

namespace PostCreator
{
    class PostCreator
    {
        public static void Main(string[] args)
        {
            var WN = int.Parse(Console.ReadLine());
            var a = WN / 4;
            var MonthNumb = 1;
            var zero = "0";
            if (a >= 10 || a == 0)
                zero = "";
            var zero2 = "0";
            string[] month = { "December", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            var day = 6;
            var position = 6;
            var FirstHalf = "W5-2017-12-30-";
            var SecondHalf = "2018-01-05";
            var MaxDay = 31;
            if (WN > 5)
            {
                while (position != WN + 1)
                {
                    var ExtraMonth = "";
                    if (day >= 10)
                        zero2 = "";
                    else
                        zero2 = "0";
                    if (MonthNumb == 4 || a == 6 || a == 9 || a == 11)
                        MaxDay = 30;
                    if (MonthNumb == 2)
                        MaxDay = 28;
                    FirstHalf = "W" + position + "-2018-" + zero + MonthNumb + "-" + zero2 + day + "-";
                    day += 6;
                    if (day > MaxDay)
                    {
                        day -= MaxDay;
                        MonthNumb++;
                        ExtraMonth = zero + MonthNumb + "-";
                    }
                    if (day >= 10)
                        zero2 = "";
                    else
                        zero2 = "0";
                    if (MonthNumb == 4 || a == 6 || a == 9 || a == 11)
                        MaxDay = 30;
                    if (MonthNumb == 2)
                        MaxDay = 28;
                    SecondHalf = ExtraMonth + zero2 + day;
                    day++;
                    position++;
                }
            }
            //Я ЧТО ТОЛЬКО НЕ ПЕРЕПРОБОВАЛ НЕ МОГУ ПОМЕСТИТЬ ФАЙЛЫ В СОЗДАННУЮ ПАПКУ!!!
            //Вот так пробовал, не получилось
            //var FolderName = @"2018";
            //var MonthName = month[a];
            //var WeekName = FirstHalf + SecondHalf;
            //var FileName = System.IO.Path.GetFileName("W" + WN + ".md");
            //var Adding = System.IO.Path.Combine(FolderName, MonthName);
            //Adding = System.IO.Path.Combine(MonthName, WeekName);
            //Adding = System.IO.Path.Combine(WeekName, FileName);

            //Всё создаётся идеально, я просто исчесал весь интернет, я 2 часа только искал как РАСПОЛОЖИТЬ папку внутри папки или файл внутри папки, ну никак ничего не нашёл...
            System.IO.Directory.CreateDirectory(@"2018\" + month[a]);
            System.IO.Directory.CreateDirectory(@"2018\.\" + FirstHalf + SecondHalf);
            StreamWriter NewFile = File.CreateText(@"2018\.\" + "W" + WN + ".md");
            NewFile.WriteLine("# Week: " + FirstHalf + SecondHalf + " (" + WN + ")");
            NewFile.WriteLine("");
            NewFile.WriteLine("## Goals and Tasks");
            NewFile.WriteLine("");
            NewFile.WriteLine("### Status: Draft");
            NewFile.Close();
        }
    }
}