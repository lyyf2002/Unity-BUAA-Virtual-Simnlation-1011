using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FamaSystem : MonoBehaviour
{
    public GameObject fama0;
    public GameObject fama1;
    public GameObject fama2;
    public GameObject fama3;
    public GameObject fama4;
    public GameObject fama5;
    public GameObject fama6;
    public GameObject fama7;
    public GameObject fama8;
    public GameObject fama9;
    public GameObject fama10;
    public GameObject fama11;
    public GameObject fama12;
    public GameObject fama13;
    public GameObject fama14; 
    public GameObject fama15; 
    public GameObject fama16;
    public GameObject fama17;
    public int numberOfFama = 0;
    private int maxNumber = 18;
    public List<GameObject> famaArray;
    private float un_x = 20f;
    private float un_y = 35.8f;
    private float un_z0 = 5f;
    private float did_x = 14f;
    private float did_y0 = 33.3f;
    private float did_z = 0.5f;
    private Vector3 un_Vector = new Vector3(90, 0, 0);
    private Vector3 did_Vector = new Vector3(0, 0, 0);
    private int i;
    public Text number;
    public float offset;
    // Start is called before the first frame update
    void Start()
    {
        famaArray.Add(fama0);
        famaArray.Add(fama1);
        famaArray.Add(fama2);
        famaArray.Add(fama3);
        famaArray.Add(fama4);
        famaArray.Add(fama5);
        famaArray.Add(fama6);
        famaArray.Add(fama7);
        famaArray.Add(fama8);
        famaArray.Add(fama9);
        famaArray.Add(fama10);
        famaArray.Add(fama11);
        famaArray.Add(fama12);
        famaArray.Add(fama13); 
        famaArray.Add(fama14); 
        famaArray.Add(fama15);
        famaArray.Add(fama16);
        famaArray.Add(fama17);
    }

    // Update is called once per frame
    void Update()
    {
        for (i = 0; i < numberOfFama; i++)
        {
            famaArray[i].transform.position = new Vector3(did_x, did_y0 + 0.5f * i,did_z);
            famaArray[i].transform.eulerAngles = did_Vector;
        }
        for (; i < maxNumber; i++)
        {
            famaArray[i].transform.position = new Vector3(un_x, un_y, un_z0 - 0.5f * i );
            famaArray[i].transform.eulerAngles = un_Vector;
        }
    }
    public void AddFama()
    {
        if(numberOfFama < maxNumber)
        {
            numberOfFama ++;
            number.text = numberOfFama.ToString();
            offset = Random.Range(-0.005f, 0.005f);
        }
         
    }
    public void SubFama()
    {
        if(numberOfFama > 0)
        {
            numberOfFama--;
            number.text = numberOfFama.ToString();
            offset = Random.Range(-0.005f, 0.005f);
        }
        
    }

}
