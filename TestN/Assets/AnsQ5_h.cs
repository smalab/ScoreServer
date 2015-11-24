using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AnsQ5_h : MonoBehaviour
{
	public static int q1;
	public static int q2;
	public static int q3;
	public static int q4;
	public static int q5;
	
	public static int q=0;
	
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
		      q1 = DropDown1.value;
		      q2 = DropDown2.value;
		      q3 = DropDown3.value;
			  q4 = DropDown4.value;
 			  q5 = DropDown5.value;

		
		if (q1==3&&q2 ==4&&q3 ==4 && q4 ==2 && q5==5)
		{
			q =1;

		}

	}
	
}
