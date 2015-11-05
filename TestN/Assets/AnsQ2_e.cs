using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AnsQ2_e : MonoBehaviour
{
	public static int q1;
	public static int q2;
	public static int q3;
	public static int q4;

	
	public Dropdown DropDown1;
	public Dropdown DropDown2;
	public Dropdown DropDown3;
	public Dropdown DropDown4;

	
	public void start()
	{
		DropDown1 = GetComponent<Dropdown>();
		DropDown2 = GetComponent<Dropdown>();
		DropDown3 = GetComponent<Dropdown>();
		DropDown4 = GetComponent<Dropdown>();

	}
	
	public void getAns()
	{
		AnsQ2_e.q1 = DropDown1.value;
		AnsQ2_e.q2 = DropDown2.value;
		AnsQ2_e.q3 = DropDown3.value;
		AnsQ2_e.q4 = DropDown4.value;

		if (q1 == 2)
		{
			q1 = 1;
			TotalResult.T_ans++;
		}
		else
		{
			q1 = 0;
		}
		
		if(q2 == 3)
		{
			q2 = 1;
			TotalResult.T_ans++;
		}
		else
		{
			q2 =0;
		}
		if (q3 == 1)
		{
			q3 = 1;
			TotalResult.T_ans++;
		}
		else
		{
			q3 = 0;
		}
		if (q4 == 1)
		{
			q4 = 1;
			TotalResult.T_ans++;
		}
		else
		{
			q4 = 0;
		}

		
		Debug.Log(q1);
		Debug.Log(q2);
	}
}