using System;

namespace GYM_System.Domain.Entities
{
    public class Entity
    {
        public Entity()
        {
            Id = Guid.NewGuid();
            Create_Date = DateTime.Now;
            Update_Date = DateTime.Now;
        }

        public Guid Id { get; private set; }
        public DateTime Create_Date { get; private set; }
        public DateTime Update_Date { get; private set; }
    }
}