using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculation : MonoBehaviour
{
    public UnityEngine.UI.Text RevTarget;
    public UnityEngine.UI.Text RevActual;
    public UnityEngine.UI.Text RevPercent;

    private float fPercentage = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //float fRevTar = float.Parse(RevTarget.text);
        //float fRevAct = float.Parse(RevActual.text);

        float fRevTar = 75000f;
        float fRevAct = 25000f;

        fPercentage = (fRevAct / fRevTar);
        UnityEngine.Debug.Log(fPercentage);

        // Need to add it putting the percentage into the text to show screen.
    }

    
}
