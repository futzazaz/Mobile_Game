using UnityEngine;

public class Cemara : MonoBehaviour
{
 
    private Vector3 offset = new Vector3(0f, 0f, -10f);
    private float smoothTime = 0.1f;
    private Vector3 velocity = Vector3.zero;

    [SerializeField] private Transform target;

    private void Start()
    {
        GameObject cam = GameObject.FindGameObjectWithTag("Player");
        target = cam.GetComponent<Transform>();
    }

    private void Update()
    {
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}

