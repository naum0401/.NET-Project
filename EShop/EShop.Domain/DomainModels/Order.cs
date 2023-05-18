using EShop.Domain.Identity;
using System;
using System.Collections.Generic;

namespace EShop.Domain.DomainModels 
{
    public class Order : BaseEntity
    {
        public EShopApplicationUser User { get; set; }
        public string UserId { get; set; }

        public virtual ICollection<ProductInOrder> Products{ get; set; }    
    }
}
