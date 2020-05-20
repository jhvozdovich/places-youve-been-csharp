using Microsoft.VisualStudio.TestTools.UnitTesting;
using Places.Models;
using System.Collections.Generic;
using System;

namespace Places.Test
{
  [TestClass]
  public class CityTests : IDisposable
  {

    public void Dispose()
    {
      City.ClearAll();
    }


    [TestMethod]
    public void PlaceConstructor_CreatePlaceInstance_CityType()
    {
      City newCity = new City("Barcelona", "http://www.test.com", "Nick", "Summer 2017 - Visit Dancing Fountains");
      Assert.AreEqual(typeof(City), newCity.GetType());
    }
    [TestMethod]
    public void PlaceConstructor_TestingCityStoringAbilityInList_CityName()
    {
      City newCity = new City("Barcelona", "http://www.test.com", "Nick", "Summer 2017 - Visit Dancing Fountains");
      City newCity2 = new City("Nice", "http://www.test.com", "Alone", "Car Race");
      Assert.AreEqual("Nice", City.CityList[1].CityName);
    }
    [TestMethod]
    public void PlaceConscructor_TestMyPicture_URL()
    {
      City newCity = new City("Barcelona", "http://www.test.com", "Nick", "Summer 2017 - Visit Dancing Fountains");
      Assert.AreEqual("http://www.test.com", newCity.MyPicture);
    }
  }
}
