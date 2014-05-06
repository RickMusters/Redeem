using UnityEngine;
using System.Collections;

public class CursorScript : MonoBehaviour {

	// Use this for initialization
	public Texture2D yourCursor;
	public float lol;
	private float cursorSizeX = 30f;
	private float cursorSizeY = 30f;
	void Start () 
	{
		Screen.showCursor = false;
	}
	
	// Update is called once per frame
	void OnGUI () 
	{
		Rect positions = new Rect(Event.current.mousePosition.x - cursorSizeX/2, Event.current.mousePosition.y- cursorSizeY/2, cursorSizeX, cursorSizeY);
		GUI.DrawTexture(positions,yourCursor);
	}
}
