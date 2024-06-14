using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swapSprites : MonoBehaviour
{
	[SerializeField] Sprite[] birdSprites;
	private Sprite newSprite;
	
	private void replaceBird2D()
	{
		newSprite = birdSprites[Random.Range(0, birdSprites.Length)];
	}
}
