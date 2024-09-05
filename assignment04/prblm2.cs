﻿using System.Data.SqlClient;
using System.Data;
using System;
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connStr = "Server=ushydmsonga1\\sqlservermani; Database=mani; Integrated Security=true";

            string cmdText = "SELECT * FROM product";

            SqlDataAdapter adapter = new SqlDataAdapter(cmdText, connStr);
            DataSet ds = new DataSet();

            adapter.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine("{0},{1},{2},{3},{4}", row["productid"].ToString(), row["pname"].ToString(), row["price"].ToString(), row["quantity"].ToString(), row["category"].ToString());
            }

            Console.ReadLine();
        }
    }
}