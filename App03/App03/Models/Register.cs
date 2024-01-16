using System.ComponentModel.DataAnnotations;

namespace App03.Models
{
    public class Register
    {
        [Key]
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }


    }

    public class LogInModel
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public bool result { get; set; }

        public string message { get; set; }

    }
}
