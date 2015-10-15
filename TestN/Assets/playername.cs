using UnityEngine;
using System.Collections;

public class playername : MonoBehaviour {
    string pn;
	// Use this for initialization
	void Start () {
        pn = textsave.player();
        pn.text = "";
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
