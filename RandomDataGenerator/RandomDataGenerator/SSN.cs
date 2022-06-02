namespace RandomDataGenerator
{
    public class SSN
    {
        private string _ssn;
        public string Number
        {
            get { return _ssn; }
            init
            {
                // Pattern for invalid SSN numbers found here: https://secure.ssa.gov/poms.nsf/lnx/0110201035
                Random rand = new Random();
                string[] invalidFirst = { "000", "666", "900" };
                string firstDigits = invalidFirst[rand.Next(invalidFirst.Length)];
                if (firstDigits == "900")
                {
                    int newDigits = 900 + rand.Next(0, 99);
                    firstDigits = newDigits.ToString();
                }
                string secondDigits = rand.Next(10, 99).ToString();
                string thirdDigits = rand.Next(1000, 9999).ToString();
                _ssn = $"{firstDigits}{secondDigits}{thirdDigits}";
            }
        }
        public SSN()
        {
            this.Number = _ssn;
        }

        public override string ToString()
        {
            // SSN in format: ###-##-####
            return $"{this.Number.Substring(0,3)}-{this.Number.Substring(3, 2)}-{this.Number.Substring(5)}";
        }
    }
}
