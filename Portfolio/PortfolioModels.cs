namespace Portafolio.Portfolio;

public sealed record SocialLink(string Label, string Url, string Icon);
public sealed record Skill(string Name, string? Level = null);
public sealed record SkillGroup(string Title, IReadOnlyList<Skill> Skills);
public sealed record ExperienceItem(string Role, string Organization, string Period, string Summary,
    IReadOnlyList<string> Details, IReadOnlyList<string> Technologies);
public sealed record Project(string Title, string Year, string Description, IReadOnlyList<string> Technologies,
    string RepositoryUrl, string? DemoUrl = null, string? ImageUrl = null, string ImageAlt = "");
public sealed record EducationItem(string Title, string Institution, string Period, string Status);
public sealed record NavigationItem(string Id, string Label);

public static class PortfolioData
{
    public const string Name = "Nicolas Rios Osorio";
    public const string City = "Medellín, Colombia";
    public const string Email = "nicorioso@gmail.com";
    public const string LinkedIn = "https://www.linkedin.com/in/nicol%C3%A1s-r%C3%ADos-osorio-882556287/";
    public const string GitHub = "https://github.com/nicorioso";
    // [PENDIENTE] Agregar el PDF con este nombre en wwwroot/files/.
    public const string CvPath = "files/cv-nicolas-rios-osorio.pdf";
    public const string PageTitle = "Nicolas Rios Osorio | Desarrollador Full Stack";
    public const string MetaDescription = "Portafolio de Nicolas Rios Osorio, desarrollador de software full stack junior en Medellín, Colombia.";
    public const string HeroStatus = "Disponible para oportunidades junior";
    public const string HeroRole = "Desarrollador de Software Full Stack";
    public const string HeroIntro = "Creo soluciones web y sigo aprendiendo en cada proyecto. Estoy buscando mi primera oportunidad para aportar y crecer como desarrollador.";
    public const string AboutEyebrow = "Un poco sobre mí";
    public const string AboutTitle = "Sobre mí";
    public const string SkillsEyebrow = "Con qué trabajo";
    public const string SkillsTitle = "Habilidades";
    public const string SkillsSubtitle = "Tecnologías que uso y temas que estoy aprendiendo.";
    public const string ExperienceEyebrow = "Mi recorrido";
    public const string ExperienceTitle = "Experiencia";
    public const string ProjectsEyebrow = "Lo que he construido";
    public const string ProjectsTitle = "Proyectos";
    public const string ProjectsSubtitle = "Proyectos personales y de aprendizaje. El código está disponible en GitHub.";
    public const string EducationEyebrow = "Aprendizaje";
    public const string EducationTitle = "Formación";
    public const string ContactEyebrow = "Hablemos";
    public const string ContactTitle = "Contacto";
    public const string ContactSubtitle = "Estoy abierto a conversar sobre oportunidades junior y proyectos. Puedes escribirme o encontrarme en estas redes.";
    public static readonly IReadOnlyList<string> AboutParagraphs =
    [
        "Soy estudiante del Tecnólogo en Análisis y Desarrollo de Software del SENA y me interesa construir aplicaciones útiles, claras y bien organizadas.",
        "Trabajo con C#/.NET, Java, SQL y desarrollo web. En mi práctica tuve la oportunidad de participar en el desarrollo de software y aprender de un equipo con experiencia.",
        "Busco mi primera oportunidad como desarrollador full stack, presencial o remoto. Quiero seguir aprendiendo, colaborar con un equipo y aportar con responsabilidad y curiosidad."
    ];
    public static readonly IReadOnlyList<NavigationItem> Navigation =
    [new("sobre-mi", "Sobre mí"), new("habilidades", "Habilidades"), new("experiencia", "Experiencia"), new("proyectos", "Proyectos"), new("formacion", "Formación"), new("contacto", "Contacto")];

    public static readonly IReadOnlyList<SocialLink> SocialLinks =
    [
        new("GitHub", GitHub, "bi-github"),
        new("LinkedIn", LinkedIn, "bi-linkedin")
    ];

    public static readonly IReadOnlyList<SkillGroup> SkillGroups =
    [
        new("Lenguajes y web", [new("C#", "Intermedio"), new("Java", "Intermedio"), new("HTML y CSS", "Intermedio"), new("JavaScript", "Básico"), new("PHP", "Básico")]),
        new("Datos y APIs", [new("SQL"), new("SQL Server"), new("APIs REST"), new("Postman")]),
        new("Herramientas", [new("Git"), new("GitHub"), new("Linux")]),
        new("Aprendiendo", [new("Docker"), new("Pruebas unitarias"), new("Metodologías ágiles")])
    ];

    public static readonly IReadOnlyList<ExperienceItem> Experience =
    [
        new("Practicante de desarrollo de software", "Aviatur Agencia de Viajes y Turismo", "2024 · 6 meses",
            "Durante mi práctica en el SENA, acompañé al equipo que modernizaba su software de ventas de PHP a .NET.",
            ["Desarrollé un módulo de reservas de viajes.", "Creé procedimientos almacenados en SQL Server y consumí una API, usando Postman para las pruebas.", "Trabajé junto a un desarrollador senior que me orientó durante el proceso."],
            ["ASP.NET Framework 4.8", "SQL Server"])
    ];

    public static readonly IReadOnlyList<Project> Projects =
    [
        new("TechCop + Spring Boot", "2025", "Tienda virtual para un negocio de computadores.",
            ["React", "Spring Boot", "[PENDIENTE: base de datos]"], "https://github.com/nicorioso/TechCop"),
        new("Descargador de YouTube", "", "Aplicación de escritorio en Python con interfaz gráfica para descargar videos hasta 4K o extraer solo el audio en MP3. Funciona en Linux y Windows.",
            ["Python", "CustomTkinter"], "https://github.com/nicorioso/DescargadorVideos")
    ];

    public static readonly IReadOnlyList<EducationItem> Education =
    [
        new("Técnico en Programación de Software", "SENA", "2023", "Finalizado"),
        new("Tecnólogo en Análisis y Desarrollo de Software", "SENA", "2026", "En curso")
    ];
}
