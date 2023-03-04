using Sirenix.OdinInspector;
using UnityEngine;

public class GridController : MonoBehaviour
{
	[SerializeField] private Vector3Int _boardSize;
	[SerializeField] private float _cellSize;


	[Button]
	private void FakeInitBoard()
	{
		var index = 0;
		var offset = -(Vector3)_boardSize / 2f + Vector3.up;
		offset.z = _cellSize / 2f;
		for (int i = 0; i < _boardSize.x; i++)
		{
			for (int j = 0; j < _boardSize.y; j++)
			{
				var tile = GameManager.Instance.ObjectPooler.InstantiateTile();
				tile.SetInfo(GameManager.Instance.SpriteCollection.GetTileSprite(index));
				index++;
				tile.transform.position = new Vector3(i, j, 0) + offset;
			}
		}
	}

	private void OnDrawGizmosSelected()
	{
		var offset = Vector3.one * _cellSize / 2f - (Vector3)_boardSize / 2f;
		offset.z = _cellSize / 2f;
		Gizmos.color = Color.green;
		for (int x = 0; x < _boardSize.x; x++)
		{
			for (int y = 0; y < _boardSize.y; y++)
			{
				for (int z = 0; z < _boardSize.z; z++)
				{
					Gizmos.DrawWireCube(new Vector3(x, y, z) + offset,
						Vector3Int.one);
				}
			}
		}
	}
}