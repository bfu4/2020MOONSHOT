
namespace meta 
{
    // another data class to allow sorting by importance
    // its too bad, i wanted constants i could grab from like java
    // but c# said fuck you
    public class Importance
    {

        public int level;

        public Importance(int lvl) 
        {
            level = lvl;
        }

        public void SetLevel(int lvl)
        {
            level = lvl;
        }

        public Importance Get() 
        {
            return this;
        }

        public int GetLevel() {
            return level;
        }
    }
}