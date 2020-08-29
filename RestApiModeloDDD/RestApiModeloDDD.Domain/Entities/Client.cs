using System;

namespace RestApiModeloDDD.Domain.Entities
{
    public class Client : Base
    {
        public Client()
        {
            CreatedAt = DateTime.Now;
        }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
