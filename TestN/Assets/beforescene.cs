using UnityEngine;
using System.Collections;

public class beforescene : MonoBehaviour {
	public int before;

public void Bottunclick(){
	
		Application.LoadLevel (before);
	}

}
