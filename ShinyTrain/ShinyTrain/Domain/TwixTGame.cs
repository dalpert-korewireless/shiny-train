namespace ShinyTrain.Domain
{
    public class TwixTGame
    {
        public TwixTGame(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}