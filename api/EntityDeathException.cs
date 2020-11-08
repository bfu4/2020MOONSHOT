using System;

namespace api
{
    [Serializable]
    public class EntityDeathException : Exception
    {
        public EntityDeathException() : base("Entity is not able to die.")
        {
            
        }
    }
}