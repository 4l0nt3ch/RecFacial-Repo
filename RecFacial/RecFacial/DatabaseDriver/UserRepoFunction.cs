using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using Xamarin.Forms;

namespace RecFacial.DatabaseDriver
{
    class UserRepoFunction
    {
        private SQLiteConnection conn_DB;

        private static UserRepoFunction repoUser;
        public static UserRepoFunction RepoUser
        {
            get
            {

                if (repoUser == null)
                {
                    throw new Exception("Debe de llamar al driver");
                }
                return repoUser;
            }
        }

        public static void Driver(String filename)
        {
            if (filename == null)
            {
                throw new ArgumentNullException();
            }

            if (RepoUser != null)
            {
                RepoUser.conn_DB.Close();
            }

            repoUser = new UserRepoFunction(filename);

        }

        private UserRepoFunction(String dbPath)
        {
            conn_DB = new SQLiteConnection(dbPath);
            conn_DB.CreateTable<UserPersonalInformation>();
        }
        public String Estatus;
        public int newEmployee(String firstName, String lastName, int age, String address, DateTime dob,
            String correo, String contraseña, String enterprise_name, String role, DateTime date_origin,
            String department, String enterpise_branch, String userName, String userType, Image userImage)
        {
            int result = 0;
            try
            {
                result = conn_DB.Insert(new UserPersonalInformation()
                {
                    firstName = firstName,
                    lastName = lastName,
                    age = age,
                    address = address,
                    dob = dob,
                    correo = correo,
                    contraseña = contraseña,
                    enterprise_name = enterprise_name,
                    role = role,
                    date_origin = date_origin,
                    department = department,
                    enterprise_branch = enterpise_branch,
                    userName = userName,
                    userType = userType,
                    userImage = userImage
                });
                Estatus = string.Format("Registros completados: {0}" + result);
            }
            catch (Exception e)
            {
                Estatus = e.Message;
            }
            return result;
        }

        public IEnumerable<UserPersonalInformation> UpdateUserList()
        {
            try
            {
                return conn_DB.Table<UserPersonalInformation>();
            }
            catch (Exception e)
            {
                Estatus = e.Message;
            }
            return Enumerable.Empty<UserPersonalInformation>();
        }
    }
}
