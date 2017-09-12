using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;



public class joystick : MonoBehaviour,IDragHandler,IPointerUpHandler,IPointerDownHandler {



	private Image bgimg;
	private Image stickimg;
	private Vector3 inputVector=Vector3.zero;

	// Use this for initialization
	void Start () {
		bgimg = GetComponent<Image> ();
		stickimg = transform.GetChild (0).GetComponent<Image> ();
		
	}


	public virtual void OnDrag(PointerEventData ped)
	{
		Vector2 pos;
		if (RectTransformUtility.ScreenPointToLocalPointInRectangle (bgimg.rectTransform, ped.position, ped.pressEventCamera, out pos)) {
			pos.x = (pos.x / bgimg.rectTransform.sizeDelta.x);
			pos.y = (pos.y / bgimg.rectTransform.sizeDelta.y);

			inputVector = new Vector3 (pos.x * 2 + 1, pos.y * 2 + 1, 0);
			inputVector = (inputVector.magnitude > 1.0f) ? inputVector.normalized : inputVector;

			stickimg.rectTransform.anchoredPosition = new Vector3 (inputVector.x * (bgimg.rectTransform.sizeDelta.x / 3), inputVector.y * (bgimg.rectTransform.sizeDelta.y / 3));
		}
	}

	public virtual void OnPointerDown(PointerEventData ped)
	{
		OnDrag (ped);
	}

	public virtual void OnPointerUp(PointerEventData ped)
	{
		inputVector = Vector3.zero;
		stickimg.rectTransform.anchoredPosition = Vector3.zero;
	}

	public float GetHorizontalValue()
	{
		return inputVector.x;
	}

	public float GetVerticalValue()
	{
		return inputVector.y;
	}
	// Update is called once per frame
	void Update () {
		
	}
}
