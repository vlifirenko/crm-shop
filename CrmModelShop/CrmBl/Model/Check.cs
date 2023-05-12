﻿namespace CrmBl.Model
{
    class Check
    {
        public int CheckId { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public int SellerId { get; set; }
        public virtual Seller Seller { get; set; }

        public DateTime Created { get; set; }

        public virtual ICollection<Sell> Sells { get; set; }

        public override string ToString() => $"#{CheckId} from {Created.ToString("dd.MM.yy hh:mm:ss")}";
    }
}