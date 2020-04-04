namespace Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    public interface IProduct
    {
        int product_id { get; set; }
        string name { get; set; }
        Nullable<decimal> price { get; set; }

        [IgnoreDataMember]
        ICollection<OrderProduct> OrderProducts { get; set; }

    }
    
    [MetadataType(typeof(IProduct))]
    public partial class Product : IProduct
    {

    }      
}
