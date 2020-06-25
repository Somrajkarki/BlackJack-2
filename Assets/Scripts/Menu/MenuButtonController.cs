using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonController : MonoBehaviour
{
    public int index;
    [SerializeField] bool keyDown;
    [SerializeField] int maxIndex;
    public AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (index < maxIndex)
                index++;
            else
                index = 0;
        }

        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (index > 0)
                index--;
            else
                index = maxIndex;
        }
    }
}
