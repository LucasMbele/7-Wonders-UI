using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu (fileName ="Grey Cards", menuName="Cards/GreyCards/1")]
public class GreyCards : CardData
{
    
     public override void change_color()
   {
    
      color.GetComponent<Image>().color = new Color32(192,192,192,255);
   }
  
}
