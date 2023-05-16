using System.Collections;
using UnityEngine;
using TMPro;

public class DialogueMildred : MonoBehaviour
{

    [SerializeField] private GameObject MarkMildred;
    [SerializeField, TextArea(4, 6)] private string[] dialogueLines;
    [SerializeField] private GameObject DialoguePanelMildred;
    [SerializeField] private TMP_Text dialogueText;

    private bool isPlayerInRange;
    private bool didDialogueStart; //va a indicar si el dialogo ha comenzado
    private int lineIndex; //nos va a indicar que linea de dialogo esta mostrando
    public AudioClip MildredSound;
    [Range(0, 1)]
    public float MildredVolume;

    private float typingTime = 0.05f;

    void Update()
    {
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.E))
        {
            if (!didDialogueStart)
            {
                StartDialogue();
            }

            else if (dialogueText.text == dialogueLines[lineIndex])  //si el texto de tmp esta mostrando la linea de dialogo completa, se va a pasar a la proxima linea

            {
                NextDialogueLine();

            }
            else
            {
                StopAllCoroutines();
                dialogueText.text = dialogueLines[lineIndex]; //para que se pueda mostrar el dialogo completo aunque no haya acabado
            }



        }

    }
    private void StartDialogue()
    {
        didDialogueStart = true;
        DialoguePanelMildred.SetActive(true);
        MarkMildred.SetActive(false);
        lineIndex = 0; //siempre muestra la primera linea de dialogo al comenzar 
        Time.timeScale = 0f;

        StartCoroutine(ShowLine());
    }

    private void NextDialogueLine()
    {
        lineIndex++;
        if (lineIndex < dialogueLines.Length)
        {
            StartCoroutine(ShowLine());
        }
        else
        {
            didDialogueStart = false;
            DialoguePanelMildred.SetActive(false);
            MarkMildred.SetActive(true);


            Time.timeScale = 1f;
        }
    }






    //Corrutina
    private IEnumerator ShowLine()
    {
        dialogueText.text = string.Empty;

        foreach (char ch in dialogueLines[lineIndex])
        {
            dialogueText.text += ch; //para lograr el efecto de tipeo 
            yield return new WaitForSecondsRealtime(typingTime);
        }
    }



}
