/*
 * interface to show tasks / to complete
 */

using System;
using System.Collections.Generic;
using render.client;
using UnityEngine;

namespace item.ui
{
    public class JourneyInterface : FunctionalInterface
    {
        public JourneyInterface(TabletBase b, string desc) : base(b, desc)
        {
            
        }

        public JourneyInterface(TabletBase b, string desc, Dictionary<Int32, Texture2D> ts) : this(b, desc)
        {
            Textures = ts;
        }
        
    }
}