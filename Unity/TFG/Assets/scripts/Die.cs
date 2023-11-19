using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    bool died = false;
    private void OnTriggerEnter(Collider collision)
    {
        if ( !died && collision.gameObject.CompareTag("dieZone"))
        {
            died = true;
            GetComponent<GURHelper.CallEvent>().TrackEvent();
            Destroy(gameObject);
            UIManager.Instance.DecreaseLife();
        }
    }
}
