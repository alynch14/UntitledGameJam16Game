using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;
public class DaylightController : MonoBehaviour
{
    public UnityEngine.Experimental.Rendering.Universal.Light2D light;
    public int minutes;
    public float timeTotal, timer;
    private float speed = 0.2f;
    //public bool shouldFadeToBlack, shouldFadeFromBlack;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0f;
        timeTotal = minutes * 60f;
        light.intensity = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<=30.0f)
        {
            light.intensity = Mathf.MoveTowards(light.intensity, 5, 0.2f * Time.deltaTime);
        }
        else if (timer >= 40.0f)
        {
            light.intensity = Mathf.MoveTowards(light.intensity, 0, 0.2f * Time.deltaTime);
        }
        timer += Time.deltaTime;
    }

    //todo: pass day number and seconds to the gamemanager
}
