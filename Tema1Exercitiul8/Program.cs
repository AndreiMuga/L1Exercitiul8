using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace Lab1Ex8
/*
 Ex8
Se citesc trei numere de la tastatura, x,y,z. Scrieti un program care va afisa cele
trei valori in ordine descrescatoare.
• Exemplu: citim 3 9 0 Afisam : 9 3 0
 */
{
    public class Program
    { public static void Main(string[] args)
        { 
            
            double primulNumar ;
            double alDoileaNumar ;
            double alTreileaNumar ;
            Console.WriteLine("Introduceti primul numarul: ");
            primulNumar = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea numar: ");
            alDoileaNumar = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduceti al treilea numar: ");
            alTreileaNumar = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Numerele introduse in ordine descrescatoare: ");
             if (primulNumar > alDoileaNumar && alDoileaNumar > alTreileaNumar )
            {
                Console.WriteLine(primulNumar +", " + alDoileaNumar + ", " + alTreileaNumar);
            } 
            else if(primulNumar > alDoileaNumar && alDoileaNumar < alTreileaNumar)
            { 
                Console.WriteLine(primulNumar + ", " + alTreileaNumar + ", "+ alDoileaNumar);
            } 
            else if( primulNumar < alDoileaNumar && primulNumar > alTreileaNumar)
            {      
                Console.WriteLine(alDoileaNumar + ", " + primulNumar + ", " + alTreileaNumar);
            }     
            else if( alTreileaNumar < alDoileaNumar && primulNumar < alDoileaNumar)
            { 
                Console.WriteLine(alDoileaNumar + ", " + alTreileaNumar + ", " + primulNumar);
            }     
            else if(alTreileaNumar > alDoileaNumar && alDoileaNumar < primulNumar )
            {      
                Console.WriteLine(alTreileaNumar + ", " + primulNumar + ", " + alDoileaNumar);
            } 
            else if( alTreileaNumar > alDoileaNumar && alDoileaNumar > primulNumar && alTreileaNumar > primulNumar)
            { 
                Console.WriteLine(alTreileaNumar + ", "+ alDoileaNumar + ", " + primulNumar);
            }     
            else     
            {      
                Console.WriteLine("Empty");     
            }     
        }   
    } 
}