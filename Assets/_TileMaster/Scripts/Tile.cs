using Datas;
using Sirenix.OdinInspector;
using UnityEngine;

public class Tile : MonoBehaviour
{
	[SerializeField] private SpriteRenderer _spriteRenderer;

	public void SetInfo(Sprite sprite)
	{
		_spriteRenderer.sprite = sprite;
	}

	[Button]
	public void Destroy()
	{
		GameManager.Instance.ObjectPooler.DestroyTile(gameObject);
	}

#if UNITY_EDITOR
	[SerializeField] private int currentIndex;
	[SerializeField] private SpriteCollection _collection;

	[Button]
	private void PrevSprite()
	{
		currentIndex--;
		if (currentIndex < 0)
			currentIndex = _collection.GetTileSpriteLength() - 1;
		SetInfo(_collection.GetTileSprite(currentIndex));
	}

	[Button]
	private void NextSprite()
	{
		currentIndex++;
		if (currentIndex >= _collection.GetTileSpriteLength())
			currentIndex = 0;
		SetInfo(_collection.GetTileSprite(currentIndex));
	}
#endif
}