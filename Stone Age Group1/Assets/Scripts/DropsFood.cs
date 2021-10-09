using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropsFood : MonoBehaviour
{
    [SerializeField] private List<GameObject> _fruitDatas;
    [SerializeField] private Transform _spawnPointFruit;
    [SerializeField] private ParticleSystem _particle;

    private AudioSource _audioSource;
    private GameObject _fruit;

    private void Awake()
    {
        if (_fruitDatas == null || _fruitDatas.Count == 0) throw new UnityException("fruitDatas == null || fruitDatas.Count == 0");
        if (_spawnPointFruit == null) throw new UnityException("spawnPointFruit == null");

        _audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (PlayerController.GetState != PlayerState.Attack) return;

        _audioSource.Play();
        _particle.Play(true);

        if (_fruit != null && _fruit.activeInHierarchy) return;

        int randomIndex = Random.Range(0, _fruitDatas.Count);
        GameObject randomFruit = _fruitDatas[randomIndex];

        _fruit = Instantiate(randomFruit, _spawnPointFruit.position, Quaternion.identity);
    }
}
