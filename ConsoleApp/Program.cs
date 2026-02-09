using Microsoft.VisualBasic.FileIO;
using System;
using System.Text;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            // (A)
            // In C#, string is immutable,
            //so each += creates a new string and copies all previous characters
            // (B)
            //StringBuilder sb = new StringBuilder();

            //for (int i = 1; i <= 5000; i++)
            //{
            //    sb.Append("PROD-");
            //    sb.Append(i);
            //    sb.Append(',');
            //}
            //string productList = sb.ToString();
            #endregion

            #region Question02
            //Console.Write("Enter age: ");
            //int age = int.Parse(Console.ReadLine());

            //Console.Write("Enter day of week (1–7, 6=Fri, 7=Sat): ");
            //int day = int.Parse(Console.ReadLine());

            //Console.Write("Do you have a student ID? (yes/no): ");
            //bool hasStudentId = Console.ReadLine().ToLower() == "yes";

            //double price = 0;

            //if (age < 5)
            //{
            //    price = 0;
            //}
            //else if (age <= 12)
            //{
            //    price = 30;
            //}
            //else if (age <= 59)
            //{
            //    price = 50;
            //}
            //else
            //{
            //    price = 25;
            //}
            //if (price > 0 && (day == 6 || day == 7))
            //{
            //    price += 10;
            //}
            //if (price > 0 && hasStudentId)
            //{
            //    price *= 0.8;
            //}
            //Console.WriteLine("\nFinal Ticket Price: " + price + " LE"); 
            #endregion

            #region Question03
            // a
            //string fileExtension = ".pdf";
            //string fileType;

            //switch (fileExtension)
            //{
            //    case ".pdf":
            //        fileType = "PDF Document";
            //        break;

            //    case ".doc":
            //    case ".docx":
            //        fileType = "Word Document";
            //        break;

            //    case ".xls":
            //    case ".xlsx":
            //        fileType = "Excel Spreadsheet";
            //        break;

            //    case ".jpg":
            //    case ".png":
            //    case ".gif":
            //        fileType = "Image File";
            //        break;

            //    default:
            //        fileType = "Unknown File Type";
            //        break;

            //// b
            //string fileExtension = ".pdf";

            //string fileType = fileExtension switch
            //{
            //    ".pdf" => "PDF Document",
            //    ".doc" or ".docx" => "Word Document",
            //    ".xls" or ".xlsx" => "Excel Spreadsheet",
            //    ".jpg" or ".png" or ".gif" => "Image File",
            //    _ => "Unknown File Type"
            //}; 
            #endregion

            #region Question04
            //int temperature = 35;

            //string weatherAdvice =
            //    temperature < 0 ? "Freezing! Stay indoors." :
            //    temperature < 15 ? "Cold. Wear a jacket." :
            //    temperature < 25 ? "Pleasant weather." :
            //    temperature < 35 ? "Warm. Stay hydrated." : "Hot! Avoid sun exposure.";

            //// Ternary is better when The logic is simple
            //// if-else is better when There are many conditions 
            #endregion
        }
    }
    }
}
