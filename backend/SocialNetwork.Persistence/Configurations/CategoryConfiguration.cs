using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmMatch.Domain.Entities;

namespace FilmMatch.Persistence.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    Id = Guid.Parse("d0bfe76e-0f12-4fcd-94aa-3be4f90d79e1"),
                    Name = "Фантастика",
                    ImageUrl = "https://atomvestnik.ru/wp-content/uploads/2022/08/%D0%9F%D1%80%D0%BE%D1%81%D1%82%D0%BE-%D1%84%D0%B0%D0%BD%D1%82%D0%B0%D1%81%D1%82%D0%B8%D0%BA%D0%B0-%D0%93%D0%9B%D0%90%D0%92%D0%9D%D0%90%D0%AF.jpg"
                },
                new Category
                {
                    Id = Guid.Parse("31f80f2a-9426-41e2-93f7-7f12180722a1"),
                    Name = "Триллер",
                    ImageUrl = "https://icdn.lenta.ru/images/2024/06/19/11/20240619112717688/preview_a517b64420fe27aa683b31e8a306868d.jpg"
                },
                new Category
                {
                    Id = Guid.Parse("5dbd7a97-f0a1-4f4e-91c7-244cbab17eec"),
                    Name = "Комедия",
                    ImageUrl = "https://images.iptv.rt.ru/images/cemmbqbir4ssk1206l40.jpg"
                },
                new Category
                {
                    Id = Guid.Parse("4b4974f1-8ea2-43f1-998f-d3a1cfb9d1c3"),
                    Name = "Драма",
                    ImageUrl = "https://www.kinonews.ru/insimgs/imgzhanr9.webp"
                },
                new Category
                {
                    Id = Guid.Parse("0b27972c-b3df-4ae4-9138-2e90c749d139"),
                    Name = "Боевик",
                    ImageUrl = "https://avatars.mds.yandex.net/get-kinopoisk-image/6201401/040a010c-660d-4185-946e-2cd812852ee2/600x900"
                }
            );
        }
    }

}
