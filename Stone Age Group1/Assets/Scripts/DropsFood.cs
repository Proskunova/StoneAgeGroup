using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropsFood : MonoBehaviour
{
    [SerializeField] private List<GameObject> fruitDatas;
    [SerializeField] private Transform spawnPointFruit;
    [SerializeField] private ParticleSystem particle;

    private AudioSource audioSource;
    private GameObject fruit;


    private void Awake()
    {
        if (fruitDatas == null || fruitDatas.Count == 0) throw new UnityException("fruitDatas == null || fruitDatas.Count == 0");
        if (spawnPointFruit == null) throw new UnityException("spawnPointFruit == null");
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (PlayerController.GetState != PlayerState.Attack) return;

        audioSource.Play();
        particle.Play(true);

        if (fruit != null && fruit.activeInHierarchy) return;

        int randomIndex = Random.Range(0, fruitDatas.Count);
        GameObject randomFruit = fruitDatas[randomIndex];

        fruit = Instantiate(randomFruit, spawnPointFruit.position, Quaternion.identity);
        
    }

}
