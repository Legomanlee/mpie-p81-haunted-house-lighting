using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLight : MonoBehaviour
{
    private Light flicker;
    float interval = 0.001f;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        flicker = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > interval && flicker.intensity < 10 && flicker.intensity > 0){
            flicker.intensity = flicker.intensity + Random.Range(0.1f, 1f) - Random.Range(0.1f, 1f);
            timer = 0;
        }
        if(timer > interval && flicker.intensity > 10){
            flicker.intensity = flicker.intensity - Random.Range(1f, 5f);
            timer = 0;
        }
        if(timer > interval && flicker.intensity < 1){
            flicker.intensity = flicker.intensity + Random.Range(1f, 5f);
            timer = 0;
        }
    }
}
