using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
	public GameObject mainCamera;
	public GameObject measureCamera_d;
	public GameObject measureCamera_L;
	public GameObject measureCamera_L2;
	// Start is called before the first frame update
	void Start()
	{
		mainCamera.SetActive(true);
		measureCamera_d.SetActive(false);
		measureCamera_L.SetActive(false);
		measureCamera_L2.SetActive(false);
	}
	public void changeToMainCamera()
	{
		mainCamera.SetActive(true);
		measureCamera_d.SetActive(false);
		measureCamera_L.SetActive(false);
		measureCamera_L2.SetActive(false);
	}
	
	public void changeTomeasureCamera_d()
	{
		mainCamera.SetActive(false);
		measureCamera_d.SetActive(true);
		measureCamera_L.SetActive(false);
		measureCamera_L2.SetActive(false);
	}
	public void changeTomeasureCamera_L()
	{
		mainCamera.SetActive(false);
		measureCamera_d.SetActive(false);
		measureCamera_L.SetActive(true);
		measureCamera_L2.SetActive(false);
	}
	public void changeTomeasureCamera_L2()
	{
		mainCamera.SetActive(false);
		measureCamera_d.SetActive(false);
		measureCamera_L.SetActive(false);
		measureCamera_L2.SetActive(true);
	}

}
