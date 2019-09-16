namespace Exam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autors",
                c => new
                    {
                        IDAutor = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Nacionalidad = c.String(),
                    })
                .PrimaryKey(t => t.IDAutor);
            
            CreateTable(
                "dbo.LibAuts",
                c => new
                    {
                        IDAutor = c.Int(nullable: false, identity: true),
                        IDLibro = c.Int(nullable: false),
                        LibAutor_IDAutor = c.Int(),
                    })
                .PrimaryKey(t => t.IDAutor)
                .ForeignKey("dbo.LibAuts", t => t.LibAutor_IDAutor)
                .Index(t => t.LibAutor_IDAutor);
            
            CreateTable(
                "dbo.Libroes",
                c => new
                    {
                        IDLibro = c.Int(nullable: false, identity: true),
                        Titulo = c.String(),
                        Editorial = c.String(),
                        Area = c.String(),
                        Libros_IDLibro = c.Int(),
                    })
                .PrimaryKey(t => t.IDLibro)
                .ForeignKey("dbo.Libroes", t => t.Libros_IDLibro)
                .Index(t => t.Libros_IDLibro);
            
            CreateTable(
                "dbo.Prestamoes",
                c => new
                    {
                        IDLector = c.Int(nullable: false, identity: true),
                        IDLibro = c.Int(nullable: false),
                        FechaPrestamo = c.DateTime(nullable: false),
                        FechaDevolucion = c.DateTime(nullable: false),
                        Devuelto = c.String(),
                        Prestamos_IDLector = c.Int(),
                    })
                .PrimaryKey(t => t.IDLector)
                .ForeignKey("dbo.Prestamoes", t => t.Prestamos_IDLector)
                .Index(t => t.Prestamos_IDLector);
            
            CreateTable(
                "dbo.Estudiantes",
                c => new
                    {
                        IDlector = c.Int(nullable: false, identity: true),
                        CI = c.Int(nullable: false),
                        Nombre = c.String(),
                        Direccion = c.String(),
                        Carrera = c.String(),
                        Edad = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDlector);
            
            CreateTable(
                "dbo.LibAutAutors",
                c => new
                    {
                        LibAut_IDAutor = c.Int(nullable: false),
                        Autor_IDAutor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.LibAut_IDAutor, t.Autor_IDAutor })
                .ForeignKey("dbo.LibAuts", t => t.LibAut_IDAutor, cascadeDelete: true)
                .ForeignKey("dbo.Autors", t => t.Autor_IDAutor, cascadeDelete: true)
                .Index(t => t.LibAut_IDAutor)
                .Index(t => t.Autor_IDAutor);
            
            CreateTable(
                "dbo.LibroLibAuts",
                c => new
                    {
                        Libro_IDLibro = c.Int(nullable: false),
                        LibAut_IDAutor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Libro_IDLibro, t.LibAut_IDAutor })
                .ForeignKey("dbo.Libroes", t => t.Libro_IDLibro, cascadeDelete: true)
                .ForeignKey("dbo.LibAuts", t => t.LibAut_IDAutor, cascadeDelete: true)
                .Index(t => t.Libro_IDLibro)
                .Index(t => t.LibAut_IDAutor);
            
            CreateTable(
                "dbo.EstudiantePrestamoes",
                c => new
                    {
                        Estudiante_IDlector = c.Int(nullable: false),
                        Prestamo_IDLector = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Estudiante_IDlector, t.Prestamo_IDLector })
                .ForeignKey("dbo.Estudiantes", t => t.Estudiante_IDlector, cascadeDelete: true)
                .ForeignKey("dbo.Prestamoes", t => t.Prestamo_IDLector, cascadeDelete: true)
                .Index(t => t.Estudiante_IDlector)
                .Index(t => t.Prestamo_IDLector);
            
            CreateTable(
                "dbo.PrestamoLibroes",
                c => new
                    {
                        Prestamo_IDLector = c.Int(nullable: false),
                        Libro_IDLibro = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Prestamo_IDLector, t.Libro_IDLibro })
                .ForeignKey("dbo.Prestamoes", t => t.Prestamo_IDLector, cascadeDelete: true)
                .ForeignKey("dbo.Libroes", t => t.Libro_IDLibro, cascadeDelete: true)
                .Index(t => t.Prestamo_IDLector)
                .Index(t => t.Libro_IDLibro);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Prestamoes", "Prestamos_IDLector", "dbo.Prestamoes");
            DropForeignKey("dbo.PrestamoLibroes", "Libro_IDLibro", "dbo.Libroes");
            DropForeignKey("dbo.PrestamoLibroes", "Prestamo_IDLector", "dbo.Prestamoes");
            DropForeignKey("dbo.EstudiantePrestamoes", "Prestamo_IDLector", "dbo.Prestamoes");
            DropForeignKey("dbo.EstudiantePrestamoes", "Estudiante_IDlector", "dbo.Estudiantes");
            DropForeignKey("dbo.Libroes", "Libros_IDLibro", "dbo.Libroes");
            DropForeignKey("dbo.LibroLibAuts", "LibAut_IDAutor", "dbo.LibAuts");
            DropForeignKey("dbo.LibroLibAuts", "Libro_IDLibro", "dbo.Libroes");
            DropForeignKey("dbo.LibAuts", "LibAutor_IDAutor", "dbo.LibAuts");
            DropForeignKey("dbo.LibAutAutors", "Autor_IDAutor", "dbo.Autors");
            DropForeignKey("dbo.LibAutAutors", "LibAut_IDAutor", "dbo.LibAuts");
            DropIndex("dbo.PrestamoLibroes", new[] { "Libro_IDLibro" });
            DropIndex("dbo.PrestamoLibroes", new[] { "Prestamo_IDLector" });
            DropIndex("dbo.EstudiantePrestamoes", new[] { "Prestamo_IDLector" });
            DropIndex("dbo.EstudiantePrestamoes", new[] { "Estudiante_IDlector" });
            DropIndex("dbo.LibroLibAuts", new[] { "LibAut_IDAutor" });
            DropIndex("dbo.LibroLibAuts", new[] { "Libro_IDLibro" });
            DropIndex("dbo.LibAutAutors", new[] { "Autor_IDAutor" });
            DropIndex("dbo.LibAutAutors", new[] { "LibAut_IDAutor" });
            DropIndex("dbo.Prestamoes", new[] { "Prestamos_IDLector" });
            DropIndex("dbo.Libroes", new[] { "Libros_IDLibro" });
            DropIndex("dbo.LibAuts", new[] { "LibAutor_IDAutor" });
            DropTable("dbo.PrestamoLibroes");
            DropTable("dbo.EstudiantePrestamoes");
            DropTable("dbo.LibroLibAuts");
            DropTable("dbo.LibAutAutors");
            DropTable("dbo.Estudiantes");
            DropTable("dbo.Prestamoes");
            DropTable("dbo.Libroes");
            DropTable("dbo.LibAuts");
            DropTable("dbo.Autors");
        }
    }
}
