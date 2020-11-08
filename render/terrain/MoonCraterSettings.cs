/*
 * concept by Sebastian Lague
 * https://github.com/SebLague/Solar-System/blob/Episode_02/Assets/Celestial%20Body/Scripts/NoiseSettings/CraterSettings.cs
 *
 * except simplified, and shorter, because unlike him, i am no math wiz nor
 * ui wiz.. this will probably look terrible, and for that, i am sorry
 *
 * all credit for this goes to Sebastian Lague, because I'm an idiot and quite frankly,
 * when it comes to this, ESPECIALLY UNITY, I have no clue what i am doing.
 */

using System;
using System.Security.Cryptography.X509Certificates;
using meta;
using UnityEngine;
using Random = System.Random;

namespace render 
{
    [Serializable]
    public class MoonCraterSettings
    {
        
        // settings that definitely matter
        public Vector2 craterSizeMinMax = new Vector2 (0.01f, 0.1f);
        public Vector2 smoothMinMax = new Vector2 (0.4f, 1.5f);
        public Vector4 _maxcoordplane;
        public float rimSteepness = 0.13f;
        public float rimWidth = 1.6f;
        [Range (0, 1)]
        public float sizeDistribution = 0.6f;
        
        [HideInInspector]
        public MoonCrater[] cachedCraters;
        
        // my class variables that i'll need
        private static Random r = new Random();
        
        
        // i like to mark exceptionally terrible code with obsolete/deprecation warnings because well,
        // it's probably even terrible for ME to use it, and i'm the one writing it
        
        // todo make this do more than generate circles and add them to an object
        [Obsolete]
        public void GenerateCraters(int craters, float sizeDistribution, bool maxCoordPlane)    
        {
            MoonCrater[] c_arr = new MoonCrater[craters];
            if (!maxCoordPlane)
            {
                for (int i = 0; i < craters; i++)
                {
                    // "float t"
                    float rf = ValueBiasLower(sizeDistribution);
                    float radius = (float) (r.NextDouble() * 6);
                    float smooth = Mathf.Lerp(smoothMinMax.x, smoothMinMax.y, 1 - rf);
                    float floorHeight = Mathf.Lerp(-1.2f, -0.2f, rf + ValueBiasLower(0.3f));
                    // this one will be a pain, i suggest having a max coord plane
                    c_arr[i] = new MoonCrater(new Circle(radius), smooth, floorHeight);
                }
            }
            else
            {
                // null check.. 
                if (_maxcoordplane != null)
                {
                    for (int i = 0; i < craters; i++)
                    {
                        // "float t"
                        float rf = ValueBiasLower(sizeDistribution);
                        float radius = (float) (r.NextDouble() * 6);
                        float smooth = Mathf.Lerp(smoothMinMax.x, smoothMinMax.y, 1 - rf);
                        float floorHeight = Mathf.Lerp(-1.2f, -0.2f, rf + ValueBiasLower(0.3f));

                        float x = GenerateInRange(_maxcoordplane.x, _maxcoordplane.z);
                        float y = GenerateInRange(_maxcoordplane.y, _maxcoordplane.w);

                        c_arr[i] = new MoonCrater(new Circle(radius, x, y), smooth, floorHeight);
                    }
                }
            }
        }

        private static float GenerateInRange(float bounds, float bounds2)
        {
            return Math.Abs((float) r.NextDouble() * bounds2 - bounds);
        }
        
        // honestly, ignore that shit, i just need storage values
        // use this where x1 is min x, x2 max x, etc.
        public void SetMaxCoordinatePlane(float x1, float y1, float x2, float y2)
        {
            _maxcoordplane = new Vector4(x1, y1, x2, y2);
        }
        
        // by Seb Lague
        // it seems important/useful, but i don't know how to do math
        public float ValueBiasLower (float biasStrength) {
            float t = (float) (r.NextDouble() * 1.0000000004656612875245796924106);

            // Avoid possible division by zero
            if (biasStrength == 1) {
                return 0;
            }

            // Remap strength for nicer input -> output relationship
            float k = Mathf.Clamp01 (1 - biasStrength);
            k = k * k * k - 1;

            // Thanks to www.shadertoy.com/view/Xd2yRd
            return Mathf.Clamp01 ((t + t * k) / (t * k + 1));
        }

        
    }
}