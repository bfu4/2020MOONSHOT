using System;

namespace api
{
    [Serializable]
    public class EntityDeathException : Exception
    {
        public EntityDeathException(string msg) : base("Failed to kill entity: " + msg)
        {
            
        }
    }
}