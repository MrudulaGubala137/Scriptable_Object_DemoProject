using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CarInfoDisplay : MonoBehaviour
{
    public Cars car;
    public Text name;
    public Image carImage;
    public Text carDescription;
    public Text rank;
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        this.name.text = car.name;
        carImage.sprite = car.carImage;
        carDescription.text = car.carDescription;
        rank.text = car.rank.ToString();
        score.text = car.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
