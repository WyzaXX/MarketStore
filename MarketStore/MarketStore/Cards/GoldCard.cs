namespace MarketStore.Cards
{
    public class GoldCard : ClubCard
    {
        private decimal discountRate = 2;

        public GoldCard(string fullname, decimal turnover, decimal purchaseValue)
        : base(fullname, turnover, purchaseValue)
        {

        }

        public override decimal CalculateDiscountRate()
        {
            var rate = (this.Turnover / 100);
            if (rate >= 10)
            {
                discountRate = 10;
            }
            if (rate > 0 && rate < 10)
            {
                discountRate += rate;
                if (discountRate > 10)
                {
                    discountRate = 10;
                }
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
