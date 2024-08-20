namespace LogServiceYiDev.Models
{
    public static class ErrorDictionary
    {
        public static readonly ErrorList[] Errors =
        [
        new() {
            ErrorCode = 1062,
            Description = "Duplicate entry",
            UserMessage = "Entrada duplicada",
            Type = "Error"
        },
        new ()
        {
            ErrorCode = 1048,
            Description = "Column cannot be null",
            UserMessage = "El campo obligatorio no puede estar vacío."
        },
        new() {
            ErrorCode = 1451,
            Description = "Cannot delete or update a parent row: a foreign key constraint fails",
            UserMessage = "No se puede eliminar este registro porque está en uso.",
            Type = "Error"
        },
        new ()
        {
            ErrorCode = 1452,
            Description = "Cannot add or update a child row: a foreign key constraint fails",
            UserMessage = "El valor proporcionado para la clave foránea no es válido.",
            Type = "Error"
        },
        new ()
        {
            ErrorCode = 1366,
            Description = "Incorrect string value",
            UserMessage = "El valor de la cadena contiene caracteres no válidos.",
            Type = "Error"
        },
        new ()
        {
            ErrorCode = 1054,
            Description = "Unknown column",
            UserMessage = "Error en la solicitud: columna desconocida.",
            Type = "Error"
        },
        new ()
        {
            ErrorCode = 1146,
            Description = "Table doesn't exist",
            UserMessage = "Error en la solicitud: la tabla especificada no existe.",
            Type = "Error"
        },
        new ()
        {
            ErrorCode = 1364,
            Description = "Field doesn't have a default value",
            UserMessage = "El campo es obligatorio y no tiene un valor predeterminado.",
            Type = "Error"
        },
        new ()
        {
            ErrorCode = 1049,
            Description = "Unknown database",
            UserMessage = "La base de datos especificada no existe.",
            Type = "Error"
        },
            /////////////// fin MySql
        new() {
            ErrorCode = 5200,
            Description = "Successful request",
            UserMessage = "Transaccion exitosa",
            Type = "Success"
        },
            new() {
            ErrorCode = 5500,
            Description = "Excepcion en la aplicacion",
            UserMessage = "Exception",
            Type = "Excep"
        },
            new() {
            ErrorCode = 5401,
            Description = "Unauthorized user",
            UserMessage = "Usuario no autorizado",
            Type = "Error"
        },
        ];
    }
}
