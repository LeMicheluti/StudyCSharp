using System;

namespace SensorReadDataApi.Domain
{
    public class Sensor
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public long Step { get; set; }
    }
}
