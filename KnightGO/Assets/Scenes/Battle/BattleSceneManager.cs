using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSceneManager : KGSceneManager
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void playerTapped(GameObject player)
    {
        print("BattleSceneManager.playerTapped activated");
    }

    public override void knightTapped(GameObject knight)
    {
        print("BattleSceneManager.knightTapped activated");
    }
}
