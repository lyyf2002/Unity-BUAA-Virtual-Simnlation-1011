using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mirrorCamera : MonoBehaviour
{
    public GameObject telescope;
    public GameObject mirror;
    public GameObject wire;
    private Vector3 telescopePosition;
    private float curz;
    private float cury;
    //public Text number;
    public int numberOfFama;
    private float y0 = 44f;
    //public Camera telescopecamera;
    // Start is called before the first frame update
    void Start()
    {
        //telescopePosition = new Vector3((mirror.transform.position.x + wire.transform.position.x) / 2f, 40f, ((mirror.transform.position.z + wire.transform.position.z) / 2f));
    }

    // Update is called once per frame
    void Update()
    {
        curz = -2 * (telescope.transform.position.z - 5.5f);
        cury = 3 * y0 - 2 * (telescope.transform.position.y - 8f) + 10f;
        if (6 - telescope.transform.position.z < (mirror.transform.position.z - 3) + 5 && 6 - telescope.transform.position.z > (mirror.transform.position.z - 3) - 5 && 2 * y0 - (telescope.transform.position.y - 8f) < (mirror.transform.position.y + 2 + 5f) && 2 * y0 - (telescope.transform.position.y - 8f) > (mirror.transform.position.y + 2 - 5f))
        {

        }
        else
        {
            curz = 50f;
            cury = 70f;
        }


        numberOfFama = GameObject.Find("Light2").GetComponent<FamaSystem>().numberOfFama;
        telescopePosition = new Vector3(20f, cury, curz);

        transform.Translate(telescopePosition - this.transform.position, Space.World);

    }
}
