using UnityEngine;
using System.Collections;

public class lx_move : MonoBehaviour
{

	private Vector3 _vec3TargetScreenSpace;// 目标物体的屏幕空间坐标
	private Vector3 _vec3TargetWorldSpace;// 目标物体的世界空间坐标
	private Transform _trans;// 目标物体的空间变换组件
	private Vector3 _vec3MouseScreenSpace;// 鼠标的屏幕空间坐标
	private Vector3 _vec3Offset;// 偏移
	private float y = 30f;
	Material material;
	void Awake() { _trans = transform; }
	public void lx_up()
	{
		//Debug.Log(transform.position);
		if (transform.position.y <= 65.0f)
		{
			transform.position = transform.position + new Vector3(0f, 0.5f, 0f);


			foreach (Transform child in transform)
			{
				if (child.name == "lx_2")
				{
					//Debug.Log(child.position);
					child.position = new Vector3(29.9f, child.position.y, -10.9f);
					foreach (Transform child1 in child)
					{
						if (child1.name == "lx_3")
						{
							Debug.Log("1" + child1.position);
							child1.position = new Vector3(29.9f, child1.position.y, -2.5f);
							child1.localScale = new Vector3(0.04f, 0.12f, 1.0f);
						}
						if (child1.name == "lx_4")
						{
							material = child1.GetComponent<Renderer>().material;
							material.mainTextureOffset = new Vector2(0f, 0f);
							//move.movement = new Vector2(0f, 0f);
							//child.localScale = new Vector3(0f, 0.1f, 1.0f);
						}

					}
				}


			}

		}
	}
	public void lx_down()
	{
		//Debug.Log(transform.position);
		if (transform.position.y >= 60.0f)
		{
			transform.position = transform.position + new Vector3(0f, -0.5f, 0f);


			foreach (Transform child in transform)
			{
				if (child.name == "lx_2")
				{
					//Debug.Log(child.position);
					child.position = new Vector3(29.9f, child.position.y, - 10.9f);
					foreach (Transform child1 in child)
					{
						if (child1.name == "lx_3")
						{
							Debug.Log("1" + child1.position);
							child1.position = new Vector3(29.9f, child1.position.y, -2.5f);
							child1.localScale = new Vector3(0.04f, 0.12f, 1.0f);
						}
						if (child1.name == "lx_4")
						{
							material = child1.GetComponent<Renderer>().material;
							material.mainTextureOffset = new Vector2(0f, 0f);
							//child.localScale = new Vector3(0f, 0.1f, 1.0f);
						}

					}
				}


			}
		}
		// 等待固定更新 


	}
}