using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingApplication.Entities
{
    public class MeetingPlatform
    {
        public int Id { get; set; }
        public string MeetingPlatformName { get; set; }

        //navigation property

        public ICollection<Meeting> Meetings { get; set; }

        public override string ToString()
        {
            return MeetingPlatformName;
        }
    }
}
