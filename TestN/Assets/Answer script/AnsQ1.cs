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
        AnsQ1.q2 = DropDown2.value;
        if (AnsQ1.q1 == 4)
        {
            AnsQ1.q1 = 1;
            TotalResult.T_ans++;
        }
        else
        {
            AnsQ1.q1 = 0;
        }

        if(AnsQ1.q2 == 2)
        {
            AnsQ1.q2 = 1;
            TotalResult.T_ans++;
        }
        else
        {
            AnsQ1.q2 =0;
        }
     
        Debug.Log(AnsQ1.q1);
        Debug.Log(AnsQ1.q2);
    }

}
