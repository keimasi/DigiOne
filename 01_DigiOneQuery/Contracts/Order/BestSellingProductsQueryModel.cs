﻿namespace _01_DigiOneQuery.Contracts.Order
{
    public class BestSellingProductsQueryModel
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public string PriceAfterDiscount { get; set; }
        public int DiscountRate { get; set; }
        public bool HasDiscount { get; set; }
        public string Slug { get; set; }
    }
}