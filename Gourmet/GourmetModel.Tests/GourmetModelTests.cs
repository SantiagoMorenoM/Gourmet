using Xunit;
using RecetaModel;
using System.Collections.Generic;
using RecetarioModel;
using IngredienteModel;
namespace GourmetModel.Tests;

public class GourmetModelTests
{
    //Ingredientes utilizados durante los tests
    Ingrediente ingrediente1 = new Ingrediente("Res", Ingrediente.gruposAlimenticios.Carnes, "gr", 3);
    Ingrediente ingrediente2 = new Ingrediente("Pollo", Ingrediente.gruposAlimenticios.Carnes, "gr", 4);
    Ingrediente ingrediente3 = new Ingrediente("Zanahoria", Ingrediente.gruposAlimenticios.Vegetales, "unidad", 50);







    //Test en el que se revisa que la cantidad de recetas en el recetario concuerde con las introducidas
    [Fact]
    public void testCantidadRecetas()
    {
        Receta receta1 = new Receta("Receta1");
        Receta receta2 = new Receta("Receta2");

        // Se le agregan 2 Recetas al Recetario
        List<Receta> recetas = new List<Receta>();
        recetas.Add(receta1);
        recetas.Add(receta2);
        Recetario recetario = new Recetario("Recetario", recetas);
        //Se revisa que la cantidad de recetas del recetario sean, efectivamente, 2

        Assert.Equal(2, recetario.getRecetas().Count);

    }
    //Test que revisa que la cantidad de ingredientes de la receta concuerden con las introducidas
    [Fact]
    public void testCantidadIngredientes()
    {   //Se agregan 2 ingredientes a la receta
        Receta receta = new Receta("Receta");
        receta.addIngrediente(ingrediente1, 200);
        receta.addIngrediente(ingrediente2, 150);
        //Se revisa que la cantidad de ingredientes de la receta sean, efectivamente, 2

        Assert.Equal(2, receta.getIngredientes().Count);


    }
    //Test que revisa el calculo de calorias de una receta
    [Fact]
    public void testCalculoCalorias()
    {
        Receta receta = new Receta("Receta");
        receta.addIngrediente(ingrediente1, 200);
        receta.addIngrediente(ingrediente3, 1);
        //Se calcula las calorias de la receta tomando el número de unidades y múltiplicado por las calorias
        // de los ingredientes

        int preCalculoIngredientes = ingrediente1.getCalorias() * 200;
        preCalculoIngredientes += ingrediente3.getCalorias() * 1;

        Assert.Equal(preCalculoIngredientes, receta.calculaCalorias());


    }
    //Test que revisa si una receta presenta un ingrediente determinado o no
    [Fact]
    public void testFindIngrediente()
    {
        Receta receta = new Receta("Receta");
        receta.addIngrediente(ingrediente2, 200);
        receta.addIngrediente(ingrediente3, 1);


        Assert.True(receta.findIngrediente(ingrediente2), "Debería encontrarse el ingrediente 2");
        Assert.False(receta.findIngrediente(ingrediente1), "No debería encontrarse el ingrediente 1");



    }
    //Test que revisa si una receta presenta un ingrediente de un grupo alimenticio determinado o no
    [Fact]
    public void testCheckGrupoAlimenticio()
    {
        Receta receta = new Receta("Receta");
        receta.addIngrediente(ingrediente1, 200);
        receta.addIngrediente(ingrediente2, 150);

        Assert.True(receta.checkGrupoAlimenticio(Ingrediente.gruposAlimenticios.Carnes), "Debería confirmar que hay carnes");
        Assert.False(receta.checkGrupoAlimenticio(Ingrediente.gruposAlimenticios.Frutas), "Debería confirmar que no hay frutas");



    }

}