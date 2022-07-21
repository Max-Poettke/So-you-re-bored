using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject boundsSprite;
    public GameObject [] fishes;
    private int fishAmount;
    public Vector3 boundRight;
    public Vector3 boundLeft;
    public Vector3 boundTop;
    public Vector3 boundBottom;

    void Start(){
        boundRight = new Vector3(boundsSprite.transform.position.x + boundsSprite.transform.localScale.x / 2f, 0, 0);
        boundLeft  = new Vector3(boundsSprite.transform.position.x - boundsSprite.transform.localScale.x / 2f, 0, 0);
        boundTop = new Vector3(0, boundsSprite.transform.position.y + boundsSprite.transform.localScale.y / 2f, 0);
        boundBottom = new Vector3(0, boundsSprite.transform.position.y - boundsSprite.transform.localScale.y / 2f, 0);
        fishAmount = fishes.Length;

        StartCoroutine(SpawnFish());
    }
    
    public IEnumerator SpawnFish(){
        while (true){

            yield return new WaitForSeconds(1);
        }
    }
}
