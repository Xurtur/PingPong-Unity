using Unity.VisualScripting;
using UnityEditor.U2D.Aseprite;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    Rigidbody2D ballbody;
    Rigidbody2D Paddle;
    public GameObject[] ObjRef;
    public SO_SFX PingAndPong;
    AudioClip PlayOnCollide;
    AudioSource AudioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ballbody = GetComponent<Rigidbody2D>();
        ObjRef = GameObject.FindGameObjectsWithTag("Player");
        AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        foreach (GameObject i in ObjRef)
        {
                Paddle = GetComponent<Rigidbody2D>();
            if (ballbody.linearVelocity.magnitude != 0 && ballbody.linearVelocity.magnitude != 150)
            { 
                ballbody.linearVelocity = Paddle.linearVelocity.normalized * 20f;
                Vector2.ClampMagnitude(ballbody.linearVelocity, 3f);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlaySoundHit();
        }
        else
        {
            PlaySoundBounce();
        }
    }
    void PlaySoundHit()
    {
        int i = 0;
        i = Random.Range(0, 5);
        PlayOnCollide = PingAndPong.HitSFX[i];
        AudioSource.resource = PlayOnCollide;
        AudioSource.Play();
    }

    void PlaySoundBounce()
    {
        int i = 0;
        i = Random.Range(0, 5);
        PlayOnCollide = PingAndPong.BounceSFX[i];
        AudioSource.resource = PlayOnCollide;
        AudioSource.Play();
    }
}
