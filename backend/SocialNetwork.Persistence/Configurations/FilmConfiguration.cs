using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using FilmMatch.Domain.Entities;

namespace FilmMatch.Persistence.Configurations
{
    public class FilmConfiguration : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.HasData(
                new Film
                {
                    Id = Guid.Parse("a1e7b5fa-34df-4bc4-902e-cdfb10dcf001"),
                    Title = "Интерстеллар",
                    ReleaseDate = DateTime.SpecifyKind(new DateTime(2014, 11, 7), DateTimeKind.Utc),
                    ImageUrl = "https://avatars.mds.yandex.net/get-kinopoisk-image/1600647/430042eb-ee69-4818-aed0-a312400a26bf/600x900",
                    LongDescription = "Эпический научно-фантастический фильм о путешествии через червоточину.",
                    ShortDescription = "Путешествие сквозь космос и время.",
                    CategoryId = Guid.Parse("d0bfe76e-0f12-4fcd-94aa-3be4f90d79e1")
                },
                new Film
                {
                    Id = Guid.Parse("8cb06d19-68aa-4ce3-a1a6-76e48d9f4d55"),
                    Title = "Начало",
                    ReleaseDate = DateTime.SpecifyKind(new DateTime(2010, 7, 16), DateTimeKind.Utc),
                    ImageUrl = "https://avatars.mds.yandex.net/get-kinopoisk-image/1629390/8ab9a119-dd74-44f0-baec-0629797483d7/600x900",
                    LongDescription = "Триллер о проникновении в сны и манипуляции сознанием.",
                    ShortDescription = "Погружение в мир сновидений.",
                    CategoryId = Guid.Parse("31f80f2a-9426-41e2-93f7-7f12180722a1")
                },
                new Film
                {
                    Id = Guid.Parse("afde4eeb-c0b7-404f-aad0-0d188fe9a921"),
                    Title = "Матрица",
                    ReleaseDate = DateTime.SpecifyKind(new DateTime(1999, 3, 31), DateTimeKind.Utc),
                    ImageUrl = "https://avatars.mds.yandex.net/get-kinopoisk-image/4774061/a53d1c75-4d1a-4c86-a936-65b2a724345c/600x900",
                    LongDescription = "Культовый фильм о виртуальной реальности и борьбе за свободу.",
                    ShortDescription = "Виртуальный мир и реальность.",
                    CategoryId = Guid.Parse("d0bfe76e-0f12-4fcd-94aa-3be4f90d79e1")
                }
            );
        }
    }
}
