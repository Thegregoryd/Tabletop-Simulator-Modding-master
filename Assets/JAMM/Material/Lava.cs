using UnityEngine;
using System.Collections;

public class Lava : MonoBehaviour 
{
	//public int materialIndex = 0;

	public Vector2 uvAnimationRate = new Vector2( 1.0f, 0.0f );
	public string textureName = "_MainTex";


	Vector2 uvOffset = Vector2.zero; //old

	public float twerk = 1;
	float scrollSpeed = 0.0025f;
	Renderer rend;

	void Start()
	{
		rend = GetComponent<Renderer>();
	}

	void Update()
	{
		float offset = Time.time * scrollSpeed * twerk;
		//uvoffset = Time.deltaTime * uvAnimationRate / 40;
		rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
	}



	/*
	void LateUpdate() 
	{
		uvOffset += ( uvAnimationRate /40 * Time.deltaTime );
		if( GetComponent<Renderer>().enabled )
		{
			GetComponent<Renderer>().sharedMaterial.SetTextureOffset( textureName, uvOffset );
		}
	}
	*/
}