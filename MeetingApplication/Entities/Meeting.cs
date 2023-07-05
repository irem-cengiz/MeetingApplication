using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingApplication.Entities
{
    public class Meeting
    {
        //Primary key
        public int Id { get; set; }   
        public string MeetingName { get; set; }

        //Foreign Key
        //her toplantının bir rapor olacağı için toplantı raporu toplantı için foreign key.

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? MeetingPlatformId { get; set; }

        public int? MeetingReportId { get; set; }

        public int? MeetingSubjectId { get; set; }

        public override string ToString()
        {
            return MeetingName; // Toplantı adını döndürür
        }
        public ICollection<MeetingPerson> MeetingPersons { get; set; }

        //navigation property
        //meeting içerisine diğer class türünde bir prop tanımladıgımız için bu navigation property oldu.


        public MeetingPlatform MeetingPlatform { get; set; }

        public MeetingSubject MeetingSubject { get; set; }

        public MeetingReport? MeetingReport { get; set; }

    }
}
