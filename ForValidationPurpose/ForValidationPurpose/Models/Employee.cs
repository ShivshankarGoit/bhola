using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ForValidationPurpose.Models
{
    public class Employee
    {

        public Guid EmployeeId
        {
            get;
            set;
        }
        [Required]
        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public DateTime DateOfBirth
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }
        public string Mobile
        {
            get;
            set;
        }

        public string PostalCode
        {
            get;
            set;
        }
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "*Email is not valid.")]
        public string EmailId
        {
            get;
            set;
        }

        public string UserName
        {
            get;
            set;
        }
        public string Password
        {
            get;
            set;
        }
        public string ConfirmPassword
        {
            get;
            set;
        }
        public string URL
        {
            get;
            set;
        }
    }
}