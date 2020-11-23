
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
        public SimpleCameraController controller;
        private readonly List<Hand> _hands = new List<Hand>();
        private readonly Inventory _inventory;
        private readonly double _healthpoints;
        protected string registryname = "base_entity";

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
        public Entity(SimpleCameraController c) : this()
        {
            controller = c;
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

        public bool Die()
        {
            try
            {
                TryToKill();
            }
            catch (Exception e)
            {
                Console.WriteLine(registryname + " failed to die.");
            }

            return true;
        }

        private void TryToKill()
        {
            if (_healthpoints != 0)
            {
                throw new EntityDeathException(); // too early!
            }
            // do something
            
        }
    }
}