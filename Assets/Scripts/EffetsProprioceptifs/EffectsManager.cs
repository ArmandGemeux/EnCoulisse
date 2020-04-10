using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class EffectsManager : MonoBehaviour
{
    public PostProcessVolume postProcessVolume;
    public ChromaticAberration chromaticAberration;
    public DepthOfField depthOfField;


    public bool effectOne;
    public bool effectTwo;
    public bool scareEffect;
    public bool invert;
    public int invertNumber;
    public float chromAbIntensity;
    public float depthIntensity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CadavreEffect();
        SouvenirEffect();
        JumpscareEffect();
    }



    public void Cadavre()
    {
        chromAbIntensity = 1f;
        postProcessVolume.profile.TryGetSettings(out chromaticAberration);
        effectOne = true;
    }

    private void CadavreEffect()
    {
        if (effectOne == true)
        {
            chromaticAberration.enabled.Override(true);
            chromaticAberration.intensity.Override(chromAbIntensity);
            if (chromAbIntensity > 0)
            {
                chromAbIntensity -= 0.02f;
                chromaticAberration.intensity.Override(chromAbIntensity);
            }
            if (chromAbIntensity <= 0)
            {
                chromaticAberration.enabled.Override(false);
                effectOne = false;
            }
        }
    }



    public void GoSouvenir()
    {
        depthIntensity = 1f;
        postProcessVolume.profile.TryGetSettings(out depthOfField);
        effectTwo = true;
    }

    private void SouvenirEffect()
    {
        if (effectTwo == true)
        {
            
            depthOfField.enabled.Override(true);
            depthOfField.focalLength.Override(depthIntensity);

            if (invert == false)
            {
                depthIntensity += 2f;
                depthOfField.focalLength.Override(depthIntensity);
                if(depthIntensity >= 100)
                {
                    invert = true;
                    invertNumber += 1;
                }
            }
            if (invert)
            {
                depthIntensity -= 2f;
                depthOfField.focalLength.Override(depthIntensity);
                if (depthIntensity <= 0)
                {
                    invert = false;
                    invertNumber += 1;
                }
            }

            if(invertNumber >= 5)
            {
                depthOfField.enabled.Override(false);
                effectTwo = false;
            }
            
        }
    }


    public void Jumpscare()
    {
        chromAbIntensity = 1f;
        postProcessVolume.profile.TryGetSettings(out chromaticAberration);
        scareEffect = true;
    }

    private void JumpscareEffect()
    {
        if (scareEffect == true)
        {
            chromaticAberration.enabled.Override(true);
            chromaticAberration.intensity.Override(chromAbIntensity);
            if (chromAbIntensity > 0)
            {
                chromAbIntensity -= 0.02f;
                chromaticAberration.intensity.Override(chromAbIntensity);
            }
            if (chromAbIntensity <= 0)
            {
                chromaticAberration.enabled.Override(false);
                scareEffect = false;
            }
        }
    }

}
