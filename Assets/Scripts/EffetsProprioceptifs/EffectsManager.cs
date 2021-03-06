﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class EffectsManager : MonoBehaviour
{
    public PostProcessVolume postProcessVolume;
    public ChromaticAberration chromaticAberration;
    public DepthOfField depthOfField;
    public ColorGrading coloGrading;
    public Vignette vignette;
    public Grain grain;


    public bool effectOne;
    public bool effectTwo;
    public bool scareEffect;
    public bool invert;
    public int invertNumber;
    public float chromAbIntensity;
    public float temperature;
    public float depthIntensity;
    public float flou;
    public bool goReveil;

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
        Reveil();
    }



    public void Cadavre()
    {
        chromAbIntensity = 1f;
        temperature = 100f;
        postProcessVolume.profile.TryGetSettings(out chromaticAberration);
        effectOne = true;
    }

    private void CadavreEffect()
    {
        if (effectOne == true)
        {
            postProcessVolume.profile.TryGetSettings(out coloGrading);
            coloGrading.temperature.Override(temperature);
            coloGrading.enabled.Override(true);
            chromaticAberration.enabled.Override(true);
            chromaticAberration.intensity.Override(chromAbIntensity);
            if (chromAbIntensity > 0)
            {
                temperature -= 1f;
                chromAbIntensity -= 0.01f;
                chromaticAberration.intensity.Override(chromAbIntensity);
            }
            if (chromAbIntensity <= 0)
            {
                chromaticAberration.enabled.Override(false);
                coloGrading.enabled.Override(false);
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
                depthIntensity += 0.8f;
                depthOfField.focalLength.Override(depthIntensity);
                if(depthIntensity >= 100)
                {
                    invert = true;
                    invertNumber += 1;
                }
            }
            if (invert)
            {
                depthIntensity -= 0.8f;
                depthOfField.focalLength.Override(depthIntensity);
                if (depthIntensity <= 0)
                {
                    invert = false;
                    invertNumber += 1;
                }
            }

            if(invertNumber >= 4)
            {
                depthOfField.enabled.Override(false);
                effectTwo = false;
            }
            
        }
    }

    public void Adrenaline()
    {
        postProcessVolume.profile.TryGetSettings(out chromaticAberration);
        chromaticAberration.enabled.Override(true);
        chromaticAberration.intensity.Override(0.75f);
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

    public void SouvenirEffects()
    {
        postProcessVolume.profile.TryGetSettings(out chromaticAberration);
        postProcessVolume.profile.TryGetSettings(out coloGrading);
        postProcessVolume.profile.TryGetSettings(out grain);
        chromaticAberration.enabled.Override(true);
        chromaticAberration.intensity.Override(0.75f);
        coloGrading.enabled.Override(true);
        coloGrading.saturation.Override(-30f);
        coloGrading.temperature.Override(-75f);
        coloGrading.postExposure.Override(0.7f);
        grain.enabled.Override(true);
        grain.intensity.Override(0.74f);
    }

    public void GoReveil()
    {
        flou = 200;
        goReveil = true;
    }

    public void Reveil()
    {
        if (goReveil)
        {
            postProcessVolume.profile.TryGetSettings(out depthOfField);
            depthOfField.enabled.Override(true);
            depthOfField.focalLength.Override(flou);
            flou -= 0.5f;
            if(flou <= 0)
            {
                goReveil = false;
            }
        }

    }

    public void TimerStress()
    {
        postProcessVolume.profile.TryGetSettings(out vignette);
        vignette.enabled.Override(true);
        vignette.color.Override(Color.red);
        vignette.intensity.Override(0.5f);
    }

    public void ResetEP()
    {
        postProcessVolume.profile.TryGetSettings(out chromaticAberration);
        postProcessVolume.profile.TryGetSettings(out coloGrading);
        postProcessVolume.profile.TryGetSettings(out grain);
        postProcessVolume.profile.TryGetSettings(out vignette);
        chromaticAberration.enabled.Override(false);
        vignette.enabled.Override(false);
        coloGrading.postExposure.Override(0.5f);
        coloGrading.temperature.Override(0f);
        coloGrading.saturation.Override(0f);
        grain.enabled.Override(false);
    }

}
