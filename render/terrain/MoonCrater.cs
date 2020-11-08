
/*
 * conceptual bullshit of the crater class
 */

using System;
using meta;
using UnityEngine;

namespace render
{
    [Serializable]
    public class MoonCrater
    {
        // this makes sense
        private readonly Circle _c;
        private float _smooth;
        
        // it would make sense to assign this to a terrain, right?
        // however, i haven't gotten far enough in a unity api to understand that >.<
        public MoonCrater(Circle c, float smooth, float floorheight)
        {
            _c = c;
            _smooth = smooth;
        }

        public void SmoothAdd(float amount)
        {
            _smooth += amount;
        }

        public float GetSmooth()
        {
            return _smooth;
        }

        public Circle GetCircle()
        {
            return _c;
        }
    }
}