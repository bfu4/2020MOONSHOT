using System;

namespace action
{
    public abstract class Action
    {
        private readonly string _description;
        private readonly bool _cancellable;
        
        public Action() {}
        public Action(string d, bool c)
        {
            _description = d;
            _cancellable = c;
        }

        public abstract bool Execute();
        
        // this is simply an OUTLINE for this concept. should be overriden for sure!
        [Obsolete] 
        public virtual bool TryCancel()
        {
            if (_cancellable)
            {
                // do something, avoid probably a CME or c# equiv..
                return true;
            }
            return false;
        }

        public string GetDescription()
        {
            return _description;
        }

        public bool IsCancellable()
        {
            return _cancellable;
        }
    }
}