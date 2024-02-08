using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
	public GameObject LightBulb;
	public Transform LinkedSwitch;
	private bool _on = false;
    private float _offPosition = 40f;
    private float _onPosition = -40f;
	private Vector3 _currentRotation = new Vector3(40f, 0f, 90f);

    private void Start()
    {
        TurnOff();
    }
    public bool IsOn()
    {
    	return _on;
    }

    public void TurnOn()
    {
    	_on = true;
    	_currentRotation.x = _onPosition;
    	LinkedSwitch.transform.localEulerAngles = _currentRotation;
    	if (LightBulb)
    	{
    		LightBulb.GetComponent<Renderer>().material.color = Color.green;
    	}
    }

    public void TurnOff()
    {
    	_on = false;
    	_currentRotation.x = _offPosition;
    	LinkedSwitch.transform.localEulerAngles = _currentRotation;
    	if (LightBulb)
    	{
    		LightBulb.GetComponent<Renderer>().material.color = Color.red;
    	}
    }
}
