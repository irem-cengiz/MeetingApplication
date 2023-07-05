using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MeetingApplication.Entities
{
    public class MeetingReport
    {
        //primary key  
        public int Id { get; set; }

        public string Content { get; set; }
        
        public override string ToString()
        {
            return Content; // Rapor içeriğini döndürür
        }

        //navigation property
        public Meeting Meeting { get; set; }

    }
}
