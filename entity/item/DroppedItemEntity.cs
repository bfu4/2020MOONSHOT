using UnityEditorInternal;

namespace entity.item
{
    public abstract class DroppedItemEntity : Entity
    {
        public DroppedItemEntity()
        {
            registryname = "item_entity_base";
        }
        public abstract bool OnContact(Entity e);
        
    }
}