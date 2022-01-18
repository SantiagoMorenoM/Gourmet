
using RecetaModel;
namespace RecetarioModel;
public class Recetario

{
     private List<Receta> recetas;
     private string titulo;
     public Recetario(string pTitulo, List<Receta> pRecetas){
         recetas=pRecetas;
         titulo=pTitulo;
     }
    public string getTitulo()
    {
        return titulo;
    }
    public List<Receta> getRecetas(){
        return recetas;
    }
}
