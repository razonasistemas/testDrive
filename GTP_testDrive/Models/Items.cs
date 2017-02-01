using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GTP_testDrive.Models
{
    public class Items
    {
        public DateTime cDate;
        public string title;
        public string description;

        public Items(DateTime cDate, string title, string description)
        {
            this.cDate = cDate;
            this.title = title;
            this.description = description;
        }
    }
}