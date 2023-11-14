using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finisar.SQLite;

namespace Moradiya_classes_management
{
    class connect
    {
        public connect()
        {
            SQLiteCommand cmd;
            SQLiteDataReader datareader;
            //hear try and catch for if database already exist than no need to create new one that's why
            //it will first try to connect with database if it's fail than in catch it will create new one
            try
            {

                SQLiteConnection con = new SQLiteConnection("Data Source=database.db;Version=3;New=False;Compress=True;");
                con.Open();
                con.Close();
            }
            catch
            {
                SQLiteConnection con = new SQLiteConnection("Data Source=database.db;Version=3;New=True;Compress=True;");
                con.Open();
                // create a new SQL command:
                cmd = con.CreateCommand();

                // Let the SQLiteCommand object know our SQL-Query:
                //create table login
                cmd.CommandText = "CREATE TABLE login (id varchar(20) primary key, password varchar(20));";
                cmd.ExecuteNonQuery();
                // Lets insert admin login into our new table
                cmd.CommandText = "INSERT INTO login (id, password) VALUES ('Admin', 'i am admin');";
                // And execute this again
                cmd.ExecuteNonQuery();
                // ...and inserting teacher login line:
                cmd.CommandText = "INSERT INTO login (id, password) VALUES ('Teacher', 'teacher');";
                // And execute this again
                cmd.ExecuteNonQuery();


                //create table student
                cmd.CommandText = "CREATE TABLE student (s_id int(20) primary key , s_photo varchar(100), f_name varchar(20),l_name varchar(20),m_name varchar(20),dob date,gender varchar(10),address varchar(100),class varchar(3),mobile_no_1 int(10),mobile_no_2 int(10));";
                cmd.ExecuteNonQuery();
                //insert first bydefault id
                cmd.CommandText = "INSERT INTO student (s_id) VALUES (1001);";
                // And execute this again
                cmd.ExecuteNonQuery();

                //create table employe
                cmd.CommandText = "CREATE TABLE employee (e_id varchar(20) primary key, photo varchar(100), f_name varchar(20),l_name varchar(20),m_name varchar(20),dob date,gender varchar(10),address varchar(100),mobile_no_1 int(10),mobile_no_2 int(10),salary int(10),employe_type varchar(20));";
                cmd.ExecuteNonQuery();
                //insert first bydefault id
                cmd.CommandText = "INSERT INTO employee (e_id) VALUES (9001);";
                // And execute this again
                cmd.ExecuteNonQuery();

                //create table exam
                cmd.CommandText = "CREATE TABLE exam(class varchar(3),subject_name varchar(15),e_date date,total_marks int(5));";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE class_subject(class varchar(3),subject_name varchar(15));";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE fee_paid(s_id varchar(20),class varchar(3),f_date date,amount int(20));";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE salary_paid(e_id varchar(20),e_f_name varchar(15),e_l_name varchar(15),e_m_name varchar(15),s_date date, amount int(10));";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE marks(s_id varchar(20),class varchar(3),subject_name varchar(15),e_date date, total_marks int(5),obtain_marks int(5));";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE total_fees(class varchar(3),total_fees int(5));";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "INSERT INTO total_fees VALUES ('1', '0');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO total_fees VALUES ('2', '0');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO total_fees VALUES ('3', '0');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO total_fees VALUES ('4', '0');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO total_fees VALUES ('5', '0');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO total_fees VALUES ('6', '0');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO total_fees VALUES ('7', '0');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO total_fees VALUES ('8', '0');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO total_fees VALUES ('9', '0');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO total_fees VALUES ('10', '0');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO total_fees VALUES ('11-com', '0');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO total_fees VALUES ('12-com', '0');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO total_fees VALUES ('11-sci', '0');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO total_fees VALUES ('12-sci', '0');";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE total_salary(e_id varchar(15),total_salary int(5));";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE deleted_student (s_id varchar(20), s_photo varchar(100), f_name varchar(20),l_name varchar(20),m_name varchar(20),dob date,gender varchar(10),address varchar(100),mobile_no_1 int(10),mobile_no_2 int(10),class varchar(3));";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE final_fee_paid (s_id varchar(20));";
                cmd.ExecuteNonQuery();


                con.Close();
            }
        }
    }
}
