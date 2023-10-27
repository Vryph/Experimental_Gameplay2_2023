using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraSettings : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Resolution[] resolutions = Screen.resolutions;

        foreach (var res in resolutions)
        {
            Debug.Log(res.width + "w" + res.height + "h : " + res.refreshRate);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Screen.SetResolution(640, 480, true);
        if (Input.GetKeyDown(KeyCode.C))
       { 
            Screen.SetResolution(640, 480, true);

            for (int i = 0; i < 5; i++)
            {
                Debug.Log(Screen.currentResolution);
            }

       }
    }
}
