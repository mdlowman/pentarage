using UnityEngine;
using System.Collections;

public class TargetBehaviour : MonoBehaviour 
{
    public float Speed = 0.1f;
    public float radius = 50.0F;
    public float power = 100.0F;
	
    // Use this for initialization
	void Start () 
    {
        mainCamera = Camera.main;
	}
	
	// Update is called once per frame
	void Update () 
    {
        var direction = (mainCamera.transform.position - transform.position);
        if (direction.sqrMagnitude < 1)
        {
            Detonate();
            return;
        }
        direction.Normalize();
        direction.y = 0;
        transform.Translate(Speed * direction);
        
	}

    public void Detonate()
    {
        GameObject.DestroyImmediate(gameObject);
    }

    private Camera mainCamera;
}
