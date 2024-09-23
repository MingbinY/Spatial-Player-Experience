using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    PlayerManager playerManager;
    CharacterController characterController;
    public float moveSpeed = 2f;
    public float runSpeed = 4f;
    [SerializeField] bool canMove = true;
    [SerializeField] Vector3 moveDir = Vector3.zero;
    public bool isRunning = false;
    public float gravity = -9.8f;

    private void Start()
    {
        playerManager = GetComponent<PlayerManager>();
        characterController = playerManager.characterController;
    }

    private void Update()
    {

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * y;
        move.y = characterController.isGrounded ? gravity : move.y;
        isRunning = Input.GetKey(KeyCode.LeftShift) ? true : false;
        characterController.Move(move * (isRunning ? runSpeed : moveSpeed) * Time.deltaTime);
    }
}
