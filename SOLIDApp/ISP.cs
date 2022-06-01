using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDApp
{
    internal class ISP
    {
        public interface ICarCommon
        {
            public int getMake();
            public int getYear();
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

        public interface ICar : ICarCommon, ICombustionEngine
        {
        }

        public interface IElectricCar : ICarCommon, IElectricEngine
        {
        }
    }
}
