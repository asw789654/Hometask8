namespace Task2
{
    internal class Bus
    {
        int speed;
        int seatNumber;
        int maxSpeed;
        bool isFull = false;
        List<string> passengers = new List<string>();
        Dictionary<int, string> seats = new Dictionary<int, string>();

        public Bus(int seatNumber = 50, int maxSpeed = 40)
        {
            this.speed = 0;
            this.seatNumber = seatNumber;
            this.maxSpeed = maxSpeed;
        }

        public Dictionary<int, string> Seats
        {
            get
            {
                return seats;
            }
            set
            {
                seats = value;
            }
        }

        public int SeatNumber
        {
            get
            {
                return seatNumber;
            }
            set
            {
                seatNumber = value;
            }
        }

        public int MaxSpeed
        {
            get
            {
                return maxSpeed;
            }
            set
            {
                maxSpeed = value;
            }
        }

        public bool IsFull
        {
            get
            {
                if (passengers.Count >= seatNumber)
                {
                    isFull = true;
                }
                else
                {
                    isFull = false;
                }
                return isFull;
            }

        }

        public void EnterBas(string newPassenger)
        {
            if (isFull)
            {
                Console.WriteLine($"Все места в автобусе заняты");
            }
            else
            {
                passengers.Add(newPassenger);
                seats.Add(passengers.IndexOf(newPassenger), newPassenger);
                Console.WriteLine($"Пассажир {newPassenger} сел на место{passengers.IndexOf(newPassenger) + 1}");
            }
        }

        public void EnterBas(List<string> newPassengers)
        {
            for (int i = 0; i < newPassengers.Count; i++)
            {
                if (IsFull)
                {
                    Console.WriteLine($"Все места в автобусе заняты");
                    break;
                }
                else
                {
                    passengers.Add(newPassengers[i]);
                    seats.Add(passengers.IndexOf(newPassengers[i]), newPassengers[i]);
                    Console.WriteLine($"Пассажир {newPassengers[i]} сел на место{passengers.IndexOf(newPassengers[i]) + 1}");
                }
            }
        }

        public void OutBas(string outPassenger)
        {
            if (passengers.Contains(outPassenger))
            {
                seats.Remove(passengers.IndexOf(outPassenger));
                passengers.Remove(outPassenger);
                Console.WriteLine($"Пассажир {outPassenger} вышел из автобуса");
            }
            else
            {
                Console.WriteLine($"Пассажира {outPassenger} нет в автобусе");
            }
        }

        public void OutBas(List<string> outPassengers)
        {
            for (int i = 0; i < outPassengers.Count; i++)
            {
                if (passengers.Contains(outPassengers[i]))
                {
                    seats.Remove(passengers.IndexOf(outPassengers[i]));
                    passengers.Remove(outPassengers[i]);
                    Console.WriteLine($"Пассажир {outPassengers[i]} вышел из автобуса");
                }
                else
                {
                    Console.WriteLine($"Пассажира {outPassengers[i]} нет в автобусе");
                }
            }
        }

        public void ChangeSpeed(int speedChangingValue)
        {
            speed += speedChangingValue;
            if (speed <= 0)
            {
                speed = 0;
                Console.WriteLine($"Автобус остановился");
            }
            else if (speedChangingValue < 0)
            {
                Console.WriteLine($"Скорость опустилась до {speed}");
            }
            else if (speed <= 0)
            {
                speed = 0;
                Console.WriteLine($"Автобус остановился");
            }
            else if (speed < maxSpeed)
            {
                Console.WriteLine($"Скорость поднялась до {speed}");
            }
            else
            {
                speed = maxSpeed;
                Console.WriteLine($"Достигнута максимальная скорость {speed}");
            }
        }
    }
}
