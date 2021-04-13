using System;
using System.IO;

namespace ProjectTerm3
{
    class Originator
    {
        // For the sake of simplicity, the originator's state is stored inside a
        // single variable.
        public State _state;

        public Originator(State state)
        {
            _state = state;
        }

        // The Originator's business logic may affect its internal state.
        // Therefore, the client should backup the state before launching
        // methods of the business logic via the save() method.
        public void DoSomething()
        {
            Console.WriteLine("Originator: I'm doing something important.");
            _state.stringVal = GenerateRandomString(30);
            Console.WriteLine($"Originator: and my state has changed to: {_state}");
        }

        private string GenerateRandomString(int length = 10)
        {
            string allowedSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string result = string.Empty;

            while (length > 0)
            {
                result += allowedSymbols[new Random().Next(0, allowedSymbols.Length)];

                length--;
            }

            return result;
        }

        // Saves the current state inside a memento.
        public IMemento Save()
        {
            return new ConcreteMemento(_state);
        }

        // Restores the Originator's state from a memento object.
        public void Restore(IMemento memento)
        {
            if (!(memento is ConcreteMemento))
            {
                throw new Exception("Unknown memento class " + memento.ToString());
            }
            double prevBalance = _state.money;
            _state = memento.GetState();
            Console.WriteLine($"Bank account balance was {prevBalance}. It has changed to: {_state.money}");
        }
    }
}