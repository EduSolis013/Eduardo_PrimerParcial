using Infraestructura.Datos;
using Infraestructura.Modelos;

namespace Servicios.ContactosService;

public class MovimientoService {
    MovimientoDatos movimientoDatos;

    public MovimientoService(string cadenaConexion) {
        movimientoDatos = new MovimientoDatos(cadenaConexion);
    }
    
    public void AgregarMovimiento(MovimientoModel movimiento) {
        movimientoDatos.AgregarMovimiento(movimiento);
    }
    
    public MovimientoModel obtenerMovimiento(int id) {
        return movimientoDatos.obtenerMovimiento(id);
    }
    
    public void alterarCiudad(MovimientoModel movimiento) {
        movimientoDatos.alterarCiudad(movimiento);
    } 
    
    public MovimientoModel quitarCiudad(int id) {
        return movimientoDatos.quitarCiudad(id);
    }
}