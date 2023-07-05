using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingApplication.Entities
{
    public class MeetingPerson
    {
        [ForeignKey("Person")]
        public string TcNo { get; set; }
        [ForeignKey("Meeting")]
        public int Id { get; set; }
        public Person Person { get; set; }
        public Meeting Meeting { get; set; }
        
    }
}
