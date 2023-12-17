namespace Task3
{
    internal class ElephantBee
    {
        int elephantPart;
        int beePart;
        public ElephantBee(int elephantPart = 20, int beePart = 20)
        {
            this.elephantPart = elephantPart;
            this.beePart = beePart;
        }

        public int ElephantPart
        {
            get
            {
                if (elephantPart >= 100)
                {
                    elephantPart = 100;
                }
                else if (elephantPart < 0)
                {
                    elephantPart = 0;
                }
                return elephantPart;
            }
            set
            {
                elephantPart = value;
                if (elephantPart >= 100)
                {
                    elephantPart = 100;
                }
                else if (elephantPart < 0)
                {
                    elephantPart = 0;
                }
            }
        }

        public int BeePart
        {
            get
            {
                if (beePart >= 100)
                {
                    beePart = 100;
                }
                else if (beePart < 0)
                {
                    beePart = 0;
                }
                return beePart;
            }
            set
            {
                beePart = value;
                if (beePart >= 100)
                {
                    beePart = 100;
                }
                else if (beePart < 0)
                {
                    beePart = 0;
                }
            }
        }

        public bool fly()
        {
            return BeePart >= ElephantPart;
        }

        public string Trumpet()
        {
            if (ElephantPart >= BeePart)
            {
                return "tu-tu-doo-doo";
            }
            else
            {
                return "wzzzz";
            }
        }

        public void Eat(string food, int value)
        {
            if (food == "nectar")
            {
                ElephantPart -= value;
                BeePart += value;
            }
            else if (food == "grass")
            {
                ElephantPart += value;
                BeePart -= value;
            }
            else
            {
                Console.WriteLine("Этим пчелослон не питается");
            }
        }
    }
}
