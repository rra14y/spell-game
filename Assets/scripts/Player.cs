
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{ 
    public int level = 0;
    public int health = 0;
   public TextMeshProUGUI level_text;
    public TextMeshProUGUI health_text;



void sethealth(int amount)
{
    health = amount;
    health_text.text = health.ToString();
}
void setlevel(int amount)
{
    level = amount;
    level_text.text = level.ToString();
}
   
public void SavePlayer()
{
    SaveSystem.SavePlayer(this);

}
public void LoadPlayer()
{
    PlayerData data = SaveSystem.LoadPlayer();
    setlevel(data.level);
    sethealth(data.health);
   
}
}