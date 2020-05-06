using System;
namespace HomeWork5
{
    public class Car
    {
        //-----------------------Car------------------------------

        //-------------------------------------------------------
        //1 Car class value and Get/Set
        private int currentSpeed;
        public int CurrentSpeed
        {
            get { return currentSpeed; }
            set { currentSpeed = value; }
        }
        private String carName;
        public String CarName
        {
            get { return carName; }
            set { carName = value; }
        }

        public void takeSpeed(int num)
        {
            while(num > 0)
            {
                currentSpeed++;
                num--;
            }
                
        }
        public void minusSpeed(int num)
        {
            while(num > 0)
            {
                currentSpeed--;
                num--;

            }
        }
        public void stopCar()
        {
            currentSpeed = 0;
            Console.WriteLine("the car is stoped");
        }
    }
}
