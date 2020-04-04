namespace Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    public interface IOrder
    {    
        int order_id { get; set; }
        string description { get; set; }
        int company_id { get; set; }

        [IgnoreDataMember]
        Company Company { get; set; }
        
        ICollection<OrderProduct> OrderProducts { get; set; }
    }
    
    [MetadataType(typeof(IOrder))]
    public partial class Order : IOrder
    {

    }      
}
