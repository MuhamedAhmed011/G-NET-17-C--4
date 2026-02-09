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
        }
    }
}
