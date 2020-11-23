using api;
using gamevent;
using render.client;

namespace gameevent
{
    public class OpenTabletEvent : OpenInterfaceEvent
    {
        private item.TabletBase _item;
        private entity.Entity _entity;
        public OpenTabletEvent(item.TabletBase i, entity.Entity e) : base(i)
        {
            _item = i;
            _entity = e;
            // have fun
            try
            {
                Happen();
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }

        private void Happen()
        {
            // iterate through interfaces from the item and load them
            if (_item.GetInterfaces().Count > 0)
            {
                foreach (FunctionalInterface f in _item.GetInterfaces())
                { 
                    InterfaceRenderer.Render(f, _entity.GetCamera());
                }
                return;
            }
            // lets fail here if the code makes it to this point.
            throw new InterfaceRenderException("No interfaces to render!");
        }
        
    }
}