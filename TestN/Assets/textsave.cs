using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class textsave : MonoBehaviour {

   public static string player;
    public InputField inputField;
    public Text text;

    public void save () {
       textsave.player = inputField.text;
        text.text = textsave.player;
        inputField.text = "";
    }
    }