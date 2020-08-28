using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Krediti.Models
{
    public class Show
    {
        public int ID { get; set; }
        public int MBRID { get; set; }
        [NotMapped]
        public string MBR { get; set; }
        //[NotMapped]
        //public SelectList MBRDataList { get; set; }
    }

    public class ShowdbContext : DbContext
    {
        public ShowdbContext() : base("defaultConn")
        {

        }
        public DbSet<Show> Show { get; set; }
        //public DbSet<MBRData> MBRData { get; set; }
    }
}