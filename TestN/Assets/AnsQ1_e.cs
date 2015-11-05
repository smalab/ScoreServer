using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AnsQ1_e : MonoBehaviour
{
	public static int q1;
	public static int q2;
	public static int q3;
	public static int q4;
	public static int q5;

	public Dropdown DropDown1;
	public Dropdown DropDown2;
	public Dropdown DropDown3;
	public Dropdown DropDown4;
	public Dropdown DropDown5;
	
	public void start()
	{
		DropDown1 = GetComponent<Dropdown>();
		DropDown2 = GetComponent<Dropdown>();
		DropDown3 = GetComponent<Dropdown>();
		DropDown4 = GetComponent<Dropdown>();
		DropDown5 = GetComponent<Dropdown>();
	}
	
	public void getAns()
	{
		AnsQ1_e.q1 = DropDown1.value;
		AnsQ1_e.q2 = DropDown2.value;
		AnsQ1_e.q3 = DropDown3.value;
		AnsQ1_e.q4 = DropDown4.value;
		AnsQ1_e.q5 = DropDown5.value;
		if (q1 == 1)
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
		if (q4 == 5)
		{
			q4 = 1;
			TotalResult.T_ans++;
		}
		else
		{
			q4 = 0;
		}
		if (q5 == 2)
		{
			q5 = 1;
			TotalResult.T_ans++;
		}
		else
		{
			q5 = 0;
		}
		
		Debug.Log(AnsQ1.q1);
		Debug.Log(AnsQ1.q2);
	}
	
}