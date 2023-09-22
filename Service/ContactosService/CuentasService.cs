using Infraestructura.Datos;
using Infraestructura.Modelos;

namespace Servicios.ContactosService;

public class CuentasService 
{
    
    CuentasDatos cuentasDatos;
    
    public CuentasService(string cadenaConexion) 
    {
        cuentasDatos = new CuentasDatos(cadenaConexion);
    }
    
    public void agregarCuenta(CuentasModel cuentas)
    {
        cuentasDatos.agregarCuenta(cuentas);
    }
    
    public CuentasModel obtenerCuenta(int id) 
    {
        return cuentasDatos.obtenerCuenta(id);
    }
    
    public void alterarCuenta(CuentasModel cuentas) 
    {
        cuentasDatos.alterarCuenta(cuentas);
    } 
    
    public CuentasModel quitarCuenta(int id) 
    {
        return cuentasDatos.quitarCuenta(id);
    }
    
}