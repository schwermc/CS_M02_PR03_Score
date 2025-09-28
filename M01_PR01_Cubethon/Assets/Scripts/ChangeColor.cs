using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private Renderer player;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Renderer>();
    }

    public void colorChange()
    {
        player.material.color = Color.black;
    }
}
