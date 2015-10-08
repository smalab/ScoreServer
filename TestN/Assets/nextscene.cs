using UnityEngine;
using System.Collections;

public class nextscene : MonoBehaviour
{
    public void ClickTest()
    {
        Application.LoadLevel("Nodatest_2");
        Debug.Log("Clicked.");
    }
}