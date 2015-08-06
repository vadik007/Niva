using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niva.Model
{
    public class UserMetadata : UserProfile
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string Passport { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return string.Format("Id: {0}, FirstName: {1}, SecondName: {2}, ThirdName: {3}, Passport: {4}, Adress: {5}, Phone: {6}", Id, FirstName, SecondName, ThirdName, Passport, Adress, Phone);
        }
    }
}
