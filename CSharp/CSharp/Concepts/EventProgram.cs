namespace CSharp.Concepts
{
    class EventProgramDriver
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.ev_CheckSpeed += new Vehicle.dg_CheckSpeed(NotifyDriver);
            vehicle.CheckSpeed(69);
            Console.Read();
        }
        static void NotifyDriver()
        {
            Console.WriteLine("The vehicle is over speeding");
        }

    }

    //This is Publisher Class
    class Vehicle
    {
        public delegate void dg_CheckSpeed();
        public event dg_CheckSpeed? ev_CheckSpeed;

        public void CheckSpeed(int speed)
        {
            if (speed > 60 && ev_CheckSpeed != null)
            {
                ev_CheckSpeed.Invoke();
                //ev_CheckSpeed(); // event can be raised like this as well
            }
        }
    }

}
