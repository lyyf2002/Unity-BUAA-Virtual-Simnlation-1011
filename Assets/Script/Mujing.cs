using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Mujing : MonoBehaviour
{
    public float mujing = 0.1f;
    public Image chasi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        chasi.GetComponent<Image>().color = new Color(255, 255, 255,((mujing<0)?(-mujing):mujing));

        
    }

    /*public void OnPointerClick(PointerEventData eventData)
    {
        if(mujing >= 1f)
        {
            mujing = -0.9f;
        }
        else
        {
            mujing += 0.1f;
        }
    }*/
    IEnumerator OnMouseOver()

    {
        if (Input.GetMouseButtonDown(0))
        {
            if (mujing >= 1f)
            {
                mujing = -0.9f;
            }
            else
            {
                mujing += 0.1f;
            }
            Debug.Log("left");
            yield return new WaitForFixedUpdate();
        }
        if (Input.GetMouseButtonDown(1))
        {
            if (mujing <= -1f)
            {
                mujing = 0.9f;
            }
            else
            {
                mujing -= 0.1f;
            }
            Debug.Log("right");
            yield return new WaitForFixedUpdate();
        }
    }

}
