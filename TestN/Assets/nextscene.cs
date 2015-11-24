using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class nextscene : MonoBehaviour
{
	public Text caution;
	public static string error;
    public int next = 1;
    public void ClickTest()
    {
		if (textsave.player != "" && textsave.glade != 0) {
			Application.LoadLevel (next);
		}else{if (textsave.player =="") {
				error ="名前を入力してください。";

		}else{if (textsave.glade == 0) {
					error="学年を入力してください。";
				}
				caution.text=error;
			}
		}

	}}