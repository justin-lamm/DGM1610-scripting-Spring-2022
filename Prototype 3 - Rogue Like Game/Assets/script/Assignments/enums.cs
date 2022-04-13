using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class enums : MonoBehaviour
{

    enum Color {blue, red, yellow, green, orange, purple};
    enum Animal {whale, panda, bird, frog, human, monkey}
    enum CarMake {Oldsmobile, Chevrolet, Ford, Mazda, Toyota, Dodge};
    enum CarModel {Alero, Cruze, Tacoma, Mustang, Miata, Viper};
    enum Food {sandwich, burger, salad, fries, rice, cake}
    enum Seasoning {salt, pepper, ranch, ketchup, mustard, cheese} 
    enum Cloth {coat, shirt, jacket, tanktop, skirt}
    enum Shoe {Adidas, Puma, Nike, slippers, barefoot}
    enum Gametype {roguelike, gacha, MMO, puzzle, racing}
    enum VideoGame {Diablo, Genshin, Runescape, Tetris, Forza}
    // Start is called before the first frame update
    void Start()
    {
        /*
        Color paint;
        paint = Color.green;

        print(paint);
        */

        CarMake make;

        CarModel model;

        make = CarMake.Dodge;
        model = CarModel.Viper;

        print("Car Manufacture:" + make + "Model:"+ model);

        Recall(CarMake.Oldsmobile, CarModel.Alero);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Recall(CarMake make, CarModel model)
    {
        if(make == CarMake.Oldsmobile && model == CarModel.Alero)
        {
            print("there is a recall on your vehicle due to a faulty ignition, please take your car to the nearest to the nearest dealer for repair");

        }
        else if(make == CarMake.Ford && model == CarModel.Mustang)
        {
            print("There is a recall on all Mustangs for being too cool to drive! Please take it to the dealer to be made less cool");
        }
        else
        {
            print("There is no recall notice for your vehicle make and model");
        }
    }

    void Recall(Food food, Seasoning seasonings)
    {
        if(food == Food.burger && seasonings == Seasoning.pepper)
        {
            print("Wow, delicious");

        }
        else if(food == Food.rice && seasonings == Seasoning.mustard)
        {
            print("That's gross");
        }
        else
        {
            print("stay hungry");
        }
    }
    void Recall(Cloth clothings, Shoe shoes)
    {
        if(clothings == Cloth.coat && shoes == Shoe.Adidas)
        {
            print("Dang you got the drip!");

        }
        else if(clothings == Cloth.skirt && shoes == Shoe.barefoot)
        {
            print("What are you evening wearing");
        }
        else
        {
            print("Put some clothes on!");
        }
    }
    void Recall(Gametype gameGenre, VideoGame games)
    {
        if(gameGenre == Gametype.roguelike && games == VideoGame.Diablo)
        {
            print("That's some good taste!");

        }
        else if(gameGenre == Gametype.gacha && games == VideoGame.Genshin)
        {
            print("Nerd!");
        }
        else
        {
            print("Wow congrats! you touch grass.");
        }
    }
    void Recall(Color colors, Animal creatures)
    {
        if(colors == Color.green && creatures == Animal.frog)
        {
            print("It's so cute!");

        }
        else if(colors == Color.orange && creatures == Animal.human)
        {
            print("You ate too much cheetos!");
        }
        else
        {
            print("Pleas, every creature has a color");
        }
    }
}






