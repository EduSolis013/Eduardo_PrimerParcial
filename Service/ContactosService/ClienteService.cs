using Infraestructura.Datos;
using Infraestructura.Modelos;

namespace Servicios.ContactosService;

public class ClienteService 
{
    
    ClienteDatos clienteDatos;

    public ClienteService(string cadenaConexion)
    {
        clienteDatos = new ClienteDatos(cadenaConexion);
    }
    
    public void AgregarCliente(ClienteModel cliente)
    {
        clienteDatos.AgregarCliente(cliente);
    }
    
    public ClienteModel obtenerCliente(int id) 
    {
        return clienteDatos.obtenerCliente(id);
    }

    public void alterarCliente(ClienteModel cliente) 
    {
        clienteDatos.alterarCliente(cliente);
    } 
    
    public ClienteModel quitarCliente(int id) 
    {
        return clienteDatos.quitarCliente(id);
    }
}