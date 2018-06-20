using UnityEngine;
using Vuforia;
using UnityEngine.Events;
using UnityEngine.UI;

[System.Serializable]
public class HitTestResultEvent : UnityEvent<HitTestResult> { }
public class VuforiaManager : MonoBehaviour 
{
    public HitTestResultEvent clickEvent;

    public Text t;

    bool summoned = false;

    public void OnInteractiveHitTest(HitTestResult result)
    {
        if(!summoned)
        {
            summoned = true;
            clickEvent.Invoke(result);
        }
    }
	
    bool hit = false;
    public void Hit()
    {
        hit = true;
    }

    private void LateUpdate()
    {
        t.text = hit.ToString();

        hit = false;
    }
}
