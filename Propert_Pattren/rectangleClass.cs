public class Rectangle:Ishape
{
    private int width;
    private int height;

    public int getWidth()
    {
        return width;
    } 

    public int getHeight()
    {
        return height;
    }

    public Ishape Clone()
    {
        return new Rectangle(this.width,this.height);
    }
}
