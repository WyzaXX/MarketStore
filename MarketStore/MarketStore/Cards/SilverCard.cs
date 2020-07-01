namespace MarketStore.Cards
{
    public class SilverCard : ClubCard
    {
        private decimal discountRate = 2;

        public SilverCard(string fullname, decimal turnover, decimal purchaseValue)
        : base(fullname, turnover, purchaseValue)
        {

        }

        public override decimal CalculateDiscountRate()
        {
            if (this.Turnover > 300)
            {
                discountRate = 3.5M;
            }
            return discountRate;
        }

        public override decimal CalculateDiscount()
        {
            var result = (PurchaseValue * discountRate) / 100;
            return result;
        }

        public override decimal TotalPrice()
        {
            var discount = CalculateDiscount();
            var result = PurchaseValue - discount;
            return result;
        }
    }
}
