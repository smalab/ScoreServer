using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class getDropdown : MonoBehaviour {
    public static int player_grade;
    public Dropdown DropDown ;

    public void Update()
    {
        DropDown = GetComponent<Dropdown>();
   
    }

    public void getDrop()
    {
        
        getDropdown.player_grade = DropDown.value;
        Debug.Log(getDropdown.player_grade);
    }

}
