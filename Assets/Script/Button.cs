using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {
	public int identifier;

	private SpriteRenderer SpRender;
	public Sprite on,off;
	public bool gantiButton;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		if(identifier == 0){
			Application.LoadLevel("Gameplay");
			tesSwipe.Lost=0;

		}
		if(identifier == 1){
			Application.LoadLevel("MainMenu");
		}
		if(identifier == 2){
			Application.LoadLevel("About");
		}
		if(identifier == 3){
			SpRender = GetComponent<SpriteRenderer>();
			Database.LoadMusOp();
			if(Database.musop){
				this.gameObject.GetComponent<SpriteRenderer>().sprite = off;
				Database.musop = false;
			} else {
				this.gameObject.GetComponent<SpriteRenderer>().sprite = on;
				Database.musop = true;
			}
			Database.SaveMusOp();
		}
		if(identifier == 4){
			Application.Quit();
		}
	}
}
