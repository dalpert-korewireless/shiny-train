using System;

namespace ShinyTrain.Domain.Exceptions
{
    public class GameAlreadExistsException : Exception
    {
        public string Name { get; set; }

        public GameAlreadExistsException(string name)
        {
            Name = name;
        }
    }
}