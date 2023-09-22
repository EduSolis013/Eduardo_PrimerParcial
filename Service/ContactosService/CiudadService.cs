using Infraestructura.Datos;
using Infraestructura.Modelos;

namespace Servicios.ContactosService;

public class CiudadService 
{
    
    CiudadDatos ciudadDatos;

    public CiudadService(string cadenaConexion) 
    {
        ciudadDatos = new CiudadDatos(cadenaConexion);
    }
    
    public void AgregarCiudad(CiudadModel ciudad) {
        ciudadDatos.AgreCiudad(ciudad);
    }
    
    public CiudadModel obtenerCiudad(int id) 
    {
        return ciudadDatos.obtenerCiudad(id);
    }
    
    public void alterarCiudad(CiudadModel ciudad) 
    {
        ciudadDatos.alterarCiudad(ciudad);
    }  
    
    public CiudadModel quitarCiudad(int id) 
    {
        return ciudadDatos.quitarCiudad(id);
    }
    
}