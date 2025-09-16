using Unity.VisualScripting;
using UnityEditor.TerrainTools;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour
{
    [SerializeField] private float Vert;
    [SerializeField] private float Hori;
    [SerializeField] KeyCode Up;
    [SerializeField] KeyCode Down;
    [SerializeField] KeyCode Left;
    [SerializeField] KeyCode Right;
    private Rigidbody2D rb2d;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {

        //Movement If Statements
        if (Input.GetKey(Up))
        {
            Vert = 300;
            MoveFunction();
        }
        if (Input.GetKey(Down))
        {
            Vert = -300;
            MoveFunction();
        }
        if (Input.GetKey(Left))
        {
            Hori = -300;
            MoveFunction();
        }
        if (Input.GetKey(Right))
        {
            Hori = 300;
            MoveFunction();
        }
        if (!Input.anyKey)
        {
            if (Vert != 0)
            {
                Vert = 00;
                MoveFunction();
            }

            if (Hori != 0)
            {
                Hori = 00;
                MoveFunction();
            }
        }
    }

    void MoveFunction()
    {
        Vector2 viktor = new Vector2 (Hori, Vert).normalized * 15f;
        rb2d.linearVelocity = viktor;
    }
}
