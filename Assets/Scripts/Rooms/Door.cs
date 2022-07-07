using System.Collections;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private float hasCinematic;
    [SerializeField] private Transform previousRoom;
    [SerializeField] private Transform nextRoom;
    [SerializeField] private CameraController cam;
    public GameObject CinematicFinal;
    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (hasCinematic == 1)
        {
            CinematicFinal.SetActive(true);
            StartCoroutine(SfarsitCut());
        }

        if (collision.tag == "Player")
        {
            if (collision.transform.position.x < transform.position.x)
                cam.MoveToNewRoom(nextRoom);
            else
                cam.MoveToNewRoom(previousRoom);
        }
    }

    IEnumerator SfarsitCut()
    { 
        yield return new WaitForSeconds(10);
        CinematicFinal.SetActive(false);
    }
}
