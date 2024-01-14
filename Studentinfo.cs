using System.Data;
using System.Data.SqlClient;

namespace hostelproject
{
    public partial class Studentinfo : Form
    {
        private function fn = new function();
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True");

        public Studentinfo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttoncustom1_Click(object sender, EventArgs e)
        {
            //    try
            //    {
            //        using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True"))
            //        {
            //            connection.Open();

            //            string name = stdname.Text;
            //            string email = stdemail.Text;
            //            string enrollno = stdenrollno.Text;
            //            string phone = stdphoneno.Text;
            //            string address = stdaddress.Text;

            //            int room_id;
            //            if (int.TryParse(txtroomid.Text, out  room_id))
            //            {
            //                DateTime dateOfBirth = DateTime.Parse(dtpDateOfBirth.Text);
            //                string fathername = txtfname.Text;

            //                // Check if the provided room_id exists in the Rooms table
            //                SqlCommand checkRoomCommand = new SqlCommand("SELECT COUNT(*) FROM Rooms WHERE room_id = @room_id AND room_status = 'available'", connection);
            //                checkRoomCommand.Parameters.AddWithValue("@room_id", room_id);
            //                int roomCount = (int)checkRoomCommand.ExecuteScalar();

            //                if (roomCount > 0)
            //                {
            //                    // Insert student data into the Student table
            //                    SqlCommand insertStudentCommand = new SqlCommand("InsertStudent", connection);
            //                    insertStudentCommand.CommandType = CommandType.StoredProcedure;

            //                    insertStudentCommand.Parameters.AddWithValue("@name", name);
            //                    insertStudentCommand.Parameters.AddWithValue("@email", email);
            //                    insertStudentCommand.Parameters.AddWithValue("@enrollno", enrollno);
            //                    insertStudentCommand.Parameters.AddWithValue("@phone", phone);
            //                    insertStudentCommand.Parameters.AddWithValue("@address", address);
            //                    insertStudentCommand.Parameters.AddWithValue("@room_id", room_id);
            //                    insertStudentCommand.Parameters.AddWithValue("@date_of_birth", dateOfBirth);
            //                    insertStudentCommand.Parameters.AddWithValue("@father_name", fathername);
            //                    insertStudentCommand.ExecuteNonQuery();

            //                    // Update the room status to 'occupied'
            //                    SqlCommand updateRoomCommand = new SqlCommand("UPDATE Rooms SET room_status = 'occupied' WHERE room_id = @room_id", connection);
            //                    updateRoomCommand.Parameters.AddWithValue("@room_id", room_id);
            //                    updateRoomCommand.ExecuteNonQuery();

            //                    MessageBox.Show("Student data inserted successfully and room assigned!");

            //                    // Rest of your code...
            //                }
            //                else
            //                {
            //                    MessageBox.Show("Invalid room ID or the room is already occupied. Please provide a valid and available room ID.");
            //                }
            //            }
            //            else
            //            {
            //                MessageBox.Show("Invalid room ID format. Please provide a valid numeric room ID.");
            //            }
            //        }
            //    }
            //    catch (FormatException)
            //    {
            //        MessageBox.Show("Invalid room ID format. Please provide a valid numeric room ID.");
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Error: " + ex.Message);
            //    }





            //try
            //{
            //    using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True"))
            //    {
            //        connection.Open();

            //        string name = stdname.Texts;
            //        string email = stdemail.Texts;
            //        string enrollno = stdenrollno.Texts;
            //        string phone = stdphoneno.Texts;
            //        string address = stdaddress.Texts;
            //        string roomNumber = txtroomid.Text;
            //        DateTime dateOfBirth = DateTime.Parse(dtpDateOfBirth.Text);
            //        string fathername = txtfname.Text;

            //        SqlCommand command = new SqlCommand("InsertStudent3", connection);
            //        command.CommandType = CommandType.StoredProcedure;

            //        command.Parameters.AddWithValue("@name", name);
            //        command.Parameters.AddWithValue("@email", email);
            //        command.Parameters.AddWithValue("@enrollno", enrollno);
            //        command.Parameters.AddWithValue("@phone", phone);
            //        command.Parameters.AddWithValue("@address", address);
            //        command.Parameters.AddWithValue("@room_number", roomNumber);
            //        command.Parameters.AddWithValue("@date_of_birth", dateOfBirth);
            //        command.Parameters.AddWithValue("@father_name", fathername);

            //        //SqlParameter roomIdParam = new SqlParameter("@room_id", SqlDbType.Int);
            //        //roomIdParam.Direction = ParameterDirection.Output;
            //        //command.Parameters.Add(roomIdParam);

            //        //connection.Open();
            //        command.ExecuteNonQuery();

            //        //int roomId = (int)roomIdParam.Value;
            //        connection.Close();
            //        // Show success message
            //      //  MessageBox.Show($"Student inserted successfully with Room ID: {roomId}");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}




            //fn.getdata();




            //try
            //{
            //    using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True"))
            //    {
            //        connection.Open();

            //        string name = stdname.Texts;
            //        string email = stdemail.Texts;
            //        string enrollno = stdenrollno.Texts;
            //        string phone = stdphoneno.Texts;
            //        string address = stdaddress.Texts;
            //        int roomid = int.Parse(txtroomid.Text);
            //        DateTime dateOfBirth = DateTime.Parse(dtpDateOfBirth.Text);
            //        string fathername = txtfname.Text;

            //        // Insert student data
            //        //string insertQuery = "INSERT INTO Student (name, email, enrollno, phone, address, room_id, date_of_birth, father_name) " +
            //                             //"VALUES (@name, @email, @enrollno, @phone, @address, @room_id, @date_of_birth, @father_name)";
            //        // SqlCommand insertCommand = new SqlCommand(insertQuery, connection);

            //        SqlCommand command = new SqlCommand("InsertStudent2", connection);
            //                command.CommandType = CommandType.StoredProcedure;
            //        command.Parameters.AddWithValue("@name", name);
            //        command.Parameters.AddWithValue("@email", email);
            //        command.Parameters.AddWithValue("@enrollno", enrollno);
            //        command.Parameters.AddWithValue("@phone", phone);
            //        command.Parameters.AddWithValue("@address", address);
            //        command.Parameters.AddWithValue("@room_id", roomid);
            //        command.Parameters.AddWithValue("@date_of_birth", dateOfBirth);
            //        command.Parameters.AddWithValue("@father_name", fathername);
            //        command.ExecuteNonQuery();
            //        //insertCommand.Parameters.AddWithValue("@name", name);
            //        //insertCommand.Parameters.AddWithValue("@email", email);
            //        //insertCommand.Parameters.AddWithValue("@enrollno", enrollno);
            //        //insertCommand.Parameters.AddWithValue("@phone", phone);
            //        //insertCommand.Parameters.AddWithValue("@address", address);
            //        //insertCommand.Parameters.AddWithValue("@room_number", roomid);
            //        //insertCommand.Parameters.AddWithValue("@date_of_birth", dateOfBirth);
            //        //insertCommand.Parameters.AddWithValue("@father_name", fathername);
            //        //insertCommand.ExecuteNonQuery();

            //        // Update room status to 'occupied'
            //        //string updateRoomQuery = "UPDATE Rooms SET occupancy_status = 'occupied' WHERE room_id = @room_id";
            //        //SqlCommand updateRoomCommand = new SqlCommand(updateRoomQuery, connection);
            //        //updateRoomCommand.Parameters.AddWithValue("@room_id",txtroomid.Text);
            //        //updateRoomCommand.ExecuteNonQuery();

            //        // Show success message
            //        // MessageBox.Show("Student inserted successfully.");

            //        connection.Close();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}



            //try
            //{
            //    using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True"))
            //    {
            //        connection.Open();

            //        string name = stdname.Texts;
            //        string email = stdemail.Texts;
            //        string enrollno = stdenrollno.Texts;
            //        string phone = stdphoneno.Texts;
            //        string address = stdaddress.Texts;
            //        int roomid = int.Parse(textBox1.Text);
            //        DateTime dateOfBirth = DateTime.Parse(dtpDateOfBirth.Text);
            //        string fathername = txtfname.Text;

            //        // Check if the room ID exists
            //        SqlCommand checkRoomCommand = new SqlCommand("SELECT COUNT(*) FROM Rooms WHERE room_id = @room_id", connection);
            //        checkRoomCommand.Parameters.AddWithValue("@room_id", roomid);
            //        int roomCount = (int)checkRoomCommand.ExecuteScalar();

            //        if (roomCount == 0)
            //        {
            //            MessageBox.Show("Room ID does not exist. Please enter a valid room ID.");
            //            return;
            //        }

            //        // Insert student data
            //        SqlCommand insertCommand = new SqlCommand("InsertStudent2", connection);
            //        insertCommand.CommandType = CommandType.StoredProcedure;
            //        insertCommand.Parameters.AddWithValue("@name", name);
            //        insertCommand.Parameters.AddWithValue("@email", email);
            //        insertCommand.Parameters.AddWithValue("@enrollno", enrollno);
            //        insertCommand.Parameters.AddWithValue("@phone", phone);
            //        insertCommand.Parameters.AddWithValue("@address", address);
            //        insertCommand.Parameters.AddWithValue("@room_id", roomid);
            //        insertCommand.Parameters.AddWithValue("@date_of_birth", dateOfBirth);
            //        insertCommand.Parameters.AddWithValue("@father_name", fathername);
            //        insertCommand.ExecuteNonQuery();

            //        // Show success message
            //        MessageBox.Show("Student inserted successfully.");

            //        connection.Close();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True"))
                {
                    connection.Open();

                    string name = stdname.Texts;
                    string email = stdemail.Texts;
                    string enrollno = stdenrollno.Texts;
                    string phone = stdphoneno.Texts;
                    string address = stdaddress.Texts;
                    int roomid = int.Parse(textBox1.Text);
                    DateTime dateOfBirth = DateTime.Parse(dtpDateOfBirth.Text);
                    string fathername = txtfname.Texts;

                    // Check if the room ID exists
                    SqlCommand checkRoomCommand = new SqlCommand("SELECT COUNT(*) FROM Rooms WHERE room_id = @room_id", connection);
                    checkRoomCommand.Parameters.AddWithValue("@room_id", roomid);
                    int roomCount = (int)checkRoomCommand.ExecuteScalar();

                    if (roomCount == 0)
                    {
                        MessageBox.Show("Room ID does not exist. Please enter a valid room ID.");
                        return;
                    }

                    // Insert student data
                    SqlCommand insertCommand = new SqlCommand("InsertStudent2", connection);
                    insertCommand.CommandType = CommandType.StoredProcedure;
                    insertCommand.Parameters.AddWithValue("@name", name);
                    insertCommand.Parameters.AddWithValue("@email", email);
                    insertCommand.Parameters.AddWithValue("@enrollno", enrollno);
                    insertCommand.Parameters.AddWithValue("@phone", phone);
                    insertCommand.Parameters.AddWithValue("@address", address);
                    insertCommand.Parameters.AddWithValue("@room_id", roomid);
                    insertCommand.Parameters.AddWithValue("@date_of_birth", dateOfBirth);
                    insertCommand.Parameters.AddWithValue("@father_name", fathername);
                    insertCommand.ExecuteNonQuery();

                    // Update room status to 'occupied'
                    SqlCommand updateRoomCommand = new SqlCommand("UPDATE Rooms SET occupancy_status = 'occupied' WHERE room_id = @room_id", connection);
                    updateRoomCommand.Parameters.AddWithValue("@room_id", roomid);
                    updateRoomCommand.ExecuteNonQuery();

                    // Show success message
                    MessageBox.Show("Student inserted successfully.");

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }



            populate();
        }

