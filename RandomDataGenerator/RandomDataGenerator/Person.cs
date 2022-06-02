namespace RandomDataGenerator
{
    public class Person
    {
        public string[] _arrayOfFirstNames = {"James","Robert","John","Michael","David","Mary","Patricia","Jennifer","Linda","Elizabeth"};
        public Dependent[] _dependents = new Dependent[10];

        private string _firstName;
        private string _lastName;
        private DateTime _birthDate;
        private SSN _ssn;
        private Phone _phoneNumber;

        public string FirstName
        {
            get { return _firstName; }
            init // Generates and sets the FirstName property
            {
                Random rand = new Random();
                int index = rand.Next(_arrayOfFirstNames.Length);
                _firstName = _arrayOfFirstNames[index];
            }
        }

        public string LastName
        {
            get { return _lastName; }
            init
            {
                Random rand = new Random();
                int count = Enum.GetValues(typeof(LastName)).Length;
                int index = rand.Next(count);
                _lastName = Enum.GetName(typeof(LastName), index);
            }
        }

        public DateTime BirthDate
        {
            get { return _birthDate; }
            init
            {
                Random rand = new Random();
                DateTime birthdate = DateTime.Today;
                int month = rand.Next(0, 12);
                int day = rand.Next(1, 31);
                int year = rand.Next(18, 80) * -1;
                birthdate = birthdate.AddMonths(month);
                birthdate = birthdate.AddDays(day);
                birthdate = birthdate.AddYears(year);
                _birthDate = birthdate;
            }
        }

        public SSN SSN
        {
            get { return _ssn; }
            init
            {
                _ssn = new SSN();
            }
        }

        public Phone Phone
        {
            get { return _phoneNumber; }
            init
            {
                _phoneNumber = new Phone();
            }
        }

        public Person()
        {
            this.FirstName = _firstName;
            this.LastName = _lastName;
            this.BirthDate = _birthDate;
            this.SSN = _ssn;
            this.Phone = _phoneNumber;
        }

        public int Age()
        {
            return DateTime.Today.Year - this.BirthDate.Year;
        }

       public void AddDependent()
        {
            Dependent d = new Dependent();
            this._dependents[_dependents.Length] = d;

        }

        public override string ToString()
        {
            return String.Format("{0,15}{1,0}\n{2,15}{3,0}\n{4,15}{5,0}\n{6,15}{7,0}\n{8,15}{9,0}\n{10,15}{11,0}", "First Name: ", this.FirstName, "Last Name: ", this.LastName,
                                            "Birthdate: ", this.BirthDate, "Age: ", this.Age(), "SSN: ", this.SSN.ToString(), "Phone Number: ", this.Phone.Format());
        }
    }
}
