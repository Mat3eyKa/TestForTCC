using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.ServiceModel;
using UserForms.Models;
using UserForms.SqlCommnads;
using UserForms.SqlStrings;

namespace UserForms
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class ServiceChat : IServiceChat
    {
        public List<Person> GetPersons() =>
            Select(Commands.selectAllCommand);
        public List<Person> GeteSerchedPersons(string name, string surname, string patronymic, string dateOfBirth,
            string phone, string city, string street, string house, string room) =>
            Select(Commands.SelectByParamsCommand(name, surname, patronymic, dateOfBirth, phone, city, street, house, room));

        private List<Person> Select(string sql)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConnectionStrings.connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(dt);
            }
            List<Person> list = new List<Person>();

            for (int i = 0; i < dt.Rows.Count; i++)
                list.Add(new Person
                {
                    Id = Convert.ToInt32(dt.Rows[i]["Id"]),
                    Name = dt.Rows[i]["Name"].ToString().Trim(),
                    Surname = dt.Rows[i]["Surname"].ToString().Trim(),
                    Patronymic = dt.Rows[i]["Patronymic"].ToString().Trim(),
                    DateOfBirth = (dt.Rows[i]["DateOfBirth"]).ToString().Trim(),
                    Phone = Convert.ToInt32(dt.Rows[i]["Phone"]),
                    City = dt.Rows[i]["City"].ToString().Trim(),
                    Street = dt.Rows[i]["Street"].ToString().Trim(),
                    House = Convert.ToInt32(dt.Rows[i]["House"]),
                    Room = Convert.ToInt32(dt.Rows[i]["Room"])
                });
            return list;
        }

        public void Create(string name, string surname, string patronymic, string dateOfBirth,
            string phone, string city, string street, string house, string room)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStrings.connectionString))
            {
                SqlCommand cmd = new SqlCommand(Commands.CreatePersonCommand(name, surname, patronymic, dateOfBirth, phone, city, street, house, room), connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Update(string id, string name, string surname, string patronymic, string dateOfBirth,
            string phone, string city, string street, string house, string room)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStrings.connectionString))
            {
                var dsds = Commands.UpdatePersonCommand(id, name, surname, patronymic, dateOfBirth, phone, city, street, house, room);
                SqlCommand cmd = new SqlCommand(Commands.UpdatePersonCommand(id, name, surname, patronymic, dateOfBirth, phone, city, street, house, room), connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Detele(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStrings.connectionString))
            {
                SqlCommand cmd = new SqlCommand(Commands.DeletePersonCommand(id), connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
