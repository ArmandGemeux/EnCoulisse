using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class EffectsManager : MonoBehaviour
{
    public PostProcessVolume postProcessVolume;
    public ChromaticAberration chromaticAberration;
    public bool go;
    public float stat;

    // Start is called before the first frame update
    void Start()
    {
        postProcessVolume.profile.TryGetSettings(out chromaticAberration);
    }

    // Update is called once per frame
    void Update()
    {
        if(go == true)
        {
            chromaticAberration.enabled.Override(true);
            chromaticAberration.intensity.Override(stat);
            if(stat > 0)
            {
                stat -= 0.02f;
                chromaticAberration.intensity.Override(stat);
            }
            if(stat <= 0)
            {
                go = false;
            }
        }
    }

    public void ChromAb()
    {
        stat = 1f;
        go = true;
    }

}
