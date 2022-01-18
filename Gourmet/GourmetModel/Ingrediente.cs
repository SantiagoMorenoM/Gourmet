namespace IngredienteModel;

public class Ingrediente
{
   // enumeración que hace referencia a los grupos alimenticios a los que pueden pertenecer cada ingrediente
    public enum gruposAlimenticios
    {
        Lacteos,
        Carnes,
        Legumbres,
        Vegetales,
        Frutas,
        Cereales
    }
    // Grupo alimenticio del ingrediente
    private gruposAlimenticios grupoAlimenticio;
    //Nombre del ingrediente
    private string nombre;
    //Unidad de medida en la que se medirá el ingrediente
    private string unidadDeMedida;
    //Calorias presentes en cada unidad del ingrediente
    private int caloriasPorUnidad;
    //Constructor en el que se genera un ingrediente
    public Ingrediente(string pNombre, gruposAlimenticios pGrupoAlimenticio, string pUnidadDeMedida , int pCalorias){
        nombre=pNombre;
        grupoAlimenticio=pGrupoAlimenticio;
        unidadDeMedida=pUnidadDeMedida;
        caloriasPorUnidad=pCalorias;

    }
    //Método en el cual se define el grupo alimenticio del ingrediente
    public void setGrupoAlimenticio(gruposAlimenticios pGrupoAlimenticio)
    {
        grupoAlimenticio = pGrupoAlimenticio;
    }
    //Método en el cual se define el nombre del ingrediente
    public void setNombre(string pNombre)
    {
        nombre = pNombre;
    }
    //Método en el cual se define la unidad de medida del ingrediente
    public void setUnidadDeMedida(string pUnidadDeMedida)
    {
        unidadDeMedida = pUnidadDeMedida;
    }
    //Método en el que se retorna el grupo alimenticio del ingrediente
    public gruposAlimenticios getGrupoAlimenticio()
    {
        return grupoAlimenticio;
    }
    //Método en el que se retorna el nombre del ingrediente
    public string getNombre()
    {
        return nombre;
    }
    //Método en el que se retorna la unidad de medida del ingrediente
    public string getUnidadDeMedida()
    {
        return unidadDeMedida;
    }
    //Método en el que se retornan calorias por cada unidad del ingrediente
    public int getCalorias(){
        return caloriasPorUnidad;
    }
}
