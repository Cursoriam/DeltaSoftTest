using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalSpawner : MonoBehaviour
{
    [SerializeField] private float maxTimer;
    private float _timer;
    [SerializeField] private GameObject goalPrefab;
    [SerializeField] private float height;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_timer > maxTimer)
        {
            var goal = Instantiate(goalPrefab);
            goal.transform.position = transform.position + new Vector3(0.0f, Random.Range(-height, height));
            Destroy(goal, Constants.GoalDestroyTime);
            _timer = 0.0f;
        }

        _timer += Time.deltaTime;
    }
}
