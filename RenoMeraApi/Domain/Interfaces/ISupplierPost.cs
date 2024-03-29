﻿namespace RenoMeraApi.Domain.Interfaces
{
    public interface ISupplierPost
    {
        public int SupplierPostId { get; set; }
        public string title { get; set; }
        public string UserId { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string City { get; set; }
        public double Price { get; set; }
        public string Phone { get; set; }
    }
}
