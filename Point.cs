namespace Program
{
    public class Point
    {
        public int X; 
        public int Y;

        public Point (int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocatioon)
        {
            if (newLocatioon == null)
            {
                throw new ArgumentNullException(nameof(newLocatioon));      // Defensive Programming --> if this is null, then the next line is never reached
            }
            Move(newLocatioon.X,newLocatioon.Y);    
        }
    }
}