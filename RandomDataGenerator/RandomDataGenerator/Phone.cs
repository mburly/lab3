namespace RandomDataGenerator
{
    public class Phone
    {
        private string _number = String.Empty;
        public string Number
        {
            get { return _number; }
            init
            {
                Random rand = new Random();
                for(int i = 0; i < 10; i++)
                {
                    int num = rand.Next(0,9);
                    if(i == 0)
                    {
                        while(num == 0 || num == 1)
                        {
                            num = rand.Next(0, 9);                        
                        }
                    }
                    _number += num;
                }
            }
        }

        public Phone()
        {
            this.Number = _number;
        }

        public string Format(char separator='-')
        {
            // Default format: ###-###-####, otherwise ###{sep}###{sep}####
            return $"{this.Number.Substring(0, 3)}{separator}{this.Number.Substring(3,3)}{separator}{this.Number.Substring(6,4)}";
        }
    }
}
