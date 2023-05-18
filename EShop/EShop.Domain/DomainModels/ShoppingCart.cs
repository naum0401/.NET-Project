
using EShop.Domain.Identity;
using System;
using System.Collections;
using System.Collections.Generic;

namespace EShop.Domain.DomainModels
{
    public class ShoppingCart : BaseEntity
    {
        public string OwnerId { get; set; }
        public virtual ICollection<ProductInShoppingCart> ProductInShoppingCarts { get; set; }

        public  virtual EShopApplicationUser Owner { get; set; }
    }
}
