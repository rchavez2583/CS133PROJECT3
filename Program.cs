using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


namespace CS133PROJECT2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<myClass> myObjectList = new List<myClass>();

            myClass myObject1 = new myClass();
            myObject1.flavor = "Vanilla";
            myObject1.type = "Wedding cake";

            myClass myObject2 = new myClass();
            myObject2.flavor = "Chocolate";
            myObject2.type = "Party cake ";



            myObjectList.Add(myObject1);
            myObjectList.Add(myObject2);


            List<myClass> newList =
            myObjectList.Where(myClass => myClass.type == "Chocolate").ToList();

            foreach (var item in newList)
            {
                Console.WriteLine("My cake is a type" + item.flavor
                                  + "And the flavor is" + item.type);
            }


        }
    }
}

public class myClass
{
    public string flavor { get; set; }
    public string type { get; set; }
   
}