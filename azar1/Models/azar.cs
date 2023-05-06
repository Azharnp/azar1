using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace azar1.Models
{
    public class azar
    {
        public int grp_ID { get; set; }
        public string grp_name { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
        public string Requestor { get; set; }
        public DateTime Date { get; set; }
        public string To_ { get; set; }
        public string Job_description { get; set; }
        public string picture { get; set; }
    }
}