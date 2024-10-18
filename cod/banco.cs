public class SmartCityContext : DbContext
{
    public SmartCityContext(DbContextOptions<SmartCityContext> options)
        : base(options)
    {
    }

    public DbSet<OcorrenciaCrime> OcorrenciasCrime { get; set; }
    public DbSet<Policial> Policias { get; set; }
    public DbSet<AreaPatrulha> AreasPatrulha { get; set; }
    public DbSet<AlarmeEmergencia> AlarmesEmergencia { get; set; }
}

public class OcorrenciaCrime
{
    public long Id { get; set; }
    public string TipoCrime { get; set; }
    public DateTime DataHora { get; set; }
    public string Localizacao { get; set; }
    public string Status { get; set; }
}

public class Policial
{
    public long Id { get; set; }
    public string Nome { get; set; }
    public string Patente { get; set; }
    public string AreaPatrulha { get; set; }
}

public class AreaPatrulha
{
    public long Id { get; set; }
    public string Nome { get; set; }
    public string LimitesGeograficos { get; set; }
}

public class AlarmeEmergencia
{
    public long Id { get; set; }
    public string TipoAlarme { get; set; }
    public string Localizacao { get; set; }
    public DateTime DataHoraAtivacao { get; set; }
    public string Status { get; set; }
}