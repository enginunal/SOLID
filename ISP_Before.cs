namespace ISP.Before
{
    public interface ICar
    {
        public int getMake();
        public int getYear();
        public int getEngineSize();
        public int getHorsePowerOfEngine();
        public string getFuelType(); 
        public string getTransmissionType();
        public int getTranmissionSpeed(); 
    }

    public interface IElectricCar : ICar
    {
        public int getBatteryType();
        public int getBatteryVoltage();     
        public int getRange();    
    }

}
