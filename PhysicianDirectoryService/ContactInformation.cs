//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhysicianDirectoryService
{
    using System;
    using System.Collections.Generic;
    
    public partial class ContactInformation
    {
        public int Id { get; set; }
        public string HomePhone { get; set; }
        public string HomeAddress { get; set; }
        public string OfficeAddress { get; set; }
        public string OfficePhone { get; set; }
        public string EmailAddress { get; set; }
        public string CellphoneNumber { get; set; }
    
        public virtual Physician Physician { get; set; }
    }
}
