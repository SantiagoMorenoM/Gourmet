
using RecetaModel;
namespace RecetarioModel;
public class Recetario

{    //Lista que contiene las recetas del recetario
     private List<Receta> recetas;
     //Cadena que representa el titulo del recetario
     private string titulo;
     //Constructor en el que se genera un recetario en base a los parametros
     public Recetario(string pTitulo, List<Receta> pRecetas){
         recetas=pRecetas;
         titulo=pTitulo;
     }
     //Método que retorna el titulo del recetario
    public string getTitulo()
    {
        return titulo;
    }
    //Método que retorna la lista de recetas del recetario
    public List<Receta> getRecetas(){
        return recetas;
    }
}
