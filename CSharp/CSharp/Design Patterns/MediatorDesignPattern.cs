namespace CSharp.DesignPatterns
{
    public class MediatorProgram
    {
        static void Main(string[] args)
        {
            IMediator mediator = new ConcreteMediator();
            IParticipant participant1 = new ConcreteParticipant1(mediator);
            IParticipant participant2 = new ConcreteParticipant2(mediator);
            mediator.AddParticipant(participant1);
            mediator.AddParticipant(participant2);
            participant1.SendMessage("This is the first participant");
            participant2.SendMessage("This is the second participant");
            Console.ReadLine();
        }
    }
    public interface IMediator
    {
        void AddParticipant(IParticipant participant);

        void BroadcastMessage(string message, IParticipant sender);
    }

    public class ConcreteMediator : IMediator
    {
        List<IParticipant> participants = new List<IParticipant>();
        public void AddParticipant(IParticipant participant)
        {
            participants.Add(participant);
        }
        public void BroadcastMessage(string message, IParticipant sender)
        {
            // Write code here to broadcast the message to the participants
        }
    }

    public interface IParticipant
    {
        void SendMessage(string message);
    }
    public class ConcreteParticipant1 : IParticipant
    {
        protected IMediator _mediator;
        public ConcreteParticipant1(IMediator mediator)
        {
            _mediator = mediator;
        }
        public void SendMessage(string message)
        {
            _mediator.BroadcastMessage(message, this);
        }
    }
    public class ConcreteParticipant2 : IParticipant
    {
        protected IMediator _mediator;
        public ConcreteParticipant2(IMediator mediator)
        {
            _mediator = mediator;
        }
        public void SendMessage(string message)
        {
            _mediator.BroadcastMessage(message, this);
        }
    }
}
