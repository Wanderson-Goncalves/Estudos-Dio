using System;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        
        int[] num = new int[n];
    
// TODO: Crie as outras condições necessárias para a resolução do desafio:

        for ( int i = 0; i < num.Length; i++)
        {
            num[i] = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine(MajorityElement(num));
        
    }
    public static int MajorityElement(int[] nums)
    {
        int major = nums[0];
        int count = 1;
        
        for ( int i = 0; i < nums.Length; i++ )
        {
          int repeatedNumber = 0;
          int counter = 0;
          
          for (int j = 1; j < nums.Length; j++)
          {
             if (nums[i] == nums[j])
             {
               repeatedNumber = nums[i];
               counter++;
              }
          }
          
          if (counter > count)
          {
            major = repeatedNumber;
            count = counter;
          }
         else if ( counter == count){
            major = repeatedNumber > major ? repeatedNumber : major;
          }
            
        }
  
        
          return major;
      
    }
  }