using System;
using System.Collections.Generic;
using IngredienteModel;
namespace RecetaModel;

public class Receta
{
    private List<Ingrediente> ingredientes;
    private int[] cantidades;
    private string nombre;

    public Receta(string pNombre, int[] pCantidades, List<Ingrediente> pIngredientes)
    {
        if (pCantidades.Length == pIngredientes.Count)
        {

            ingredientes = pIngredientes;
            cantidades = pCantidades;
            nombre = pNombre;

        }
        else
        {
            throw new Exception("Parametros Invalidos, los ingredientes no concuerdan con las cantidades");

        }
    }
    public Receta(string pNombre)
    {
        nombre = pNombre;
        ingredientes = new List<Ingrediente>();
        cantidades = new int[0];

    }
    public void setNombre(string pNombre)
    {
        nombre = pNombre;
    }
    public string getNombre()
    {
        return nombre;
    }
    public List<Ingrediente> getIngredientes()
    {
        return ingredientes;
    }
    public void addIngrediente(Ingrediente ingrediente, int cantidad)
    {
        ingredientes.Add(ingrediente);
        int[] tempCantidades = new int[ingredientes.Count];
        for (int i = 0; i < ingredientes.Count - 1; i++)
        {
            tempCantidades[i] = cantidades[i];

        }
        tempCantidades[ingredientes.Count - 1] = cantidad;
        cantidades = tempCantidades;

    }
    public int calculaCalorias()
    {
        int calorias = 0;
        for (int i = 0; i < ingredientes.Count; i++)
        {
            calorias += ingredientes[i].getCalorias() * cantidades[i];
        }
        return calorias;
    }

    public bool findIngrediente(Ingrediente buscado)
    {
        bool encontrado = false;
        for (int i = 0; i < ingredientes.Count && !encontrado; i++)
        {
            encontrado = ingredientes[i].Equals(buscado);

        }
        return encontrado;

    }
    public bool checkTipo(Ingrediente.tipoMateriaPrima tipo)
    {
        bool encontrado = false;
        for (int i = 0; i < ingredientes.Count && !encontrado; i++)
        {
            encontrado = ingredientes[i].getTipo().Equals(tipo);

        }
        return encontrado;

    }


}
