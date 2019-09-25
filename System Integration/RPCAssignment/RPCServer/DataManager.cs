using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using Dapper;
using RPCAssignment.Models;

namespace RPCAssignment
{
    public class DataManager
    {
        private string TXTFILEPATH = "C:\\Users\\nikod\\Documents\\GitHub\\Software2019\\Solutions\\System Integration\\RPCAssignment\\RPCServer\\TextFiles\\Students.txt";
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\nikod\\Documents\\MSSQLLocalDB.mdf;Integrated Security=True;Connect Timeout=30";

        // The method for getting students from the database using the connectionString given above.
        private string GetStudentsFromDB()
        {
            List<Student> studentList = new List<Student>();
            string result = "";

            // Using Dapper to make a SELECT query in the db.
            using (IDbConnection conn = new SqlConnection(connectionString))
            {
                studentList = conn.Query<Student>("SELECT * from Students").ToList();
            }

            foreach (var student in studentList)
            {
                result += $"{student.Name} {student.Email},";
            }

            return result;
        }

        // The method for getting students from the Text file located in the TextFiles folder.
        private string GetStudentsFromTxt()
        {
            string[] lines = File.ReadAllLines(TXTFILEPATH);
            string result = "";

            // Splitting each student in the txt file by adding a , 
            foreach (var student in lines)
            {
                result += $"{student},";
            }

            return result;
        }

        // Method for our client to call for through RPC.
        public string GetStudents()
        {
            string result = GetStudentsFromDB() + GetStudentsFromTxt();

            return result;
        }

    }
}