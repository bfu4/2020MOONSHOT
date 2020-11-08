using entity;

namespace gameevent
{
    abstract class EquipEvent
    {
        protected readonly Hand hand;
        protected readonly Entity entity;

        public EquipEvent()
        {
        }
        public EquipEvent(Entity e, Hand h)
        {
            entity = e;
            hand = h;
        }
    }
}