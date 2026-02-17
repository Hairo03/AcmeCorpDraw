using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AcmeCorpDraw.WebApp.Migrations
{
    /// <inheritdoc />
    public partial class AddSerialNumbers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SerialNumbers",
                columns: new[] { "Id", "Number" },
                values: new object[,]
                {
                    { 1, "ACME-0JIE-XYX2-N0AT" },
                    { 2, "ACME-0OIF-73CP-X5VS" },
                    { 3, "ACME-0W6O-6ELF-XET8" },
                    { 4, "ACME-0ZQP-X1SV-4MM1" },
                    { 5, "ACME-21TB-AP2C-IJB2" },
                    { 6, "ACME-2NOH-CMFO-XCR4" },
                    { 7, "ACME-2OM6-B1M4-N9NF" },
                    { 8, "ACME-2YNM-14T5-DY8P" },
                    { 9, "ACME-3GPO-KOQL-YT6J" },
                    { 10, "ACME-3PL4-EIQX-8K4Q" },
                    { 11, "ACME-44YA-X9EL-ATXA" },
                    { 12, "ACME-4P7H-PLHH-0G9U" },
                    { 13, "ACME-60UN-FNY6-5IGD" },
                    { 14, "ACME-6GIQ-BUDW-I8FL" },
                    { 15, "ACME-6O0R-GLNH-H8RI" },
                    { 16, "ACME-6OF2-L76M-4FFB" },
                    { 17, "ACME-7JV9-ZD6H-9V9E" },
                    { 18, "ACME-86OA-DWYV-97CF" },
                    { 19, "ACME-86VT-UE7N-W2SG" },
                    { 20, "ACME-96SP-IIUE-3HC0" },
                    { 21, "ACME-AM44-21NZ-7BAO" },
                    { 22, "ACME-ASNZ-FJPK-5WA9" },
                    { 23, "ACME-B0J4-DWMP-AL4O" },
                    { 24, "ACME-C0PV-G3VH-ZLK2" },
                    { 25, "ACME-C5H4-FPH5-4EKE" },
                    { 26, "ACME-CUHZ-AXUC-BQW3" },
                    { 27, "ACME-D9SY-WYV3-4CK9" },
                    { 28, "ACME-DR5A-XQDQ-THN6" },
                    { 29, "ACME-EJ5C-BZSM-Y39Y" },
                    { 30, "ACME-F114-083B-D7IV" },
                    { 31, "ACME-FHTN-C2BI-XGMV" },
                    { 32, "ACME-FHXC-6MO6-8XR8" },
                    { 33, "ACME-FTBC-2DY7-HRVF" },
                    { 34, "ACME-G513-DOS1-MXH7" },
                    { 35, "ACME-GUEE-5W1N-XJV5" },
                    { 36, "ACME-HDWP-3FEE-04XF" },
                    { 37, "ACME-HITW-TRGO-J47R" },
                    { 38, "ACME-HJZC-WJ29-LLX2" },
                    { 39, "ACME-HTR4-WTQK-RLQM" },
                    { 40, "ACME-HXR9-DZFK-22ZC" },
                    { 41, "ACME-I8PX-UC9D-48TO" },
                    { 42, "ACME-IM3S-MUHP-UOBE" },
                    { 43, "ACME-IW1M-DCTN-QINF" },
                    { 44, "ACME-IZQM-G76Z-TN98" },
                    { 45, "ACME-JF69-LLRE-KRHP" },
                    { 46, "ACME-JHMH-Y1SG-EM06" },
                    { 47, "ACME-JPAU-A94S-YKTR" },
                    { 48, "ACME-K87F-C8QH-4ZGD" },
                    { 49, "ACME-KGDB-V5YQ-QC31" },
                    { 50, "ACME-KN8Y-1XGM-6POY" },
                    { 51, "ACME-KNW9-5O4G-PM6K" },
                    { 52, "ACME-LP1C-WLZT-WIOA" },
                    { 53, "ACME-M2F1-3YRX-R2B1" },
                    { 54, "ACME-M8YP-XUFV-ZDFG" },
                    { 55, "ACME-M9GA-HX36-FL15" },
                    { 56, "ACME-MQTV-XHOT-L4R8" },
                    { 57, "ACME-MTC6-0D9Z-IMO7" },
                    { 58, "ACME-MU9Y-FHSN-8QSN" },
                    { 59, "ACME-N2M5-JGLH-JEZY" },
                    { 60, "ACME-NHTL-6K9X-YUS8" },
                    { 61, "ACME-O31P-6CA2-TY64" },
                    { 62, "ACME-OWBW-L1V6-IZKA" },
                    { 63, "ACME-PL1O-JIVK-CS61" },
                    { 64, "ACME-PU94-KWFI-KO0L" },
                    { 65, "ACME-Q1KF-EMRT-XID5" },
                    { 66, "ACME-Q5MG-SU8B-O5QY" },
                    { 67, "ACME-QAXV-KCZ6-XW97" },
                    { 68, "ACME-QIS9-O4TO-97TA" },
                    { 69, "ACME-QPHX-56PT-TMED" },
                    { 70, "ACME-R37Z-VW30-XJXW" },
                    { 71, "ACME-RNP4-PN1C-LC76" },
                    { 72, "ACME-RRRZ-Q67P-6JIS" },
                    { 73, "ACME-SA00-1OY3-12S0" },
                    { 74, "ACME-SBGD-PLXC-RCTQ" },
                    { 75, "ACME-SOES-79ZN-KN0P" },
                    { 76, "ACME-SOOV-UGVJ-CRH2" },
                    { 77, "ACME-STZI-8E3P-LE17" },
                    { 78, "ACME-T2QO-HC6T-EIYL" },
                    { 79, "ACME-T8FT-9FPK-FYFK" },
                    { 80, "ACME-TBM4-NYPV-2A6V" },
                    { 81, "ACME-TP8S-59E3-TBNB" },
                    { 82, "ACME-TS56-AEU9-YM0G" },
                    { 83, "ACME-UKAR-1UFR-CBIL" },
                    { 84, "ACME-VC9M-Q7EU-S9I2" },
                    { 85, "ACME-VDKW-VMOH-OGXT" },
                    { 86, "ACME-VMXB-8VDS-Q4DY" },
                    { 87, "ACME-WWPK-0CMY-099N" },
                    { 88, "ACME-X7UE-R0GR-NT21" },
                    { 89, "ACME-X8JU-4DE9-AYSP" },
                    { 90, "ACME-XKBL-SPUC-5FKA" },
                    { 91, "ACME-XMHN-YJNO-FUKI" },
                    { 92, "ACME-XMXY-A9Q9-OZ9C" },
                    { 93, "ACME-Y9LU-6H7L-HLGX" },
                    { 94, "ACME-YEUC-YVC9-BLEB" },
                    { 95, "ACME-YQWV-6UFZ-P1ZE" },
                    { 96, "ACME-Z3SB-FHBC-YTPB" },
                    { 97, "ACME-Z4Y8-38KJ-HSH8" },
                    { 98, "ACME-Z5KT-WTJL-R7U8" },
                    { 99, "ACME-ZIQW-9E1H-5DAM" },
                    { 100, "ACME-ZVMI-I92G-99YI" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
