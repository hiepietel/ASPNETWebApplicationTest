namespace ASPNETWebApplicationTest.Models
{
    public class NumberModel
    {
        /// <summary>
        /// Number passed by the user.
        /// </summary>
        
        public string number { get; set; }
        /// <summary>
        /// Factorial od the number, which was passed by the user.
        /// </summary>
        public double factorial { get; set; }

        public double square { get; set; }
        public double cube { get; set; }
        /// <summary>
        /// Show if the number is a prime number
        /// </summary>
        public bool isPrime { get; set; }
    }
}