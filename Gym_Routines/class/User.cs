using System;
using System.Collections.Generic;
using System.Text;

namespace Gym_Routines
{
    class User
    {
        string fullName;
        string user;
        string pwd;
        string email;

        public User(string fullName, string user, string pwd, string email)
        {
            this.fullName = fullName;
            this.user = user;
            this.pwd = pwd;
            this.email = email;    
        }
        public User() : this("","","","") { }

        public void SetFullName(string fullName)
        {
            this.fullName = fullName;
        }
        public string GetFullName()
        {
            return fullName;
        }
        public void SetUser(string user)
        {
            this.user = user;
        }
        public string GetUser()
        {
            return user;
        }
        public void SetPwd(string pwd)
        {
            this.pwd = pwd;
        }
        public string GetPwd()
        {
            return pwd;
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }
        public string GetEmail()
        {
            return email;
        }
    }
}
