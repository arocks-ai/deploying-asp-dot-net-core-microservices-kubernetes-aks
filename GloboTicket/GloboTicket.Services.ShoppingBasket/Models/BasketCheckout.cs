﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GloboTicket.Services.ShoppingBasket.Models
{
    public class BasketCheckout
    {
        public Guid BasketId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        //payment information

    }
}
