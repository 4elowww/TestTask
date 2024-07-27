using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed;
    private Rigidbody _rb;
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    public void PlayerRun()
    {
        Speed = 7f;
    }
    public void PlayerStop()
    {
        Speed = 0;
        Debug.Log("Player stoped");
    }
    private float _PointerDownPositionX;
    [SerializeField][Range(-.2f, .2f)] private float _horizontalSpeed;
    private void FixedUpdate()
    {
        _rb.velocity = Vector3.forward * Speed;
    }
    public void OnPoiterDown()
    {
        _PointerDownPositionX = Input.mousePosition.x;
    }
    public void OnPointerDrag()
    {
        if (_PointerDownPositionX < Input.mousePosition.x)
            _horizontalSpeed = .2f;
        else
            _horizontalSpeed = -.2f;

        transform.position = new Vector3(transform.position.x + _horizontalSpeed, -4.5f, transform.position.z);
        _PointerDownPositionX = Input.mousePosition.x;
    }
}
