using Datas;
using Ultimate.Core.Runtime.Singleton;

public class GameManager : Singleton<GameManager>
{
	#region Properties

	public SpriteCollection SpriteCollection;
	public ObjectPooler ObjectPooler;

	#endregion

	public override void Init()
	{
	}
}