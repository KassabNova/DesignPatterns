using System;

namespace ProjectTerm3
{
    public interface IMemento
    {
        string GetName();

        string GetState();

        DateTime GetDate();
    }
}