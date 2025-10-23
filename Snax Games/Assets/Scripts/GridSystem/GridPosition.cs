// Represents a position in the grid
public struct GridPosition
{

    public int x;
    public int z;

    public GridPosition(int x, int z)
    {
        this.x = x;
        this.z = z;
    }
    public override string ToString()
    {
        return $"X: {x}, Z: {z}";
    }

    // Override GetHashCode so its easier to use GridPosition
    public override int GetHashCode()
    {
        return (x, z).GetHashCode();
    }
}
