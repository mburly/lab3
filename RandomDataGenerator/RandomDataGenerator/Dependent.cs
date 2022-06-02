namespace RandomDataGenerator
{
    public class Dependent : Person
    {
        public Dependent()
        {
            if(DateTime.Today.Year - this.BirthDate.Year > 10)
            {
                Random rand = new Random();
                this.BirthDate = DateTime.Today.AddYears(rand.Next(0, 10) * -1);
            }
        }
    }
}
