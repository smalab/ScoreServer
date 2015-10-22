using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AnsQ1 : MonoBehaviour
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
        AnsQ1.q1 = DropDown1.value;
        if (AnsQ1.q1 == 3)
        {
            AnsQ1.q1 = 1;
        }
        else
        {
            AnsQ1.q1 = 0;
        }

        if(AnsQ1.q2 == 1)
        {
            AnsQ1.q2 = 1;
        }
        else
        {
            AnsQ1.q2 =0;
        }
        AnsQ1.q2 = DropDown2.value;
        Debug.Log(AnsQ1.q1);
        Debug.Log(AnsQ1.q2);
    }

}
