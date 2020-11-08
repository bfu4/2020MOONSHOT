using meta;
using entity;

namespace item 
{
    public abstract class Item 
    { 
        public abstract bool CanPlayerHold();
        public abstract Importance GetImportance();
        public abstract Dimension GetDimension();
        public abstract double GetDurability();
        
    }
}