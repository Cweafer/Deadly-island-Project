using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class VitalBars : MonoBehaviour
{
    public Slider healthBar;
    public int maxHealth;
    public int healthDecreaseRate;

    public Slider thirstBar;
    public int maxThirst;
    public int thirstDecreaseRate;

    public Slider hungerBar;
    public int maxHunger;
    public int hungerDecreaseRate;

    /*public Slider woundBar;
    public int minWound;
    public int maxWound;

    public Slider exposureBar;
    public int minExposure;
    public int maxExposure;
    public int exposureIncreaseRate;*/

    void Start()
    {
        healthBar.maxValue = maxHealth;
        healthBar.value = maxHealth;

        thirstBar.maxValue = maxThirst;
        thirstBar.value = maxThirst;

        hungerBar.maxValue = maxHunger;
        hungerBar.value = maxHunger;

        /*woundBar.minValue = minWound;
        woundBar.value = minWound;
        woundBar.maxValue = maxWound;

        exposureBar.minValue = minExposure;
        exposureBar.value = minExposure;
        exposureBar.maxValue = maxExposure;*/
    }

    void Update()
    {
        //HEALTH CONTROL
        if (hungerBar.value <= 0 && (thirstBar.value <= 0))
        {
            healthBar.value -= Time.deltaTime / healthDecreaseRate * 2;
        }
        else if (hungerBar.value <= 0 || thirstBar.value <= 0)
        {
            healthBar.value -= Time.deltaTime / healthDecreaseRate;
        }
        /*else if (woundBar.value >= 0)
        {
            healthBar.value -= Time.deltaTime / woundBar.value;
        }
        else if (exposureBar.value >= 0)
        {
            healthBar.value -= Time.deltaTime / exposureBar.value;
        }*/
        if (healthBar.value <= 0)
        {
            Death();
        }

        //THIRST CONTROL
        if (thirstBar.value >= 0)
        {
            thirstBar.value -= Time.deltaTime / thirstDecreaseRate;
        }
        else if (thirstBar.value <= 0)
        {
            thirstBar.value = 0;
        }
        else if (thirstBar.value >= maxThirst)
        {
            thirstBar.value = maxThirst;
        }

        //HUNGER CONTROL
        if (hungerBar.value >= 0)
        {
            hungerBar.value -= Time.deltaTime / hungerDecreaseRate;
        }
        else if (hungerBar.value <= 0)
        {
            hungerBar.value = 0;
        }
        else if (hungerBar.value >= maxHunger)
        {
            hungerBar.value = maxHunger;
        }

        //WOUND CONTROL
        //if Player collides with danger
        //depending on what the danger is, increase the wound amount accordingly
        //random event, animal attack

        //EXPOSURE CONTROL
        //if Player is not in shelter or near firecamp
        //exposureBar.value += Time.deltaTime / exposureIncreaseRate;
    }

    void Death()
    {
        //Change Scene
    }
}
