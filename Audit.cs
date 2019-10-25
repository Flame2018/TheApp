using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TheApp.Data
{
    public class Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public Headcount UHeadcount { get; set; }

        public string SLT { get; set; }

        [Display(Name = "Finance Dept")]
        public int FDepartment { get; set; }
        [ForeignKey("FDepartment")]
        public Headcount FDHeadcount { get; set; }

        [Display(Name = "Finance Entity")]
        public int FEntity { get; set; }
        [ForeignKey("FEntity")]
        public Headcount FEHeadcount { get; set; }

        [Display(Name = "Approved Positions")]
        public int Approved { get; set; }
        [ForeignKey("Approved")]
        public Headcount Appr { get; set; }

        [Display(Name = "Employee Count")]
        public int ECount { get; set; }

        [Display(Name = "Contractor Count")]
        public int CCount { get; set; }

        [Display(Name = "Open Position Count")]
        public int OCount { get; set; }

        [Display(Name ="Time Stamp")]
        public DateTime DTStamp { get; set; }

        [Display(Name ="Update or Submit")]
        public string UorS { get; set; }
    }
}
