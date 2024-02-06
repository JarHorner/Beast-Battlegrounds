using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameBoard : MonoBehaviour
{
    public static GameBoard Instance;
    [SerializeField] private Transform[] boardPositions;

    private void Awake()
    {
        Instance = this;

        foreach(Transform boardPosition in boardPositions)
        {
            AssignEventTriggersToBoardPositions(boardPosition);
        }
    }

    private void AssignEventTriggersToBoardPositions(Transform boardPosition)
    {
        EventTrigger trigger = boardPosition.GetComponent<EventTrigger>();
        EventTrigger.Entry pointerEnterEntry = new EventTrigger.Entry();
        pointerEnterEntry.eventID = EventTriggerType.PointerEnter;
        pointerEnterEntry.callback.AddListener((eventData) => { HighlightOnEnter(boardPosition); });
        trigger.triggers.Add(pointerEnterEntry);

        EventTrigger.Entry pointerExitEntry = new EventTrigger.Entry();
        pointerExitEntry.eventID = EventTriggerType.PointerExit;
        pointerExitEntry.callback.AddListener((eventData) => { UnhighlightOnExit(boardPosition); });
        trigger.triggers.Add(pointerExitEntry);
    }

    public void HighlightOnEnter(Transform boardPosition)
    {
        boardPosition.GetComponent<SpriteRenderer>().color = new Color(0.5f, 0.8f, 0.5f, 0.5f);
    }

    public void UnhighlightOnExit(Transform boardPosition)
    {
        boardPosition.GetComponent<SpriteRenderer>().color = new Color(0.7f, 0.7f, 0.7f, 0.5f);
    }
}
