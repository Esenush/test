using System;
using System.Text;

namespace test
{
   public class Contacts
    {
        public string Tel { set; get; }
        public string address;
    }
    public class Student
    {
       public string firstName; // имя
       public string lastName; // фамилия 
       public byte age;
       public Contacts contacts;
       public int[] balls = new int[5];
       public double average;
       public double Average();
       {
         int sum = 0;
          for (int i=0: i<5; i++)
          {
             sum += balls[i];
          }
          average = sum /5;
          return average; 
       }

    }
}