        public void populate()
        {
            con.Open();
            string query = "select * from Student";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void buttoncustom5_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void buttoncustom2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True"))
                {
                    connection.Open();

                    if (!int.TryParse(stdUsn.Texts, out int studentId))
                    {
                        MessageBox.Show("Invalid student ID. Please enter a valid integer value.");
                        return;
                    }

                    string email = stdemail.Texts;
                    string phone = stdphoneno.Texts;
                    string address = stdaddress.Texts;

                    // Check if the student ID exists
                    SqlCommand checkStudentCommand = new SqlCommand("SELECT COUNT(*) FROM Student WHERE student_id = @student_id", connection);
                    checkStudentCommand.Parameters.AddWithValue("@student_id", studentId);
                    int studentCount = (int)checkStudentCommand.ExecuteScalar();

                    if (studentCount == 0)
                    {
                        MessageBox.Show("Student ID does not exist. Please enter a valid student ID.");
                        return;
                    }

                    // Update student information
                    SqlCommand updateCommand = new SqlCommand("UPDATE Student SET email = @email, phone = @phone, address = @address WHERE student_id = @student_id", connection);
                    updateCommand.Parameters.AddWithValue("@student_id", studentId);
                    updateCommand.Parameters.AddWithValue("@email", email);
                    updateCommand.Parameters.AddWithValue("@phone", phone);
                    updateCommand.Parameters.AddWithValue("@address", address);
                    updateCommand.ExecuteNonQuery();

                    // Show success message
                    MessageBox.Show("Student information updated successfully.");

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


            populate();

        }

        private void buttoncustom3_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True"))
                {
                    connection.Open();

                    if (!int.TryParse(stdUsn.Texts, out int studentId))
                    {
                        MessageBox.Show("Invalid student ID. Please enter a valid integer value.");
                        return;
                    }

                    // Check if the student ID exists
                    SqlCommand checkStudentCommand = new SqlCommand("SELECT COUNT(*) FROM Student WHERE student_id = @student_id", connection);
                    checkStudentCommand.Parameters.AddWithValue("@student_id", studentId);
                    int studentCount = (int)checkStudentCommand.ExecuteScalar();

                    if (studentCount == 0)
                    {
                        MessageBox.Show("Student ID does not exist. Please enter a valid student ID.");
                        return;
                    }

                    // Delete student data
                    SqlCommand deleteCommand = new SqlCommand("DELETE FROM Student WHERE student_id = @student_id", connection);
                    deleteCommand.Parameters.AddWithValue("@student_id", studentId);
                    deleteCommand.ExecuteNonQuery();

                    // Show success message
                    MessageBox.Show("Student data deleted successfully.");

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            //fn.getdata();
            populate();
        }

        private void txtroomid_Click(object sender, EventArgs e)
        {

        }

        private void btnsent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttoncustom4_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId;
                if (!int.TryParse(stdUsn.Texts, out studentId))
                {
                    MessageBox.Show("Invalid student ID. Please enter a valid integer value.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True"))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM Student WHERE student_id = @student_id", connection);
                    command.Parameters.AddWithValue("@student_id", studentId);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("No student records found with the provided ID.");
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


