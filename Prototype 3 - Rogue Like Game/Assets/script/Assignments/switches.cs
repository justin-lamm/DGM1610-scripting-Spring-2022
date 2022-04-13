using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switches : MonoBehaviour
{
   public string npcConv;

   public int socialClass;

   public int weather; 

   public string battleConv;

   public string foodRating;

   public int drinks;

   public int emotion; 

   public string transportation;

    public int weapon; 

   public string clothing;


   void Start()
   {
       
       switch(npcConv)
       {
           case "Hello":
           print("Hello good citizen! May the blessings of zander be upon you!");
            break;
           case "Goodbye":
           print("Goodbye! Safe travels to you and your party!");
           break;
           case "We are being attacked":
           print("You run away in shame, you coward!");
           break;

       }
       
        
       switch(socialClass)
       {
           case 5:
           Debug.Log("Hello your Magesty!");
           break;
           case 4:
           Debug.Log("Hello Young Princess!");
           break;
           case 3:
           Debug.Log("Good evening Urtho");
           break;       
           case 2:
           Debug.Log("Hello, Major!");
           break;
           case 1:
           Debug.Log("May I purchase some of your fine cheeses?");
           break;
           case 0:
           Debug.Log("Get away from me you riff raff!");
           break;
           default:
           Debug.Log("I do not talk with strangers!!!");
           break;
           
           }

           switch(weather)
       {
           case 4:
           Debug.Log("It's raining");
           break;
           case 3:
           Debug.Log("It's snowing");
           break;       
           case 2:
           Debug.Log("It's windy");
           break;
           case 1:
           Debug.Log("It's sunny");
           break;
           case 0:
           Debug.Log("It's cloudy");
           break;
           default:
           Debug.Log("Did you not go outside today? Go touch grass!");
           break;
           
           }

           switch(battleConv)
       {
           case "you are quite strong":
           print("You too");
            break;
           case "You are weak":
           print("wait til you see my true power!");
           break;
           case "Stop! I surrender":
           print("You better, fool");
           break;
           case "Come forward":
           print("Why don't you do that as well?");
           break;


       }
           switch(foodRating)
       {
           case "The food is good":
           print("Perfect! Do you want more?");
            break;
           case "The food is horrible":
           print("I'm sorry. Do you want a different dish?");
           break;
           case "The food is ok":
           print("Let us know what we can do better");
           break;
           case "The food is excellent. Thank you":
           print("My pleasure! We will keep it going");
           break;

       }
       
        
       switch(drinks)
       {
           case 5:
           Debug.Log("Here is a bottle of soda");
           break;
           case 4:
           Debug.Log("Here is a cup of orange juice");
           break;
           case 3:
           Debug.Log("Here is a cup of coffee");
           break;       
           case 2:
           Debug.Log("Here is a cup of tea");
           break;
           case 1:
           Debug.Log("Here is a cup of water");
           break;
           case 0:
           Debug.Log("Here is a bottle of lemonade");
           break;
           default:
           Debug.Log("Please select your drink. Aren't you thirsty?");
           break;
           
           }

           switch(emotion)
       {
           case 4:
           Debug.Log("I'm happy");
           break;
           case 3:
           Debug.Log("I'm sad");
           break;       
           case 2:
           Debug.Log("I'm angry, stop bothering me");
           break;
           case 1:
           Debug.Log("I'm stressed. Give me some space");
           break;
           case 0:
           Debug.Log("I'm excited!");
           break;
           default:
           Debug.Log("I dont know. Talk to me normally");
           break;
           
           }

           switch(transportation)
       {
           case "I want to travel on ground":
           print("Here is a horse");
            break;
           case "I want to travel by sea":
           print("Here is a boat");
           break;
           case "I want to travel in the air":
           print("Here is a flying horse");
           break;
           case "I want to travel underground":
           print("Here is a shovel");
           break;
           default:
           Debug.Log("Do you want to go or not?");
           break;


       }
       switch(weapon)
       {
           case 4:
           Debug.Log("Here is a claymore");
           break;
           case 3:
           Debug.Log("here is a bow");
           break;       
           case 2:
           Debug.Log("Here is a sword");
           break;
           case 1:
           Debug.Log("Here is a pair of dual blade");
           break;
           case 0:
           Debug.Log("Here is a hammer");
           break;
           default:
           Debug.Log("Are you going to fight barehanded?");
           break;
           
           }

           switch(clothing)
       {
           case "I want something warm":
           print("Here is a coat");
            break;
           case "I want something cool":
           print("Here is a tank top");
           break;
           case "I want something with high defense":
           print("Here is an armor");
           break;
           case "I want something light":
           print("Just don't wear anything");
           break;
           default:
           Debug.Log("What clothing do you want?");
           break;
       }

   }
}
