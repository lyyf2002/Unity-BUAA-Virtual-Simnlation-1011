using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Wujing : MonoBehaviour
{
    public float wujing = -8f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("telescopeCamera").GetComponent<UnityStandardAssets.ImageEffects.BlurOptimized>().blurSize = (wujing < 0)?(-wujing):wujing;

    }
    
    IEnumerator OnMouseOver()

    {
        if (Input.GetMouseButtonDown(0))
        {
            if (wujing == 8f)
            {
                wujing = -7f;
            }
            else
            {
                wujing++;
            }
            yield return new WaitForFixedUpdate();
        }
        else if (Input.GetMouseButtonDown(1))
        {
            if (wujing == -8f)
            {
                wujing = 7f;
            }
            else
            {
                wujing--;
            }
            yield return new WaitForFixedUpdate();
        }
    }
}
