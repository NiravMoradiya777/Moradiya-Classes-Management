using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finisar.SQLite;
using System.IO;

namespace Moradiya_classes_management
{
    class database:connect
    {
        public SQLiteConnection con = new SQLiteConnection("Data Source=database.db;Version=3;New=False;Compress=True;");
        public SQLiteCommand cmd;
        public SQLiteDataReader datareader;
        public SQLiteDataAdapter adepter;

        //this all function is for retriving something from database
        public int give_new_id(string ID_Name, string TableName)
        {
            con.Open();
            cmd = con.CreateCommand();
            string commandText = "select "+ID_Name+ " from "+TableName+" order by rowid desc limit 1 ";
            cmd.CommandText = commandText;
            string lastvalue = cmd.ExecuteScalar().ToString();
            //convert old id to integer
            int i = Convert.ToInt32(lastvalue);
            //give new id increment by 1
            i = i + 1;
            con.Close();
            return i;
        }
        //this all function is for select operation in database
        public string get_password(string username)
        {
            string password=null;
            con.Open();
            cmd = con.CreateCommand();
            string commandText = "select password from login where id='"+username+"'";
            cmd.CommandText = commandText;
            datareader = cmd.ExecuteReader();
            while (datareader.Read())
            {

                password = datareader.GetString(0);
            }
            con.Close();
            return password;
        }

