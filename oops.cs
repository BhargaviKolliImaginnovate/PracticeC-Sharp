using System;
using System.Reflection.Metadata;

namespace oops{
    class oops{
        public string user;
        private string password;
        static int age;
        private int mobile;

//Constructor
        public oops(){
            user="starlink";
            password="star";
            age++;
        }

//overloading
        public oops(string user = "jaddu", int mobile = 943245789 ){

            this.user=user; 
            this.mobile=mobile;
            this.password="secret";

        }

        public void getDetails(){
            Console.WriteLine("My name is {0}, this is my age {1} ",user, age);
        }

    }
}
