using System;
using Sirenix.Utilities;
using UnityEngine;

namespace Datas
{
	[CreateAssetMenu(fileName = "SpriteCollection", menuName = "Data/SpriteCollection", order = 0)]
	public class SpriteCollection : ScriptableObject
	{
		[SerializeField] private Sprite[] _tileSprites;

		public Sprite GetTileSprite(int index)
		{
			if (_tileSprites.IsNullOrEmpty())
				throw new NullReferenceException("Tile Sprites is null");
			index = index % _tileSprites.Length;
			return _tileSprites[index];
		}

		public int GetTileSpriteLength()
		{
			return _tileSprites.Length;
		}
	}
}