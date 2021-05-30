using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;

namespace RecFacial.DatabaseDriver
{
        [Table("UserDetails")]
        public class UserPersonalInformation
        {
            [PrimaryKey, AutoIncrement]
            public int Id { get; set; }

            [MaxLength(50)]
            public String firstName { get; set; }

            [MaxLength(50)]
            public String lastName { get; set; }

            public int age { get; set; }

            [MaxLength(50)]
            public String address { get; set; }

            public DateTime dob { get; set; }

            [MaxLength(50), Unique]
            public String correo { get; set; }

            [MaxLength(50), Unique]
            public String contraseña { get; set; }

            [MaxLength(50)]
            public String enterprise_name { get; set; }

            [MaxLength(50)]
            public String role { get; set; }

            public DateTime date_origin { get; set; }

            [MaxLength(50)]
            public String department { get; set; }

            [MaxLength(50)]
            public String enterprise_branch { get; set; }

            [MaxLength(50), Unique]
            public String userName { get; set; }

            [MaxLength(50)]
            public String userType { get; set; }

            public Image userImage { get; set; }
        }
}
