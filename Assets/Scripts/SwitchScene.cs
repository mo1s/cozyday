using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D coll)
    {
        SceneManager.LoadScene("OutsideLocation", LoadSceneMode.Single);
    }
}
