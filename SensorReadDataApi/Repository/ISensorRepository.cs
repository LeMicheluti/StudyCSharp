using SensorReadDataApi.Domain;
using System.Collections.Generic;

namespace SensorReadDataApi.Repository
{
    public interface ISensorRepository
    {
        public IEnumerable<Sensor> ListAll();

        public int Insert(long step);
    }
}
