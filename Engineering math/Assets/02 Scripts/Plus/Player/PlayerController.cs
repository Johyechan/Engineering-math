using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerMovement _playerMovement;

    private PlayerFire _playerFire;

    void Awake()
    {
        _playerMovement = GetComponent<PlayerMovement>();
        _playerFire = GetComponent<PlayerFire>();
    }

    void Update()
    {
        _playerMovement.Move();
        _playerFire.Fire();
    }
}
