using System;
namespace ProjectTerm3
{
    class ConcreteMemento : IMemento
    {
        private State _state;

        private DateTime _date;

        public ConcreteMemento(State state)
        {
            _state = new State(state);
            _date = DateTime.Now;
        }

        // The Originator uses this method when restoring its state.
        public State GetState()
        {
            return _state;
        }

        // The rest of the methods are used by the Caretaker to display
        // metadata.
        public string GetName()
        {
            return $"{_date} ";
        }

        public DateTime GetDate()
        {
            return _date;
        }
    }
}