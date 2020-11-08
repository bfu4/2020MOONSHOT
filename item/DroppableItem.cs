namespace item
{
    public abstract class DroppableItem : Item
    {
        private readonly bool _despawnable;
        public abstract bool Despawn();
        
        public DroppableItem(bool canDespawn)
        {
            _despawnable = canDespawn;
        }

        public bool IsDespawnable()
        {
            return _despawnable;
        }
        
    }
}