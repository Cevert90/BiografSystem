using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesApi.Migrations
{
    /// <inheritdoc />
    public partial class AddDescriptionSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "I detta roliga och underhållande mysterium, som inte liknar något du sett tidigare, är George en herde som varje kväll läser deckarromaner för sina älskade får, i tron att de omöjligt kan förstå. Men när en mystisk händelse stör livet på gården inser fåren att de själva måste bli detektiver. När de följer ledtrådarna och undersöker mänskliga misstänkta bevisar de att även får kan vara briljanta brottslösare.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "En familj stöter på en uråldrig mumie i denna nya tolkning av det klassiska monstret.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Den här gången ställs fansens favorithjältar – nu tillsammans med Johnny Cage själv – mot varandra i den ultimata, och fullständigt skoningslösa, blodiga kampen för att besegra Shao Kahns mörka härskande som hotar själva existensen av Earthrealm och dess försvarare.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Efter att ha använt en mystisk \"One Wish Willow\" i hopp om att vinna sin förälskelses hjärta, får en hopplös romantiker precis det han önskar sig. Men han upptäcker snart att för en del önskningar får man betala ett mörkt och fruktansvärt pris.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "");
        }
    }
}
