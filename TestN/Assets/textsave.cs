using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class textsave : MonoBehaviour {

   public static string player;
	public static int glade;
    public InputField inputField;
	public Dropdown DropDown1;

	public void start(){
		DropDown1 = GetComponent<Dropdown> ();
	}
    public void save () {
       textsave.player = inputField.text;
		glade = DropDown1.value;
        Debug.Log(textsave.player);
    }
    }