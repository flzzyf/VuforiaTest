using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.Events;
using UnityEngine.UI;

[System.Serializable]
public class HitTestResultEvent : UnityEvent<HitTestResult> { }
public class EventTest : MonoBehaviour 
{
    public HitTestResultEvent clickEvent;

    int a = 5;

    public Text t;

    public void OnInteractiveHitTest(HitTestResult result)
    {
        if(a > 0)
        {
            a--;
            clickEvent.Invoke(result);

        }

    }

    public void Click()
    {
        //clickEvent.Invoke();
    }

    public void QWE()
    {
        Debug.Log("qwe");
    }

    public void ASD()
    {
        t.text = "点击";
    }
}
