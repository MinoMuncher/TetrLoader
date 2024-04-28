namespace TetrLoader.JsonClass.Raw;

public class RawUser
{
	public bool? success { get; set; }
	public DataUser? data { get; set; }
	public Cache? cache { get; set; }
}

public class Cache
{
	public string status { get; set; }
	public long? cached_at { get; set; }
	public long? cached_until { get; set; }
}

public class DataUser
{
	public User? user { get; set; }
}