namespace P6Shop_API_Jessica.Models.DTOs
{
    public class UserDTO
    {
        //Un DTO (Data Transfer Object) es el método nás usado para
        //pasar estructuras entre un API y una App (o cualquier otro UI)
        //Se hace principalemte por dos razones:
        //1. para que el equipo de desarrollo del UI (o posibles ingenierías inversas)
        //no entiendan la estructura de los models en el API
        //2. Simplificar objetos muy complejos, ya que es más rápido pasar la mínima data requerida por los objetos json entre el app y el API
        //3. Si es necesario volver a generar los modelos con el scaffold porque hubo algún cambio de estructura de una 
        //tabla por ejemplo, no es necesario cambiar nada en el controller si la estructura del modelo
        //cambió y además habíamos hecho cambios en el modelo generado automáticamente

        //Nota: Para efectos de ejemplificar el uso del DTO, Vamos a manejar los nombres 
        //de propiedades en español.

        public int IDUsuario { get; set; }
        public string Nombre { get; set; } = null!;
        public string CorreoElectronico { get; set; } = null!;
        public string Contrasennia { get; set; } = null!;
        public string CorreoRespaldo { get; set; } = null!;
        public string MuneroTelefono { get; set; } = null!;
        public int IDRol { get; set; }
        public int IDPais { get; set; }

        //No es necesario en todos los casos escribir las composiciones, este es uno de esos casos

        public string RolDescripcion { get; set; } = null;
        public string PaisNombre { get; set; } = null;

    }
}
