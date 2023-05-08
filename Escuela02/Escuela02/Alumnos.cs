class Alumno
{
    public string matricula;
    public string nombre;
    public string apellidoPaterno;
    public string apellidoMaterno;
    public DateTime fechaNacimiento;
    public string curp;

    public Alumno(string matricula, string nombre, string apellidoPaterno, string apellidoMaterno, DateTime fechaNacimiento, string curp)
    {
        this.matricula = "2" + matricula;
        this.nombre = nombre;
        this.apellidoPaterno = apellidoPaterno;
        this.apellidoMaterno = apellidoMaterno;
        this.fechaNacimiento = fechaNacimiento;
        this.curp = curp;
    }

    public override string ToString()
    {
        return string.Format("{0}, {1} {2} ({3}): {4}", apellidoPaterno, nombre, apellidoMaterno, matricula, curp);
    }
}
