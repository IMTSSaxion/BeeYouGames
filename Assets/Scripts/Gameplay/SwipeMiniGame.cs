using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SwipeMiniGame : ASwipe, IInteractable
{
    [SerializeField]
    private ParticleSystem trailPrefab;
    [SerializeField]
    private string prompt;
    [SerializeField][Range(1, 50)]
    private int targetSwipeAmount = 5;

    private int swipeCount;
    private ParticleSystem trail;

    public string Prompt => prompt;

    public bool Available { get; set; }

    public UnityEvent OnComplete;
    public UnityEvent OnInteract;

    // Start is called before the first frame update
    void Start()
    {
        Available = true;
    }

    public bool Interact(PlayerInteractor interactor)
    {
        OnInteract.Invoke();
        return true;
    }


    // Update is called once per frame
    void Update()
    {
#if UNITY_STANDALONE

        if (GetSwipeOnPC().magnitude >= pixelDistToDetect)
        {
            swipeCount++;
            Debug.Log(swipeCount);
        }
#endif
#if UNITY_ANDROID

            if(GetSwipeOnPhone().magnitude >= pixelDistToDetect)
            {
                swipeCount++;
                Debug.Log(swipeCount);
            }
#endif

        if (swipeCount >= targetSwipeAmount)
        {
            OnComplete.Invoke();
            isActive = false;
        }
            
    }

    private void TrailFollowTouch()
    {
        trail.transform.position = GetTouchPosition();
    }

    private void TrailFollowMouse()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
        Debug.Log("MousePos" + mousePos);
        trail.transform.position = mousePos;
    }
}