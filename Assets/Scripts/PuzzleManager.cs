using UnityEngine;
using TMPro;

public class PuzzleManager : MonoBehaviour
{
    public RectTransform bar1, bar2, bar3, bar4, bar5, bar6;

    public TextMeshProUGUI[] slots; // slot 1–4

    private int currentIndex = 0;
    private string correctAnswer = "FEDG";

    void Start()
    {
        bar1.anchoredPosition = new Vector2(-485.5f, 0f);
        bar2.anchoredPosition = new Vector2(-325f, -0.8f);
        bar3.anchoredPosition = new Vector2(-93f, -0.3f);
        bar4.anchoredPosition = new Vector2(154f, 1.7f);
        bar5.anchoredPosition = new Vector2(380f, -27f);
        bar6.anchoredPosition = new Vector2(531f, 2.3f);
    }

    public void AddLetter(string letter)
    {
        if (currentIndex >= slots.Length) return;

        slots[currentIndex].text = letter;
        currentIndex++;

        if (currentIndex == slots.Length)
        {
            CheckAnswer();
        }
    }

    void CheckAnswer()
    {
        string result = "";

        foreach (var slot in slots)
        {
            result += slot.text;
        }

        if (result == correctAnswer)
        {
            Debug.Log("BENAR!");
        }
        else
        {
            Debug.Log("SALAH!");
            ResetSlots();
        }
    }

    void ResetSlots()
    {
        foreach (var slot in slots)
        {
            slot.text = "";
        }

        currentIndex = 0;
    }
}