using System;
using UnityEngine;
using Random = System.Random;

namespace meta
{
    public class Circle
    {
        private float _radius;
        private static float _x;
        private static float _y;
        private static readonly Random R = new Random();
        private float[] _coords = new float[2];
        
        [Obsolete("i mean, why would you use this anyways?")]
        public Circle(float radius) : this(radius, (float) R.NextDouble(), (float) R.NextDouble())
        {
            
        }
        
        public Circle(float radius, float x, float y)
        {
            _radius = radius;
            _x = x;
            _y = y;
            _coords[0] = _x;
            _coords[1] = _y;
        }

        public float GetRadius()
        {
            return _radius;
        }
        
        /*
         * where GetCoords()[0] is X and GetCoords()[1] is Y
         */
        public float[] GetCoords()
        {
            return _coords;
        }
    }
}