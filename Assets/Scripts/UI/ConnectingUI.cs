using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectingUI : MonoBehaviour
{
    private void Start()
    {
        KitchenGameMultiplayer.Instance.OnTryingToJoinGame += KitchenGameMultiplier_OnTryingToJoinGame;
        KitchenGameMultiplayer.Instance.OnFailedToJoinGame += KitchenGameMultiplier_OnFailedToJoinGame;

        Hide();
    }

    private void KitchenGameMultiplier_OnFailedToJoinGame(object sender, System.EventArgs e)
    {
        Hide();
    }

    private void KitchenGameMultiplier_OnTryingToJoinGame(object sender, System.EventArgs e)
    {
        Show();
    }

    private void Show()
    {
        gameObject.SetActive(true);
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }

    private void OnDestroy()
    {
        KitchenGameMultiplayer.Instance.OnTryingToJoinGame -= KitchenGameMultiplier_OnTryingToJoinGame;
        KitchenGameMultiplayer.Instance.OnFailedToJoinGame -= KitchenGameMultiplier_OnFailedToJoinGame;
    }
}
