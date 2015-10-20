using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AnsQ5 : MonoBehaviour
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

    public void Update()
    {
        DropDown1 = GetComponent<Dropdown>();
        DropDown2 = GetComponent<Dropdown>();
        DropDown3 = GetComponent<Dropdown>();
        DropDown4 = GetComponent<Dropdown>();
        DropDown5 = GetComponent<Dropdown>();
    }

    public void getAns()
    {
        AnsQ5.q1 = DropDown1.value;
        AnsQ5.q2 = DropDown2.value;
        AnsQ5.q3 = DropDown3.value;
        AnsQ5.q4 = DropDown4.value;
        AnsQ5.q5 = DropDown5.value;

        Debug.Log(AnsQ5.q1);
        Debug.Log(AnsQ5.q2);
        Debug.Log(AnsQ5.q3);
        Debug.Log(AnsQ5.q4);
        Debug.Log(AnsQ5.q5);
    }

}
