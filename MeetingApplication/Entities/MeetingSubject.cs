using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MeetingApplication.Entities
{
    public class MeetingSubject
    {
        public int Id { get; set; }
        public string MeetingSubjectName { get; set; }

        public ICollection<Meeting> Meetings { get; set; }

        public override string ToString()
        {
            return MeetingSubjectName; // Rapor konusu adı döndürür.
        }


    }
}
