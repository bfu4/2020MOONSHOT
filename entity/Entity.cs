
using System;
using System.Collections.Generic;
using api;

using UnityTemplateProjects;
using Random = System.Random;

namespace entity
{
    public class Entity
    {
        // UUID must be set on construction
        public readonly string uUID;
        // camera for entities that require cameras.. sigh
        private UnityEngine.Camera _camera;
        private readonly List<Hand> _hands = new List<Hand>();
        private readonly Inventory _inventory;
        private double _healthpoints;
        protected string Registryname = "base_entity";

        // a basic entity constructor
        public Entity()
        {
            uUID = GenerateUUID();
            // default size of inventory is 10
            _inventory = new Inventory();
            _healthpoints = 0;
        }

        public Entity(double hp)
        {
            _healthpoints = hp;
        }
        

        // constructor with camera
        public Entity(UnityEngine.Camera c) : this()
        {
            _camera = c;
        }

        public UnityEngine.Camera GetCamera()
        {
            return _camera;
        }

        // generate unique id
        protected string GenerateUUID()
        {
            Random r = new Random();
            string lcc = "abcdefghijklmnopqrstuvwxyz";
            string s = "";
            for (int i = 0; i < 4; i++)
            {
                s += r.Next(100, 999).ToString() + lcc[r.Next(25)];
            }

            return s;
        }

        /* generic entity methods */

        public List<Hand> GetHandsList()
        {
            return _hands;
        }

        public void AddHand(Hand h)
        {
            _hands.Add(h);
        }

        public Hand GetHandFrom(Orientation o)
        {
            int index = o != Orientation.LEFT ? 0 : 1;
            return _hands[index];
        }

        public Inventory GetInventory()
        {
            return _inventory;
        }

        public void SetHealthpoints(double d)
        {
            _healthpoints = d;
        }
        public bool Die()
        {
            try
            {
                NaturalKill();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        public string GetRegistryName()
        {
            return Registryname;
        }

        private void NaturalKill()
        {
            if (_healthpoints != 0)
            {
                throw new EntityDeathException(Registryname + "@" + uUID + "does not have sufficient health points for a natural death."); // too early!
            }
            // do something
            
        }
    }
}