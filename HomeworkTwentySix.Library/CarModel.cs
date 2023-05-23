using System;

namespace HomeworkTwentySix.Library
{
    public abstract class CarModel
    {
        public int NumberOfSeats { get; set; }

        public void Sound()
        {
            Console.WriteLine("Brooom!");
        }

        public abstract void Start();
    }
}
