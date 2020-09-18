﻿
using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] text ={"АРТЕМ",
        "LOVE",
        "ВАЗЕЛИН",
        "CONTEX",
        "C++",
        " +79263772622",
        " 89263772622",
        " (926)3772622" };

      //string str56 = "c:\vazelin\artem\nude_photos";
      string str56 = $"stringi {text[0]}A";
      Console.WriteLine(str56);


      foreach (string item in text)
      {
        string pattern = @"[7]{0,1}[(]{0,1}\d{3}[)]{0,1}[-]{0,1}\d{3}[-]{0,1}\d{2}[-]{0,1}\d{2}";
        if (Regex.IsMatch(item, pattern))
        {
          //Console.WriteLine($"{item} это телефон"); 
          Console.WriteLine(item + " это телефон");
        }
        else
        {
          Console.WriteLine(
          string.Format("{0} это НЕ телефон", item)
          );
        }

      }

    }
  }
}