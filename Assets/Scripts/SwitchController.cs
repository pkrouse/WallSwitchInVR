using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
	private float _startY;
	private float _endY;
	private bool _active = false;
	// private enum Action{TurnOn, TurnOff};
	// private Action myAction;
	private Flipper _flipper;

	void Start()
    {
        _flipper = GetComponent<Flipper>();
    }

    void OnTriggerEnter(Collider c)
    {
    	if (_active)
    		return;
    	_startY = c.transform.position.y;
    	_active = true;
    }

    void OnTriggerExit(Collider c)
    {
    	if (!_active)
    		return;
    	_endY = c.transform.position.y;
    	float dx = _startY - _endY;
    	if (dx < 0)
    		_flipper.TurnOn();
    	else
    		_flipper.TurnOff();
    	_active = false;
    }
}
