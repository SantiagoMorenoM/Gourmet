using System;
using System.Collections.Generic;
using IngredienteModel;
namespace RecetaModel;

public class Receta
{   //Lista que contiene los ingredientes necesarios para cocinar la receta
    private List<Ingrediente> ingredientes;
    //Cantidad de cada ingrediente que es necesaria para cocinar la receta
    private int[] cantidades;
    //Nombre de la receta
    private string nombre;

    //Constructor en el cual se genera la Receta en base a los parametros recibidos
    public Receta(string pNombre, int[] pCantidades, List<Ingrediente> pIngredientes)
    {
        //Confirma que el número de ingredientes concuerde con el número de cantidades de ingredientes
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
    //Constructor para el caso en que se quiera crear una receta sin ingredientes definidos
    public Receta(string pNombre)
    {
        nombre = pNombre;
        ingredientes = new List<Ingrediente>();
        cantidades = new int[0];

    }
    //Método en el que se módifica el nombre de la receta

    public void setNombre(string pNombre)
    {
        nombre = pNombre;
    }
    //Método en el que se retorna el nombre de la receta
    public string getNombre()
    {
        return nombre;
    }
    //Método en el que se retorna los ingredientes de la receta
    public List<Ingrediente> getIngredientes()
    {
        return ingredientes;
    }
    //Método en el que se agrega un ingredientes a la receta
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
    //Método en el que se calculan las calorias de la receta en base a las calorias de cada ingrediente y las
    // cantidades
    public int calculaCalorias()
    {
        int calorias = 0;
        for (int i = 0; i < ingredientes.Count; i++)
        {
            calorias += ingredientes[i].getCalorias() * cantidades[i];
        }
        return calorias;
    }

    //Método que recibe un ingrediente por parametro y retorna un booleano que indica si la receta hace uso de
    // de el ingrediente recibido
    public bool findIngrediente(Ingrediente buscado)
    {
        bool encontrado = false;
        for (int i = 0; i < ingredientes.Count && !encontrado; i++)
        {
            encontrado = ingredientes[i].Equals(buscado);

        }
        return encontrado;

    }
    //Método que recibe un grupo alimenticio por parametro y que retorna un booleano que indica si la receta
    //utiliza un ingrediente de este grupo alimenticio
    public bool checkGrupoAlimenticio(Ingrediente.gruposAlimenticios tipo)
    {
        bool encontrado = false;
        for (int i = 0; i < ingredientes.Count && !encontrado; i++)
        {
            encontrado = ingredientes[i].getGrupoAlimenticio().Equals(tipo);

        }
        return encontrado;

    }


}
