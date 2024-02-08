using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualColliderCoordinator : MonoBehaviour
{
	public enum ColliderLocation{TOP, BOTTOM};

	private bool _inProcess = false;
	private ColliderLocation _processing;
	private Flipper _flipper;

	void Start()
    {
        _flipper = GetComponent<Flipper>();
    }

    public void RegisterEntry(ColliderLocation id)
    {
    	if (_inProcess){
    		NotifyFlipper();
    		_inProcess = false;
    		return;
    	}
    	_inProcess = true;
    	_processing = id;
    }

    private void NotifyFlipper()
    {
    	if (_processing == ColliderLocation.TOP)
    		_flipper.TurnOff();
    	else
    		_flipper.TurnOn();
    }
}
