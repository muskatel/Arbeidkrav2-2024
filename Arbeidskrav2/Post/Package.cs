namespace Arbeidskrav2.Post;

public class Package
{
    
    public string Description { get; set; }
    public int Weight { get; set; }
    private List<int> dimensions;

    public Package(string description, List<int> dimensions)
    {
        this.Description = description;
        this.Dimensions = dimensions;
    }

    /// <summary>
    /// Returns the dimension of the item in descending order of sizes.
    /// </summary>
    public List<int> Dimensions
    {
        get => dimensions;
        set
        {
            // Sort values after we create a package
            // This helps further down the line when comparing packing options
            dimensions = value;
            dimensions.Sort();
            dimensions.Reverse();
        }
    }


    public override string ToString()
    {
        return Description;//  + "\n"  + dimensions[0] + "mm x " + dimensions[1] + "mm x " + dimensions[2] + "mm - " + Weight+ "g";
    }
}