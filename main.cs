using System;
using System.Linq;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    List<string> sobj = new List<string>()
     {"arun", "aaron", "kumar", "kawasaki", "satish", "basavaraj", "brisbane"};
   var query = sobj
                .Where(s => s.Length >5)
                .Select(s => s)
                .Where((s, i) => { return s.Length >3; })
                .OrderByDescending(s => s.Length)
                .ThenByDescending(s => s);
   foreach(string name in query){
     Console.WriteLine(name);
   }
  }
}