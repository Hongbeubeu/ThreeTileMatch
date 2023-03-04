using Ultimate.Core.Runtime.Pool;
using UnityEngine;

[CreateAssetMenu(fileName = "ObjectPooler", menuName = "Data/ObjectPooler")]
public class ObjectPooler : ScriptableObject
{
	[SerializeField] private Tile _tile;

	public Tile InstantiateTile()
	{
		return FastPoolManager.GetPool(_tile).FastInstantiate<Tile>();
	}

	public void DestroyTile(GameObject go)
	{
		FastPoolManager.GetPool(_tile).FastDestroy(go);
	}
}