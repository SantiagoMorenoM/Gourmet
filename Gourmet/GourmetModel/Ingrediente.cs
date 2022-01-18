namespace GourmetModel;

public class Ingrediente
{
   
    public enum tipoMateriaPrima
    {
        Lacteos,
        Carnes,
        Legumbres,
        Vegetales,
        Frutas,
        Cereales
    }
    private tipoMateriaPrima tipo;
    private string nombre;
    private string unidadDeMedida;
    public Ingrediente(string pNombre, tipoMateriaPrima pTipo, string pUnidadDeMedida ){
        nombre=pNombre;
        tipo=pTipo;
        unidadDeMedida=pUnidadDeMedida;

    }
    public void setTipo(tipoMateriaPrima pTipo)
    {
        tipo = pTipo;
    }
    public void setNombre(string pNombre)
    {
        nombre = pNombre;
    }
    public void setTipo(string pUnidadDeMedida)
    {
        unidadDeMedida = pUnidadDeMedida
    }
    public tipoMateriaPrima getTipo()
    {
        return tipo;
    }
    public string getNombre()
    {
        return nombre;
    }
    public string getUnidadDeMedida()
    {
        return unidadDeMedida;
    }
}
