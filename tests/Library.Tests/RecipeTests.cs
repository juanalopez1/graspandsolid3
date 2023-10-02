using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace Full_GRASP_And_SOLID.Library;

public class RecipeTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CorrectGetProductionCost()
    {
        Product myProduct = new Product("café", 55.0);
        Equipment myEquipment = new Equipment("batidora", 80.0);
        Step myStep = new Step(myProduct, 2.0, myEquipment, 2);
        Product myProduct2 = new Product("leche", 23.0);
        Equipment myEquipment2 = new Equipment("", 0);
        Step myStep2 = new Step(myProduct2, 1.0, myEquipment2, 0);

        Recipe myRecipe = new Recipe();
        myRecipe.AddStep(myStep);
        myRecipe.AddStep(myStep2);

        double expected = 293;
        double myResult = myRecipe.GetProductionCost();

        Assert.That(myResult, Is.EqualTo(expected));
    }

}