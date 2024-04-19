using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum knightType { Water, Fire, Earth, Gold, Air }

public class Knightro : MonoBehaviour
{
    [SerializeField] private float spawnRate = 0.10f;
    [SerializeField] private float catchRate = 0.10f;
    [SerializeField] private int attack = 0;
    [SerializeField] private int defense = 0;
    [SerializeField] private int health = 100;
    [SerializeField] private knightType type; 

    public float SpawnRate { get { return spawnRate; } }
    public float CatchRate { get { return catchRate; } }
    public int Attack { get { return attack; } }
    public int Defense { get { return defense; } }
    public int Health { get { return health; } }

    private void Start()
    {
        DontDestroyOnLoad(this);
    }

    private void OnMouseDown()
    {
        KGSceneManager[] managers = FindObjectsOfType<KGSceneManager>();
        foreach(KGSceneManager kgSceneManager in managers)
        {
            if(kgSceneManager.gameObject.activeSelf)
            {
                kgSceneManager.knightTapped(this.gameObject);
            }
        }
    }

    public bool IsStrongAgainst(knightType enemyType)
    {
        switch (type)
        {
            case knightType.Water:
                return enemyType == knightType.Fire;
            case knightType.Fire:
                return enemyType == knightType.Gold;
            case knightType.Earth:
                return enemyType == knightType.Air;
            case knightType.Gold:
                return enemyType == knightType.Earth;
            case knightType.Air:
                return enemyType == knightType.Water;
            default:
                return false;
        }
    }

    public bool IsWeakAgainst(knightType enemyType)
    {
        switch (type)
        {
            case knightType.Water:
                return enemyType == knightType.Earth;
            case knightType.Fire:
                return enemyType ==knightType.Water;
            case knightType.Earth:
                return enemyType == knightType.Fire;
            case knightType.Gold:
                return enemyType == knightType.Air;
            case knightType.Air:
                return enemyType == knightType.Gold;
            default:
                return false;
        }
    }
}
