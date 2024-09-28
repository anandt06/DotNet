namespace CSharp.Design_Patterns
{
    internal class VisitorDesignPattern
    {
        static void Main(string[] args)
        {
            IProduct book = new Book { Price = 30.0 };

            IProduct electronic = new Electronic { Price = 200.0 };

            IVisitor visitor = new TaxVisitor();

            book.Accept(visitor); // Output: Tax for the book: 3

            electronic.Accept(visitor); // Output: Tax for the electronic: 40
        }
    }

    public interface IProduct
    {
        void Accept(IVisitor visitor);
    }

    public class Book : IProduct
    {
        public double Price { get; set; }
        public double Weight { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Electronic : IProduct
    {
        public double Price { get; set; }
        public double WarrantyPeriod { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public interface IVisitor
    {
        void Visit(Book book);

        void Visit(Electronic electronic);

    }

    public class TaxVisitor : IVisitor
    {
        public void Visit(Book book)
        {
            double tax = book.Price * 0.1;
            Console.WriteLine($"Tax for the book: {tax}");
        }

        public void Visit(Electronic electronic)
        {
            double tax = electronic.Price * 0.2;
            Console.WriteLine($"Tax for the electronic: {tax}");
        }
    }
}
