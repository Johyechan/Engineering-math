using TreeEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private Rigidbody _rigidBody;

    private float x, y, z = 0;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    public void Move()
    {
        // 플레이어 이동 transform
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + Vector3.forward * _moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + Vector3.back * _moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + Vector3.left * _moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + Vector3.right * _moveSpeed * Time.deltaTime;
        }

        // 플레이어 이동 Rigidbody
        if (Input.GetKey(KeyCode.UpArrow))
        {
            z += 0.01f;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            z -= 0.01f;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            x -= 0.01f;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            x += 0.01f;
        }

        _rigidBody.linearVelocity = new Vector3(x, y, z) * _moveSpeed;
    }
}
