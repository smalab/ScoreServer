using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AnsQ2_h : MonoBehaviour
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
		q1 = DropDown1.value;

		q2 = DropDown2.value;
	
		
		if (q1 == 1)
		{
			q1 = 1;

		}
		else
		{
			q1 = 0;
		}
		
		if (q2 == 5) 
		{
			q2 = 1;
	
		} 
		else 
		{
			q2 = 0;
		}
		
		Debug.Log(q1);
		Debug.Log(q2);
	}
}
