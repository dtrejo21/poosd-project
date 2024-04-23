using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheBattle : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void battleTime()
    {
        Knightro myKnight = new Knightro();
        Knightro enemyKnight = new Knightro();
        myKnight.setType(0);
        enemyKnight.setType(1);

        System.Random r = new System.Random();

        int attack1 = 0;
        int attack2 = 0;

        // will add a d6 roll
        attack1 = attack1 + r.Next(1, 7);
        attack2 = attack2 + r.Next(1, 7);

        // gives the knightro an extra roll if it has advantage
        if (myKnight.IsStrongAgainst(enemyKnight))
            attack1 = attack1 + r.Next(1, 7);
        if (enemyKnight.IsStrongAgainst(myKnight))
            attack2 = attack2 + r.Next(1, 7);

        // removes a d6 from the knightro if it is weak against it
        if (myKnight.IsWeakAgainst(enemyKnight))
            attack1 = attack1 - r.Next(1, 7);
        if (enemyKnight.IsWeakAgainst(myKnight))
            attack2 = attack2 - r.Next(1, 7);

        if(attack1 > attack2)
            SceneTransitionManager.Instance.GoToScene(KGConstants.SCENE_WIN, new List<GameObject>());
        else
            SceneTransitionManager.Instance.GoToScene(KGConstants.SCENE_LOST, new List<GameObject>());
    }
}
