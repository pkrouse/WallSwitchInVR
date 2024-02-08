using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderController : MonoBehaviour
{
	public DualColliderCoordinator.ColliderLocation location;
	private DualColliderCoordinator coordinator;
	private bool _active = false;
    // Start is called before the first frame update
    void Start()
    {
    	//PlayerPrefs
        coordinator = GetComponentInParent<DualColliderCoordinator>();
    }

    void OnTriggerEnter(Collider collider)
    {
    	if (_active)
    		return;
    	coordinator.RegisterEntry(location);
    	_active = true;
    	Invoke("Reset", 0.5f);
    }

    private void Reset()
    {
    	_active = false;
    }
}
