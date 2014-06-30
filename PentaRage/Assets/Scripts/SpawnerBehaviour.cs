using UnityEngine;
using System.Collections;

public class SpawnerBehaviour : MonoBehaviour 
{
    public GameObject Targets;
    public int SpawnCounter = 10;
    public int SpawnCoolDown = 1;
    
	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (_timer > 0)
        {
            _timer -= Time.deltaTime;
            return;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            SpawnTarget();
            _timer = SpawnCoolDown;
        }
	}

    public void SpawnTarget()
    {
        for (var i = 0; i < SpawnCounter; i++)
        {
            var target = (GameObject) GameObject.Instantiate(Targets);
            var x = Random.Range(-10, 10);
            var z = Random.Range(-10, 10);
            var location = transform.position;
            location.x += x;
            location.z += z;
            target.transform.position = location;
        }
    }
    private float _timer = 0;
}