        public void change_password(string id,string pass)
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "update login set password='" + pass + "' where id ='" + id + "';";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //from hear all below tables are for insert in database
        public void add_new_student(string id,string img,string f_name,string l_name,string m_name,string date,string gender, string address,string std,long no_1,long no_2)
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into student values('" + id + "', '" + img + "', '" + f_name + "', '" + l_name + "', '" + m_name + "', '" + date + "', '" + gender + "', '" + address + "', '" + std + "', '" + no_1 + "', '" + no_2 + "');";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void update_student(string id,string img, string f_name, string l_name, string m_name, string date, string gender, string address,  string std, long no_1, long no_2)
        {
            con.Open();
            cmd = con.CreateCommand();
            //cmd.CommandText = "update student (s_photo,f_name,l_name,m_name,dob,gender,address,class,mobile_no_1,mobile_no_2) set ('" + img + "', '" + f_name + "', '" + l_name + "', '" + m_name + "', '" + date + "', '" + address + "', '" + gender + "', '" + std + "', '" + no_1 + "', '" + no_2 + "');";
            cmd.CommandText = "update student set s_photo='" + img + "',f_name='" + f_name + "',l_name= '" + l_name + "',m_name= '" + m_name + "',dob= '" + date + "',gender= '" + gender + "',address= '" + address + "',class= '" + std + "',mobile_no_1= '" + no_1 + "',mobile_no_2= '" + no_2 + "' where s_id ='"+id+"';";
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public string[] get_student_information_by_id(string id)
        {
            string[] information = new string[11];

            con.Open();
            //here below "Student_Information.id.ToString()" is for retrive information from selected button from view button
            //or we can say that this is for retrive data from previous page in privious page id is public static that's why it's accessible here
            cmd = new Finisar.SQLite.SQLiteCommand("select * from student  where s_id='" + id + "'", con);
            datareader = cmd.ExecuteReader();

            while (datareader.Read())
            {
                information[0] = datareader[0].ToString();
                information[1] = datareader[1].ToString();
                information[2] = datareader[2].ToString();
                information[3] = datareader[3].ToString();
                information[4] = datareader[4].ToString();
                information[5] = datareader[5].ToString();
                information[6] = datareader[6].ToString();
                information[7] = datareader[7].ToString();
                information[8] = datareader[8].ToString();
                information[9] = datareader[9].ToString();
                information[10] = datareader[10].ToString();
            }

            con.Close();

            return information;
        }
        public void delete_student(string id)
        {
            con.Open();
            cmd = con.CreateCommand();
            //cmd.CommandText = "update student (s_photo,f_name,l_name,m_name,dob,gender,address,class,mobile_no_1,mobile_no_2) set ('" + img + "', '" + f_name + "', '" + l_name + "', '" + m_name + "', '" + date + "', '" + address + "', '" + gender + "', '" + std + "', '" + no_1 + "', '" + no_2 + "');";
            cmd.CommandText = "DELETE FROM student where s_id ='" + id + "';";
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void student_in_delete_table(string id, string img, string f_name, string l_name, string m_name, string date, string address, string gender, long no_1, long no_2, string std)
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into deleted_student values('" + id + "', '" + img + "', '" + f_name + "', '" + l_name + "', '" + m_name + "', '" + date + "', '" + address + "', '" + gender + "',  '" + no_1 + "', '" + no_2 + "','" + std + "');";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public string[] get_student_Marks_by_id(string id)
        {
            string[] information = new string[11];

            con.Open();
            //here below "Student_Information.id.ToString()" is for retrive information from selected button from view button
            //or we can say that this is for retrive data from previous page in privious page id is public static that's why it's accessible here
            cmd = new Finisar.SQLite.SQLiteCommand("select * from marks  where s_id='" + id + "'", con);
            datareader = cmd.ExecuteReader();

            while (datareader.Read())
            {
                information[0] = datareader[0].ToString();
                information[1] = datareader[1].ToString();
                information[2] = datareader[2].ToString();
                information[3] = datareader[3].ToString();
                information[4] = datareader[4].ToString();
                information[5] = datareader[5].ToString();
            }
            con.Close();
            return information;
        }

        public void add_new_employee(string id, string img, string f_name, string l_name, string m_name, string date,  string gender, string address,  long no_1, long no_2, long salary, string type)
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into employee values('" + id + "', '" + img + "', '" + f_name + "', '" + l_name + "', '" + m_name + "', '" + date + "', '" + gender + "', '" + address + "', '" + no_1 + "', '" + no_2 + "', '" + salary + "', '" + type + "');";
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public string[] get_employe_information_by_id(string id)
        {
            string[] information = new string[12];
            con.Open();
            //here below "Student_Information.id.ToString()" is for retrive information from selected button from view button
            //or we can say that this is for retrive data from previous page in privious page id is public static that's why it's accessible here
            cmd = new Finisar.SQLite.SQLiteCommand("select * from employee  where e_id='" + id + "'", con);
            datareader = cmd.ExecuteReader();

            while (datareader.Read())
            {
                information[0] = datareader[0].ToString();
                information[1] = datareader[1].ToString();
                information[2] = datareader[2].ToString();
                information[3] = datareader[3].ToString();
                information[4] = datareader[4].ToString();
                information[5] = datareader[5].ToString();
                information[6] = datareader[6].ToString();
                information[7] = datareader[7].ToString();
                information[8] = datareader[8].ToString();
                information[9] = datareader[9].ToString();
                information[10] = datareader[10].ToString();
                information[11] = datareader[11].ToString();
            }
            con.Close();
            return information;
        }

        public void update_employee(string id, string img, string f_name, string l_name, string m_name, string date, string gender, string address,  long no_1, long no_2, long salary, string emp_type)
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "update employee set photo='" + img + "',f_name='" + f_name + "',l_name= '" + l_name + "',m_name= '" + m_name + "',dob= '" + date + "',gender= '" + gender + "',address= '" + address + "',mobile_no_1= '" + no_1 + "',mobile_no_2= '" + no_2 + "',salary= '" + salary + "',employe_type= '" + emp_type + "' where e_id ='" + id + "';";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public string[] get_fee_information_statement_by_class(string Class)
        {
            string[] information = new string[12];
            con.Open();
            cmd = new Finisar.SQLite.SQLiteCommand("SELECT * FROM fee_paid, (select total_fees from total_fees where class='"+Class+ "') where class='"+Class+"'  order by f_date", con);
            datareader = cmd.ExecuteReader();
            while (datareader.Read())
            {
                information[0] = datareader[0].ToString();
                information[1] = datareader[1].ToString();
                information[2] = datareader[2].ToString();
                information[3] = datareader[3].ToString();
                information[4] = datareader[4].ToString();
            }
            con.Close();
            return information;
        }

        public int get_total_fees(string Class)
        {
            int total_fee=0;
            con.Open();
            cmd = new Finisar.SQLite.SQLiteCommand("SELECT total_fees FROM total_fees where class = '"+Class+"'", con);
            datareader = cmd.ExecuteReader();
            while (datareader.Read())
            {
                total_fee = Convert.ToInt32(datareader[0]);
            }
            con.Close();
            return total_fee;
        }

        public int get_paid_fees(string id)
        {
            int paid_fee = 0;
            con.Open();             
            cmd = new Finisar.SQLite.SQLiteCommand("SELECT sum(amount) from fee_paid where s_id = '"+id+"'", con);
            datareader = cmd.ExecuteReader();
            while (datareader.Read())
            {
                paid_fee = Convert.ToInt32(datareader[0]);
            }
            con.Close();
            return paid_fee;
        }

        public void pay_fee(string id, string Class, string date,int amount)
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into fee_paid values('" + id + "', '" + Class + "','" + date + "', '" + amount + "');";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void add_subject(string Class,string subject)
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into class_subject values('" + Class + "', '" + subject + "');";
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void delete_subject(string Class,string subject)
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM class_subject where class ='" + Class + "' and subject_name='"+subject+"';";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public string[] get_subject_by_class(string Class)
        {
            string[] information = new string[10];
            int i=0;
            con.Open();
            cmd = new Finisar.SQLite.SQLiteCommand("SELECT subject_name FROM class_subject where class='" + Class + "'", con);
            datareader = cmd.ExecuteReader();
            while (datareader.Read())
            {
                information[i] = datareader[0].ToString();
                i++;
            }
            con.Close();
            return information;
        }

        public void update_exam(string Class, string subject,string date, string marks, string old_Class, string old_date)
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "update exam set class='" + Class + "',subject_name='" + subject + "',e_date= '" + date + "',total_marks= '" + marks + "' where class = '"+old_Class+"' and e_date = '"+ old_date +"';";
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void delete_exam(string Class, string date)
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM exam where class ='" + Class + "' and e_date ='" + date + "';";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void add_new_exam(string Class, string subject, string e_date, string marks)
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into exam values('" + Class + "', '" + subject + "', '" + e_date + "', '" + marks + "');";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void add_marks(string s_id, string Class,string subject, string date, string total, string obtain)
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into marks values('" + s_id + "', '" + Class + "','" + subject + "','" + date + "','" + total + "','" + obtain + "');";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public int get_paid_salary(string id)
        {
            int paid_salary = 0;
            con.Open();
            cmd = new Finisar.SQLite.SQLiteCommand("SELECT sum(amount) from salary_paid where e_id = '" + id + "'", con);
            datareader = cmd.ExecuteReader();
            while (datareader.Read())
            {
                paid_salary = Convert.ToInt32(datareader[0]);
            }
            con.Close();
            return paid_salary;
        }

        public int get_total_salary(string id)
        {
            int total_salary = 0;
            con.Open();
            cmd = new Finisar.SQLite.SQLiteCommand("SELECT salary FROM employee where e_id = '" + id + "'", con);
            datareader = cmd.ExecuteReader();
            while (datareader.Read())
            {
                total_salary = Convert.ToInt32(datareader[0]);
            }
            con.Close();
            //this return * 12 for full year package
            return total_salary * 12;
        }
        public void salary_paid(string e_id, string f_name, string l_name, string m_name, string date, string amount)
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into salary_paid values('" + e_id + "', '" + f_name + "','" + l_name + "','" + m_name + "','" + date + "','" + amount + "');";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void update_fees(string Class, string fees)
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "update total_fees set total_fees='" + fees + "' where class='" + Class + "';";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void update_salary(string id, string salary)
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "update employee set salary='" + salary + "' where  e_id='" + id + "';";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public int total_number_of_student_by_class(string Class)
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM student where class = '"+Class+"';";
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return count;
        }

        public int get_paid_total_fees()
        {
            int total_paid_fees = 0;
            con.Open();
            cmd = new Finisar.SQLite.SQLiteCommand("SELECT sum(amount) FROM fee_paid", con);
            datareader = cmd.ExecuteReader();
            while (datareader.Read())
            {
                total_paid_fees = Convert.ToInt32(datareader[0]);
            }
            con.Close();
            return total_paid_fees;
        }

        public int get_paid_total_salary()
        {
            int total_paid_salary = 0;
            con.Open();
            cmd = new Finisar.SQLite.SQLiteCommand("SELECT sum(amount) FROM salary_paid", con);
            datareader = cmd.ExecuteReader();
            while (datareader.Read())
            {
                total_paid_salary = Convert.ToInt32(datareader[0]);
            }
            con.Close();
            return total_paid_salary;
        }

        public int get_total_salary_of_all_employee()
        {
            int total_salary_of_employee = 0;
            con.Open();
            cmd = new Finisar.SQLite.SQLiteCommand("SELECT sum(salary) FROM employee", con);
            datareader = cmd.ExecuteReader();
            while (datareader.Read())
            {
                total_salary_of_employee = Convert.ToInt32(datareader[0]);
            }
            con.Close();
            return total_salary_of_employee * 12;
        }

        public int[] get_total_marks_and_obtain_marks_by_id_and_month(string id,string month)
        {
            int[] information = new int[2];
            con.Open();
            cmd = new Finisar.SQLite.SQLiteCommand("SELECT sum(total_marks),sum(obtain_marks) from marks where s_id='" + id + "' and e_date like'_____" + month + "%'", con);
            datareader = cmd.ExecuteReader();
            while (datareader.Read())
            {
                information[0] = Convert.ToInt32(datareader[0]);
                information[1] = Convert.ToInt32(datareader[1]);
            }
            con.Close();
            return information;
        }
        public void insert_into_final_fee_paid(string id)
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into final_fee_paid values('" + id + "');";
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //public string[,] get_all_data_of_all_student_fot_new_academic_year(int size)
        //{
        //    string[,] arr = new string[size, 11];
        //    con.Open();
        //    cmd.CommandText = "select * from student where class = '12-com' or class = '12-sci'";
        //    datareader = cmd.ExecuteReader();
        //    int i = 0;
        //    while (datareader.Read())
        //    {
        //        if (i < size)
        //        {
        //            arr[i, 0] = datareader["s_id"].ToString();
        //            arr[i, 1] = datareader["s_photo"].ToString(); ;
        //            arr[i, 2] = datareader["f_name"].ToString();
        //            arr[i, 3] = datareader["l_name"].ToString();
        //            arr[i, 4] = datareader["m_name"].ToString();
        //            arr[i, 5] = datareader["dob"].ToString();
        //            arr[i, 6] = datareader["gender"].ToString();
        //            arr[i, 7] = datareader["address"].ToString();
        //            arr[i, 8] = datareader["class"].ToString();
        //            arr[i, 9] = datareader["mobile_no_1"].ToString();
        //            arr[i, 10] = datareader["mobile_no_2"].ToString();
        //        }
        //        i++;
        //    }
        //    con.Close();
        //    return arr;
        //}

    }
    
}
