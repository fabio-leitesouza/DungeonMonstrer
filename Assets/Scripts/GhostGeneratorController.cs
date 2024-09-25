using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostGeneratorController : MonoBehaviour
{
    public GameObject Ghost;
    private float countTime = 0;
    public float TimeGeneratorGhost = 1;

    void Update()
    {
        GeneratorNewGhost();
    }

    void GeneratorNewGhost()
    {
        Vector3 creationPoint = positionRandom();
        Instantiate(Ghost, creationPoint, transform.rotation);
    }
    Vector3 positionRandom()
    {
        Vector3 position = Random.insideUnitSphere * 5;
        position += transform.position; 
        position.y = transform.position.y; //copia a posição do y de objeto gerador
        return position;
    }
}
