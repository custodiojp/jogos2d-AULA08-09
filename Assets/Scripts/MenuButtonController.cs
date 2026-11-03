using UnityEngine;

public class MenuButtonController : MonoBehaviour
{
    public GameObject button;

    public void ShowButton()
    {
        button.SetActive(true);
    }
}