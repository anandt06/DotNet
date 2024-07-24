namespace CSharp.DesignPatterns
{
    internal class CommandDesignPattern
    {
        static void Main(string[] args)
        {
            // Receiver
            Light light = new Light();

            // Commands
            ICommand turnOn = new TurnOnCommand(light);
            ICommand turnOff = new TurnOffCommand(light);

            // Invoker
            RemoteControl remote = new RemoteControl();

            // Turn on the light
            remote.SetCommand(turnOn);
            remote.PressButton();

            // Turn off the light
            remote.SetCommand(turnOff);
            remote.PressButton();
        }
    }
    public interface ICommand
    {
        void Execute();
    }
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("The light is on");
        }

        public void TurnOff()
        {
            Console.WriteLine("The light is off");
        }
    }

    public class TurnOnCommand : ICommand
    {
        private readonly Light _light;

        public TurnOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }
    }

    public class TurnOffCommand : ICommand
    {
        private readonly Light _light;

        public TurnOffCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOff();
        }
    }
    public class RemoteControl
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void PressButton()
        {
            _command.Execute();
        }
    }

}
