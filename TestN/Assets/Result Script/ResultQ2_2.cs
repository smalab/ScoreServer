﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ResultQ2_2 : MonoBehaviour
{
    // public GameObject ResultQ1.1;
    public Text rltQ2_2;
    public string ResQ2_2;
    // Use this for initialization
    void Start()
    {

        if (AnsQ2.q2 == 1)
        {
            ResQ2_2 = "〇";
      
            Debug.Log(TotalResult.T_ans);
        }
        else
        {
            ResQ2_2 = "×";
        }

        rltQ2_2.text = ResQ2_2;

    }
}