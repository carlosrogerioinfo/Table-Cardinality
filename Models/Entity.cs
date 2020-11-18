using System;

namespace App.EFCore.Test.Models
{
    public abstract class Entity
    {
        public Entity()
        {
            this.Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }

    }
}
