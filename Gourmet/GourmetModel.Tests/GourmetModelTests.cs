using Xunit;
using RecetaModel;
using System.Collections.Generic;
using RecetarioModel;
using IngredienteModel;
namespace GourmetModel.Tests;

public class GourmetModelTests
{
    Ingrediente ingrediente1 = new Ingrediente("Res", Ingrediente.tipoMateriaPrima.Carnes, "gr", 3);
    Ingrediente ingrediente2 = new Ingrediente("Pollo", Ingrediente.tipoMateriaPrima.Carnes, "gr", 4);
    Ingrediente ingrediente3 = new Ingrediente("Zanahoria", Ingrediente.tipoMateriaPrima.Vegetales, "unidad", 50);







    [Fact]
    public void testCantidadRecetas()
    {
        Receta receta = new Receta("Receta");

        List<Receta> recetas = new List<Receta>();
        recetas.Add(receta);
        recetas.Add(receta);
        Recetario recetario = new Recetario("Recetario", recetas);

        Assert.Equal(2, recetario.getRecetas().Count);

    }
    [Fact]
    public void testCantidadIngredientes()
    {
        Receta receta = new Receta("Receta");
        receta.addIngrediente(ingrediente1, 200);
        receta.addIngrediente(ingrediente2, 150);

        Assert.Equal(2, receta.getIngredientes().Count);


    }
    [Fact]
    public void testCalculoCalorias()
    {
        Receta receta = new Receta("Receta");
        receta.addIngrediente(ingrediente1, 200);
        receta.addIngrediente(ingrediente3, 1);

        int preCalculoIngredientes = ingrediente1.getCalorias() * 200;
        preCalculoIngredientes += ingrediente3.getCalorias() * 1;

        Assert.Equal(preCalculoIngredientes, receta.calculaCalorias());


    }
    [Fact]
    public void testFindIngrediente()
    {
        Receta receta = new Receta("Receta");
        receta.addIngrediente(ingrediente2, 200);
        receta.addIngrediente(ingrediente3, 1);


        Assert.True(receta.findIngrediente(ingrediente2), "Debería encontrarse el ingrediente 2");
        Assert.False(receta.findIngrediente(ingrediente1), "No debería encontrarse el ingrediente 1");



    }
    [Fact]
    public void testCheckTipo()
    {
        Receta receta = new Receta("Receta");
        receta.addIngrediente(ingrediente1, 200);
        receta.addIngrediente(ingrediente2, 150);

        Assert.True(receta.checkTipo(Ingrediente.tipoMateriaPrima.Carnes), "Debería confirmar que hay carnes");
        Assert.False(receta.checkTipo(Ingrediente.tipoMateriaPrima.Frutas), "Debería confirmar que no hay frutas");



    }

}