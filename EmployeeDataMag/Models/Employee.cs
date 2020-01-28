using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace EmployeeDataMag.Models
{
    public class Employee
    {
       
        public int id { set; get; }
        [Required]
        public String name { set; get; }
        [Required]
        public string Email{ set; get; }
        public branch branch { set; get; }

    }
    public enum branch
  { 
        it,cse,Mech,eee
    
    } 

}
