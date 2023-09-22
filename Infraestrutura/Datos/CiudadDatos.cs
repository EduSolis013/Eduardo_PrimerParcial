using System.Data;
using Infraestructura.Conexiones;
namespace Infraestructura.Datos;
using Infraestructura.Modelos;

public class CiudadDatos 
{

  private ConexionDB conexion;
  
  public CiudadDatos(string cadenaConexion) 
  {
    conexion = new ConexionDB(cadenaConexion);
  }
  
  public void AgreCiudad(CiudadModel ciudad)
  {
    var conn = conexion.GetConexion();
    var comando = new Npgsql.NpgsqlCommand("insert into ciudad( ciudad, departamento, postal_code)" +
                                           "values(@ciudad, @departamento, @postal_code)", conn);
    comando.Parameters.AddWithValue("ciudad", ciudad.ciudad);
    comando.Parameters.AddWithValue("departamento", ciudad.departamento);
    comando.Parameters.AddWithValue("postal_code", ciudad.postal_code);

    comando.ExecuteNonQuery();
  }
  
  public CiudadModel obtenerCiudad(int id) {
    var conn = conexion.GetConexion();
    var comando = new Npgsql.NpgsqlCommand($"Select * from ciudad where id_ciudad = {id}", conn);
    using var reader = comando.ExecuteReader();
    if (reader.Read())
    {
      return new CiudadModel
      {
        id_ciudad = reader.GetInt32("id_ciudad"),
        ciudad = reader.GetString("ciudad"),
        departamento = reader.GetString("departamento"),
        postal_code = reader.GetInt32("postal_code")
      };
    }
    return null;
  }
  
  public void alterarCiudad(CiudadModel ciudad) 
  {
    var conn = conexion.GetConexion();
    var comando = new Npgsql.NpgsqlCommand($"update ciudad set ciudad = '{ciudad.ciudad}', " +
                                           $"departamento = '{ciudad.departamento}', " +
                                           $"postal_code = '{ciudad.postal_code}' " +
                                           $" where id_ciudad = {ciudad.id_ciudad}", conn);
    comando.ExecuteNonQuery();
  }

  public CiudadModel quitarCiudad(int id)
  {
    var conn = conexion.GetConexion();
    var comando = new Npgsql.NpgsqlCommand($"delete from ciudad where id_ciudad = {id}", conn);
    using var reader = comando.ExecuteReader();
    return null;
  }
  
}