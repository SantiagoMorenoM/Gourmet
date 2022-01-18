namespace GourmetModel;
using GourmetModel.Receta;
public class Recetario

{
     private List<Receta> recetas;
     private string nombre;
     public Recetario(string pNombre, List<Receta> pRecetas){
         recetas=pRecetas;
         nombre=pNombre;
     }
    public string getNombre()
    {
        return nombre;
    }
    public List<Receta> getRecetas(){
        return recetas;
    }
}
