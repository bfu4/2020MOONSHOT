
namespace meta 
{
    // essentially just a data class
    public class Dimension
    {
        public int width;
        public int length;
        public int height;
        
        public Dimension(int w, int l, int h)
        {
            width = w;
            length = l;
            height = h;
        }

        void AddToWidth(int amount)
        {
            width += amount;
        }

        void AddToLength(int amount)
        {
            length += amount;
        }

        void AddToHeight(int amount)
        {
            height += amount;
        }
    }
}