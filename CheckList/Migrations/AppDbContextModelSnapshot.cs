using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CheckList.Models;

namespace CheckList.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CheckList.Models.ChkList", b =>
                {
                    b.Property<int>("ChkListId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ChkListName");

                    b.Property<string>("FromTemplate");

                    b.Property<string>("Json");

                    b.Property<int>("ProjectId");

                    b.HasKey("ChkListId");

                    b.HasIndex("ProjectId");

                    b.ToTable("ChkLists");
                });

            modelBuilder.Entity("CheckList.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ProjectName");

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("CheckList.Models.Template", b =>
                {
                    b.Property<int>("TemplateId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Json");

                    b.Property<int>("ProjectId");

                    b.Property<string>("TemplateName");

                    b.HasKey("TemplateId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Templates");
                });

            modelBuilder.Entity("CheckList.Models.ChkList", b =>
                {
                    b.HasOne("CheckList.Models.Project", "Project")
                        .WithMany("ChkLists")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CheckList.Models.Template", b =>
                {
                    b.HasOne("CheckList.Models.Project", "Project")
                        .WithMany("Templates")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
