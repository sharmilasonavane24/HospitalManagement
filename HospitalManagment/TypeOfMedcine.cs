//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HospitalManagment
{
    using System;
    using System.Collections.Generic;
    
    public partial class TypeOfMedcine
    {
        public TypeOfMedcine()
        {
            this.MedcineNames = new HashSet<MedcineName>();
        }
    
        public int TypeOfMedicineId { get; set; }
        public string TypeName { get; set; }
    
        public virtual ICollection<MedcineName> MedcineNames { get; set; }
    }
}
