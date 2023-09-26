﻿namespace BethanysPieShopHRM.Shared.Model
{
    public class Marker
    {
        public string Description { get; set; } = String.Empty;

        public double X { get; set; }

        public double Y { get; set; }

        public bool? ShowPopup { get; set; }
    }
}
