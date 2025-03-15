using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephone
{
    public class Contact
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string MobileNumber { get; private set; }
        public string Email { get; private set; }
        public string Category { get; private set; }

        public Contact(string firstName, string lastName, string mobileNumber, string email, string category)
        {
            FirstName = firstName;
            LastName = lastName;
            MobileNumber = mobileNumber;
            Email = email;
            Category = category;
        }

        public string ToCsv()
        {
            return $"{FirstName},{LastName},{MobileNumber},{Email},{Category}";
        }

        public static Contact FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            return new Contact(values[0], values[1], values[2], values[3], values[4]);
        }
    }


}
