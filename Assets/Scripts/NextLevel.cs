using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    [SerializeField] private int level;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Application.LoadLevel(level);
        }
    }
}
