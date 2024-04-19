using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int XP = 0;
    [SerializeField] private int requiredXP = 100;
    [SerializeField] private int baseLvl = 100;
    [SerializeField] private List<GameObject> knightros = new List<GameObject>();

    private int level = 1;



    public int ExperiencePoints { get { return XP; } }
    public int RequiredExperiencePoints { get { return requiredXP; } }
    public int BaseLevel { get { return baseLvl; } }
    public List<GameObject> KnightrosList { get { return knightros; } }

    public void AddXP(int XP)
    {
        this.XP = Mathf.Max(0, XP);
    }

    public void AddKnightro(GameObject knightro)
    {
        knightros.Add(knightro);
    }

    private void LevelData()
    {
        level = (XP / baseLvl) + 1;
        requiredXP = baseLvl * level;
    }
    // Start is called before the first frame update
    void Start()
    {
        LevelData();
    }

}
