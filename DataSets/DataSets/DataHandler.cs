using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace DataSets
{
    class DataHandler
    {
        public DataHandler() { }
        //set connection string
        string connection = "Server = COMPSCI_BADDIE\\PINKDATABASE; Initial Catalog = BelgiumCampus; Integrated Security = SSPI";

        public DataSet displayStudents()
        {
            //set sql query to run
            string query = @"SELECT * FROM Students";
            //vreate sqlDataAdapter object, and pass it query and connection string
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            //create data set object
            DataSet dataSet = new DataSet();
            //fill dataset object swith data fetched by sqldataAdapter
            adapter.Fill(dataSet);
            SaveDataSetToFile(dataSet, @"C:\Users\kekan\Desktop\PRG 282\DataSets\Students.txt");
            return dataSet;
            //store the data on a text file
            

        }
        private void SaveDataSetToFile(DataSet dataSet, string filePath)
        {
            // Check if the dataset has tables and rows
            if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                
                // Open a StreamWriter to write data to a file
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    DataTable table = dataSet.Tables[0];

                    // Write the column headers
                    foreach (DataColumn column in table.Columns)
                    {
                        writer.Write(column.ColumnName + "\t");
                    }
                    writer.WriteLine();

                    // Write each row's data
                    foreach (DataRow row in table.Rows)
                    {
                        foreach (var item in row.ItemArray)
                        {
                            writer.Write(item.ToString() + "\t");
                        }
                        writer.WriteLine();
                    }
                }
            }
        }
        public DataTable displayLectures()
        {
            //set sql query to run
            string query = @"SELECT * FROM Lecturers";
            //vreate sqlDataAdapter object, and pass it query and connection string
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            //create data set object
            DataTable dataTable = new DataTable();
            //fill dataset object swith data fetched by sqldataAdapter
            adapter.Fill(dataTable);
            SaveDataTableToFile(dataTable, @"C:\Users\kekan\Desktop\PRG 282\DataSets\Lecturers.txt");//calling the save method
            return dataTable;
            //store on a text file
        }
        private void SaveDataTableToFile(DataTable dataTable, string filePath)
        {
            // Check if the DataTable has rows
            if (dataTable.Rows.Count > 0)
            {
                // Open a StreamWriter to write data to a file
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Write the column headers
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        writer.Write(column.ColumnName + "\t");
                    }
                    writer.WriteLine();

                    // Write each row's data
                    foreach (DataRow row in dataTable.Rows)
                    {
                        foreach (var item in row.ItemArray)
                        {
                            writer.Write(item.ToString() + "\t");
                        }
                        writer.WriteLine();
                    }
                }
            }
        }

    }
}
