namespace Examen
{
    public interface IAsignatura
    {
        string Email { get; set; }
        string Nombre { get; set; }
        string NumeroCuenta { get; set; }

        bool Equals(object? obj);
        int GetHashCode();
        void Imprimir();
        string? ToString();
    }
}