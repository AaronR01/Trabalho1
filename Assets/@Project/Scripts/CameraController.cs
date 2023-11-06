using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Transform leftEdge;
    [SerializeField] private Transform rightEdge;
    [SerializeField] private Transform bottomEdge;
    [SerializeField] private Transform topEdge;

    private Transform player;
    private float halfWidth;
    private float halfHeight;
    public Transform target;


    // Start is called before the first frame update
    void Start()
    {
        player = target;
        halfHeight = Camera.main.orthographicSize;
        halfWidth = halfHeight * Camera.main.aspect;
    }


    void FollowPlayer()
    {
        float x = Mathf.Clamp(player.position.x, leftEdge.position.x + halfWidth, rightEdge.position.x - halfWidth);
        float y = Mathf.Clamp(player.position.y, bottomEdge.position.y + halfHeight, topEdge.position.y  - halfHeight);
        float z = transform.position.z;
        transform.position = new Vector3(x, y, z);
    }
    private void LateUpdate()
    {
        FollowPlayer();
    }
}