namespace events
{
    public class GuessTimes: EventArgs
    {
        public GuessTimes()
        {
            Times++;
        }

        public int Times { get; set; } 
       

    }
}