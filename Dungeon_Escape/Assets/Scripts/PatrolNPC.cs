using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolNPC : MonoBehaviour
{
    public Transform[] waypoints;
    private int _currentWaypointIndex = 0;
    public float _speed = 2f;
    private Vector3 lastPosition;
    // Start is called before the first frame update
    void Start()
    {
        lastPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = (transform.position - lastPosition).normalized;
        if (direction.magnitude > 0)
        {
            transform.rotation = Quaternion.LookRotation(direction);
        }
        lastPosition = transform.position;
        Transform wp = waypoints[_currentWaypointIndex];
        if (Vector3.Distance(transform.position, wp.position) < 0.01f)
        {
            _currentWaypointIndex = (_currentWaypointIndex + 1) % waypoints.Length;
        }
        else
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                wp.position,
                _speed * Time.deltaTime);
        }
    }
}
