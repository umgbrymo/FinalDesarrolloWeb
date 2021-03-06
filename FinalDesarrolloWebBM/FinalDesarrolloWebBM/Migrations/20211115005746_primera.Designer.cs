// <auto-generated />
using FinalDesarrolloWebBM.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinalDesarrolloWebBM.Migrations
{
    [DbContext(typeof(ModeloContexto))]
    [Migration("20211115005746_primera")]
    partial class primera
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FinalDesarrolloWebBM.Models.Alumno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("activo");

                    b.Property<bool>("aprobadoreprobado");

                    b.Property<string>("primer_apellido")
                        .IsRequired();

                    b.Property<string>("primer_nombre")
                        .IsRequired();

                    b.Property<string>("segundo_apellido")
                        .IsRequired();

                    b.Property<string>("segundo_nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("AlumnoItems");
                });

            modelBuilder.Entity("FinalDesarrolloWebBM.Models.Nota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Idalumno");

                    b.Property<int>("idcurso");

                    b.Property<int>("nota");

                    b.HasKey("Id");

                    b.HasIndex("Idalumno");

                    b.ToTable("NotaItems");
                });

            modelBuilder.Entity("FinalDesarrolloWebBM.Models.Nota", b =>
                {
                    b.HasOne("FinalDesarrolloWebBM.Models.Alumno", "Alumno")
                        .WithMany()
                        .HasForeignKey("Idalumno")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
