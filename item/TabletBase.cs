using System.Collections.Generic;
using UnityEngine;
using meta;
using render.client;

namespace item 
{
    public abstract class TabletBase : DroppableItem
    {
        protected readonly Dimension dimension;
        protected readonly Importance importance;
        protected readonly bool playerRestricted;
        protected readonly bool holdable;
        protected double durability;
        protected readonly bool _despawnable;
        protected List<FunctionalInterface> _interfaces;

        public TabletBase(Dimension d, Importance i, bool playerOnly, bool canBeHeld, double db, bool candespawn) : base(candespawn)
        {
            dimension = d;
            importance = i;
            playerRestricted = playerOnly;
            holdable = canBeHeld;
            durability = db;
            _despawnable = candespawn;
        }

        public void AddInterface(FunctionalInterface i)
        {
            _interfaces.Add(i);
        }

        public List<FunctionalInterface> GetInterfaces()
        {
            return _interfaces;
        }

        public abstract void OnHold();
        public abstract bool OnPickup();
        public abstract void OnBreak();

    }
}