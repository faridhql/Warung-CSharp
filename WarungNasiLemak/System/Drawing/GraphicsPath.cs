namespace System.Drawing
{
    internal class GraphicsPath
    {
        private Rectangle rectangle;
        private int v;

        public GraphicsPath(Rectangle rectangle, int v)
        {
            this.rectangle = rectangle;
            this.v = v;
        }
    }
}