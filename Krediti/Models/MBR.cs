using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Krediti.Models
{
    public class MBRData
    {
        [Key]
        public int MBRID { get; set; }
        public string MBR { get; set; }
        public string Naziv { get; set; }
        public string Naselje { get; set; }
        public string Ulica { get; set; }
    }
    public class MBRDataDbContext : DbContext
    {
        public MBRDataDbContext() : base("defaultConn")
        {
        }
        public DbSet<MBRData> MBRData { get; set; }


    }

}

