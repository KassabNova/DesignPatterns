using System;

namespace ProjectTerm3
{
    public interface IMemento
    {
        string GetName();

        State GetState();

        DateTime GetDate();
    }
}