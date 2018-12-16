using System;

namespace Webapi.Entities
{

    public class Entity<T> where T : class
    {
        public DateTime? LastUpdate { get; }
        public T Data { get; }
        public Entity(T data, DateTime? lastUpdate)
        {
            Data = data;
            LastUpdate = lastUpdate;
        }
    }
    public interface IEntity
    {
        int Id { get; }
        DateTime? LastUpdate { get; }
        
    }
}