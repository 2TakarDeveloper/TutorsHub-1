﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.UserModels
{
    public enum Role { Admin=1, Executive=2, Tutor =3 ,Student=4}
    public enum Status { Active=1, Pending=2, Blocked=3 }

    public  class User
    {
        public Role Role { get; set; }
        public Status Status { get; set; }

        [RegularExpression("^[a-zA-Z0-9._-]*$", ErrorMessage = "User Name can contain alpha numeric characters, period, dash or underscore only")]
        [MinLength(2)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(18, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
        [Display(Name = "Password")]
        [RegularExpression("(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[\\W]).{8,}", ErrorMessage = "Password must contain one uppercase letter, one lowercase letter, one digit and one special character.")]
        public string Password { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Key]
        public string Email { get; set; }


        public string ProfilePictureUrl { get; set; }

    
        public string Gender { get; set; }

      
        public DateTime? DateOfBirth { get; set; }

        public string Mobilenumber { get; set; }
        public string Address { get; set; }

     
        public DateTime UserSince { get; set; }


        //public DateTime? LastLogin { get; set; }
        public DateTime LastLogin { get; set; }

        public virtual User Copy(User user)
        {
            throw new NotImplementedException();
        }

        public string Type { get; set; }

        [NotMapped]
        public string LastActive { get; set; }// include day/month
        [NotMapped]
        public string MemberSince { get; set; }// include min/hrs/day
       


        public void TimeSpanUpdate()
        {
            
            TimeSpan activitySpan = DateTime.Now.Subtract(LastLogin);
            TimeSpan memberSpan = DateTime.Now.Subtract(UserSince);

            
            MemberSince = $"{memberSpan:%d} days";
            LastActive = $"{activitySpan:%h} hours {activitySpan:%m} minutes";


        }

    }
}
