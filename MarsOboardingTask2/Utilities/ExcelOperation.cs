using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ExcelOperation
{
    public class ExcelData
    {
        //Creating the collection we will use to store data 
        private static List<DataCollection> dataCollection = new List<DataCollection>();

        //Populating stream data into the "dataCollection" collection 
        public static void PopulateInCollection(string Excelfilename)
        {
            DataTable table = ExcelToDataTable(Excelfilename);

            //Iterate through the columns and rows 
            for (int row = 1; row <= table.Rows.Count; row++)
            {
                for (int col = 0; col < table.Columns.Count-1; col++)
                {
                    DataCollection dtTable = new DataCollection()
                    {
                        RowNumber = row,
                        ColumnName = table.Columns[col].ColumnName,
                        ColumnValue = table.Rows[row - 1][col].ToString()
                    };

                    //Add detaile per row 
                    dataCollection.Add(dtTable);
                }
            }
        }

        public static DataTable ExcelToDataTable(String Excelfilename)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            //Open system file amd returns it as a stream 
            using (FileStream stream = File.Open(Excelfilename, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (data) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });
                    //Get all the Tables 
                    DataTableCollection table = result.Tables;

                    //Store it in DataTable 
                    DataTable resultTable = table["Login"];

                    //return sheet
                    return resultTable;
                }
            }
        }

        public static string ReadData(int rowNumber, string ColumnName)
        {
            try
            {
                //Retriving Data using LINQ 
                string data = (from colData in dataCollection
                               where colData.ColumnName == ColumnName && colData.RowNumber == rowNumber
                               select colData.ColumnValue).SingleOrDefault();

                return data.ToString();
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        //Class properties that will store the Excel data by Row and Column Name 
        public class DataCollection
        {
            public int RowNumber { get; set; }
            public string ColumnName { get; set; }
            public string ColumnValue { get; set; }
        }
    }
}