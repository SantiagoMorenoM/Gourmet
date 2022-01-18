using System;
using System.Collections.Generic;
using GourmetModel.Ingrediente;
namespace GourmetModel;

public class Receta
{
    private List<Ingrediente> ingredientes;
    private int[] cantidades;
    private string nombre;
    
    public Receta(string pNombre, int[] pCantidades,List<Ingrediente> pIngredientes ){
        if(pCantidades.length==pIngredientes.Count){

            ingredientes=pIngredientes;
            cantidades=pCantidades;
            nombre=pNombre;

        } else{
            Console.WriteLine("Parametros Invalidos, los ingredientes no concuerdan con las cantidades");
        }
    }
      public Receta(string pNombre ){
          nombre=pNombre;
          ingredientes= new List<Ingrediente>();
      
    }
    public void setNombre(string pNombre)
    {
        nombre = pNombre;
    }
    public string getNombre()
    {
        return nombre;
    }
    public void addIngrediente(Ingrediente ingrediente, int cantidad){
        ingredientes.Add(ingrediente);
        int[] tempCantidades= new int[ingredientes.Count];
        for(int i=0; i<ingredientes.Count-1; i++){
            tempCantidades[i]=cantidades[i];

        }
        tempCantidades[ingredientes.Count-1]= cantidad;
        cantidades=tempCantidades;

    }
    

}
