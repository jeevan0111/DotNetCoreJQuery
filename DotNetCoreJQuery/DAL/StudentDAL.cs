using System;
using Npgsql;
using DotNetCoreJQuery.Models;
using System.Data;

namespace DotNetCoreJQuery.DAL
{
    public class StudentDAL
    {
        private readonly IConfiguration _configuration;

       
        public StudentDAL(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();
            //string sqlDataSource = "Server=localhost;Database=MyDB;Port=5432;User Id=postgres;Password=password;";

            string sqlDataSource =  _configuration.GetConnectionString("MyDBConn");

            using (NpgsqlConnection connection = new NpgsqlConnection(sqlDataSource))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand("get_all_students", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    NpgsqlDataReader myReader = command.ExecuteReader();
                    while (myReader.Read())
                    {
                        Student student = new Student();
                        student.Id = Convert.ToInt32(myReader["id"]);
                        student.StudentName = myReader["studentname"].ToString();
                        student.StudentGender = myReader["studentgender"].ToString();
                        student.Age = Convert.ToInt32(myReader["age"]);
                        student.Standard = myReader["standard"].ToString();
                        student.FatherName = myReader["fathername"].ToString();
                        students.Add(student);

                    }
                    myReader.Close();
                    connection.Close();
                }
            }
            return students;

        }

        public void AddStudent (Student student)
        {
            string sqlDataSource = _configuration.GetConnectionString("MyDBConn");

            using (NpgsqlConnection connection = new NpgsqlConnection(sqlDataSource))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand("insert_student_data", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    //NpgsqlDataReader myReader = command.ExecuteReader();

                    command.Parameters.AddWithValue("@studentname", student.StudentName);
                    command.Parameters.AddWithValue("@studentgender", student.StudentGender);
                    command.Parameters.AddWithValue("@age", student.Age);
                    command.Parameters.AddWithValue("@standard", student.Standard);
                    command.Parameters.AddWithValue("@fathername", student.FatherName);

                    command.ExecuteNonQuery();

                    //myReader.Close();
                    connection.Close();
                }
            }
        }
    }
}

