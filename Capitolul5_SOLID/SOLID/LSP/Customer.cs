namespace LSP
{
    class Customer : IDiscount, IDatabase
    {
        public string Name;
        public string type = "default";

        public virtual double getDiscount(double TotalSales)
        {
            return TotalSales * 0.1;
        }
        public virtual void Add()
        {
            //do nothing for now
        }
    }
}