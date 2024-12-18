using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/GeniiStats")]
public class creatData : ScriptableObject
{
    public string nickName;
    [Range(0,100)]
    public int fly, run, swim, hp;
    public List<string> avalibleActions;//programed options: idle, walk, jump, called, idle emote
    //ideas/want to add: dance, sing
    public string randAct()
    {
        return avalibleActions[Random.Range(0,avalibleActions.Count-1)];
    }

    public void changeStat(string stat, int amt)
    {
        switch (stat)
        {case"fly":
                fly += amt;
            break;
        case "run":
            run+= amt;
            break;
        case "swim":
            swim+= amt;
            break;
        case "hp":
            hp+= amt;
            break;
            
        }
    }
}
