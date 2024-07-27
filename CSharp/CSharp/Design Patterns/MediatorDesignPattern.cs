namespace CSharp.DesignPatterns
{
    public class MediatorProgram
    {
        static void Main(string[] args)
        {
            IChatMediator mediator = new ChatMediator();
            IParticipant participant1 = new Participant1(mediator, "Participant 1");
            IParticipant participant2 = new Participant2(mediator, "Participant 2");
            mediator.AddParticipant(participant1);
            mediator.AddParticipant(participant2);
            participant1.SendMessage("This is the first participant");
            participant2.SendMessage("This is the second participant");
            Console.ReadLine();
        }
    }
    public interface IChatMediator
    {
        void AddParticipant(IParticipant participant);

        void BroadcastMessage(string message, IParticipant sender);
    }

    public class ChatMediator : IChatMediator
    {
        List<IParticipant> participants = new List<IParticipant>();
        public void AddParticipant(IParticipant participant)
        {
            participants.Add(participant);
        }
        public void BroadcastMessage(string message, IParticipant sender)
        {
            foreach (var participant in participants)
            {
                if (participant != sender)
                {
                    participant.ReceiveMessage(message);
                }
            }
        }
    }

    public interface IParticipant
    {
        void SendMessage(string message);

        void ReceiveMessage(string message);
    }
    public class Participant1 : IParticipant
    {
        protected IChatMediator _mediator;

        private string _name;
        public Participant1(IChatMediator mediator, string name)
        {
            _mediator = mediator;
            _name = name;
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"{_name} receives: {message}");
        }

        public void SendMessage(string message)
        {
            _mediator.BroadcastMessage(message, this);
        }
    }
    public class Participant2 : IParticipant
    {
        protected IChatMediator _mediator;

        private string _name;
        public Participant2(IChatMediator mediator, string name)
        {
            _mediator = mediator;
            _name = name;
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"{_name} receives: {message}");
        }

        public void SendMessage(string message)
        {
            _mediator.BroadcastMessage(message, this);
        }
    }
}
