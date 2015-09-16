using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MCS.Models
{
    public class CompleteInfoModel
    {
        public string ClaimDate { get; set; }
        public string Date { get; set; }
        public string RepairedBy { get; set; }
        public string ActionNotes { get; set; }

        public CompleteInfoModel() { }
    }
}