using System;

namespace ShinyTrain.Domain.Exceptions
{
    public class PlayerAlreadyExistsException : Exception
    {
        public string Name { get; set; }

        public PlayerAlreadyExistsException(string playerName)
        {
            Name = playerName;
        }
    }
}