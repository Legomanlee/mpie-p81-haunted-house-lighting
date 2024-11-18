using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchPower : MonoBehaviour
{
    private Light torch;

    // Start is called before the first frame update
    void Start()
    {
        torch = GetComponent<Light>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)){
            torch.enabled = !torch.enabled;
        }

    }
}
