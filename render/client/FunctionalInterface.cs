using System;
using System.Collections.Generic;
using UnityEngine;
using Object = System.Object;

namespace render.client
{
    public class FunctionalInterface
    {
        protected readonly Object Parent;
        protected readonly string Description;
        protected Dictionary<Int32, Texture2D> Textures = new Dictionary<int, Texture2D>();

        public FunctionalInterface(Object e, string desc)
        {
            Parent = e;
            Description = desc;
        }
        
        public Dictionary<Int32, Texture2D> GetTextures()
        {
            return Textures;
        }
        public string GetDescription()
        {
            return Description;
        }

        public Object GetParent()
        {
            return Parent;
        }
    }
}