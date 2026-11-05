
public Class Circle:Ishape
{
    private int length;

    public int getLength()
    {
        return length;
    }

    public Ishape Clone()
    {
        return new Circle(this.length);
    }
}