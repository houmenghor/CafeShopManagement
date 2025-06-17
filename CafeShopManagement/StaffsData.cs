using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CafeShopManagement
{
    internal class StaffData
    {
        SqlConnection connect = Connection.GetConnection();
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime HiredDate { get; set; }
        public string ProfileImage { get; set; }
        public bool Status { get; set; }

      
        

       


        public List<StaffData> GetStaffList()
        {
            List<StaffData> stafflist = new List<StaffData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM staffs WHERE status ='1' ";


                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            StaffData staffData = new StaffData();
                            staffData.Id = (int)reader["id"];
                            staffData.Name = reader["name"].ToString();
                            staffData.Gender = reader["gender"].ToString();
                            staffData.Position = reader["position"].ToString();
                            staffData.Email = reader["email"].ToString();
                            staffData.Phone = reader["phone"].ToString();
                            staffData.HiredDate = Convert.ToDateTime(reader["hired_date"]);
                            staffData.ProfileImage = reader["profile_image"].ToString();
                            staffData.Status = Convert.ToBoolean(reader["status"]);

                            stafflist.Add(staffData);

                        }

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Connection Failed: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return stafflist;
        }


    }
}
