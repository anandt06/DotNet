namespace CSharp.Design_Patterns
{
    //The Abstract Factory Design Pattern is a creational pattern that provides an interface for creating families of related or dependent objects without
    //specifying their concrete classes. It is particularly useful in scenarios where you need to create objects that are related by a common theme
    //but differ in their implementation.

    //The Abstract Factory Pattern allows you to create a super-factory that can create other factories. This super-factory is also known as a factory of factories.
    //The main advantage of using the Abstract Factory Pattern is that it isolates the client code from the concrete classes of objects that are created,
    //leading to more decoupled and maintainable code.
    internal class AbstractFactoryDesignPattern
    {
        // Step 5: Use the Abstract Factory in Client Code
        static void Main(string[] args)
        {
            #region Use the Abstract Factory in Client Code
            // Create a Lenovo factory
            IDeviceFactory lenovoFactory = new LenovoFactory();
            IDevice lenovoMobile = lenovoFactory.CreateMobile();
            IDevice lenovoLaptop = lenovoFactory.CreateLaptop();
            IDevice lenovoDesktop = lenovoFactory.CreateDesktop();

            lenovoMobile.GetDetails();
            lenovoLaptop.GetDetails();
            lenovoDesktop.GetDetails();

            // Create an HP factory
            IDeviceFactory hpFactory = new HPFactory();
            IDevice hpMobile = hpFactory.CreateMobile();
            IDevice hpLaptop = hpFactory.CreateLaptop();
            IDevice hpDesktop = hpFactory.CreateDesktop();

            hpMobile.GetDetails();
            hpLaptop.GetDetails();
            hpDesktop.GetDetails();

            // Create an Apple factory
            IDeviceFactory appleFactory = new AppleFactory();
            IDevice appleMobile = appleFactory.CreateMobile();
            IDevice appleLaptop = appleFactory.CreateLaptop();
            IDevice appleDesktop = appleFactory.CreateDesktop();

            appleMobile.GetDetails();
            appleLaptop.GetDetails();
            appleDesktop.GetDetails(); 
            #endregion
        }
    }

    // Step 1: Define Abstract Product Interfaces
    public interface IDevice
    {
        void GetDetails();
    }

    // Step 2: Create Concrete Product Classes for Each Company
    #region Create Concrete Product Classes for Each Company
    public class LenovoMobile : IDevice
    {
        public void GetDetails()
        {
            Console.WriteLine("Lenovo Mobile");
        }
    }

    public class LenovoLaptop : IDevice
    {
        public void GetDetails()
        {
            Console.WriteLine("Lenovo Laptop");
        }
    }

    public class LenovoDesktop : IDevice
    {
        public void GetDetails()
        {
            Console.WriteLine("Lenovo Desktop");
        }
    }

    public class HPMobile : IDevice
    {
        public void GetDetails()
        {
            Console.WriteLine("HP Mobile");
        }
    }

    public class HPLaptop : IDevice
    {
        public void GetDetails()
        {
            Console.WriteLine("HP Laptop");
        }
    }

    public class HPDesktop : IDevice
    {
        public void GetDetails()
        {
            Console.WriteLine("HP Desktop");
        }
    }

    public class AppleMobile : IDevice
    {
        public void GetDetails()
        {
            Console.WriteLine("Apple Mobile");
        }
    }

    public class AppleLaptop : IDevice
    {
        public void GetDetails()
        {
            Console.WriteLine("Apple Laptop");
        }
    }

    public class AppleDesktop : IDevice
    {
        public void GetDetails()
        {
            Console.WriteLine("Apple Desktop");
        }
    } 
    #endregion

    //Step 3: Define the Abstract Factory Interface
    public interface IDeviceFactory
    {
        IDevice CreateMobile();
        IDevice CreateLaptop();
        IDevice CreateDesktop();
    }

    //Step 4: Implement Concrete Factory Classes for Each Company
    #region Implement Concrete Factory Classes for Each Company
    public class LenovoFactory : IDeviceFactory
    {
        public IDevice CreateMobile()
        {
            return new LenovoMobile();
        }

        public IDevice CreateLaptop()
        {
            return new LenovoLaptop();
        }

        public IDevice CreateDesktop()
        {
            return new LenovoDesktop();
        }
    }

    public class HPFactory : IDeviceFactory
    {
        public IDevice CreateMobile()
        {
            return new HPMobile();
        }

        public IDevice CreateLaptop()
        {
            return new HPLaptop();
        }

        public IDevice CreateDesktop()
        {
            return new HPDesktop();
        }
    }

    public class AppleFactory : IDeviceFactory
    {
        public IDevice CreateMobile()
        {
            return new AppleMobile();
        }

        public IDevice CreateLaptop()
        {
            return new AppleLaptop();
        }

        public IDevice CreateDesktop()
        {
            return new AppleDesktop();
        }
    } 
    #endregion
}
