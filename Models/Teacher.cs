//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace student_Management.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Teacher
    {
        public int teacher_id { get; set; }
        public Nullable<int> user_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public Nullable<System.DateTime> date_of_birth { get; set; }
        public string address { get; set; }
        public string phone_number { get; set; }
        public Nullable<System.DateTime> hire_date { get; set; }
    
        public virtual User User { get; set; }
    }
}
