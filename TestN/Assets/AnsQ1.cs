﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AnsQ1 : MonoBehaviour
{
    public static int q1;
    public static int q2;
    public Dropdown DropDown1;
    public Dropdown DropDown2;

    public void Update()
    {
        DropDown1 = GetComponent<Dropdown>();
        DropDown2 = GetComponent<Dropdown>();
    }

    public void getAns()
    {
        AnsQ1.q1 = DropDown1.value;
        AnsQ1.q2 = DropDown2.value;
        Debug.Log(AnsQ1.q1);
        Debug.Log(AnsQ1.q2);
    }

}
