namespace RandomDataGenerator
{
    public class Dependent : Person
    {
        public Dependent()
        {
            // Dependent's birthdays must be between 0 and 10 years from now
            if(DateTime.Today.Year - this.BirthDate.Year > 10)
            {
                Random rand = new Random();
                this.BirthDate = DateTime.Today.AddYears(rand.Next(0, 10) * -1);
            }
        }
    }
}
