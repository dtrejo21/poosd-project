using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class KnightSpawn : Singleton<KnightSpawn>
{

    [SerializeField] private Knightro[] accessKnightros;
    [SerializeField] private Player player;
    [SerializeField] private float delay = 100.0f;
    [SerializeField] private int initKnightros = 10;
    [SerializeField] private float min = 5.0f;
    [SerializeField] private float max = 50.0f;

    private List<Knightro> liveKnightros = new List<Knightro>();
    private Knightro selectedKnightro;

    public List<Knightro> LiveKnightros
    {
        get { return liveKnightros; }
    }

    public Knightro SelectedKnightro
    {
        get { return selectedKnightro; }
    }

    private void Awake()
    {
        Assert.IsNotNull(player);
        Assert.IsNotNull(accessKnightros);
    }

    private void InitializeKnightros()
    {
        int index = UnityEngine.Random.Range(0, accessKnightros.Length);
        float x = player.transform.position.x + Generate();
        float y = player.transform.position.y;
        float z = player.transform.position.z + Generate();
        liveKnightros.Add(Instantiate(accessKnightros[index], new Vector3(x, y, z), Quaternion.identity));

    }

    public void KnightroWasSelected(Knightro knightro)
    {
        selectedKnightro = knightro;
    }

    private float Generate()
    {
        float randomNum = UnityEngine.Random.Range(min, max);
        bool isPositive = UnityEngine.Random.Range(0, 10) < 5;
        return randomNum * (isPositive ? 1 : -1);
    }

    private IEnumerator GenerateKnightros()
    {
        while (true)
        {
            InitializeKnightros();
            yield return new WaitForSeconds(delay);
        }
    }

    void Start()
    {
        for (int i = 0; i < initKnightros; i++)
        {
            InitializeKnightros();
        }

        StartCoroutine(GenerateKnightros());
    }

}
