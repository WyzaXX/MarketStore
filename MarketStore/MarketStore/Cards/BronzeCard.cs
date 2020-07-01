namespace MarketStore.Cards
{
    public class BronzeCard : ClubCard
    {
        private decimal discountRate;

        public BronzeCard(string fullname, decimal turnover, decimal purchaseValue)
        : base(fullname, turnover, purchaseValue)
        {

        }

        public override decimal CalculateDiscountRate()
        {
            if (this.Turnover >= 100 && this.Turnover <= 300)
            {
                discountRate = 1.0M;
            }
            else if (this.Turnover > 300)
            {
                discountRate = 3.5M;
            }
            return discountRate;
        }

        public override decimal CalculateDiscount()
        {
            if (discountRate == 0)
            {
                return 0.0M;
            }
            else
            {
                var result = (PurchaseValue * discountRate) / 100;
                return result;
            }
        }

        public override decimal TotalPrice()
        {
            var discount = CalculateDiscount();
            var result = PurchaseValue - discount;
            return result;
        }
    }
}
