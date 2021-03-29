using System;
using System.IO;

namespace Process_CSV
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("sales_data_sample.csv");

            double totalFor2003 = 0;
            double totalFor2004 = 0;
            double totalFor2005 = 0;


            for (int i = 1; i < lines.Length; i++)
            {
                //    0             1            2           3            4      5 .....
                //ORDERNUMBER,QUANTITYORDERED,PRICEEACH,ORDERLINENUMBER,SALES,ORDERDATE,STATUS,QTR_ID,MONTH_ID,YEAR_ID,PRODUCTLINE,MSRP,PRODUCTCODE,CUSTOMERNAME,PHONE,ADDRESSLINE1,ADDRESSLINE2,CITY,STATE,POSTALCODE,COUNTRY,TERRITORY,CONTACTLASTNAME,CONTACTFIRSTNAME,DEALSIZE
                string line = lines[i];
                               
                string[] pieces = line.Split(",");
                
                string status = pieces[6];
                int year =  Convert.ToInt32(pieces[9]);
                int month = Convert.ToInt32(pieces[8]);
                double sales = Convert.ToDouble(pieces[4]);
                
                if (pieces[6].ToLower() == "shipped")
                {
                    switch (year)
                    {
                        case 2003:
                            totalFor2003 += sales;
                            break;
                        case 2004:
                            totalFor2004 += sales;
                            break;
                        case 2005:
                            totalFor2005 += sales;
                            break;
                        default:
                            break;
                    }
                }

            } // end of for

            Console.WriteLine($"The total sales for shipped items for 2003 is {totalFor2003.ToString("C")}!");
            Console.WriteLine($"The total sales for shipped items for 2004 is {totalFor2004.ToString("C")}!");
            Console.WriteLine($"The total sales for shipped items for 2005 is {totalFor2005.ToString("C")}!");


        }
    }
}
