using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_SDPT_CSharp_Tutorial_Series
{

    internal class Encapsulation
    {
        //Episode 18: Encapsulation | Q
        public static void EncapsulationLesson()
        {
            {
                User u = new User(1000, "Ryle", "Ryle", "Sabados");
                Console.WriteLine(u.fullName);
            }
        }

    }
    class User
    {
        /*
        //Declare Private Attributes/Fields
        private int userID;
        private string username, firstname, lastname;

        //Property (using get and set)
        public int UserID
        {
            get 
            { 
                return userID; 
            }
            set
            {
                if (value >=1000) userID = value; //you can also implement error checking such as this(17:38)
                else Console.WriteLine("UserID must not be below 1000");
            }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string firstName
        {
            get { return firstname; }
            set
            {
                firstname = value;
            }
        }
        public string Lastname
        {
            get { return lastname; }
            set
            {
                lastname = value;
            }
        }

        public string FullName
        {
            get { return firstName + " " +Lastname; }
        }
        
        public User(int userID, string username, string firstName, string lastname)
        {
            UserID = userID;
            Username = username;
            this.firstName = firstName;
            Lastname = lastname;
        }
        */
        //Automatic Property
        public int userID
        {
            get; //you cant remove get property in automatic property
            set; //Disadvantage: you can't set criteria for set
        }
        public string userName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string fullName
        {
            get { return firstName + " " + lastName; }
        }

        public User(int userID, string userName, string firstName, string lastName)
        {
            this.userID = userID;
            this.userName = userName;
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
