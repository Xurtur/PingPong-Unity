using UnityEngine;

[CreateAssetMenu(fileName = "SO_SFX", menuName = "Scriptable Objects/SO_SFX")]
public class SO_SFX : ScriptableObject
{
    [SerializeField] public AudioClip[] HitSFX;
    [SerializeField] public AudioClip[] BounceSFX;
}
