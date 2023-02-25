using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
    public static ObjectPooling instance;
    private List<GameObject> pooledObjects = new List<GameObject>(); //Objetos que voy a reciclar
    private int amountToPool = 10; //Cantidad de objetos disponibles para reciclar
    [SerializeField] private GameObject fruitPrefab;
    [SerializeField] List <GameObject> fruitPrefabs= new List<GameObject>();

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        
        for (int i = 0; i < amountToPool; i++)
        {
            int randomFruit = Random.Range(0, fruitPrefabs.Count);
            GameObject obj = Instantiate(fruitPrefabs[randomFruit]);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        return null;
    }
}
