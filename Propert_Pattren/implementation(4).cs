public Class Implement
{
   public List<Ishape> cloneShapes(List<Ishape> shapes)
   {
    List<Ishape> clonedShapes = new List<Ishape>();
    foreach(Ishape shape in shapes)
    {
        clonedShapes.Add(shape.Clone());
    }
    return clonedShapes;
   }
}