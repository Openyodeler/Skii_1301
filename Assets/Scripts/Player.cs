using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float forcePower;
    [SerializeField] Rigidbody rb;

    private InputAction moveAction;
    private Vector2 moveValue;

    private int point;
    public int Point {  get { return point; } set { point = value; } }

    [SerializeField] private int hp;
    public int HP { get { return hp; } set { hp = value; } }

    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move"); 
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveLeftOrRight();
    }

    private void MoveLeftOrRight()
    {
        moveValue = moveAction.ReadValue<Vector2>();
        rb.AddForce(moveValue.x * Vector3.right * forcePower);
    }

    public void Resetforce()
    {
        rb.angularVelocity = Vector3.zero;
        rb.linearVelocity = Vector3.zero;
    }
}


