namespace TetrLoader.JsonClass.Raw;

public class RawRecords
{
	public bool? success { get; set; }
	public DataRecords? data { get; set; }
	public Cache? cache { get; set; }
}

public class Record
{
	public override bool Equals(object? obj)
	{
		return _id == (obj as Record)?._id;
	}

	public override int GetHashCode()
	{
		return _id.GetHashCode();
	}

	public string? _id { get; set; }
	public List<EndContext>? endcontext { get; set; }
	public bool? ismulti { get; set; }
	public string? replayid { get; set; }
	public string? stream { get; set; }
	public DateTime? ts { get; set; }
	public User? user { get; set; }
}

public class DataRecords
{
	public List<Record>? records { get; set; }
}