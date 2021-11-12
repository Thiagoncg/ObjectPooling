using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool instance;
    private List<GameObject> pooledObjects = new List<GameObject>();
    private int amountToPool = 20;
    [SerializeField] private GameObject bulletSpaceshipPrefab;

    private void Awake()
    {
        //if (instance == null)
        //{
            instance = this;
        //}
    }

    //Em um loop instanciar os objetos e criar um grupo e desativalos.
    private void Start()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject obj = Instantiate(bulletSpaceshipPrefab);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
    }
    // Criaremos um objeto publico que retorna do jogo deifinão do tamanho do for para a contagem de objetos
    public GameObject GetPooledObjet()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if(!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        return null;
    }


}
