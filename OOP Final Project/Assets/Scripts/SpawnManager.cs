using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> prefabList;

    // Start is called before the first frame update
    void Start()
    {
        GameObject objectToSpawn = prefabList[GameManager.Instance.sessionData.figureIndex];
        Instantiate(objectToSpawn, new Vector3(0, 1, 0), objectToSpawn.transform.rotation);
    }
}
