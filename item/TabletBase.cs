using UnityEngine;
using meta;

namespace item 
{
    public abstract class TabletBase : DroppableItem
    {
        private readonly Dimension dimension;
        private readonly Importance importance;
        private readonly bool playerRestricted;
        private readonly bool holdable;
        private double durability;
        private readonly bool _despawnable;
        public TabletBase(Dimension d, Importance i, bool playerOnly, bool canBeHeld, double db, bool candespawn) : base(candespawn)
        {
            dimension = d;
            importance = i;
            playerRestricted = playerOnly;
            holdable = canBeHeld;
            durability = db;
            _despawnable = candespawn;
        }

        public abstract void OnHold();
        public abstract bool OnPickup();
        public abstract void OnBreak();

    }
}