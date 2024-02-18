using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelthyBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    public void SetMaxhelthy(int helthy)
    {
        slider.maxValue = helthy;
        slider.value = helthy;

      fill.color=  gradient.Evaluate(1f);
        
    }
    public void setHelthybar(int helthy)
    {
        slider.value = helthy;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
