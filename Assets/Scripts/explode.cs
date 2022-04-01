using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explode : MonoBehaviour
{

    public AudioClip sound;
    public GameObject explosion;
    public int scor = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("fruit"))
        {
            scor++;
            Destroy(collision.transform.gameObject);
            Instantiate(explosion, collision.transform.position, collision.transform.rotation);
            AudioSource.PlayClipAtPoint(sound, collision.transform.position);
        }
    }
}
