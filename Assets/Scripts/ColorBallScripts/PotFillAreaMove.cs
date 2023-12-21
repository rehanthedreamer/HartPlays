﻿using UnityEngine;
using System.Collections;

public class PotFillAreaMove : MonoBehaviour
{


	public CameraAnchor CamAncher;
	public float PotMovingSpeed;
	// Use this for initialization
	void Start ()
	{

		CamAncher = this.GetComponent<CameraAnchor> ();
	}

	// Update is called once per frame
	void Update ()
	{
		if (GameManager.PotMove == true) {
			if (CamAncher.anchorType == CameraAnchor.AnchorType.LeftTop || CamAncher.anchorType == CameraAnchor.AnchorType.LeftCenter || CamAncher.anchorType == CameraAnchor.AnchorType.LeftBottom) {
				CamAncher.anchorOffset.y += Time.deltaTime * PotMovingSpeed;
			}
			if (CamAncher.anchorType == CameraAnchor.AnchorType.RightTop || CamAncher.anchorType == CameraAnchor.AnchorType.RightCenter || CamAncher.anchorType == CameraAnchor.AnchorType.RightBottom) {
				CamAncher.anchorOffset.y -= Time.deltaTime * PotMovingSpeed;
			}
			if (CamAncher.anchorType == CameraAnchor.AnchorType.TopRight || CamAncher.anchorType == CameraAnchor.AnchorType.TopCenter || CamAncher.anchorType == CameraAnchor.AnchorType.TopLeft) {
				CamAncher.anchorOffset.x += Time.deltaTime * PotMovingSpeed;
			}
			if (CamAncher.anchorType == CameraAnchor.AnchorType.BottomRight || CamAncher.anchorType == CameraAnchor.AnchorType.BottomCenter || CamAncher.anchorType == CameraAnchor.AnchorType.BottomLeft) {
				CamAncher.anchorOffset.x -= Time.deltaTime * PotMovingSpeed;
			}
		}
	}

	void OnTriggerEnter2D (Collider2D coll)
	{	
		if (coll.gameObject.tag == "LeftTopColider" && CamAncher.anchorType == CameraAnchor.AnchorType.LeftCenter) {
			Vector3 temp = transform.rotation.eulerAngles;
			temp.z += -90f;
			transform.rotation = Quaternion.Euler (temp);
			CamAncher.anchorType = CameraAnchor.AnchorType.TopCenter;
			CamAncher.anchorOffset.y = -0.3f;
			CamAncher.anchorOffset.x = -2.30f;
		
		}
		if (coll.gameObject.tag == "TopRightCollider" && CamAncher.anchorType == CameraAnchor.AnchorType.TopCenter) {
			Vector3 temp = transform.rotation.eulerAngles;
			temp.z += -90f;
			transform.rotation = Quaternion.Euler (temp);
			CamAncher.anchorType = CameraAnchor.AnchorType.RightCenter;
			CamAncher.anchorOffset.y = 4.5f;
			CamAncher.anchorOffset.x = 2.5125f;

		}
		if (coll.gameObject.tag == "RightBottomCollider" && CamAncher.anchorType == CameraAnchor.AnchorType.RightCenter) {
			Vector3 temp = transform.rotation.eulerAngles;
			temp.z += -90f;
			transform.rotation = Quaternion.Euler (temp);
			CamAncher.anchorType = CameraAnchor.AnchorType.BottomCenter;
			CamAncher.anchorOffset.y = 0.3f;
			CamAncher.anchorOffset.x = 2.35f;

		}
		if (coll.gameObject.tag == "BottomLeftCollider" && CamAncher.anchorType == CameraAnchor.AnchorType.BottomCenter) {
			Vector3 temp = transform.rotation.eulerAngles;
			temp.z += -90f;
			transform.rotation = Quaternion.Euler (temp);
			CamAncher.anchorType = CameraAnchor.AnchorType.LeftCenter;
			CamAncher.anchorOffset.y = -4.5f;
			CamAncher.anchorOffset.x = -2.5125f;

		}

	}
}
