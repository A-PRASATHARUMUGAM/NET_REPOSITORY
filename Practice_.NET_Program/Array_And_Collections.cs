
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices.Marshalling;

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

        //1. List 
            //Add(); - add the value 
            //Remove();  - value to remove 
            //RemoveAt(); - index to remove 

        //2. Dictionaries
                //Add
                //Keys.ElementAt()
                //Values.ElementAt()
                //Remove(); - Enter the key to remove

        //3. Stack
                //push
                //pop
                //peek
                //count
                    
                

        //4. Queue
                //Enqueue -- add the value to front 
                //Dequeue -- remove the value to front
                //Peep  -- show the value to front 

                            //Non Generic Collection

        //1. ArrayList 
            //Add();   - add the value 
            //Remove(); - value to remove  
            //RemoveAt(); - index to remove 

        //2. HashTable - store like key value pair  then using DictionaryEntry 
                //Add();   - store like key value pair 
                //Remove(); - Enter the key to remove
                //key, value 
        



        public static void collect()
        {
            //Array 

            //Type - 1 
            int[] arr = new int[5];

            //Type - 2
            int[] arr2 = { 1, 2, 3, 4, 5 };

            //Type - 3
            int[] arr3 = new int[] { 1, 2, 3, 6, 5 };

            foreach (int val2 in arr3)
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


            //SYNTAX  - ArrayList variablename= new ArrayList();
            ArrayList arrayList = new ArrayList();

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





            //2. HashTable   - Using Dictionary Keyword to get data via foreach in 

            //SYNTAX - Hastable variablename = new Hashtable();
            Hashtable checkHash = new Hashtable();


            Console.WriteLine("                --- HashTable ----");

            //Add  - store like key value pair 
            checkHash.Add(1, 45);
            checkHash.Add(2, 433.4f);
            checkHash.Add(3, "kandhan");
            checkHash.Add(4, true);
            checkHash.Add("bool", true);
            checkHash.Add("A2", null); //--Empty 

            Console.WriteLine(checkHash["bool"]); // call via key then index



            foreach (DictionaryEntry val in checkHash)
            {

                Console.WriteLine($"key {val.Key}: value {val.Value}"); 
              
            }


            //Remove()              // - Key to remove the value 
            Console.WriteLine("                  key to remove the value ");

            checkHash.Remove("bool"); 

            foreach (DictionaryEntry val in checkHash)
            {
                Console.WriteLine($"key {val.Key}: value {val.Value}");

            }













            //Generic Collection - Limited to one type of object

            //1. List

           //SYNTAX  -  List<datatype> variablename= new List<datatype>();
           List<int> checkList = new List<int>();
           List<string> checkList2 = new List<string>();
           List<float> checkList3 = new List<float>();


                        Console.WriteLine("                --- List ----");
                        //Add
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

            //2. Dictionary

            //SYNTAX  - Dictionary<Key,Value> variablename =new Dictionary<Key,Value>();

            Dictionary<int, string> checkdict = new Dictionary<int,string>();

            Console.WriteLine("      --------- Dictionary -----------");


                        //Add
                        checkdict.Add(0,"prasath");
                        checkdict.Add(1, "kandhan");
                        checkdict.Add(2, "vignesh");

               
                       foreach(var val in checkdict)
                        {
                            Console.WriteLine($"{val.Key}, {val.Value}");

                        }

                        //ElementAt() - using to show keys and values
                        //using for loop
                        Console.WriteLine("                using for loop the ElementAt() , Keys, Values");
                        for(var i =0; i <checkdict.Count; i++)
                        {

                            Console.WriteLine(checkdict.Keys.ElementAt(i)); 
                            Console.WriteLine(checkdict.Values.ElementAt(i)); 
                        }

                        //Remove();     - Enter the key to remove 

                        checkdict.Remove(2);
                        Console.WriteLine("              Enter the key to remove");
                        for (var i = 0; i < checkdict.Count; i++)
                        {
                            Console.WriteLine(checkdict.Keys.ElementAt(i));
                            Console.WriteLine(checkdict.Values.ElementAt(i));
                        }


            //3. Stack 
                    Console.WriteLine("         ----- STACK -------");
                    //First In Last Out[FIFO]
                    //Stack<int> stack = new Stack<int>();
                    //Push, Pop and Peek.


            //SYNTAX - Stack<int> variablename = new Stack<int>();

            Stack<int> checkstack = new Stack<int>();

                        //Push  - insert the data to 
                        checkstack.Push(20);
                        checkstack.Push(30);
                        checkstack.Push(70);

                        foreach (var val in checkstack)
                        {
                            Console.WriteLine(val);
                        }
                                        Console.WriteLine("Using Pop ");
                        //Pop   - Remove the value to top 
                        checkstack.Pop();

                        foreach (var val in checkstack)
                        {
                            Console.WriteLine(val);
                        }
                                        Console.WriteLine("Using Peek ");
                        //Peek  - show data from top of the stack
                        Console.WriteLine(checkstack.Peek());

                                        Console.WriteLine("Using Count");
                        //Count  - show the count of the stack        
                        Console.WriteLine(checkstack.Count());


            //4. Queue

            Console.WriteLine("         ----- Queue -------");
            //First In First Out[FIFO]
            //Queue<int> queue = new Queue<int>();
            //Enqueue, Dequeue and Peek.

            //SYNTAX - Queue<datatype> variablename = new Queue<datatype>();


            Queue<int> checkqueue = new Queue<int>();


            //Enqueue  - add the value to front
            checkqueue.Enqueue(20); 
            checkqueue.Enqueue(30);
            checkqueue.Enqueue(40);
            checkqueue.Enqueue(50);


            foreach (var val in checkqueue)
            {
                Console.WriteLine(val);
            }

            //Dequeue  - Remove the value to front
            checkqueue.Dequeue();   

            Console.WriteLine("after Dequeue");

            foreach (var val in checkqueue)
            {
                Console.WriteLine(val );
            }

            //Peek  - show the front of the value 
            Console.Write(checkqueue.Peek());






    
            //Non Generic Collection  - not specifice 
            //ArrayList  varname= new ArrayList();      -- Non specifice to store   values   

            //Hashtable  varname= new HashTable();      --  Non specifice store key value pair 


            ////Generic Collection     - specifice 

            //List<int>  varname2= new List<int>();          --   specifice to store  values

            //Dictionary<key,value> varname = new Dictionary<int,string>();  --store specifice key value pair 







        }
    }
}    