using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoyStick_Change : MonoBehaviour {

	private Transform img;
	private Transform trs;
	private Image img2;

	public Canvas parent;

	// Use this for initialization
	void Start () {
		img2 = this.GetComponent<Image>();
	}

	// Update is called once per frame
	void Update () {

	}

	void  FixedUpdate(){
		if (Input.GetMouseButtonDown(0)) {
			Vector2 pos2;

			RectTransformUtility.ScreenPointToLocalPointInRectangle (parent.transform as RectTransform, Input.mousePosition, parent.worldCamera, out pos2);
			if (pos2.x < 0) {
                print(pos2.x + " " + pos2.y);
				img2.rectTransform.anchoredPosition = pos2;
			}
		}

	}
}
