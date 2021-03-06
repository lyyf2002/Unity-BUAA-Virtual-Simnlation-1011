using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_mirror : MonoBehaviour
{
    
	private Vector3 _vec3TargetScreenSpace;// 目标物体的屏幕空间坐标
	private Vector3 _vec3TargetWorldSpace;// 目标物体的世界空间坐标
	private Transform _trans;// 目标物体的空间变换组件
	private Vector3 _vec3MouseScreenSpace;// 鼠标的屏幕空间坐标
	private Vector3 _vec3Offset;// 偏移
	private float offset_x = -4.8f;
	private float offset_z = -12.8f;
	public GameObject holder;
	public GameObject telescope;
	void Awake() { _trans = transform; }

    private void Updata()
    {
		this.transform.Translate(new Vector3(holder.transform.position.x + offset_x,this.transform.position.y, holder.transform.position.z + offset_z));
       
	}
	IEnumerator OnMouseDown()

	{
		Debug.Log("in onmousedonw");
		// 把目标物体的世界空间坐标转换到它自身的屏幕空间坐标 

		_vec3TargetScreenSpace = Camera.main.WorldToScreenPoint(_trans.position);

		// 存储鼠标的屏幕空间坐标（Z值使用目标物体的屏幕空间坐标） 

		_vec3MouseScreenSpace = new Vector3(Input.mousePosition.x, Input.mousePosition.y, _vec3TargetScreenSpace.z);

		// 计算目标物体与鼠标物体在世界空间中的偏移量 

		_vec3Offset = _trans.position - Camera.main.ScreenToWorldPoint(_vec3MouseScreenSpace);

		// 鼠标左键按下 

		while (Input.GetMouseButton(0))
		{
			Debug.Log("getmousebutton");
			// 存储鼠标的屏幕空间坐标（Z值使用目标物体的屏幕空间坐标）

			_vec3MouseScreenSpace = new Vector3(Input.mousePosition.x, Input.mousePosition.y, _vec3TargetScreenSpace.z);

			// 把鼠标的屏幕空间坐标转换到世界空间坐标（Z值使用目标物体的屏幕空间坐标），加上偏移量，以此作为目标物体的世界空间坐标

			_vec3TargetWorldSpace = Camera.main.ScreenToWorldPoint(_vec3MouseScreenSpace) + _vec3Offset;

			// 更新目标物体的世界空间坐标 
			if(_vec3TargetWorldSpace.y > telescope.transform.position.y-9f)
            {
				_vec3TargetWorldSpace.y = telescope.transform.position.y-9f;

			}
			if(_vec3TargetWorldSpace.y < 31f)
            {
				_vec3TargetWorldSpace.y = 31f;

			}
			_trans.position = new Vector3(this.transform.position.x, _vec3TargetWorldSpace.y,this.transform.position.z);

			// 等待固定更新 

			yield return new WaitForFixedUpdate();
		}
	}
}
