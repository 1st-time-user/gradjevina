using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Krediti.Models
{
    public class Aktivnosti
    {
        public int ID { get; set; }
        public int? MBRID { get; set; }
        [NotMapped]
        public SelectList MBRData { get; set; }
        public string MBR { get; set; }
        public DaNe? Pitanje1 { get; set; }
        
        public DaNe2? Pitanje2 { get; set; }
        public string Pitanje3 { get; set; }

        public DaNe? Pitanje4 { get; set; }
        public string Pitanje5 { get; set; }
        public DaNe? Pitanje6 { get; set; }
        public string Pitanje7 { get; set; }
    }
    public enum DaNe2
    {
        [Display(Name = "Projekat u celini")]
        Ceo,
        [Display(Name = "Deo većeg projekta")]
        Deo
    }
    public enum DaNe
    {

        //[Display(Name = "Da")]
        Da = 1,
        //[Display(Name = "Ne, ali nameravamo ")]
        Ne = 2
     }

    public class aktivnostidbContext : DbContext
    {
        public aktivnostidbContext() : base("defaultConn")
        {

        }
        public DbSet<Aktivnosti> Aktivnosti { get; set; }
        public DbSet<MBRData> MBRData { get; set; }
        public DbSet<Show> Show { get; set; }
    }


}