using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AnsQ4_e : MonoBehaviour
{
	public static int q;
	public static int q1;
	public static int q2;
	public Dropdown DropDown1;
	public Dropdown DropDown2;
	
	public void start()
	{
		DropDown1 = GetComponent<Dropdown>();
		DropDown2 = GetComponent<Dropdown>();
	}
	
	public void getAns()
	{
		AnsQ4_e.q1 = DropDown1.value;
		AnsQ4_e.q2 = DropDown2.value;
		if (q1 == 3 && q2==2)
		{
			q = 1;
			TotalResult.T_ans++;
		}
		else
		{
			q = 0;
		}

		Debug.Log(q1);
		Debug.Log(q2);
	}
	
}
