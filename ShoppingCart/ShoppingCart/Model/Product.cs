namespace ShoppingCart.Model
{
    public class Product
    {
        private int _id;
        private string _name;
        private double _price;
        private float _discountPer;
        public Product(int id , string name , double price ,float discountPer)
        {
            _id=id;
            _name=name;
            _price=price;
            _discountPer=discountPer;
        }
        public int Id { get { return _id; } }
        public string Name { get { return _name; } }
        public double Price { get { return _price; } }
        public float DiscountPer { get { return _discountPer; } }
        public double calculateItemFinalPrice()
        {
            return _price - _price*(_discountPer/100);
        }

    }
}
