using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using photodotnet.Data;

namespace photodotnet.Migrations
{
    [DbContext(typeof(PhotoContext))]
    partial class PhotoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("photodotnet.Models.Photo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Key");

                    b.Property<string>("Name");

                    b.Property<string>("Url");

                    b.Property<bool>("Visible");

                    b.HasKey("Id");

                    b.ToTable("Photo");
                });
        }
    }
}
