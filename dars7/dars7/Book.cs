namespace dars7
{
    public class Book
    {
        public string name { get; set; }
        public decimal price { get; set; }
        public override string ToString()
        {
            return $"{name.ToString()}   {price.ToString()}";
        }
    }
}
