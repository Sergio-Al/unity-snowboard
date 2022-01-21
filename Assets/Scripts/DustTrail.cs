using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem dustEffect;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "MainSurface")
        {
            dustEffect.Play();
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "MainSurface")
        {
            dustEffect.Stop();
        }
    }
}
