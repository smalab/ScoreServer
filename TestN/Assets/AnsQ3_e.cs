using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AnsQ3_e : MonoBehaviour
{
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
		AnsQ3_e.q1 = DropDown1.value;
		TotalResult.totalQ++;
		AnsQ3_e.q2 = DropDown2.value;
		TotalResult.totalQ++;
		if (q1 == 5)
		{
			q1 = 1;
			TotalResult.T_ans++;
		}
		else
		{
			q1 = 0;
		}
		
		if (q2 == 4)
		{
			q2 = 1;
			TotalResult.T_ans++;
		}
		else
		{
			q2 = 0;
		}
		Debug.Log(q1);
		Debug.Log(q2);
	}
	
}
