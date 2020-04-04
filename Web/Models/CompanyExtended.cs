namespace Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    public interface ICompany
    {
        int company_id { get; set; }
        string name { get; set; }
    
        ICollection<Order> Orders { get; set; }
    }
    
    [MetadataType(typeof(ICompany))]
    public partial class Company : ICompany
    {

    }    
}
