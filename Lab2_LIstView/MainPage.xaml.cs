using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab2_LIstView
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]

    public class Food {
        public string name { get; set; }
        public string description { get; set; }
        public string ImageURL1 { get; set; }
        public string ImageURL2 { get; set; }
    }


    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Food> FoodList { get; private set; }
            
          
        
        public MainPage()
        {
            InitializeComponent();
            FoodList  = new ObservableCollection<Food>();            

            FoodList.Add(new Food
            {
                name = "apple",
                description = "an apple a day keeps the doctor away",
                ImageURL1 = "apple.jpg",
                ImageURL2 = "apple2.jpg"
            });

            FoodList.Add(new Food
            {
                name = "banana",
                description = "Monkeys love them",
                ImageURL1 = "banana.jpg",
                ImageURL2 = "banana2.jpg"
            });

            FoodList.Add(new Food
            {
                name = "cherry",
                description = "Don't eat the pit",
                ImageURL1 = "cherry.jpg",
                ImageURL2 = "cherry2.jpg"
            });

            FoodList.Add(new Food
            {
                name = "donut",
                description = "Sugary goodness",
                ImageURL1 = "donut.jpg",
                ImageURL2 = "donut2.jpg"
            });

            FoodList.Add(new Food
            {
                name = "eggs",
                description = "Best food that comes from an animals butt",
                ImageURL1 = "eggs.jpg",
                ImageURL2 = "eggs2.png"
            });
            
            BindingContext = this;
        }
    }
}
