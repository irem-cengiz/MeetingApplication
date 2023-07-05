using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MeetingApplication.Entities
{
    public class Person
    {

        [Key]
        public string TcNo { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICollection<MeetingPerson> MeetingPersons{ get; set; }

        public override string ToString()
        {
            string tamad = $"{FirstName}  {LastName}";
            return tamad;
        }

    }
}
