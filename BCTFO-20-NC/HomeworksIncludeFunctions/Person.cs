﻿namespace Homeworks
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private byte age;
        public byte Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
            }
        }

        private string pin;
        public string Pin
        {
            get { return pin; }
            set
            {
                if (value.Length == 11)
                {
                    pin = value;
                }
            }
        }

        private string phoneNumber;
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (value.Length == 9)
                {
                    phoneNumber = value;
                }
            }
        }


        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                if (value.Contains('@') && value.Contains('.'))
                {
                    email = value;
                }
            }
        }

    }
}
