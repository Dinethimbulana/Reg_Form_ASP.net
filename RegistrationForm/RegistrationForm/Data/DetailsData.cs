using ASharp.BasicLayered.Data;
using RegistrationForm.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RegistrationForm.Data
{
    public class DetailsData
    {
        public void Insert(detailsDomain domain)
        {

            var command = new SqlCommand("InsertData"); //name of sp
            CommonData.ExecuteNonQuery(Constructcommand(command, domain));
        }

        public SqlCommand Constructcommand(SqlCommand command, detailsDomain domain)
        {
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Fname", domain.FName);
            command.Parameters.AddWithValue("@Lname", domain.LName);
            command.Parameters.AddWithValue("@Email", domain.Email);
            command.Parameters.AddWithValue("@Gender", domain.Gender);
            command.Parameters.AddWithValue("@Address", domain.Address);
            command.Parameters.AddWithValue("@PhoneNo", domain.PNo);
            command.Parameters.AddWithValue("@Password", domain.Password);

            return command;

        }
    }
}