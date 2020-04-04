namespace Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    public interface IOrderProduct
    {
        int order_id { get; set; }
        int product_id { get; set; }
        Nullable<decimal> price { get; set; }
        int quantity { get; set; }
    
    	[IgnoreDataMember]
        Order Order { get; set; }
        Product Product { get; set; }
    }
    
    [MetadataType(typeof(IOrderProduct))]
    public partial class OrderProduct : IOrderProduct
    {

    }        
}
