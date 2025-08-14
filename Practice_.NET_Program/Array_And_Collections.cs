
using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace Practice_.NET_Program
{
     class Array_And_Collections
    {

                            //COLLECTIONS

        //Array

        //Types Of Collection

        //Generic Collection - Limited to one type of object

        //Non Generic Collection - Can store any type of object

                        //Generic Collection

        //1. List,
               //Add(); - add the value 
               //Remove();  - value to remove 
               //RemoveAt(); - index to remove 

        //2. Dictionaries,

        //3. Stack,

        //4. Queue

                        //Non Generic Collection

        //1. ArrayList,
                //Add();   - add the value 
                //Remove(); - value to remove 
               //RemoveAt(); - index to remove 
        //2. HashTable



        public static void collect()
        {
                      //Array 
       
            //Type - 1 
            int[] arr = new int[5];

            //Type - 2
            int[] arr2 = { 1, 2, 3, 4, 5 };

            //Type - 3
            int[] arr3 = new int[] { 1, 2, 3, 6, 5 };
            
            foreach(int val2 in arr3)
            {
                Console.WriteLine(val2);
            }


            arr[0] = 10;
            arr[1] = 20;
            arr[2] = 30;
            arr[3] = 40;
            arr[4] = 50;

            //ForEach
            foreach (int val in arr)
            {

                Console.WriteLine(val);
            }



                                //Types Of Collection


            //Non Generic Collection - Can store any type of object


            //1. ArrayList,

                     
                      
             

                            //SYNTAX
                        ArrayList arrayList= new ArrayList();

                        Console.WriteLine("              ---  Array List --- ");
                        //Add()
                        arrayList.Add(50);    
                        arrayList.Add(3.3f);
                        arrayList.Add("check 1");
                        arrayList.Add(true);
                        arrayList.Add(50);



                        foreach (var val in arrayList)
                        {
                            Console.WriteLine(val);

                        }

                        //Remove()
                        Console.WriteLine("              After value to remove ");

                        arrayList.Remove(50);           // Removed the Index order 

                        foreach (var val in arrayList)
                        {
                            Console.WriteLine(val);


                        }

                        //RemoveAt()
                        Console.WriteLine("              After  index to remove");

                        arrayList.RemoveAt(3);          // Removed the Selection order 


                        foreach (var val in arrayList)
                        {
                            Console.WriteLine(val);


                        }


            //Generic Collection - Limited to one type of object

            //1. List

                        //SYNTAX
                        List<int> checkList = new List<int>();
                        List<string> checkList2 = new List<string>();
                        List<float> checkList3 = new List<float>();


                        Console.WriteLine("                --- List ----");
                        checkList.Add(50);
                        checkList.Add(20);
                        checkList.Add(30);
                        checkList.Add(5);
               
                        foreach(var val in checkList)
                        {

                            Console.WriteLine(val);
                        }

                        //Remove()
                        Console.WriteLine("              After value to remove ");

                        checkList.Remove(50);           // Removed the Index order 

                        foreach (var val in checkList)
                        {
                            Console.WriteLine(val);


                        }

                        //RemoveAt()
                        Console.WriteLine("              After index to remove ");

                        checkList.RemoveAt(1);          // Removed the Selection order 


                        foreach (var val in checkList)
                        {
                            Console.WriteLine(val);


                        }







        }
    }
}
