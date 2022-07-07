using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    
    [Header("Text Heal")]
    [SerializeField] private TextMesh textHeal;

    [SerializeField] private float healthValue;

    [SerializeField] private AudioClip sunetViata;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            collision.GetComponent<Health>().AddHealth(healthValue);
            gameObject.SetActive(false);
            SoundManager.instance.PlaySound(sunetViata);
            GameObject.Destroy(textHeal);

        }
    }

}
