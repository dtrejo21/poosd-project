using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class KGSceneManager : MonoBehaviour
{
    public abstract void playerTapped(GameObject player);
    public abstract void knightTapped(GameObject knight);
}
