using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CarSpotter
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Car> SpottedCars = [];

        public MainPage()
        {
            InitializeComponent();

            CarListView.ItemsSource = SpottedCars;
        }

        private void OnSubmitClicked(object sender, EventArgs e)
        {
            string carName = CarNameEntry.Text;
            string carModel = CarModelEntry.Text;

            SpottedCars.Add(new Car { CarName = carName, CarModel = carModel });

            CarNameEntry.Text = "";
            CarModelEntry.Text = "";
        }
    }

    public class Car
    {
        public string CarName { get; set; }
        public string CarModel { get; set; }
    }
}