//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyFitnessBuddy
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        public Users()
        {
            this.FoodEntry = new HashSet<FoodEntry>();
        }
    
        public System.Guid ID { get; set; }
        public string strName { get; set; }
        public string strPassword { get; set; }
    
        public virtual ICollection<FoodEntry> FoodEntry { get; set; }
    }
}
