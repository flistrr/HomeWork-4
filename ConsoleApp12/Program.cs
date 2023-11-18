using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Text;

namespace Hometask1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person[] people = new Person[6];
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Person();
                
            }
            Person.Output(people);
        }
    }
}
