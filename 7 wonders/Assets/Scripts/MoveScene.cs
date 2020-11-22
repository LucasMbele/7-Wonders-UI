using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MoveScene : MonoBehaviour
{
 
    public void LoginMovetoMenu ()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
