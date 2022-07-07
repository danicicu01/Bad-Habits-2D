using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TriggerCinematic : MonoBehaviour
{
    //[SerializeField] private float hasCinematic;
    [SerializeField] private CameraController cam;
    public GameObject CinematicFinal;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*if (hasCinematic == 1)
        {
            CinematicFinal.SetActive(true);
            StartCoroutine(SfarsitCut());
        }*/

        if (collision.tag == "Player")
        {
            CinematicFinal.SetActive(true);
            StartCoroutine(SfarsitCut());
        }
    }

    IEnumerator SfarsitCut()
    {
        yield return new WaitForSeconds(10);
        CinematicFinal.SetActive(false);
    }
}
