using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move : MonoBehaviour
{
    // Start is called before the first frame update

    //private float speed = 1.0f, speedd = 0.5f;

    Material material;
    public Vector2 movement;
    public Vector2 speed;
    public Button button;
    public Text tt;
    Vector3 moveDirection = Vector3.forward;
    Vector3 moveDirection2 = Vector3.right;
    Vector3 mem1, mem2, mem3;
    //GameObject x = GameObject.Find("measureCamera_d");
    //Camera measureCamera_d = x;
    //Debug.Log("1     " + A.x);
    //Debug.Log("3     "+child.position.x);
    //Debug.Log(child.name);


    void Start()
    {

        foreach (Transform child in transform)
        {
            
            if (child.name == "lx_4")
            {
                material = child.GetComponent<Renderer>().material;
                material.mainTextureOffset = new Vector2(0f, 0f);
            }

        }
        Debug.Log(transform.position);
        foreach (Transform child in transform)
        {
            if (child.name == "lx_3")
            {
                 Debug.Log(child.position);
                Debug.Log(child.localScale);
            }
         

        }
        //button = GameObject.Find("Button_object").GetComponent<Button>();
        //tt = button.transform.Find("Text").GetComponent<Text>();
        ///tt.text = "平移";
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 A = moveDirection * 0.002f * 1.0f;
        Vector3 B = moveDirection2 * 0.002f * 0.5f;


       
        if (Input.GetButton("Fire1"))
        {
            
            //Vector3 C;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 vec = transform.InverseTransformPoint(transform.position);

            RaycastHit hit;

            //Debug.Log("1     ");

            if (Physics.Raycast(ray, out hit))
            {
                //Debug.Log("2     ");
                if (hit.collider.gameObject == gameObject &&transform.position.z <-8.25)
                {
                    //Debug.Log("3     ");
                    //Debug.Log("1     ");
                    transform.position +=  A;
                    Debug.Log("2     "+transform.position);
                    foreach (Transform child in transform)
                    {
                        if (child.name == "lx_3")
                        {
                           // Debug.Log("1 ");

                            child.position = child.position - A / 2;
            
                            child.localScale += B/5;
                        }
                        if(child.name == "lx_4")
                        {
                            movement += speed * Time.deltaTime;
                            //Debug.Log(movement);
                            material.mainTextureOffset = new Vector2(0f, transform.position.z * 10 + Random.Range(0.07f, 0.11f));
                            //Debug.Log(material.mainTextureOffset);
                        }
                        
                    }
                    
                }
            }
        }
    }

  
}
