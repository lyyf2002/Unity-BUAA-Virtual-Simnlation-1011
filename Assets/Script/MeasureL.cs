using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeasureL : MonoBehaviour
{
    public GameObject holder;
    public GameObject measureL_ruler;
    private Vector3 ruler_position;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ruler_position = new Vector3(holder.transform.position.x + 28,
                                     measureL_ruler.transform.position.y,
                                     measureL_ruler.transform.position.z);
        measureL_ruler.transform.position = ruler_position;
    }
}
