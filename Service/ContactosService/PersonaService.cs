using Infraestructura.Datos;
using Infraestructura.Modelos;


namespace Servicios.ContactosService;

public class PersonaService 
{
    
    PersonaDatos personaDatos;
    
    public PersonaService(string cadenaConexion) 
    {
        personaDatos = new PersonaDatos(cadenaConexion);
    }
    
    public void agregarPersona(PersonaModel persona)
    {
        personaDatos.agregarPersona(persona);
    }
    
    public PersonaModel obtenerPersona(int id)
    {
        return personaDatos.obtenersPersona(id);
    }
    
    public void alterarPersona(PersonaModel persona) 
    {
        personaDatos.alterarPersona(persona);
    } 
    
    public PersonaModel quitarPersona(int id) 
    {
        return personaDatos.quitarPersona(id);
    }
}