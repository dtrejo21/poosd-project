using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorldSceneManager : KGSceneManager
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

    }

    public override void knightTapped(GameObject knight)
    {
        SceneManager.LoadScene(KGConstants.SCENE_CAPTURE, LoadSceneMode.Additive);
    }
}
