using System;
using render.client;

namespace api
{
    [Serializable]
    public class InterfaceRenderException : Exception
    {
        public InterfaceRenderException(string message) : base("Failed to render: " + message)
        {
            
        }
    }
}