using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace RecFacial.DatabaseDriver.Models
{
    public class EmpModel
    {
        [PrimaryKey,AutoIncrement]
        public int UserID { get; set; }

        [MaxLength(50)]
        public String FirstName { get; set; }

        [MaxLength(50)]
        public String LastName { get; set; }

        [MaxLength(3)]
        public int Age { get; set; }

        [MaxLength(100)]
        public String Address { get; set; }

        public String DOB { get; set; }

        [MaxLength(50)]
        public String Email { get; set; }

        [MaxLength(50)]
        public String Password { get; set; }

        [MaxLength(50)]
        public String EntName { get; set; }

        [MaxLength(50)]
        public String Role { get; set; }

        [MaxLength(50)]
        public String DateOrigin { get; set; }

        [MaxLength(50)]
        public String Department { get; set; }

        [MaxLength(50)]
        public String Branch { get; set; }

        [MaxLength(50)]
        public String UserName { get; set; }

        [MaxLength(50)]
        public String UserType { get; set; }

    }
}
