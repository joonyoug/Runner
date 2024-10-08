﻿using WebApplication1.Data.Enum;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class EditRaceViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string? Url { get; set; }
        public DateTime? StartTime { get; set; }
        public int? EntryFee { get; set; }
        public string? Website { get; set; }
        public string? Twitter { get; set; }
        public string? Facebook { get; set; }
        public string? Contact { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }

        public IFormFile Image { get; set; }
        public RaceCategory RaceCategory { get; set; }



    }
}
