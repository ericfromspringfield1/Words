namespace ElectronicInterfaces
{
    public class ISpeaker : TurnTable
    {
        public int Volume {get; set;}
        public void VolumeUp();
        public void VolumeDown();
    }
}
