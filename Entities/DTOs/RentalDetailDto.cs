﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDto:IDto
    {
        [NotMapped]
        public int RentId { get; set; }
        public int CarId { get; set; }
        public string Description { get; set; }
        public string CustomerName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }

    }
}
