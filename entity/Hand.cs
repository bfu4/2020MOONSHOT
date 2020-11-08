
namespace entity
{
    public class Hand
    {
        protected readonly Orientation orientation;
        public Hand(Orientation o)
        {
            if (o == Orientation.LEFT || o == Orientation.RIGHT)
            {
                orientation = o;
            }
            else
            {
                // default to right
                orientation = Orientation.RIGHT;
            }
        }

        public Orientation GetOrientation()
        {
            return orientation;
        }
    }

    public enum Orientation
    {
        LEFT,
        RIGHT
    }
}