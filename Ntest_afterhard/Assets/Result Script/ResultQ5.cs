using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ResultQ5 : MonoBehaviour
{
    public Text rltQ5;
    public string ResQ5;
    // Use this for initialization
    void Start()
    {

        if (AnsQ5.q5Ans == 1)
        {
            ResQ5 = "〇";
        }
        else
        {
            ResQ5 = "×";
        }

        rltQ5.text = ResQ5;

    }
}