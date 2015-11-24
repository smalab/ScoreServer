using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AnsQ2 : MonoBehaviour
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
        AnsQ2.q1 = DropDown1.value;
        AnsQ2.q2 = DropDown2.value;

		TotalResult.totalQ++;
		TotalResult.totalQ++;
        if (AnsQ2.q1 == 1)
        {
            AnsQ2.q1 = 1;

        }
        else
        {
            AnsQ2.q1 = 0;
        }

        if (AnsQ2.q2 == 5)
        {
            AnsQ2.q2 = 1;

        }
        else
        {
            AnsQ2.q2 = 0;
        }
        Debug.Log(AnsQ2.q1);
        Debug.Log(AnsQ2.q2);
    }

}
