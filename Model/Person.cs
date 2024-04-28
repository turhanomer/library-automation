using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_automation.Model
{
    public class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public DateTime createdTime { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string authorization { get; set; }


        public Person(int id, string name, string surname, DateTime createdTime, string username, string password, string authoriztaion)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.createdTime = createdTime; 
            this.username = username;
            this.password = password;
            this.authorization = authoriztaion;
        } 

        public void setId(int id)
        { 
            this.id = id;
        }
        public int getId()
        {
            return this.id;
        }
        public void setName(string name)
        {
            this.name = this.name;
        }
        public string getName()
        {
            return this.name;
        }
        public void setSurname(string name)
        {
            this.surname = this.surname;
        }
        public string getSurname()
        {
            return this.surname;
        }
        public void setTime(DateTime createdTime)
        {
            this.createdTime = createdTime;
        }
        public DateTime getTime()
        {
            return this.createdTime;
        }
        public void setUsername(string username)
        {
            this.username = username;
        }
        public string getUsername()
        {
            return this.username;
        }
        public void setPassword(string password)
        {
            this.password = this.password;
        }
        public string getPassword()
        {
            return this.password;
        }
        public void setAuthorization(string authorization)
        {
            this.authorization = authorization;
        }
        public string getAuthorization()
        {
            return this.authorization;
        }
        public override string ToString()
        {
            return "Name - Surname: " + this.name + " " + this.surname;
        }
    }
}
