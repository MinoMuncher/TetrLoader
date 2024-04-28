using TetrLoader.JsonClass.Raw;

namespace TetrLoader.JsonClass.API;

public class UserSearch
{
	public bool? success { get; set; }
	public UserSearchData data { get; set; }
	public Cache cache { get; set; }
}

public class UserSearchData
{
	public User user { get; set; }
}