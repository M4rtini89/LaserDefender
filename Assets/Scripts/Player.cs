using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10; // Units per second
    [SerializeField] private float positionClampX = 5;
    [SerializeField] private float positionClampY = 9;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        Move();
    }

    private void Move()
    {
        var deltaX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        var deltaY = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        var newXPos = Mathf.Clamp(transform.position.x + deltaX, -positionClampX, positionClampX);
        var newYPox = Mathf.Clamp(transform.position.y + deltaY, -positionClampY, positionClampY);
        var newPosition = new Vector2(newXPos, newYPox);
        transform.position = newPosition;
    }
}