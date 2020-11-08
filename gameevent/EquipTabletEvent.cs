/*
 * class for when you equip the tablet. will be opened with 't'
 * shows completion and tasks to do, starts near broken however
 * event to initiate rendering and whatnot
 */

using entity;
using item;

namespace gameevent
{
    class EquipTabletEvent : EquipEvent
    {
        private readonly Entity _entity;
        private readonly TabletBase _tablet;
        
        // handOrientation can be an enum! yay!
        public EquipTabletEvent(Entity e, Orientation o, TabletBase t) : base(e, e.GetHandFrom(o))
        {
            _entity = e;
            _tablet = t;
        }

        public Entity GetEntity()
        {
            return _entity;
        }

        public TabletBase GetTablet()
        {
            return _tablet;
        }
    }
}