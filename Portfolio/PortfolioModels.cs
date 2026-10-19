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
    public const string PageTitle = "Nicolas Rios Osorio | Desarrollador de Software Full Stack Junior (.NET, Java, SQL)";
    public const string MetaDescription = "Portafolio de Nicolas Rios Osorio, desarrollador de software full stack junior en Medellín, Colombia. C#/.NET, Java, SQL Server y desarrollo web.";
    public const string HeroStatus = "Disponible para nuevas oportunidades · Presencial o remoto";
    public const string HeroRole = "Desarrollador de Software Full Stack";
    public const string HeroIntro = "Desarrollador full stack junior con experiencia práctica en C#/.NET, SQL Server y desarrollo web. Construyo aplicaciones claras y bien estructuradas, y busco mi primera oportunidad profesional para aportar a un equipo y seguir creciendo.";
    public const string AboutEyebrow = "Perfil profesional";
    public const string AboutTitle = "Sobre mí";
    public const string SkillsEyebrow = "Stack tecnológico";
    public const string SkillsTitle = "Habilidades";
    public const string SkillsSubtitle = "Lenguajes, frameworks y herramientas con las que trabajo, y las que estoy fortaleciendo.";
    public const string ExperienceEyebrow = "Trayectoria";
    public const string ExperienceTitle = "Experiencia";
    public const string ProjectsEyebrow = "Trabajo destacado";
    public const string ProjectsTitle = "Proyectos";
    public const string ProjectsSubtitle = "Proyectos personales y académicos que reflejan mi forma de trabajar. El código fuente está disponible en GitHub.";
    public const string EducationEyebrow = "Formación académica";
    public const string EducationTitle = "Formación";
    public const string ContactEyebrow = "Hablemos";
    public const string ContactTitle = "Contacto";
    public const string ContactSubtitle = "Estoy disponible para conversar sobre oportunidades como desarrollador junior. Escríbeme por correo o conéctate conmigo en LinkedIn y GitHub.";
    public static readonly IReadOnlyList<string> AboutParagraphs =
    [
        "Soy desarrollador de software full stack junior y estudiante del Tecnólogo en Análisis y Desarrollo de Software del SENA. Me enfoco en construir aplicaciones útiles, claras y bien organizadas, cuidando tanto la estructura del código como la experiencia de quien las usa.",
        "Trabajo con C#/.NET, Java, SQL Server y tecnologías web como HTML, CSS y JavaScript. Durante mi práctica profesional en Aviatur participé en la modernización de un sistema de ventas de PHP a .NET, desarrollando un módulo de reservas de viajes y procedimientos almacenados en SQL Server junto a un desarrollador senior.",
        "Busco mi primera oportunidad como desarrollador full stack, en modalidad presencial o remota, donde pueda aportar con responsabilidad, trabajar en equipo y seguir fortaleciendo mis habilidades técnicas."
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
        new("Frameworks y plataformas", [new("Blazor", "Intermedio"), new("ASP.NET Core", "Intermedio"), new("Spring Boot", "Básico"), new("Python", "Básico")]),
        new("Lenguajes y desarrollo web", [new("C#", "Intermedio"), new("Java", "Intermedio"), new("HTML y CSS", "Intermedio"), new("JavaScript", "Básico"), new("PHP", "Básico")]),
        new("Bases de datos y APIs", [new("SQL"), new("SQL Server"), new("Procedimientos almacenados"), new("APIs REST"), new("Postman")]),
        new("Herramientas de desarrollo", [new("Git"), new("GitHub"), new("Linux")]),
        new("En formación", [new("Docker"), new("Pruebas unitarias"), new("Metodologías ágiles")])
    ];

    public static readonly IReadOnlyList<ExperienceItem> Experience =
    [
        new("Practicante de desarrollo de software", "Aviatur Agencia de Viajes y Turismo", "2026 · 6 meses",
            "Práctica profesional del SENA en el equipo de desarrollo que modernizaba el software de ventas de la empresa, migrándolo de PHP a .NET.",
            ["Desarrollé un módulo extenso de reservas de viajes para el sistema de ventas en proceso de migración.", "Implementé procedimientos almacenados en SQL Server para dar soporte a las operaciones de datos del módulo.", "Consumí una API y validé su funcionamiento con Postman.", "Trabajé de forma colaborativa con un desarrollador senior, recibiendo orientación técnica durante todo el proceso."],
            ["ASP.NET Framework 4.8", "C#", "SQL Server", "Postman"])
    ];

    public static readonly IReadOnlyList<Project> Projects =
    [
        new("TechCop · Tienda virtual full stack", "2025", "Aplicación web full stack de comercio electrónico para un negocio de computadores, con interfaz desarrollada en React y backend en Spring Boot.",
            ["React", "Spring Boot", "[PENDIENTE: base de datos]"], "https://github.com/nicorioso/TechCop"),
        new("Descargador de YouTube", "", "Aplicación de escritorio multiplataforma (Linux y Windows) desarrollada en Python, con interfaz gráfica en CustomTkinter. Permite descargar videos hasta en 4K o extraer únicamente el audio en formato MP3.",
            ["Python", "CustomTkinter"], "https://github.com/nicorioso/DescargadorVideos",
            ImageUrl: "img/descargador-videos.png", ImageAlt: "Captura de la aplicación Descargador de YouTube")
    ];

    public static readonly IReadOnlyList<EducationItem> Education =
    [
        new("Técnico en Programación de Software", "SENA", "2023", "Finalizado"),
        new("Tecnólogo en Análisis y Desarrollo de Software", "SENA", "2026", "En curso")
    ];
}
