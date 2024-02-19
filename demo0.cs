using System;      
public class IfExample  
    {  
       public static void Main(string[] args)  
        {  
            int num ;
            Console.WriteLine("Enter the Number " );
          
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)  
            {  
                Console.WriteLine("It is even number");  
            }  
              
        }  
    }  
