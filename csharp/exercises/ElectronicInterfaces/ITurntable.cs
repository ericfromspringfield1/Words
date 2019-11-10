namespace ElectronicInterfaces
{
    public class ITurnTable
    {
        public double CurrentSpeed { get; set; }
        public bool IsPlaying { get; set; }
        public void Play();

    }
}