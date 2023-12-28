using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCheck : MonoBehaviour
{
    public GameObject mark;
    LineRenderer lineRenderer;
    int index = 0;
    IEnumerator timeChecker()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(0.5f);
            GameObject marked = Instantiate(mark,
            gameObject.transform.position, gameObject.transform.rotation);
            lineRenderer.positionCount++;
            lineRenderer.SetPosition(index, marked.transform.position);
            index++;
        }
    }
    void Start()
    {
        StartCoroutine(timeChecker());
        lineRenderer = GetComponent<LineRenderer>();
    }
}
