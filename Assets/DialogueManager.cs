using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> queueDialogue;

    public GameObject dialogueUIObj;
    public TMP_Text dialogueTextObj;

    // Start is called before the first frame update
    void Start()
    {
        queueDialogue = new Queue<string>();
        dialogueUIObj.SetActive(false);
    }

    public void StartDialogue(string[] sentences)
    {
        queueDialogue.Clear();

        dialogueUIObj.SetActive(true);

        foreach(string currentString in sentences)
        {
            queueDialogue.Enqueue(currentString);
        }

        DisplayNextString();
    }

    public void DisplayNextString()
    {
        dialogueTextObj.text = queueDialogue.Dequeue();
    }

    public void DialogueButton()
    {
        DisplayNextString();
    }


}

// TODO: Make it so when all objects in the queue are gone, the UI gets removed

// queue.Clear() Removes all objects from the Queue<T>.
// queue.Dequeue() Removes and returns the object at the beginning of the Queue<T>.
// queue.Enqueue(T) Adds an object at the beginning of the Queue<T> without removing it.
// queue.Peek() Returns the object at the beginning of the Queue<T> without removing it.
