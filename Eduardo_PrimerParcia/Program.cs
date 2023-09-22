
using Infraestructura.Modelos;
using Servicios.ContactosService;

CiudadService ciudadService = new CiudadService("Server=localhost;Port=5432;User Id=postgres;Password=8845;Database=Eduardo_PrimerParcial;");

ciudadService.AgregarCiudad(new Infraestructura.Modelos.CiudadModel {
    ciudad = "Carapegua",
    departamento = "Central",
    postal_code = 7742
});

var obtCiudad = ciudadService.obtenerCiudad(2);
Console.WriteLine($"Ciudad: {obtCiudad.ciudad} Codigo postal: {obtCiudad.postal_code}");

var AlterCiudad = ciudadService.obtenerCiudad(1);
AlterCiudad.ciudad = "Ita";
AlterCiudad.departamento = "Central";
AlterCiudad.postal_code = 2056;
ciudadService.alterarCiudad(AlterCiudad);

ciudadService.quitarCiudad(5);

PersonaService personaService = new PersonaService("Server=localhost;Port=5432;User Id=postgres;Password=8845;Database=Eduardo_PrimerParcial;");
ClienteService clienteService = new ClienteService("Server=localhost;Port=5432;User Id=postgres;Password=8845;Database=Eduardo_PrimerParcial;");

personaService.agregarPersona(new Infraestructura.Modelos.PersonaModel() {
    id_ciudad = 2,
    nombre = "Antonio",
    estado = "i",
    apellido = "Gonzalez",
    nro_documento = "2654782",
    email = "antinioonazaleso@gmail.com",

});

var Persona = personaService.obtenerPersona(1);
Console.WriteLine($"Nombre Completo: {Persona.nombre} {Persona.apellido} ");

var AlterPersona  = personaService.obtenerPersona(2);
AlterPersona.id_ciudad = 6;
AlterPersona.nombre = "Amara";
AlterPersona.apellido = "Valteone";
AlterPersona.celular = "09855842265";
AlterPersona.email = "amaravalteone@gmail.com";
AlterPersona.direccion = "Grito y piranga";
AlterPersona.nro_documento = "51456252";

AlterPersona.estado = "a";
personaService.alterarPersona(AlterPersona);

personaService.quitarPersona(3);


clienteService.AgregarCliente(new Infraestructura.Modelos.ClienteModel() {
    id_persona = 1,
    estado = "a",
    calificacion = "7",
    fecha_ingreso = DateTime.Now,
});

var obtCliente = clienteService.obtenerCliente(6);
Console.WriteLine($"clificacion: {obtCliente.calificacion} estado: {obtCliente.estado}");

var AlterCliente = clienteService.obtenerCliente(1);
AlterCliente.id_persona = 1;
AlterCliente.estado = "a";
AlterCliente.calificacion = "2";
AlterCliente.fecha_ingreso = DateTime.Now;;
clienteService.alterarCliente(AlterCliente);

clienteService.quitarCliente(1);

CuentasService cuentaService = new CuentasService("Server=localhost;Port=5432;User Id=postgres;Password=8845;Database=Eduardo_PrimerParcial;");
MovimientoService movimientoService = new MovimientoService("Server=localhost;Port=5432;User Id=postgres;Password=8845;Database=Eduardo_PrimerParcial;");

cuentaService.agregarCuenta(new Infraestructura.Modelos.CuentasModel() {
    id_cliente = 1,
    nro_cuenta = "85-1",
    tipo_cuenta = "Cuenta debito",
    estado = "a",
    costo_mantenimiento = 2000,
    fecha_alta = DateTime.Now,
    saldo = 852,
    moneda = "Libtras Esterlinas",
    nro_contrato = "001",
    promedio_acreditacion = "9.5",

});

var odtCuenta = cuentaService.obtenerCuenta(1);
Console.WriteLine($"cuenta: {odtCuenta.nro_cuenta}  saldo: {odtCuenta.saldo} cuenta: {odtCuenta.tipo_cuenta}");


var AlterCuenta = cuentaService.obtenerCuenta(1);
AlterCuenta.id_cliente = 2;
AlterCuenta.nro_cuenta = "6114";
AlterCuenta.tipo_cuenta = "Credito";
AlterCuenta.estado = "a";
AlterCuenta.costo_mantenimiento = 2504;
AlterCuenta.fecha_alta = DateTime.Now;;
AlterCuenta.saldo = 156;
AlterCuenta.nro_contrato = "9885";
AlterCuenta.moneda = "Yen";
AlterCuenta.promedio_acreditacion = "9";

cuentaService.alterarCuenta(AlterCuenta);

cuentaService.quitarCuenta(3);

movimientoService.AgregarMovimiento(new Infraestructura.Modelos.MovimientoModel() {
    id_cuentas = 8,
    fecha_movimiento = DateTime.Now,
    saldo_anterior = 48485,
    monto_movimiento = 4826,
    tipo_movimiento = "Transferencia",
    cuenta_origen = 79523,
    canal_decimal = "2.845",
    saldo_actual = 1592,
    cuenta_destino = 231815,
});

var obtMovimiento = movimientoService.obtenerMovimiento(2);
Console.WriteLine($"Fecha: {obtMovimiento.fecha_movimiento} saldo: {obtMovimiento.saldo_actual} movimiento: {obtMovimiento.monto_movimiento} destino: {obtMovimiento.cuenta_destino}");

var AlterMovimiento = movimientoService.obtenerMovimiento(2);
AlterMovimiento.id_cuentas = 1;
AlterMovimiento.fecha_movimiento = DateTime.Now;
AlterMovimiento.tipo_movimiento = "Debito";
AlterMovimiento.cuenta_destino = 814306;
AlterMovimiento.canal_decimal = "8";
AlterMovimiento.monto_movimiento = 1529;
AlterMovimiento.saldo_actual = 155693;
AlterMovimiento.cuenta_origen = 48482971;

movimientoService.alterarCiudad(EditMovimiento);

movimientoService.quitarCiudad(3);




