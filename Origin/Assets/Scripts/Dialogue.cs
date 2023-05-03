using System.Collections;
using TMPro;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    [SerializeField] private GameObject DialogueMark;
    [SerializeField, TextArea(4,6)] private string[] dialogueLines;
    [SerializeField] private GameObject DialoguePanel;
    [SerializeField] private TMP_Text dialogueText;

    private bool isPlayerInRange;
    private bool didDialogueStart; //va a indicar si el dialogo ha comenzado
    private int lineIndex; //nos va a indicar que linea de dialogo esta mostrando

    private float typingTime = 0.05f;
   
    void Update()
    {
        if(isPlayerInRange && Input.GetKeyDown(KeyCode.E))
        {
            if (!didDialogueStart)
            {
                StartDialogue();
            }
        
           else if(dialogueText.text == dialogueLines[lineIndex])  //si el texto de tmp esta mostrando la linea de dialogo completa, se va a pasar a la proxima linea

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
        DialoguePanel.SetActive(true);
        DialogueMark.SetActive(false);
        lineIndex = 0; //siempre muestra la primera linea de dialogo al comenzar 
        Time.timeScale = 0f;

        StartCoroutine(ShowLine());
    }

    private void NextDialogueLine()
    {
        lineIndex++;
        if(lineIndex < dialogueLines.Length)
        {
            StartCoroutine(ShowLine());
        }
        else
        {
            didDialogueStart = false;
            DialoguePanel.SetActive(false);
            DialogueMark.SetActive(true);
            Time.timeScale = 1f;
        }
    }






    //Corrutina
    private IEnumerator ShowLine()
    {
        dialogueText.text = string.Empty;

        foreach(char ch in dialogueLines[lineIndex])
        {
            dialogueText.text += ch; //para lograr el efecto de tipeo 
            yield return new WaitForSecondsRealtime(typingTime);
        }
    }
    







    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isPlayerInRange = true;
            DialogueMark.SetActive(true);
            
        }
       
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isPlayerInRange = false;
            DialogueMark.SetActive(false);
          
        }
    }

}
