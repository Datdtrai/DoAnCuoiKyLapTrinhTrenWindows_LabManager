//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LabManager.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SignIn
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string IDMember { get; set; }
    
        public virtual Member Member { get; set; }
    }
}
