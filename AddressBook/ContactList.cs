using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
  public  class ContactList
    {


       public string firstName;
       public string lastName;
        public string[] address = new string[2];
        public string state;
        public int zipCode;
        public long phoneNumber;
        public string email;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactList"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="address">The address.</param>
        /// <param name="state">The state.</param>
        /// <param name="zipCode">The zip code.</param>
        /// <param name="phoneNumber">The phone number.</param>
        /// <param name="email">The email.</param>
        /// here created the parameter constructor of class ContactList and passing the value of person 
         public ContactList(string firstName, string lastName, string[] address, string state, int zipCode, long phoneNumber, string email)
        {
           
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.state = state;
            this.zipCode = zipCode;
            this.phoneNumber = phoneNumber;
            this.email = email;

        }








    }
}
