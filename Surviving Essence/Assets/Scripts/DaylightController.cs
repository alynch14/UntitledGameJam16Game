using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;
public class DaylightController : MonoBehaviour
{
    public GameManager gameManager;
    public UnityEngine.Experimental.Rendering.Universal.Light2D light;
    public int minutes;
    public float timeTotal;
    //public GameManager.instance.second timer;
    private float speed = 0.2f;
    //public bool shouldFadeToBlack, shouldFadeFromBlack;

    // Start is called before the first frame update
    void Start()
    {
        //GameManager.instance.second = 0f;
        timeTotal = minutes * 60f;
        light.intensity = 0f;
        light.color = Color.yellow;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.instance.second <= 20.0f)
        {
            light.intensity = Mathf.MoveTowards(light.intensity, 5, speed * Time.deltaTime);
            light.color = new Color(light.color.r, light.color.g, light.color.b, Mathf.MoveTowards(light.color.a, 0f, speed * Time.deltaTime)); ;
        }
        else if (GameManager.instance.second >= 40.0f)
        {
            light.intensity = Mathf.MoveTowards(light.intensity, 0, speed * Time.deltaTime);
        }
        GameManager.instance.second += Time.deltaTime;
        if(GameManager.instance.second > timeTotal)
        {
            GameManager.instance.day++;
            GameManager.instance.second = 0;
        }
    }

    //todo: pass day number and seconds to the gamemanager
}
