namespace MarketStore.Cards
{
    using System;
    using System.Text;

    public abstract class ClubCard
    {
        private decimal turnover;
        private decimal purchaseValue;
        private string fullName;

        public ClubCard(string fullname, decimal turnover, decimal purchaseValue)
        {
            this.Fullname = fullname;
            this.Turnover = turnover;
            this.PurchaseValue = purchaseValue;
        }

        public string Fullname
        {
            get { return fullName; }
            set
            {
                if (value == string.Empty || value == null || value == " ")
                {
                    throw new Exception("Name must be Valid.");
                }
                fullName = value;
            }
        }

        public decimal Turnover
        {
            get { return this.turnover; }
            private set
            {
                if (value < 0)
                {
                    throw new Exception("Turnover must be a positive number!");
                }
                this.turnover = value;

            }
        }

        public decimal PurchaseValue
        {
            get { return this.purchaseValue; }
            private set
            {
                if (value < 0)
                {
                    throw new Exception("Purchase value must be a positive number!");
                }
                this.purchaseValue = value;
            }
        }

        public virtual decimal CalculateDiscountRate()
        { return 0.0M; }

        public virtual decimal CalculateDiscount()
        { return 0.0M; }

        public virtual decimal TotalPrice()
        { return 0.0M; }

        //Overriden toString() to show the expected outputs.
        public override string ToString()
        {
            var sb = new StringBuilder();
            var value = PurchaseValue;
            var discountRate = CalculateDiscountRate();
            var discount = CalculateDiscount();
            var total = TotalPrice();

            sb.AppendLine($@"Purchase value: ${value:F2}");
            sb.AppendLine();
            sb.AppendLine($@"Discount rate: {discountRate:F1}%");
            sb.AppendLine();
            sb.AppendLine($@"Discount: ${discount:F2}");
            sb.AppendLine();
            sb.AppendLine($@"Total: ${total:F2}");
            sb.AppendLine();

            return sb.ToString();
        }
    }

}
