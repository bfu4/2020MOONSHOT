using System;
using entity;

namespace action
{
    public class PickupAction : Action
    {
        private readonly Entity _entity;

        public PickupAction(Entity e, bool canBeCancelled, string desc) : base(desc, canBeCancelled)
        {
            _entity = e;
            
        }
        public override bool Execute()
        {
            throw new System.NotImplementedException();
        }

        [Obsolete]
        public override bool TryCancel()
        {
            if (IsCancellable())
            {
                // do something, check if Item is despawned
                // check item and entity type
                return true;
            }

            return false;
        }

        public Entity GetEntity()
        {
            return _entity;
        }
        
    }
}