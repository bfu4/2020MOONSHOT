
/*
 * the main user interface tablet thing 
 */

using System.Collections.Generic;
using entity;
using item.ui;
using meta;
using render.client;

namespace item
{
    public class Hacklet : TabletBase
    {
        private readonly Importance _importance;
        private readonly Dimension _dimension;
        private readonly Entity _entity;
        
        private const double Durability = 300d;
        
        public Hacklet(Dimension d, Importance i, Entity e) : base(d, i, true, true, Durability, true)
        {
            _dimension = d;
            _importance = i;
            _entity = e;
            _interfaces = new List<FunctionalInterface>();
        }

        public Hacklet(Dimension d, Importance i, Entity e, List<FunctionalInterface> interfaces) : this(d, i, e)
        {
            _interfaces = interfaces;
        }

        public override void OnHold()
        {
            // todo
        }

        public override bool OnPickup()
        {
            foreach (Item i in _entity.GetInventory())
            {
                if (i is Hacklet)
                {
                    return false;
                }
            }
            // seems reasonable
            _entity.GetInventory().Add(this);
            // disappear from floor, give message
            return true;
        }

        public override void OnBreak()
        {
            // todo, game end  because if it breaks you're fucked anyways
        }

        public override bool CanPlayerHold()
        {
            return true;
        }

        public override Importance GetImportance()
        {
            return _importance;
        }

        public override Dimension GetDimension()
        {
            return _dimension;
        }

        public override double GetDurability()
        {
            return Durability;
        }

        public override bool Despawn()
        {
            // disappear
            throw new System.NotImplementedException();
        }
    }
}