using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CreateListOfPoints : MonoBehaviour
{
    Dictionary<string, int> racers = new Dictionary<string, int>();

    private void Start() {

        racers.Add("Luiz Gomes", 50);
        racers.Add("Sara Araújo", 137);
        racers.Add("Gustavo Caravalho", 78);
        racers.Add("Andrey", 10);
        racers.Add("Joaquim", 37);
        racers.Add("Celso", 90);

        SortDictionary(racers);
    }

    private void SortDictionary(Dictionary<string, int> dict) {

        dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        
        foreach(var i in dict.Values) {
            Debug.Log(i);
        }

        foreach(var b in dict.Keys) {
            Debug.Log(b);
        }
    }
}