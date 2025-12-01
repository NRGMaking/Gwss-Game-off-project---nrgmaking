using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
   public void OnPlay(){

    SceneManager.LoadScene("SampleScene");



   }

   public void OnQuit(){


    Application.Quit();
   }
}
