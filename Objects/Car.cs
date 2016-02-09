using System.Collections.Generic;

namespace Cars.Objects
{
  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;

    private static Car firstCar = new Car("2014 Porsche 911", 114991, 7864);
    private static Car secondCar = new Car("2011 Ford F450", 55995, 14241);
    private static Car thirdCar = new Car("2013 Lexus RX 350", 44700, 20000);
    private static Car fourthCar = new Car("2018 Mercedes Benz CLS550", 39900, 37979);

    private static List<Car> _carObjects = new List<Car>(){ firstCar, secondCar, thirdCar, fourthCar };

    // Car constructor
    public Car(string SetMakeModel, int SetPrice, int SetMiles)
    {
      _makeModel = SetMakeModel;
      _price = SetPrice;
      _miles = SetMiles;
    }
    // MakeModel Getter and Setter
    public void SetMakeModel(string carMakeModel){
      _makeModel = carMakeModel;
    }
    public string GetMakeModel()
    {
      return _makeModel;
    }
    // Price Getter and Setter
    public void SetPrice(int carPrice)
    {
      _price = carPrice;
    }
    public int GetPrice()
    {
      return _price;
    }
    // Miles Getter and Setter
    public void SetMiles(int carMiles)
    {
      _miles = carMiles;
    }
    public int GetMiles()
    {
      return _miles;
    }

    // Method to return list of all car objects
    public static List<Car> GetAll()
    {
      return _carObjects;
    }
    // This method takes the newly created car object (from the HomeModule.cs file) and adds it to the list of car objects
    public void Save()
    {
      _carObjects.Add(this);
    }

  }
}
