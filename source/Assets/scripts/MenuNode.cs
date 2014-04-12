using UnityEngine;
using System.Collections;

public class MenuNode : MonoBehaviour {
	//public GameObject prevNode; // if the user "moves left" cycle to this node
	//public GameObject nextNode; // if the user "moves right" cycle to this node
	public GameObject pointer;
	public string sceneName; // the scene to load
	//public bool initialNode; // specify that this is the initial node

	private bool _selected;

	// Use this for initialization
	void Start () {
		//_selected = initialNode;		
        _selected = false;
		pointer.renderer.material.color = Color.blue;
	}
	
	// Update is called once per frame
	void Update () {        
        /*
		if(_selected) {
			if(Input.GetButtonDown ("Horizontal")) {
				// "Left"
				if(Input.GetAxis("Horizontal") < 0 && prevNode != null) {
					// switch selection to prevNode
					prevNode.GetComponent<MenuNode>().SetSelected();
					_selected = false;
				}
				// "Right"
				else if(Input.GetAxis ("Horizontal") > 0 && nextNode != null) {
					// switch selection to nextNode
					nextNode.GetComponent<MenuNode>().SetSelected();
					_selected = false;
				}
			}
			else if(Input.GetKeyDown ("return") && sceneName != string.Empty) {
				// change to the scene
				Application.LoadLevel (sceneName);
			}
			else if(Input.GetKeyDown ("return")) {
				Debug.Log ("return hit!");
			}
		}
        */

        if (Input.GetMouseButtonDown(0) && _selected && sceneName != string.Empty)
        {
            Application.LoadLevel(sceneName);
        }
	}


	void SetSelected() {
		_selected = true;
	}

    void OnMouseOver()
    {
        //this.renderer.material.color = Color.red;
		pointer.renderer.material.color = Color.red;
        _selected = true;
    }

    void OnMouseExit()
    {
        //this.renderer.material.color = Color.blue;
		pointer.renderer.material.color = Color.blue;
        _selected = false;
    }
}
