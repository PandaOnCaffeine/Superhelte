namespace Superhelte
{
    public class Superhero
    {
        //instance variables
        private string _secretIdentity;

        private string _powers;

        private string _maskAndCostume;

        private string _moralCode;

        private string _archEnemy;


        //Get Set
        //inkapsulating
        public string SecretIdentity
        {
            get { return _secretIdentity; }
            private set
            {
                _secretIdentity = value;
            }
        }

        public string Powers
        {
            get { return _powers; }
            private set
            {
                _powers = value;
            }
        }

        public string MaskAndCostume
        {
            get { return _maskAndCostume; }
            private set
            {
                _maskAndCostume = value;
            }
        }

        public string MoralCode
        {
            get { return _moralCode; }
            private set
            {
                _moralCode = value;
            }
        }

        public string ArchEnemy
        {
            get { return _archEnemy; }
            private set
            {
                _archEnemy = value;
            }
        }

        //Methods
        public void UsePowers()
        {
            Console.WriteLine("Uses Powers");
        }

        public void ChangeToCostume()
        {
            Console.WriteLine("Changes to costume");

        }

    }
}
