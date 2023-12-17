using System.Linq;

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
            if (IsFull)
            {
                Console.WriteLine($"Все места в автобусе заняты");
            }
            else
            {
                passengers.Add(newPassenger);
                for (int i = 0; i < passengers.Count; i++)
                {
                    if (!seats.ContainsKey(i))
                    {
                        seats.Add(i, newPassenger);
                        Console.WriteLine($"Пассажир {newPassenger} сел на место {i + 1}");
                        break;
                    }
                }
            }
        }

        public void EnterBas(List<string> newPassengers)
        {
            for (int i = 0; i < newPassengers.Count; i++)
            {
                EnterBas(newPassengers[i]);
            }
        }

        public void OutBas(string outPassenger)
        {
            int key = new int();
            if (passengers.Contains(outPassenger))
            {
                foreach(var seat in seats)
                {
                    if(seat.Value == outPassenger)
                    {
                        key = seat.Key;
                        break;
                    }
                }
                seats.Remove(key);
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
                OutBas(outPassengers[i]);
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
