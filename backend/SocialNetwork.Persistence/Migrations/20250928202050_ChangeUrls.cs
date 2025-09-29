using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmMatch.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ChangeUrls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0b27972c-b3df-4ae4-9138-2e90c749d139"),
                column: "ImageUrl",
                value: "https://avatars.mds.yandex.net/get-kinopoisk-image/6201401/040a010c-660d-4185-946e-2cd812852ee2/600x900");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("31f80f2a-9426-41e2-93f7-7f12180722a1"),
                column: "ImageUrl",
                value: "https://icdn.lenta.ru/images/2024/06/19/11/20240619112717688/preview_a517b64420fe27aa683b31e8a306868d.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4b4974f1-8ea2-43f1-998f-d3a1cfb9d1c3"),
                column: "ImageUrl",
                value: "https://www.kinonews.ru/insimgs/imgzhanr9.webp");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5dbd7a97-f0a1-4f4e-91c7-244cbab17eec"),
                column: "ImageUrl",
                value: "https://images.iptv.rt.ru/images/cemmbqbir4ssk1206l40.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d0bfe76e-0f12-4fcd-94aa-3be4f90d79e1"),
                column: "ImageUrl",
                value: "https://atomvestnik.ru/wp-content/uploads/2022/08/%D0%9F%D1%80%D0%BE%D1%81%D1%82%D0%BE-%D1%84%D0%B0%D0%BD%D1%82%D0%B0%D1%81%D1%82%D0%B8%D0%BA%D0%B0-%D0%93%D0%9B%D0%90%D0%92%D0%9D%D0%90%D0%AF.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: new Guid("8cb06d19-68aa-4ce3-a1a6-76e48d9f4d55"),
                column: "ImageUrl",
                value: "https://avatars.mds.yandex.net/get-kinopoisk-image/1629390/8ab9a119-dd74-44f0-baec-0629797483d7/600x900");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: new Guid("a1e7b5fa-34df-4bc4-902e-cdfb10dcf001"),
                column: "ImageUrl",
                value: "https://avatars.mds.yandex.net/get-kinopoisk-image/1600647/430042eb-ee69-4818-aed0-a312400a26bf/600x900");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: new Guid("afde4eeb-c0b7-404f-aad0-0d188fe9a921"),
                column: "ImageUrl",
                value: "https://avatars.mds.yandex.net/get-kinopoisk-image/4774061/a53d1c75-4d1a-4c86-a936-65b2a724345c/600x900");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0b27972c-b3df-4ae4-9138-2e90c749d139"),
                column: "ImageUrl",
                value: "http://localhost:5210/images/category/action.png");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("31f80f2a-9426-41e2-93f7-7f12180722a1"),
                column: "ImageUrl",
                value: "http://localhost:5210/images/category/triller.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4b4974f1-8ea2-43f1-998f-d3a1cfb9d1c3"),
                column: "ImageUrl",
                value: "http://localhost:5210/images/category/drama.png");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5dbd7a97-f0a1-4f4e-91c7-244cbab17eec"),
                column: "ImageUrl",
                value: "http://localhost:5210/images/category/comedy.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d0bfe76e-0f12-4fcd-94aa-3be4f90d79e1"),
                column: "ImageUrl",
                value: "http://localhost:5210/images/category/fantasy.png");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: new Guid("8cb06d19-68aa-4ce3-a1a6-76e48d9f4d55"),
                column: "ImageUrl",
                value: "https://avatars.mds.yandex.net/get-kinopoisk-image/4771096/2a0000017e39d1cfcb48b5f4fe5a81e8b9f4/1920x");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: new Guid("a1e7b5fa-34df-4bc4-902e-cdfb10dcf001"),
                column: "ImageUrl",
                value: "https://avatars.mds.yandex.net/get-kinopoisk-image/4771096/2a0000017e39d1cfcb48b5f4fe5a81e8b9f4/1920x");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: new Guid("afde4eeb-c0b7-404f-aad0-0d188fe9a921"),
                column: "ImageUrl",
                value: "https://avatars.mds.yandex.net/get-kinopoisk-image/4771096/2a0000017e39d1cfcb48b5f4fe5a81e8b9f4/1920x");
        }
    }
}
