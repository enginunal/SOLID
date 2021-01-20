namespace ISP.After
{
    public interface ICarCommon 
    {
        public int getMake();
        public int getYear();                
    }

    public interface ICar : ICarCommon, ICombustionEngine
    {                
    }

    public interface IElectricCar : ICarCommon, IElectricEngine
    {      
    }

    public interface IElectricEngine
    {
        public int getBatteryVoltage();
        public int getBatteryType();
        public int getRange();
    }
    
    public interface ICombustionEngine
    {
        public int getHorsePowerOfEngine();
        public int getEngineSize();
        public string getFuelType(); 
    }
