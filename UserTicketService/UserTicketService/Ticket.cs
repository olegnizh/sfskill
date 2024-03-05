﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UserTicketService
{
    public class Ticket
    {
        public int Id { get; }
        public string Description { get; }
        public int Price { get; }

        public Ticket(int id, string description, int price)
        {
            this.Id = id;
            this.Description = description;
            this.Price = price;
        }


    }





}
