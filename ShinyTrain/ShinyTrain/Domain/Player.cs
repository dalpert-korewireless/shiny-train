namespace ShinyTrain.Domain
{
    public class Player
    {
        public Player(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}