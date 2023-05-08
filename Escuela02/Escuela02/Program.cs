using System;
using System.Collections.Generic;

class Escuela
{
    protected List<Maestro> maestros;
    protected List<Alumno> alumnos;
    protected List<Administrativo> administrativos;

    public Escuela()
    {
        maestros = new List<Maestro>();
        alumnos = new List<Alumno>();
        administrativos = new List<Administrativo>();
    }

    public void agregarMaestro(Maestro m)
    {
        maestros.Add(m);
    }

    public void agregarAlumno(Alumno a)
    {
        alumnos.Add(a);
    }

    public void agregarAdministrativo(Administrativo ad)
    {
        administrativos.Add(ad);
    }

    public void mostrarMaestros()
    {
        Console.WriteLine("Lista de maestros:");
        foreach (Maestro m in maestros)
        {
            Console.WriteLine(m);
        }
    }

    public void mostrarAlumnos()
    {
        Console.WriteLine("Lista de alumnos:\"\\n\"");
        foreach (Alumno a in alumnos)
        {
            Console.WriteLine(a);
        }
    }

    public void mostrarAdministrativos()
    {
        Console.WriteLine("Lista de administrativos:\"\\n\"");
        foreach (Administrativo ad in administrativos)
        {
            Console.WriteLine(ad);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Escuela EscuDocu = new Escuela();
        EscuDocu.agregarMaestro(new Maestro("0000000001", "Juan", "Pérez", "González", new DateTime(1970, 1, 1), "XXXX000101XXX"));
        EscuDocu.agregarMaestro(new Maestro("0000000002", "María", "García", "Hernández", new DateTime(1975, 2, 3), "XXXX000102XXX"));
        EscuDocu.agregarMaestro(new Maestro("0000000003", "Carlos", "Martínez", "Ruiz", new DateTime(1980, 3, 5), "XXXX000103XXX"));
        EscuDocu.agregarMaestro(new Maestro("0000000004", "Ana", "López", "Sánchez", new DateTime(1985, 4, 7), "XXXX000104XXX"));
        EscuDocu.agregarMaestro(new Maestro("0000000001", "Juan", "Pérez", "González", new DateTime(1970, 1, 1), "XXXX000101XXX"));
        EscuDocu.agregarMaestro(new Maestro("0000000002", "María", "Hernández", "Sánchez", new DateTime(1980, 2, 2), "XXXX800202XXX"));
        EscuDocu.agregarMaestro(new Maestro("1111111111", "Pedro", "García", "López", new DateTime(1980, 2, 3), "XXXX000102XXX"));
        EscuDocu.agregarMaestro(new Maestro("2222222222", "María", "Hernández", "Sánchez", new DateTime(1975, 5, 12), "XXXX000103XXX"));
        EscuDocu.agregarMaestro(new Maestro("3333333333", "Carlos", "Rodríguez", "Ramírez", new DateTime(1987, 9, 8), "XXXX000104XXX"));
        EscuDocu.agregarMaestro(new Maestro("4444444444", "Ana", "Fernández", "Gómez", new DateTime(1990, 11, 20), "XXXX000105XXX"));
        EscuDocu.agregarMaestro(new Maestro("5555555555", "Luis", "Gutiérrez", "Díaz", new DateTime(1982, 4, 18), "XXXX000106XXX"));
        EscuDocu.agregarMaestro(new Maestro("6666666666", "Laura", "Moreno", "Torres", new DateTime(1978, 6, 29), "XXXX000107XXX"));
        EscuDocu.agregarMaestro(new Maestro("7777777777", "Francisco", "Méndez", "Vega", new DateTime(1985, 7, 22), "XXXX000108XXX"));
        EscuDocu.agregarMaestro(new Maestro("8888888888", "Isabel", "Ortega", "Jiménez", new DateTime(1992, 8, 11), "XXXX000109XXX"));
        EscuDocu.agregarMaestro(new Maestro("9999999999", "Jorge", "Santos", "Castillo", new DateTime(1984, 12, 17), "XXXX000110XXX"));
        EscuDocu.agregarMaestro(new Maestro("0123456789", "Marta", "Navarro", "Ruiz", new DateTime(1995, 1, 24), "XXXX000111XXX"));
        EscuDocu.agregarMaestro(new Maestro("9876543210", "Roberto", "Álvarez", "Góngora", new DateTime(1981, 10, 5), "XXXX000112XXX"));
        EscuDocu.agregarMaestro(new Maestro("2468101214", "Lucía", "Molina", "Salas", new DateTime(1989, 3, 14), "XXXX000113XXX"));
        EscuDocu.agregarMaestro(new Maestro("3691215182", "David", "Ramos", "Cruz", new DateTime(1977, 7, 27), "XXXX000114XXX"));
        EscuDocu.agregarMaestro(new Maestro("4812162022", "Alejandra", "Romero", "Chávez", new DateTime(1993, 11, 28), "XXXX000115XXX"));
        EscuDocu.agregarMaestro(new Maestro("6022446688", "Cristina", "Guzmán", "Velasco", new DateTime(1983, 12, 31), "XXXX000116XXX"));


        EscuDocu.agregarAlumno(new Alumno("0000000001", "Luis", "Hernández", "García", new DateTime(2005, 1, 1), "XXXX000201XXX"));
        EscuDocu.agregarAlumno(new Alumno("0000000002", "Isabel", "Martínez", "Rodríguez", new DateTime(2006, 2, 3), "XXXX000202XXX"));
        EscuDocu.agregarAlumno(new Alumno("0000000003", "Mario", "González", "Pérez", new DateTime(2007, 3, 5), "XXXX000203XXX"));
        EscuDocu.agregarAlumno(new Alumno("0000000004", "Laura", "Sánchez", "López", new DateTime(2008, 4, 7), "XXXX000204XXX"));
        EscuDocu.agregarAlumno(new Alumno("12345611", "Juan", "Pérez", "González", new DateTime(2000, 1, 1), "PERJ000101HDF"));
        EscuDocu.agregarAlumno(new Alumno("12345612", "María", "López", "Hernández", new DateTime(2001, 2, 2), "LOHM010202JNG"));
        EscuDocu.agregarAlumno(new Alumno("12345613", "Pedro", "García", "Martínez", new DateTime(2002, 3, 3), "GAMP020303HJK"));
        EscuDocu.agregarAlumno(new Alumno("12345614", "Ana", "Ramírez", "Sánchez", new DateTime(2003, 4, 4), "RASA030404KLM"));
        EscuDocu.agregarAlumno(new Alumno("12345615", "Jorge", "Guzmán", "Pérez", new DateTime(2004, 5, 5), "GUZJ040505NPO"));
        EscuDocu.agregarAlumno(new Alumno("12345616", "Laura", "Torres", "Gómez", new DateTime(2005, 6, 6), "TOGL050606QRT"));
        EscuDocu.agregarAlumno(new Alumno("12345617", "Francisco", "Castro", "Vargas", new DateTime(2006, 7, 7), "CASV060707USW"));
        EscuDocu.agregarAlumno(new Alumno("12345618", "Margarita", "Martínez", "Romero", new DateTime(2007, 8, 8), "MARJ070808VAX"));
        EscuDocu.agregarAlumno(new Alumno("12345619", "Ricardo", "Hernández", "Álvarez", new DateTime(2008, 9, 9), "HERA080909YBZ"));
        EscuDocu.agregarAlumno(new Alumno("12345620", "Sofía", "Sánchez", "Flores", new DateTime(2009, 10, 10), "SAFL091010CKA"));
        EscuDocu.agregarAlumno(new Alumno("12345621", "Luis", "González", "Pérez", new DateTime(2010, 11, 11), "GONL101111DEM"));
        EscuDocu.agregarAlumno(new Alumno("12345622", "Fernanda", "Rodríguez", "Jiménez", new DateTime(2011, 12, 12), "RODJ111212FEN"));
        EscuDocu.agregarAlumno(new Alumno("12345623", "Gabriel", "García", "Hernández", new DateTime(2012, 1, 13), "GARH120113GHI"));
        EscuDocu.agregarAlumno(new Alumno("12345624", "Lucía", "Martínez", "Sánchez", new DateTime(2013, 2, 14), "MARS130214JKL"));
        EscuDocu.agregarAlumno(new Alumno("12345625", "Emilio", "López", "González", new DateTime(2014, 3, 15), "LOPG140315MNO"));
        EscuDocu.agregarAlumno(new Alumno("12345626", "Valentina", "Hernández", "Pérez", new DateTime(2015, 4, 16), "HERP150416PQR"));
        EscuDocu.agregarAlumno(new Alumno("12345627", "Andrés", "Pérez", "Romero", new DateTime(2016, 5, 17), "PERR160517STU"));
        EscuDocu.agregarAlumno(new Alumno("12345628", "Renata", "González", "Flores", new DateTime(2017, 6, 18), "GONR170618VWX"));
        EscuDocu.agregarAlumno(new Alumno("12345629", "César", "Ramírez", "Sánchez", new DateTime(2018, 7, 19), "RAMC180719YZA"));
        EscuDocu.agregarAlumno(new Alumno("12345630", "Ximena", "Vargas", "Gómez", new DateTime(2019, 8, 20), "VAGX190820BCD"));
        EscuDocu.agregarAlumno(new Alumno("12345631", "Diego", "Martínez", "Pérez", new DateTime(2020, 9, 21), "MARJ200921EFJ"));
        EscuDocu.agregarAlumno(new Alumno("12345632", "Abril", "Hernández", "García", new DateTime(2021, 10, 22), "HERA211022GKL"));
        EscuDocu.agregarAlumno(new Alumno("12345633", "Javier", "Guzmán", "Torres", new DateTime(2022, 11, 23), "GUZJ221123HNM"));
        EscuDocu.agregarAlumno(new Alumno("12345634", "Mariana", "Sánchez", "Castro", new DateTime(2023, 12, 24), "SANC231224PKO"));
        EscuDocu.agregarAlumno(new Alumno("12345635", "Eduardo", "González", "Ramírez", new DateTime(2024, 1, 25), "GONR240125QRP"));
        EscuDocu.agregarAlumno(new Alumno("12345636", "Ana", "López", "Hernández", new DateTime(2025, 2, 26), "LOPH250226STQ"));
        EscuDocu.agregarAlumno(new Alumno("12345637", "Pedro", "García", "Martínez", new DateTime(2026, 3, 27), "GARM260327UVW"));
        EscuDocu.agregarAlumno(new Alumno("12345638", "Valeria", "Martínez", "Sánchez", new DateTime(2026, 3, 27), "GARM260327UVW"));

        EscuDocu.agregarAdministrativo(new Administrativo("0000000001", "Miguel", "Gutiérrez", "Fernández", new DateTime(1975, 1, 1), "XXXX000301XXX"));
        EscuDocu.agregarAdministrativo(new Administrativo("0000000002", "Lucía", "Méndez", "Cortés", new DateTime(1980, 2, 3), "XXXX000302XXX"));
        EscuDocu.agregarAdministrativo(new Administrativo("0000000003", "Juan", "García", "Rodríguez", new DateTime(1985, 3, 5), "XXXX000303XXX"));
        EscuDocu.agregarAdministrativo(new Administrativo("12348", "Ana", "García", "Pérez", new DateTime(1995, 4, 4), "GARL950404JKL"));
        EscuDocu.agregarAdministrativo(new Administrativo("12349", "Pedro", "Sánchez", "González", new DateTime(2000, 5, 5), "SANG000505MNO"));
        EscuDocu.agregarAdministrativo(new Administrativo("123410", "Mónica", "Pérez", "Martínez", new DateTime(2005, 6, 6), "PERM050606PQR"));
        EscuDocu.agregarAdministrativo(new Administrativo("123411", "David", "Martínez", "Hernández", new DateTime(2010, 7, 7), "MARH100707STU"));
        EscuDocu.agregarAdministrativo(new Administrativo("123412", "Laura", "González", "García", new DateTime(2015, 8, 8), "GONL150808VWX"));
        EscuDocu.agregarAdministrativo(new Administrativo("123413", "Fernando", "Ramírez", "Sánchez", new DateTime(2020, 9, 9), "RAMF200909YZA"));
        EscuDocu.agregarAdministrativo(new Administrativo("123414", "Sofía", "Vargas", "Gómez", new DateTime(2025, 10, 10), "VARS251010BCD"));
        EscuDocu.agregarAdministrativo(new Administrativo("123415", "Daniel", "Guzmán", "Pérez", new DateTime(2030, 11, 11), "GUZD301111EFJ"));
        EscuDocu.agregarAdministrativo(new Administrativo("123416", "Carolina", "Sánchez", "Hernández", new DateTime(2035, 12, 12), "SANJ351212GKL"));
        EscuDocu.agregarAdministrativo(new Administrativo("123417", "Roberto", "López", "García", new DateTime(2040, 1, 13), "LOPR400113HNM"));
        EscuDocu.agregarAdministrativo(new Administrativo("123418", "Isabel", "García", "Martínez", new DateTime(2045, 2, 14), "GARJ450214PKO"));
        EscuDocu.agregarAdministrativo(new Administrativo("123419", "Juan", "Hernández", "Sánchez", new DateTime(2050, 3, 15), "HERJ500315QRP"));

                EscuDocu.mostrarMaestros();
                EscuDocu.mostrarAlumnos();
                EscuDocu.mostrarAdministrativos();
    }
}