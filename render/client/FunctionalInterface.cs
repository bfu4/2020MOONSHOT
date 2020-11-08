using System;

namespace render.client
{
    public class FunctionalInterface
    {
        private readonly Object parent;

        public FunctionalInterface()
        {
            
        }

        public FunctionalInterface(Object e)
        {
            parent = e;
        }

        public Object GetParent()
        {
            return parent;
        }
    }
}