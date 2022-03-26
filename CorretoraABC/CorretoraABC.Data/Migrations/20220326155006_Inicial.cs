using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CorretoraABC.Data.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Acoes",
                columns: table => new
                {
                    AcaoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Sigla = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acoes", x => x.AcaoID);
                });

            migrationBuilder.CreateTable(
                name: "Cotacoes",
                columns: table => new
                {
                    CotacaoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AcaoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Abertura = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Alta = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Baixa = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Fechamento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FechamentoAjustado = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Volume = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cotacoes", x => x.CotacaoID);
                    table.ForeignKey(
                        name: "FK_Cotacoes_Acoes_AcaoID",
                        column: x => x.AcaoID,
                        principalTable: "Acoes",
                        principalColumn: "AcaoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Acoes",
                columns: new[] { "AcaoID", "Nome", "Sigla" },
                values: new object[] { new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), "Magazine Luiza S.A.", "MGLU3.SA" });

            migrationBuilder.InsertData(
                table: "Cotacoes",
                columns: new[] { "CotacaoID", "Abertura", "AcaoID", "Alta", "Baixa", "Data", "Fechamento", "FechamentoAjustado", "Volume" },
                values: new object[,]
                {
                    { new Guid("00fb86b9-ad89-4f23-aa87-49ba285ca235"), 13.170000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 13.700000m, 12.917500m, new DateTime(2020, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.212500m, 12.888129m, 58392000 },
                    { new Guid("01258a95-fde9-4dc0-b442-4c19c4c406da"), 14.587500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 14.725000m, 14.402500m, new DateTime(2020, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.465000m, 14.109880m, 36514000 },
                    { new Guid("016f07d5-5bda-4b1a-82d6-06ff68ad121d"), 11.297500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 11.302500m, 11.000000m, new DateTime(2019, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.147500m, 10.865669m, 34445600 },
                    { new Guid("01a9fe17-df0a-4177-a2f8-f02f6e68129c"), 9.137500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.217500m, 8.937500m, new DateTime(2019, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.180000m, 8.930758m, 22660800 },
                    { new Guid("021fb341-2504-4045-98b8-e9f6a4446fd6"), 5.333437m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.405625m, 5.265625m, new DateTime(2019, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.389375m, 5.243051m, 26000000 },
                    { new Guid("0318a3c1-a6a4-4af4-86a1-5a5def554d2c"), 5.625000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.687500m, 5.410312m, new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.504687m, 5.343105m, 43971200 },
                    { new Guid("0420f869-cb87-4923-80ef-a61e98f75b5d"), 5.473437m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.479687m, 5.348125m, new DateTime(2019, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.362812m, 5.205395m, 15523200 },
                    { new Guid("04727e23-5a40-4352-937c-c71a317e75ab"), 5.371250m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.371250m, 5.070312m, new DateTime(2019, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.078125m, 4.929065m, 48358400 },
                    { new Guid("062fa3b8-56d6-41e5-a662-c73634989f8f"), 13.920000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 14.180000m, 13.732500m, new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.145000m, 13.797739m, 32739600 },
                    { new Guid("072d5e67-4497-4ce7-b68c-d824f6ac0ab5"), 6.468750m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 6.593750m, 6.409062m, new DateTime(2019, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.562500m, 6.384326m, 83241600 },
                    { new Guid("07432d42-fd9c-45da-82b3-70a1a143d80c"), 5.312812m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.661250m, 5.185312m, new DateTime(2019, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.559375m, 5.396187m, 122038400 },
                    { new Guid("07a6f81b-5e17-4220-a05d-b48553d21fb6"), 11.125000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 11.325000m, 10.872500m, new DateTime(2019, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.300000m, 11.014312m, 47176000 },
                    { new Guid("07f48dec-dd39-4939-862c-049b2ab0b54a"), 9.125000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.235000m, 9.020000m, new DateTime(2019, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.152500m, 8.904007m, 27328800 },
                    { new Guid("0a7b8842-152c-4bd0-a1e8-ffd8b1037554"), 12.075000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 12.332500m, 11.927500m, new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.332500m, 12.029735m, 29600800 },
                    { new Guid("0d6d6943-8b79-4c0e-86ba-7a706b18bd82"), 7.740625m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 7.758125m, 7.566562m, new DateTime(2019, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.640000m, 7.432570m, 35929600 },
                    { new Guid("0df4daa5-e6e6-4db0-90a6-686df4663f04"), 8.125000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 8.232500m, 7.390000m, new DateTime(2020, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.552500m, 7.367085m, 85826000 },
                    { new Guid("0ee20654-fe91-4fe3-9a44-97ac12e58aa7"), 6.625000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 6.675000m, 6.536562m, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.568750m, 6.390405m, 22857600 },
                    { new Guid("0fcd5567-a406-4e32-b9c1-8cb4ea8f8be7"), 10.797500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 10.995000m, 10.792500m, new DateTime(2019, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.930000m, 10.653667m, 23985600 },
                    { new Guid("10339d24-3332-46d9-a07f-5be2775ed5c2"), 9.517500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.550000m, 9.325000m, new DateTime(2019, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.457500m, 9.200726m, 23158000 },
                    { new Guid("106ae4b4-422d-451d-a412-3da4259db3eb"), 11.375000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 11.377500m, 11.075000m, new DateTime(2019, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.075000m, 10.795001m, 36308000 },
                    { new Guid("109d313e-7dc0-48f7-a4dd-a1a2c56925aa"), 5.312500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.354687m, 5.235312m, new DateTime(2019, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.281250m, 5.126227m, 22780800 },
                    { new Guid("11627dc3-7b9a-4b93-bef7-c68f8ca8848e"), 9.165000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.300000m, 9.087500m, new DateTime(2019, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.300000m, 9.047503m, 31424800 },
                    { new Guid("11fa311f-f611-4058-a29b-90e301d9476c"), 9.287500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.322500m, 9.067500m, new DateTime(2019, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.125000m, 8.877253m, 35486800 },
                    { new Guid("13708881-3a8b-4163-88c6-7b5ff349d05d"), 9.442500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.442500m, 8.992500m, new DateTime(2019, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.105000m, 8.857795m, 38738800 },
                    { new Guid("1432ad33-f206-4188-8ce2-8032d050dc9e"), 7.734687m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 7.826562m, 7.659687m, new DateTime(2019, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.718750m, 7.509182m, 39859200 },
                    { new Guid("15291cbc-13c2-4c5d-b369-e1be742c24dc"), 9.140000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.325000m, 9.012500m, new DateTime(2019, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.325000m, 9.071821m, 23190000 },
                    { new Guid("1580732f-f13b-4b15-83e6-eb09ffd27563"), 14.377500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 14.522500m, 14.162500m, new DateTime(2020, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.322500m, 13.970881m, 39798000 },
                    { new Guid("16293985-0092-449e-b96d-1d174cfa159c"), 6.500000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 6.564375m, 6.468750m, new DateTime(2019, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.514062m, 6.337202m, 22841600 },
                    { new Guid("166cbcb2-35bb-4f00-8cd8-0214f332482e"), 11.175000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 11.422500m, 11.140000m, new DateTime(2019, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.372500m, 11.084981m, 47984000 },
                    { new Guid("16d2c984-14ef-4772-9863-ec4cb7bce504"), 14.400000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 14.667500m, 14.282500m, new DateTime(2020, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.415000m, 14.061110m, 32872800 },
                    { new Guid("18072bbe-7fb2-4327-b390-99c4a4b4c506"), 6.000000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 6.125000m, 5.989062m, new DateTime(2019, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.125000m, 5.958704m, 27113600 },
                    { new Guid("1807c1ec-825c-4bae-9e28-84dee971c993"), 5.359062m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.562187m, 5.328125m, new DateTime(2019, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.535937m, 5.373438m, 39683200 },
                    { new Guid("186dd989-e730-4a8a-8345-c2a940f97e8f"), 5.562500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.578125m, 5.484687m, new DateTime(2019, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.537187m, 5.374651m, 25369600 },
                    { new Guid("19649741-125d-43e1-a9c1-3f21286b2657"), 10.862500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 11.400000m, 10.800000m, new DateTime(2019, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.400000m, 11.111783m, 65134000 },
                    { new Guid("1a775059-cb83-4a43-ad35-3a1dcbd82bb2"), 14.192500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 14.262500m, 14.000000m, new DateTime(2020, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.037500m, 13.692876m, 30074800 },
                    { new Guid("1ab6b176-f76d-4952-9192-97af4a70882d"), 8.768750m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 8.899687m, 8.671875m, new DateTime(2019, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.860937m, 8.620358m, 45667200 },
                    { new Guid("1b4ea8a0-6995-43fb-b987-c6427ddbf79d"), 7.694375m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 7.931250m, 7.653125m, new DateTime(2019, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.875000m, 7.661191m, 37884800 },
                    { new Guid("1bf50286-8b0b-4f56-9b7f-1aa838def646"), 8.750000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.977500m, 8.517500m, new DateTime(2020, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.517500m, 8.308393m, 92384800 },
                    { new Guid("1d64cb87-1388-4855-9ccc-44530bd689ae"), 11.237500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 11.825000m, 11.227500m, new DateTime(2019, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.797500m, 11.499234m, 92438400 },
                    { new Guid("1e15325b-85c4-4773-8e21-2e56329e5be5"), 14.120000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 14.237500m, 13.915000m, new DateTime(2020, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.132500m, 13.785544m, 24566000 },
                    { new Guid("1e2423ff-5042-49fd-a780-0b858da39a3c"), 13.930000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 14.185000m, 13.902500m, new DateTime(2020, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.977500m, 13.634349m, 32257200 },
                    { new Guid("1e2d1e91-9b4a-4148-9503-b576eb78d39e"), 11.250000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 11.297500m, 10.942500m, new DateTime(2019, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.245000m, 10.960704m, 110621200 }
                });

            migrationBuilder.InsertData(
                table: "Cotacoes",
                columns: new[] { "CotacaoID", "Abertura", "AcaoID", "Alta", "Baixa", "Data", "Fechamento", "FechamentoAjustado", "Volume" },
                values: new object[,]
                {
                    { new Guid("208954a9-510e-4090-bf6b-84b3ec99ae6d"), 8.450000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 8.717500m, 8.192500m, new DateTime(2019, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.717500m, 8.480815m, 42700800 },
                    { new Guid("20fff1d9-78c5-4c38-8c7b-090f2f313823"), 5.719062m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.781250m, 5.562500m, new DateTime(2019, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.570312m, 5.419076m, 32684800 },
                    { new Guid("21d9a2c5-aa92-48d5-9f41-4d710f39d998"), 6.062500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 6.062500m, 5.878125m, new DateTime(2019, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.937812m, 5.776597m, 22060800 },
                    { new Guid("23563c23-ae24-43a4-af83-eabb3b47a8d3"), 13.762500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 13.825000m, 13.437500m, new DateTime(2020, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.450000m, 13.119799m, 30095200 },
                    { new Guid("23f2d0c4-03c8-48c2-8222-26a7079507ea"), 5.328750m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.353125m, 5.160937m, new DateTime(2019, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.233750m, 5.080121m, 36246400 },
                    { new Guid("24218db5-07e9-44b7-bb5b-8d58287fc2db"), 6.531250m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 6.593437m, 6.453125m, new DateTime(2019, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.453437m, 6.278223m, 33401600 },
                    { new Guid("24bd064a-08fb-4913-8b81-b8671deef024"), 5.436562m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.460625m, 5.352812m, new DateTime(2019, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.352812m, 5.195687m, 16227200 },
                    { new Guid("258ab570-3773-4efd-9048-91da0c2dce33"), 11.032500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 11.602500m, 10.762500m, new DateTime(2020, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.332500m, 11.054286m, 113371200 },
                    { new Guid("258ae05b-99a6-4a0b-a3e6-b4f89d743f58"), 9.400000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.482500m, 8.977500m, new DateTime(2019, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.072500m, 8.826178m, 44445600 },
                    { new Guid("258b9305-55f1-467c-9a10-cbd89e7f4368"), 12.132500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 12.182500m, 11.975000m, new DateTime(2019, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.155000m, 11.847696m, 30079600 },
                    { new Guid("2592024d-e595-48c6-9828-e8de42ce2188"), 5.765625m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.789062m, 5.625000m, new DateTime(2019, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.625625m, 5.472887m, 29926400 },
                    { new Guid("27a78979-d801-4899-b0cc-4e2f57038656"), 7.245312m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 7.318437m, 7.232812m, new DateTime(2019, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.312500m, 7.113962m, 22313600 },
                    { new Guid("27f1d739-4513-42db-8d61-eb8d7c2d083a"), 13.530000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 14.000000m, 13.512500m, new DateTime(2020, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.000000m, 13.656297m, 29623600 },
                    { new Guid("2aac1c13-cb37-4876-a266-268e20c07e0a"), 11.070000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 11.297500m, 11.017500m, new DateTime(2019, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.222500m, 10.938771m, 39038400 },
                    { new Guid("2ad7017c-c96a-4d0e-92bd-1d7c1683ae1e"), 6.296875m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 6.322187m, 5.977500m, new DateTime(2019, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.004687m, 5.841657m, 54857600 },
                    { new Guid("2b08752c-580a-4ab5-8ceb-6e9df42ff7ff"), 5.111250m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.148125m, 4.953750m, new DateTime(2019, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.994375m, 4.858776m, 39385600 },
                    { new Guid("2d00d866-b1d1-423b-a7e7-092f962d9149"), 5.281562m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.388750m, 5.161562m, new DateTime(2019, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.337187m, 5.180521m, 44809600 },
                    { new Guid("2d5f7f40-48de-4223-aba1-f9651881b3f7"), 14.092500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 14.175000m, 13.755000m, new DateTime(2020, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.125000m, 13.778227m, 44303600 },
                    { new Guid("2d66dbc4-018b-445b-9549-914145ee54c6"), 6.875000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 7.842500m, 6.250000m, new DateTime(2020, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.637500m, 7.449998m, 112723200 },
                    { new Guid("2dcb2730-e3a4-46fc-89b9-26b29b7d8840"), 5.642187m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.695312m, 5.593750m, new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.695312m, 5.528135m, 31497600 },
                    { new Guid("2f684b5a-5889-4a26-a15f-00acc7d50150"), 8.750000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 8.847500m, 8.470000m, new DateTime(2019, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.750000m, 8.512433m, 50517200 },
                    { new Guid("2fba72e1-bfb0-4790-8bec-447c70aff3cb"), 6.437500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 6.441875m, 6.281250m, new DateTime(2019, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.347500m, 6.175162m, 42611200 },
                    { new Guid("3045365f-c051-464d-8017-d92d8a924829"), 13.730000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 14.325000m, 13.525000m, new DateTime(2020, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.262500m, 13.912353m, 54978400 },
                    { new Guid("308e4eea-925d-4aba-bf69-11050b27290b"), 6.003125m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 6.109375m, 6.003125m, new DateTime(2019, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.046875m, 5.882699m, 29065600 },
                    { new Guid("3162db9f-df2a-403c-825f-b1bf9f86f09a"), 5.437187m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.444375m, 5.218750m, new DateTime(2019, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.218750m, 5.065561m, 40012800 },
                    { new Guid("31c87b51-5d57-4951-83b8-51f2076f4511"), 5.625000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.653125m, 5.486875m, new DateTime(2019, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.530312m, 5.367978m, 32902400 },
                    { new Guid("33172531-08fa-4245-9296-17b5dd13e1ed"), 10.550000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 10.795000m, 10.512500m, new DateTime(2019, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.667500m, 10.397802m, 42348000 },
                    { new Guid("33cf22e0-bfbb-44db-abd5-30c0cf952d41"), 5.285000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.335000m, 5.236250m, new DateTime(2019, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.312187m, 5.156256m, 23593600 },
                    { new Guid("34475cf5-bb09-4fb0-95d6-c6e2bc11ec75"), 13.500000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 13.882500m, 12.885000m, new DateTime(2020, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.095000m, 12.773516m, 51324800 },
                    { new Guid("359b4295-9837-41fe-b861-5f4ed2e44d66"), 5.570312m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.611562m, 5.487500m, new DateTime(2019, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.540000m, 5.377381m, 22969600 },
                    { new Guid("37a99a40-7d2e-43a4-accd-102d5e476028"), 5.250312m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.357500m, 5.250000m, new DateTime(2019, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.343750m, 5.198665m, 16678400 },
                    { new Guid("38959531-3ec6-4622-9997-9c49a7d41b85"), 8.250000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 8.327500m, 7.907500m, new DateTime(2019, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.125000m, 7.904402m, 96050400 },
                    { new Guid("3a1f8419-b5f4-40aa-9efc-3a9d73bd8571"), 14.482500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 14.532500m, 13.957500m, new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.135000m, 13.787984m, 44558000 },
                    { new Guid("3a8ea090-f315-486b-86b6-a43ec1f3ce58"), 9.187500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.305000m, 9.135000m, new DateTime(2019, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.260000m, 9.008588m, 20688400 },
                    { new Guid("3a9052d6-5ee6-4b72-90d5-2d35d95d9cae"), 12.200000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 12.247500m, 11.877500m, new DateTime(2019, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.925000m, 11.623511m, 32350400 },
                    { new Guid("3d40cef3-68b7-44d0-97ec-2c007a2b1d8d"), 12.125000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 12.332500m, 12.075000m, new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.222500m, 11.922435m, 26737600 },
                    { new Guid("3d6ccef9-70fc-4a8b-80a2-6e6839e7234c"), 5.311250m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.311875m, 5.140937m, new DateTime(2019, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.166562m, 5.014905m, 21715200 },
                    { new Guid("3d87e633-dfe2-4b71-ad13-2913022d065e"), 5.529687m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.580312m, 5.486562m, new DateTime(2019, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.515625m, 5.353722m, 13638400 },
                    { new Guid("3dc5d0e7-ad6c-4af1-8a05-16ab607711dc"), 11.175000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 11.437500m, 11.000000m, new DateTime(2019, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.017500m, 10.738955m, 58363600 },
                    { new Guid("3ee0ca4d-f608-4435-a5a7-0ced9aad07ac"), 5.465312m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.593750m, 5.412812m, new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.475625m, 5.314896m, 28412800 },
                    { new Guid("3f8fd6fd-15a6-4f9d-ad44-3271849cee5a"), 14.625000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 14.710000m, 14.257500m, new DateTime(2020, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.325000m, 13.973318m, 34484400 },
                    { new Guid("3fbc9293-44c4-4a43-828d-1411150f4aac"), 5.248437m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.398750m, 5.212812m, new DateTime(2019, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.283437m, 5.128349m, 40563200 }
                });

            migrationBuilder.InsertData(
                table: "Cotacoes",
                columns: new[] { "CotacaoID", "Abertura", "AcaoID", "Alta", "Baixa", "Data", "Fechamento", "FechamentoAjustado", "Volume" },
                values: new object[,]
                {
                    { new Guid("400d83a9-c32e-4b8c-b5a9-5f51f61e1dcb"), 10.837500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 10.887500m, 10.605000m, new DateTime(2019, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.775000m, 10.502585m, 24721600 },
                    { new Guid("40da6db3-406e-44bf-bac6-553ca81e1b7f"), 5.968750m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 6.218750m, 5.968750m, new DateTime(2019, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.132812m, 5.966303m, 38476800 },
                    { new Guid("41ff139b-ae2f-46e4-b47b-adfcf75038fd"), 9.145000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.145000m, 8.935000m, new DateTime(2019, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.997500m, 8.753214m, 24673600 },
                    { new Guid("41ff8b0b-e6fd-4565-b427-020f793aec07"), 9.070000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.345000m, 8.945000m, new DateTime(2019, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.970000m, 8.726461m, 29592000 },
                    { new Guid("4212082b-2a97-4184-b38e-5905389a2111"), 6.619687m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 6.902187m, 6.601250m, new DateTime(2019, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.901562m, 6.714182m, 43267200 },
                    { new Guid("463c6733-489a-486a-a4e8-47aba7ae282f"), 7.531250m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 7.733437m, 7.468750m, new DateTime(2019, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.729687m, 7.519824m, 47913600 },
                    { new Guid("46be1310-d88f-480a-a256-86cbe4cc142a"), 11.255000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 11.397500m, 11.200000m, new DateTime(2019, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.350000m, 11.063050m, 30212800 },
                    { new Guid("47605ade-8588-4408-8840-5659f1d60497"), 13.910000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 14.287500m, 13.800000m, new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.950000m, 13.607524m, 38781200 },
                    { new Guid("47bfaacf-b8bd-46c8-9f5e-42746d38781a"), 13.450000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 13.607500m, 13.275000m, new DateTime(2020, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.587500m, 13.253923m, 24184000 },
                    { new Guid("47e25dbc-c93b-4f58-8c33-c77c82244003"), 10.625000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 10.690000m, 8.552500m, new DateTime(2020, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.500000m, 10.242224m, 120562800 },
                    { new Guid("486057ff-5898-444a-a42e-11a6cfc2e0e7"), 7.065312m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 7.225000m, 7.037500m, new DateTime(2019, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.168750m, 6.974115m, 30169600 },
                    { new Guid("48641e31-05f9-4b65-9ff2-73275d778c3a"), 5.946875m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 6.106250m, 5.847187m, new DateTime(2019, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.914687m, 5.754100m, 45321600 },
                    { new Guid("4aaf6ec4-323e-46bd-b48f-01afacc0c414"), 6.509062m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 6.546562m, 6.420937m, new DateTime(2019, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.520312m, 6.343283m, 23817600 },
                    { new Guid("4adfad7d-488d-423b-85d4-ad358c465b93"), 8.371875m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 8.437500m, 8.135625m, new DateTime(2019, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.241250m, 8.017494m, 50419200 },
                    { new Guid("4ee0bd3f-ff39-44c6-9db5-414fb38933e4"), 9.225000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.225000m, 8.810000m, new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.077500m, 8.831042m, 46431600 },
                    { new Guid("50825b9a-38a3-43cb-9c34-6e484301783d"), 5.127500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.270625m, 5.071875m, new DateTime(2019, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.150937m, 4.999739m, 26668800 },
                    { new Guid("511cf6ec-1b95-4eae-b422-bd103252bbf2"), 6.026875m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 6.026875m, 5.809375m, new DateTime(2019, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.809375m, 5.651648m, 34588800 },
                    { new Guid("5121743c-d21e-4d5f-98c9-d8c29eb89635"), 5.496875m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.530625m, 5.314687m, new DateTime(2019, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.420625m, 5.261511m, 32044800 },
                    { new Guid("54af89d5-3313-458a-bcdc-2508c8c1a5a1"), 12.250000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 12.630000m, 11.805000m, new DateTime(2020, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.630000m, 12.319931m, 78799200 },
                    { new Guid("54b3bc31-e550-49b7-92fd-63a168a9b895"), 8.850000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.087500m, 8.850000m, new DateTime(2019, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.952500m, 8.709436m, 46304000 },
                    { new Guid("55938387-10f3-44bd-b306-2065189d0b40"), 6.956875m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 7.000000m, 6.909375m, new DateTime(2019, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.909375m, 6.721782m, 36316800 },
                    { new Guid("56efffeb-48a4-4256-8267-195598c1c895"), 5.593750m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.625000m, 5.540000m, new DateTime(2019, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.578437m, 5.426980m, 16448000 },
                    { new Guid("57531604-8511-4fb2-a07d-ff27c300ba9c"), 11.245000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 11.312500m, 10.882500m, new DateTime(2019, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.130000m, 10.848610m, 59731600 },
                    { new Guid("576d01b3-d07e-4ece-8c83-222029c3e627"), 9.397500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.462500m, 9.100000m, new DateTime(2019, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.390000m, 9.135057m, 35834400 },
                    { new Guid("57a2617d-5164-437e-a72d-de86cd4bdacb"), 12.155000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 12.587500m, 12.125000m, new DateTime(2020, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.572500m, 12.263843m, 40007200 },
                    { new Guid("59513567-55b3-4fec-9d70-9b36124dca36"), 7.875000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 8.263750m, 7.832812m, new DateTime(2019, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.243750m, 8.019929m, 46249600 },
                    { new Guid("59c2873e-f041-4fbc-af62-a79ac807c127"), 10.845000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 10.875000m, 10.500000m, new DateTime(2019, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.500000m, 10.234539m, 32608400 },
                    { new Guid("5abce485-325a-41e0-afae-2d7feff0b587"), 8.835000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 8.912500m, 8.332500m, new DateTime(2020, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.885000m, 8.666871m, 65810400 },
                    { new Guid("5b80d1b3-1508-439b-9d0d-b4cb2967f84c"), 9.175000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.225000m, 8.570000m, new DateTime(2019, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.607500m, 8.373804m, 52826400 },
                    { new Guid("5be4ef42-cf04-43b2-8f35-02128084384d"), 5.187500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.215000m, 5.075000m, new DateTime(2019, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.109375m, 4.959397m, 41980800 },
                    { new Guid("5c19c38e-b6e0-4971-b8b0-dd601d3c9b34"), 7.781875m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 7.799375m, 7.542187m, new DateTime(2019, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.562500m, 7.357175m, 36387200 },
                    { new Guid("5cbf55a5-d4eb-4089-850e-5a7e7ae03f15"), 5.262500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.262500m, 5.125000m, new DateTime(2019, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.187500m, 5.035228m, 20828800 },
                    { new Guid("5e3fcdd0-80bc-4ccd-a833-5c7e4520167b"), 11.332500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 11.512500m, 11.207500m, new DateTime(2019, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.400000m, 11.111783m, 48190000 },
                    { new Guid("5f313f75-3c84-41c2-bfa1-14bd4f845f5f"), 5.656250m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.755937m, 5.562500m, new DateTime(2019, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.632812m, 5.479878m, 35641600 },
                    { new Guid("5fe8e082-8e84-425a-b6e1-cdc82a377192"), 12.150000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 12.312500m, 12.100000m, new DateTime(2019, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.185000m, 11.876938m, 26009200 },
                    { new Guid("6158e3d7-6b3f-42c2-83f2-dabd030865df"), 9.022500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.040000m, 8.377500m, new DateTime(2019, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.550000m, 8.317863m, 57427200 },
                    { new Guid("617d36b2-737c-41bc-87b4-e76688f8bd02"), 10.795000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 10.847500m, 10.157500m, new DateTime(2019, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.287500m, 10.027411m, 49930800 },
                    { new Guid("62627ee5-8bac-4544-a227-f3065718f8e8"), 6.937500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 7.130312m, 6.889375m, new DateTime(2019, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.065000m, 6.873182m, 31500800 },
                    { new Guid("6262fcd6-505e-4732-9134-39f4c334ad85"), 13.300000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 13.700000m, 12.932500m, new DateTime(2020, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.567500m, 13.234415m, 37954800 },
                    { new Guid("62724b7d-37fe-4a0e-8ca7-f6f6e169b798"), 6.593750m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 6.686875m, 6.589687m, new DateTime(2019, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.645312m, 6.464888m, 39737600 },
                    { new Guid("62c25be1-c4b1-4bb5-92c7-359b943b91b5"), 9.672500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 10.185000m, 9.412500m, new DateTime(2020, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.750000m, 9.510635m, 68294000 },
                    { new Guid("62ed12fb-b8da-4b22-83ed-da440e603d10"), 5.468750m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.468750m, 5.198750m, new DateTime(2019, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.250000m, 5.095894m, 51513600 }
                });

            migrationBuilder.InsertData(
                table: "Cotacoes",
                columns: new[] { "CotacaoID", "Abertura", "AcaoID", "Alta", "Baixa", "Data", "Fechamento", "FechamentoAjustado", "Volume" },
                values: new object[,]
                {
                    { new Guid("63298ac5-fac7-4a8f-b1b3-a843ea8ed04d"), 9.755000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 10.590000m, 9.695000m, new DateTime(2020, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.090000m, 9.842289m, 97178400 },
                    { new Guid("646e4b1e-1708-4106-b3e8-ba8142aeb1f9"), 11.222500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 11.272500m, 11.062500m, new DateTime(2019, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.250000m, 10.965576m, 42849600 },
                    { new Guid("65399aaf-d52d-4c66-8def-40362d54c960"), 8.243750m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 8.482500m, 8.219375m, new DateTime(2019, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.267187m, 8.042729m, 56502400 },
                    { new Guid("655cecc2-83ef-4c7c-b72a-48483ca2acaa"), 11.362500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 11.412500m, 11.130000m, new DateTime(2019, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.230000m, 10.946081m, 39413200 },
                    { new Guid("659fea34-9136-44bb-9757-648a7bc92652"), 10.715000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 10.720000m, 10.425000m, new DateTime(2019, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.625000m, 10.356378m, 91291200 },
                    { new Guid("66e5d760-8463-43ef-a904-ef2cdd33c6b0"), 13.550000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 13.680000m, 13.075000m, new DateTime(2020, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.365000m, 13.036887m, 33515200 },
                    { new Guid("67450629-68f1-4169-9698-c5e76fd8fb55"), 11.720000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 11.975000m, 11.662500m, new DateTime(2019, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.895000m, 11.594270m, 45071600 },
                    { new Guid("67b0009a-4f9c-4a34-b025-cbe55a85b284"), 12.372500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 12.470000m, 12.165000m, new DateTime(2019, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.325000m, 12.013398m, 42746000 },
                    { new Guid("68221930-50e7-433a-ad13-966f2fb73416"), 5.484375m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.526562m, 5.421875m, new DateTime(2019, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.443750m, 5.283957m, 22496000 },
                    { new Guid("684b6629-0811-4016-9a57-b21d435d0547"), 10.877500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 11.197500m, 10.737500m, new DateTime(2019, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.952500m, 10.675598m, 42558800 },
                    { new Guid("6a6b3666-a593-48b9-9164-4d86af34ad4a"), 10.715000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 11.110000m, 10.562500m, new DateTime(2019, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.005000m, 10.726769m, 128373200 },
                    { new Guid("6d3378ec-6718-4acd-aeb8-be6b9617218c"), 9.350000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.782500m, 9.017500m, new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.370000m, 9.139965m, 73661200 },
                    { new Guid("6d4ca803-0ff3-430c-8e9e-2f9ec95af2ab"), 8.200000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.017500m, 7.662500m, new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.662500m, 7.474384m, 113467200 },
                    { new Guid("6d7231d3-1f35-43a9-b030-7fe67a09b3cf"), 5.465625m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.518437m, 5.430625m, new DateTime(2019, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.518437m, 5.356452m, 24489600 },
                    { new Guid("6d830766-3c02-409e-9081-e9f5bc42d76e"), 5.559687m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.615312m, 5.500000m, new DateTime(2019, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.593750m, 5.429554m, 34128000 },
                    { new Guid("6ef0499f-b468-430c-b5ed-aa02f005d188"), 5.296875m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.312187m, 5.124062m, new DateTime(2019, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.124062m, 4.973652m, 31440000 },
                    { new Guid("6efe0d5b-a521-462f-a70d-208742fa0ef7"), 8.502500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 8.745000m, 8.375000m, new DateTime(2019, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.727500m, 8.490545m, 44195600 },
                    { new Guid("6f026140-4b80-4821-85e4-38bb53b3cd0b"), 12.037500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 12.250000m, 11.915000m, new DateTime(2019, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.132500m, 11.825764m, 41210000 },
                    { new Guid("70dc6f9c-a340-4998-bc28-e5b8a19244af"), 9.870000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 10.187500m, 9.840000m, new DateTime(2019, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.125000m, 9.869020m, 43940800 },
                    { new Guid("70f5eca4-048c-40e6-a21f-8a7eda7c2102"), 5.507500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.507500m, 5.365625m, new DateTime(2019, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.406250m, 5.259468m, 47628800 },
                    { new Guid("72845e8c-990e-40b4-a189-bfb72ce414a8"), 9.375000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.507500m, 9.027500m, new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.077500m, 8.831042m, 40306800 },
                    { new Guid("72d4cfd6-b4f5-4d96-b1bf-b3dde2c5ddd7"), 13.600000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 13.615000m, 12.967500m, new DateTime(2020, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.112500m, 12.790586m, 45342400 },
                    { new Guid("73204759-635a-4a14-b00a-0596a656d45a"), 12.625000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 13.057500m, 12.605000m, new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.020000m, 12.700356m, 44120000 },
                    { new Guid("73bb7ae7-458a-4421-8e4d-00df667e8d96"), 9.287500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.665000m, 9.285000m, new DateTime(2019, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.445000m, 9.188563m, 48288400 },
                    { new Guid("73bfe1af-fbe3-4bf5-bd7b-21fcf4303f4d"), 8.897500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.315000m, 8.837500m, new DateTime(2019, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.315000m, 9.062093m, 55866000 },
                    { new Guid("742ca5b5-51fe-42b6-8904-e2af07ac5f62"), 12.347500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 12.347500m, 11.807500m, new DateTime(2019, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.970000m, 11.667374m, 48477200 },
                    { new Guid("7508758f-0020-42c2-89cf-93bbdd862788"), 11.402500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 11.475000m, 11.040000m, new DateTime(2019, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.050000m, 10.770633m, 39114800 },
                    { new Guid("7610dce0-c936-478c-8039-3711715eefad"), 11.450000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 11.477500m, 11.257500m, new DateTime(2019, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.257500m, 10.972886m, 45510400 },
                    { new Guid("76d8b378-119f-40a4-87a0-529f55ebb235"), 10.620000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 10.800000m, 9.702500m, new DateTime(2020, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.747500m, 9.508198m, 97161600 },
                    { new Guid("77938487-3a7c-4e91-bf65-6072ef304c3a"), 9.030000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.420000m, 8.212500m, new DateTime(2020, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.892500m, 8.674187m, 108219600 },
                    { new Guid("77a61a69-3512-40fb-af49-5252b068ddce"), 9.575000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.920000m, 9.570000m, new DateTime(2019, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.912500m, 9.661892m, 35893600 },
                    { new Guid("794db098-674d-43c8-bdb8-4fc49dc99eea"), 5.780937m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.796562m, 5.605000m, new DateTime(2019, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.750000m, 5.581217m, 26342400 },
                    { new Guid("7a363313-b796-458a-9737-d924cb14a296"), 9.000000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.707500m, 7.642500m, new DateTime(2020, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.500000m, 8.291323m, 70036800 },
                    { new Guid("7c853f10-974f-473a-a2f1-f1be0f897ed2"), 5.218750m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.271875m, 5.172500m, new DateTime(2019, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.271875m, 5.117127m, 20364800 },
                    { new Guid("7d362338-e6ce-4012-b205-f94e0377758d"), 5.673437m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.702812m, 5.593750m, new DateTime(2019, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.615937m, 5.451090m, 19398400 },
                    { new Guid("7e3fe30d-86b3-4ba3-8104-25244fa422ec"), 7.368750m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 7.368750m, 7.160937m, new DateTime(2019, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.211562m, 7.015765m, 34518400 },
                    { new Guid("7f164bb8-6b26-44e8-af9e-fabab475b004"), 6.628125m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 6.749687m, 6.463125m, new DateTime(2019, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.484375m, 6.308321m, 44108800 },
                    { new Guid("7f5761ed-47d1-40d3-88a1-752f45f622f0"), 6.581250m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 6.643437m, 6.469687m, new DateTime(2019, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.503125m, 6.326562m, 35424000 },
                    { new Guid("7f684948-51ba-4ebd-8b71-b48c64528b97"), 5.129062m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.140625m, 4.986562m, new DateTime(2019, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.034375m, 4.886599m, 40636800 },
                    { new Guid("7f84d89f-6cdf-4ee2-b59f-ae9375f16bf3"), 5.250000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.374375m, 5.237812m, new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.301875m, 5.146246m, 30272000 },
                    { new Guid("814ddc1c-58d6-472a-abcb-14cbc2580adf"), 9.400000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.575000m, 9.355000m, new DateTime(2019, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.462500m, 9.205588m, 64444400 },
                    { new Guid("8239cf07-a94b-4727-ad56-8dfca3211885"), 6.375000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 6.546875m, 6.364062m, new DateTime(2019, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.474687m, 6.298896m, 36195200 }
                });

            migrationBuilder.InsertData(
                table: "Cotacoes",
                columns: new[] { "CotacaoID", "Abertura", "AcaoID", "Alta", "Baixa", "Data", "Fechamento", "FechamentoAjustado", "Volume" },
                values: new object[,]
                {
                    { new Guid("82bea510-068d-4413-ac04-7428773a99ae"), 7.409375m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 7.841875m, 7.409375m, new DateTime(2019, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.637187m, 7.429834m, 83689600 },
                    { new Guid("8350f911-6ef0-49ff-8a4e-ce9b236d1044"), 7.343750m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 7.355937m, 7.188437m, new DateTime(2019, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.207812m, 7.012116m, 29961600 },
                    { new Guid("83cd3c4a-77ec-4afb-b287-2ca0dc148450"), 9.600000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.845000m, 9.305000m, new DateTime(2020, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.550000m, 9.315546m, 65006000 },
                    { new Guid("841d0b69-5152-4dfb-a879-30c7ee329728"), 5.381250m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.435937m, 5.343750m, new DateTime(2019, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.401562m, 5.243007m, 22960000 },
                    { new Guid("876d4bed-30fe-4ea4-9b79-0a0bd82cf824"), 5.593750m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.640000m, 5.503750m, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.587500m, 5.423487m, 20665600 },
                    { new Guid("879666e2-199b-4588-8665-1a7b1ec0350b"), 5.250000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.312500m, 5.142500m, new DateTime(2019, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.312500m, 5.156559m, 22025600 },
                    { new Guid("88039df6-4a30-4afd-a51f-ca36aa3e0108"), 9.925000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.995000m, 9.700000m, new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.735000m, 9.488878m, 30410400 },
                    { new Guid("88906c3a-d168-4c1d-a4cf-9cacd04dbbb1"), 13.022500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 13.262500m, 12.762500m, new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.950000m, 12.632074m, 37484400 },
                    { new Guid("889b17f1-35cb-4f66-9284-a6355f1d109c"), 14.500000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 14.537500m, 13.950000m, new DateTime(2020, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.957500m, 13.614841m, 41164000 },
                    { new Guid("88de9f42-9265-400c-8737-852399485d34"), 12.675000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 13.360000m, 12.455000m, new DateTime(2020, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.137500m, 12.814972m, 64611600 },
                    { new Guid("8942816b-b79d-476c-abbc-e5c65c587845"), 5.562500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.702500m, 5.539687m, new DateTime(2019, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.661562m, 5.495375m, 21174400 },
                    { new Guid("894cb716-ea46-45d7-a9ee-190598779d59"), 9.412500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.420000m, 9.052500m, new DateTime(2019, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.132500m, 8.884548m, 41342400 },
                    { new Guid("8959c080-b0c5-4444-98f3-09b4e7b33ecd"), 8.005000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 8.405000m, 6.617500m, new DateTime(2020, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.202500m, 7.025677m, 121748400 },
                    { new Guid("89654f36-f428-42b7-9af8-1482a4d1d2fd"), 5.527812m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.542500m, 5.462500m, new DateTime(2019, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.484375m, 5.323390m, 14454400 },
                    { new Guid("898bcf30-455b-4cbc-a826-8f9adbe946f2"), 9.245000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.265000m, 8.962500m, new DateTime(2019, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.000000m, 8.755645m, 31526400 },
                    { new Guid("8c5b3ed8-aaa0-4946-abed-c2eba7e557a8"), 5.656250m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.673125m, 5.547187m, new DateTime(2019, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.550000m, 5.387088m, 37481600 },
                    { new Guid("8ec06228-30d9-40af-afed-686c4ed5fa7f"), 5.429687m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.512500m, 5.330312m, new DateTime(2019, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.409687m, 5.250894m, 33091200 },
                    { new Guid("91f915d2-48c0-4f22-a9fd-3d540fead66c"), 11.300000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 11.365000m, 10.767500m, new DateTime(2019, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.850000m, 10.575689m, 65437200 },
                    { new Guid("921204b8-5076-4afc-8267-e31124e7e9e2"), 5.899062m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 6.017187m, 5.871875m, new DateTime(2019, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.960625m, 5.798791m, 43356800 },
                    { new Guid("9283162a-3797-4a38-8c9a-f8ba73b346e3"), 8.897500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.265000m, 8.882500m, new DateTime(2019, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.150000m, 8.901573m, 69824400 },
                    { new Guid("9475179c-9b65-41c7-a627-f654af879525"), 5.158437m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.400625m, 5.158437m, new DateTime(2019, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.275625m, 5.132390m, 33945600 },
                    { new Guid("9481f67d-cb9a-4314-ad90-5a58943ce0cf"), 10.067500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 10.550000m, 9.860000m, new DateTime(2020, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.490000m, 10.232468m, 63285200 },
                    { new Guid("94a959a7-adc9-4c53-a0cc-0b4e7b0239e2"), 10.837500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 11.160000m, 10.642500m, new DateTime(2019, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.160000m, 10.877851m, 95930400 },
                    { new Guid("95424fc5-4799-4106-b5a6-9a77cb3b4250"), 12.035000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 12.197500m, 11.192500m, new DateTime(2019, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.242500m, 10.958266m, 125373600 },
                    { new Guid("9624f5f8-e9ae-4fb5-a311-421b11dab1be"), 5.648437m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.745000m, 5.570312m, new DateTime(2019, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.705312m, 5.537841m, 39078400 },
                    { new Guid("9637aaf2-5599-4b83-a498-2839a0689b32"), 7.343750m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 7.511250m, 7.250000m, new DateTime(2019, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.251562m, 7.054679m, 61776000 },
                    { new Guid("96608861-99dd-4e22-8cb4-597eeb76867b"), 10.675000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 11.115000m, 10.642500m, new DateTime(2019, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.062500m, 10.782818m, 72272400 },
                    { new Guid("9785efb1-a5ba-4974-9e6c-93397a95ac65"), 6.437500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 6.569687m, 6.421562m, new DateTime(2019, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.550312m, 6.372468m, 41241600 },
                    { new Guid("97b5a5a7-9b5a-4baf-862b-c749627a2b1a"), 13.632500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 14.137500m, 13.562500m, new DateTime(2020, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.985000m, 13.641665m, 42104000 },
                    { new Guid("97c07189-8fc4-4ae0-ab68-b37b3f31019c"), 13.925000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 13.982500m, 13.375000m, new DateTime(2020, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.557500m, 13.224661m, 39083200 },
                    { new Guid("97ec2166-c023-4847-8f79-2fe853a504ac"), 14.400000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 14.490000m, 14.000000m, new DateTime(2020, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.082500m, 13.736772m, 36680000 },
                    { new Guid("981e31e4-7d1d-4fcf-b1d3-79cb7aca98d1"), 5.311875m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.475000m, 5.287812m, new DateTime(2019, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.406250m, 5.259468m, 32944000 },
                    { new Guid("9950abb2-53ea-4f16-b8cf-3fd35e3d49f1"), 5.500000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.623437m, 5.479375m, new DateTime(2019, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.592187m, 5.440356m, 37011200 },
                    { new Guid("99bb6630-c052-4a4f-af1d-661d169d3843"), 11.485000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 11.650000m, 11.325000m, new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.650000m, 11.355463m, 33751600 },
                    { new Guid("99f1fc8b-8868-4318-93c4-f46a1b7e42ff"), 12.235000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 12.300000m, 12.125000m, new DateTime(2020, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.197500m, 11.898048m, 26818800 },
                    { new Guid("9bc15600-b841-49fd-8d2c-a3a12929da9f"), 9.192500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.305000m, 9.135000m, new DateTime(2019, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.135000m, 8.886981m, 25524400 },
                    { new Guid("9c0bd579-1d08-4cae-9ac6-218fc9a1ae44"), 10.272500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 10.525000m, 10.167500m, new DateTime(2020, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.477500m, 10.220276m, 33824400 },
                    { new Guid("9c1cb324-450b-4fdd-b406-1be01e3377a0"), 5.844687m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.897500m, 5.658125m, new DateTime(2019, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.828125m, 5.669889m, 28297600 },
                    { new Guid("9e1f220b-c4a2-448c-9aa5-c1662b7e46a9"), 5.406562m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.620937m, 5.350000m, new DateTime(2019, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.578125m, 5.414387m, 33779200 },
                    { new Guid("a249f643-754d-4a5a-b3bd-23ebeecfc61d"), 5.594062m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.659375m, 5.556250m, new DateTime(2019, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.651562m, 5.485669m, 24432000 },
                    { new Guid("a35a695e-7e49-4305-bd63-6111d79d3c6f"), 5.309687m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.316875m, 5.190937m, new DateTime(2019, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.225000m, 5.083139m, 13920000 },
                    { new Guid("a3738159-134f-4376-9886-d7c3f4faf554"), 8.425000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 8.662500m, 8.287500m, new DateTime(2019, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.650000m, 8.415149m, 65658000 }
                });

            migrationBuilder.InsertData(
                table: "Cotacoes",
                columns: new[] { "CotacaoID", "Abertura", "AcaoID", "Alta", "Baixa", "Data", "Fechamento", "FechamentoAjustado", "Volume" },
                values: new object[,]
                {
                    { new Guid("a40cf527-4c06-4be1-89df-f9c14b7e09be"), 9.175000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.335000m, 9.137500m, new DateTime(2019, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.285000m, 9.032908m, 39026400 },
                    { new Guid("a52bcf37-8349-4545-b6cd-355704911321"), 9.140000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.210000m, 9.037500m, new DateTime(2019, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.200000m, 8.950214m, 16346400 },
                    { new Guid("a5d60de4-3a41-4a07-937d-897aaa265f91"), 8.805000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 8.817500m, 8.512500m, new DateTime(2019, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.525000m, 8.293542m, 31115200 },
                    { new Guid("a62dd080-99ff-4701-82e5-e9c74198f101"), 12.200000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 12.275000m, 12.157500m, new DateTime(2019, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.272500m, 11.962226m, 19397200 },
                    { new Guid("a6a3ed27-e47f-4bd3-8218-f524f5d32f6f"), 11.990000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 12.092500m, 11.882500m, new DateTime(2019, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.957500m, 11.655189m, 36261600 },
                    { new Guid("a87d8bf5-36a8-4422-ac43-e24e5f736bc2"), 14.127500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 14.275000m, 13.707500m, new DateTime(2020, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.922500m, 13.580700m, 36062400 },
                    { new Guid("a8f07b1a-8c5b-44b2-ba9e-0892c9e33ddf"), 5.389687m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.389687m, 5.171875m, new DateTime(2019, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.192187m, 5.039778m, 35606400 },
                    { new Guid("a98ca05d-83a5-4c33-8e74-79318a13828c"), 5.638125m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.812187m, 5.594687m, new DateTime(2019, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.812187m, 5.641579m, 27017600 },
                    { new Guid("a9a4b657-0be2-45c0-a6d9-8f3bb1627577"), 10.360000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 10.650000m, 10.022500m, new DateTime(2020, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.022500m, 9.776446m, 78595200 },
                    { new Guid("aa9b919e-d001-4f1a-ab16-2074e93dacae"), 13.502500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 14.247500m, 13.502500m, new DateTime(2020, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.247500m, 13.897720m, 41425600 },
                    { new Guid("acf8e326-252b-4e7c-8ccf-86d9d6445769"), 8.985000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.140000m, 8.862500m, new DateTime(2019, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.140000m, 8.891845m, 42718400 },
                    { new Guid("ae85128a-ef76-44a5-b936-81698af4ed6b"), 13.912500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 14.455000m, 13.850000m, new DateTime(2020, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.112500m, 13.766035m, 38342000 },
                    { new Guid("b10802eb-c8b1-4bb7-9bf1-ae8fa1236c96"), 5.647187m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.696875m, 5.598750m, new DateTime(2019, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.675937m, 5.509328m, 23216000 },
                    { new Guid("b12ef3d1-bc5b-419b-a720-993c13864f78"), 8.412500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 8.745000m, 8.245000m, new DateTime(2019, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.445000m, 8.215714m, 66399200 },
                    { new Guid("b29e54a1-2459-43b1-8e67-6a3c6c44a5d4"), 10.725000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 10.850000m, 10.585000m, new DateTime(2020, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.725000m, 10.644061m, 45244400 },
                    { new Guid("b70c5f59-5d89-4775-918b-626b93a858c5"), 5.344375m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.468750m, 5.314375m, new DateTime(2019, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.468750m, 5.320271m, 24780800 },
                    { new Guid("b723806f-0bbc-4c32-8843-2ad5f45691d0"), 9.350000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.730000m, 9.325000m, new DateTime(2019, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.695000m, 9.431776m, 59760000 },
                    { new Guid("b7bb9e84-dbec-4f7d-b9b6-bf2eed20a5cb"), 5.253125m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.615625m, 5.250312m, new DateTime(2019, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.565625m, 5.402255m, 51174400 },
                    { new Guid("b8d5aedb-0700-4501-bdb2-b57912766ddf"), 5.751562m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.760937m, 5.573437m, new DateTime(2019, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.575000m, 5.411354m, 27721600 },
                    { new Guid("b94aa5ac-6231-422a-a182-5da5bcaca958"), 5.656250m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.687500m, 5.562500m, new DateTime(2019, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.562500m, 5.411476m, 15702400 },
                    { new Guid("b9859052-e05e-476a-b49a-c3855e7033f0"), 6.125000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 6.162500m, 5.875937m, new DateTime(2019, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.974687m, 5.812472m, 40675200 },
                    { new Guid("ba543f84-5d69-4853-98e2-a6daec675e10"), 9.555000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.675000m, 8.777500m, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.972500m, 8.752222m, 82290000 },
                    { new Guid("ba684129-9e13-4c3e-be1b-119139f73723"), 5.553125m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.696562m, 5.472500m, new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.639062m, 5.485959m, 33337600 },
                    { new Guid("bb7248ff-d3a9-4145-9dbe-de85a63ec9c6"), 11.050000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 11.072500m, 10.627500m, new DateTime(2019, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.760000m, 10.487964m, 71944400 },
                    { new Guid("bc6bc959-521f-466c-a6e5-508a246863d2"), 10.000000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 10.542500m, 9.975000m, new DateTime(2019, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.542500m, 10.275963m, 44124800 },
                    { new Guid("bd363e45-8c20-4119-a38c-99f38077bb01"), 5.586250m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.621875m, 5.428125m, new DateTime(2019, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.428125m, 5.268791m, 41360000 },
                    { new Guid("bd553e0e-11a6-4c30-929c-0eab92c12bec"), 5.937500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 6.075000m, 5.925625m, new DateTime(2019, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.027812m, 5.864154m, 28982400 },
                    { new Guid("be9bcc81-34af-4d8f-aa5a-18301abae575"), 5.617187m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.712187m, 5.603437m, new DateTime(2019, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.646875m, 5.481119m, 21654400 },
                    { new Guid("c0c04460-6019-493f-bf8b-0c19b63bf96a"), 8.625000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 8.800000m, 8.612500m, new DateTime(2019, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.765000m, 8.527027m, 25575200 },
                    { new Guid("c102f4a3-9957-4636-9e28-ed30d54f3d78"), 10.872500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 10.987500m, 10.790000m, new DateTime(2019, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.812500m, 10.539137m, 23944400 },
                    { new Guid("c24ec0a6-6bc0-4f1c-b332-56215a5ce240"), 5.439062m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.506875m, 5.398437m, new DateTime(2019, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.452500m, 5.292450m, 28726400 },
                    { new Guid("c2b82a57-3fdd-4254-8f03-89e8e4725ada"), 12.100000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 12.327500m, 11.950000m, new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.232500m, 11.932190m, 27359200 },
                    { new Guid("c2bd8d70-0b74-4657-b61d-c8ab548fa059"), 8.421875m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 8.726250m, 8.384375m, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.640625m, 8.406029m, 79395200 },
                    { new Guid("c35d9aaa-c82d-4e63-8051-f9d95d4f27a1"), 8.565000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 8.732500m, 8.455000m, new DateTime(2019, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.552500m, 8.320294m, 52060400 },
                    { new Guid("c3d93f13-51df-4b4d-a0b3-9eefb10099df"), 5.656250m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.672187m, 5.560625m, new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.589062m, 5.425004m, 22624000 },
                    { new Guid("c5fe7e06-d739-4fe2-b4cc-ee3508985ede"), 14.562500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 14.775000m, 14.375000m, new DateTime(2020, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.555000m, 14.197673m, 38234000 },
                    { new Guid("c67c65f9-5079-4812-bfc3-2b6d86e5395e"), 9.025000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.250000m, 8.992500m, new DateTime(2019, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.192500m, 8.942920m, 37714800 },
                    { new Guid("c759cd4a-cc63-4c4a-ae28-a605a741a3b1"), 6.187500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 6.218437m, 6.000000m, new DateTime(2019, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.078750m, 5.913710m, 26220800 },
                    { new Guid("c9eb2152-d7d4-4c2b-af07-220207da548c"), 10.897500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 10.997500m, 10.730000m, new DateTime(2019, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.872500m, 10.597620m, 32365600 },
                    { new Guid("c9f01904-d4ee-4818-9dd9-df36b115ff2f"), 5.124687m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.317500m, 5.087812m, new DateTime(2019, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.300000m, 5.144426m, 38249600 },
                    { new Guid("cab61a12-907b-4e20-9d3c-9e75df81f1ea"), 10.675000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 11.087500m, 10.650000m, new DateTime(2019, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.792500m, 10.519643m, 53416000 },
                    { new Guid("cb007c81-568a-4808-8b32-755974b10018"), 13.420000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 13.590000m, 13.300000m, new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.415000m, 13.085658m, 36965600 }
                });

            migrationBuilder.InsertData(
                table: "Cotacoes",
                columns: new[] { "CotacaoID", "Abertura", "AcaoID", "Alta", "Baixa", "Data", "Fechamento", "FechamentoAjustado", "Volume" },
                values: new object[,]
                {
                    { new Guid("cb2dddc8-b8ea-4fcc-9e8f-c1a4a247dbaf"), 11.330000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 11.570000m, 10.880000m, new DateTime(2019, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.010000m, 10.731645m, 72748800 },
                    { new Guid("ccf0669f-7cd0-44fe-8819-407539f0ef70"), 5.961562m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 6.201562m, 5.954062m, new DateTime(2019, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.201562m, 6.033187m, 31520000 },
                    { new Guid("cdcf769c-1ddd-4ba1-8ed0-758be6732b86"), 6.543750m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 6.597500m, 6.480937m, new DateTime(2019, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.597500m, 6.418375m, 32460800 },
                    { new Guid("ce03d533-e8e4-4d0d-81d1-1f6054585b6a"), 14.500000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 14.980000m, 14.287500m, new DateTime(2020, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.712500m, 14.351304m, 73775200 },
                    { new Guid("ce384ae2-e6d4-4f1f-835b-7bb17569385e"), 5.024375m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.352187m, 5.010937m, new DateTime(2019, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.337500m, 5.192585m, 44016000 },
                    { new Guid("d0196e77-36c0-4315-afac-56087f997170"), 5.621875m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.684062m, 5.397500m, new DateTime(2019, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.415625m, 5.256658m, 44316800 },
                    { new Guid("d0fd3929-0167-4e4e-9b15-5f014ad15249"), 13.000000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 13.350000m, 12.505000m, new DateTime(2020, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.562500m, 12.254089m, 58818800 },
                    { new Guid("d111cff1-f45b-402f-a30a-1961fe283ec6"), 5.381250m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.400625m, 5.211562m, new DateTime(2019, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.218750m, 5.077058m, 56912000 },
                    { new Guid("d15ac999-77a4-444a-a0f5-7491855480f7"), 5.121250m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.266875m, 5.078125m, new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.266875m, 5.112274m, 14982400 },
                    { new Guid("d160602c-79b2-435d-955c-16d2a38f3183"), 7.226562m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 7.371562m, 7.226562m, new DateTime(2019, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.296875m, 7.098762m, 35814400 },
                    { new Guid("d2b2fc54-ae57-4806-9445-fa544f988b33"), 5.187187m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.265625m, 5.125312m, new DateTime(2019, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.230625m, 5.077088m, 25052800 },
                    { new Guid("d35002d1-b2bf-4d18-ac36-6e23a01dae37"), 6.204062m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 6.387500m, 6.140625m, new DateTime(2019, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.328125m, 6.156314m, 37593600 },
                    { new Guid("d3fdf255-7b4c-4afb-9f7a-be76fdef3edd"), 10.550000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 10.700000m, 10.307500m, new DateTime(2019, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.450000m, 10.185802m, 38353200 },
                    { new Guid("d632bff4-d8c3-4c46-ac74-79af29e6983c"), 5.219062m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.255937m, 5.103125m, new DateTime(2019, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.150000m, 4.998830m, 32627200 },
                    { new Guid("d6f2a795-5f66-40dc-a28c-6fe69d3856f7"), 5.578125m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.611875m, 5.462812m, new DateTime(2019, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.500000m, 5.338556m, 25504000 },
                    { new Guid("d8472f7e-6567-4e65-8f24-7054999e06da"), 10.860000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 10.987500m, 10.587500m, new DateTime(2019, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.750000m, 10.478217m, 28584400 },
                    { new Guid("d8f6d032-a2c8-46d0-a231-25904dbf97b2"), 5.496250m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.677812m, 5.487812m, new DateTime(2019, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.606562m, 5.454341m, 37299200 },
                    { new Guid("d998f546-00cd-4046-a4ff-6e22a1da72b9"), 7.781250m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 7.793750m, 7.439062m, new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.439062m, 7.237089m, 48448000 },
                    { new Guid("d9bf69ed-a529-4693-8762-98c33395fa42"), 10.402500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 10.720000m, 10.242500m, new DateTime(2019, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.690000m, 10.419733m, 41211200 },
                    { new Guid("da2069f6-982b-4c8f-872d-1c4d359272a8"), 9.342500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.562500m, 9.145000m, new DateTime(2019, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.237500m, 8.986698m, 52995600 },
                    { new Guid("ddda62ac-b464-4813-9f5c-c36bad21ef87"), 6.530937m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 6.718750m, 6.418750m, new DateTime(2019, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.611562m, 6.432055m, 47436800 },
                    { new Guid("df332818-ad01-47ee-9100-6c72e750f72e"), 5.546875m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.567187m, 5.453437m, new DateTime(2019, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.533437m, 5.371011m, 17363200 },
                    { new Guid("df69de38-293a-41d8-b8f7-608b730733d6"), 9.650000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.937500m, 9.540000m, new DateTime(2019, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.600000m, 9.339356m, 39637200 },
                    { new Guid("dfa42653-400f-449a-bb59-29053c8a3904"), 10.160000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 11.100000m, 10.065000m, new DateTime(2020, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.280000m, 10.027623m, 91541200 },
                    { new Guid("dfff76aa-81ba-480b-96ee-014d469dfb8b"), 5.331562m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.481250m, 5.212500m, new DateTime(2019, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.212500m, 5.059494m, 37664000 },
                    { new Guid("e0620b29-3789-451c-81ab-f3e84a5ad1cc"), 5.303125m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.318750m, 5.159687m, new DateTime(2019, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.210625m, 5.057674m, 77120000 },
                    { new Guid("e2188b95-07e7-4e62-8dcf-6f2639fb1ab4"), 9.660000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.742500m, 9.465000m, new DateTime(2019, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.500000m, 9.259819m, 42653200 },
                    { new Guid("e25d50f0-78ae-4671-beb8-a2c1f3b9ddd5"), 6.585937m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 6.640625m, 6.531250m, new DateTime(2019, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.639375m, 6.459113m, 22755200 },
                    { new Guid("e37d2519-52e4-47f4-b0ad-00cb8ece040e"), 10.875000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 11.370000m, 10.810000m, new DateTime(2019, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.255000m, 10.970451m, 44655600 },
                    { new Guid("e3a002f0-1731-49f1-a683-4fb2b029da2d"), 5.702812m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.735000m, 5.500000m, new DateTime(2019, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.526562m, 5.376514m, 25910400 },
                    { new Guid("e5a2954a-b5ff-4bbd-989a-f60b04ab162a"), 5.737500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.976875m, 5.718750m, new DateTime(2019, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.976875m, 5.814600m, 68633600 },
                    { new Guid("e5d96aea-684e-43f6-83c6-fea7249cf8c7"), 5.634375m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.906250m, 5.629062m, new DateTime(2019, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.906250m, 5.745892m, 66128000 },
                    { new Guid("e6a26f58-3eb2-42a9-8be4-0cdda3959157"), 12.075000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 12.415000m, 12.000000m, new DateTime(2019, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.267500m, 11.957350m, 54632800 },
                    { new Guid("e6db24d7-b753-4708-a92d-cdb304737e3c"), 5.078125m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.343437m, 5.000625m, new DateTime(2019, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.334062m, 5.177489m, 33744000 },
                    { new Guid("e8fe4887-0aa3-4bdc-8149-d0b769caaecd"), 11.250000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 11.692500m, 9.975000m, new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.770000m, 10.505594m, 80331600 },
                    { new Guid("eaa99140-fbcf-4bed-9f53-e5a43978ee7c"), 5.531250m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.670625m, 5.504687m, new DateTime(2019, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.638125m, 5.472626m, 43244800 },
                    { new Guid("ec539790-b713-46ce-84ee-d5743bb946bc"), 7.593750m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 7.784375m, 7.593750m, new DateTime(2019, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.681562m, 7.473004m, 27779200 },
                    { new Guid("ec684aa0-9c38-41b5-bef2-808b997fc1e6"), 6.093750m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 6.280000m, 6.063437m, new DateTime(2019, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.256562m, 6.086694m, 49232000 },
                    { new Guid("ec96dd0d-91bb-43c5-ac7d-98301a7496f7"), 9.287500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.362500m, 9.177500m, new DateTime(2019, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.362500m, 9.108305m, 25854800 },
                    { new Guid("ed273f0c-f168-43c1-a152-7c0960670dc9"), 12.155000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 12.257500m, 11.990000m, new DateTime(2019, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.147500m, 11.840387m, 36742800 },
                    { new Guid("ed73fe91-8eaf-462c-bd21-64fd626b6b49"), 13.050000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 13.557500m, 13.037500m, new DateTime(2020, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.557500m, 13.224661m, 34307200 },
                    { new Guid("ee782162-ecd8-47b5-acfe-79020655e4c7"), 5.192187m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.261250m, 5.109375m, new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.197187m, 5.044631m, 33910400 }
                });

            migrationBuilder.InsertData(
                table: "Cotacoes",
                columns: new[] { "CotacaoID", "Abertura", "AcaoID", "Alta", "Baixa", "Data", "Fechamento", "FechamentoAjustado", "Volume" },
                values: new object[,]
                {
                    { new Guid("ef161013-5a0e-4886-a8ef-1725009ec32a"), 13.000000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 13.000000m, 11.650000m, new DateTime(2020, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.947500m, 11.654186m, 84786000 },
                    { new Guid("ef525f1e-9945-4de2-b505-3bc451826c8d"), 5.656250m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.687500m, 5.554687m, new DateTime(2019, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.597187m, 5.432890m, 24796800 },
                    { new Guid("ef5cb714-08cc-40be-9bf5-cf1b0856cb25"), 9.225000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 10.837500m, 9.180000m, new DateTime(2020, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.000000m, 9.754498m, 125173600 },
                    { new Guid("f06c5d39-44fd-428b-b67e-0772666161f5"), 13.265000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 13.512500m, 12.940000m, new DateTime(2020, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.220000m, 12.895447m, 53716400 },
                    { new Guid("f3811de6-d0a7-47cb-bca4-809f894312f3"), 5.452500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.453125m, 5.265625m, new DateTime(2019, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.303125m, 5.147460m, 25846400 },
                    { new Guid("f3a6da69-d6d4-4908-b08b-c6acf6794db4"), 6.630000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 6.684375m, 6.519375m, new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.561875m, 6.383717m, 27094400 },
                    { new Guid("f3b392eb-259a-4cf3-a7ed-4dc07ec94920"), 9.202500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.317500m, 9.127500m, new DateTime(2019, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.142500m, 8.894277m, 27740400 },
                    { new Guid("f3f665f6-5b3c-408c-947e-4a36bb38bc16"), 5.534375m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.562500m, 5.411875m, new DateTime(2019, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.468750m, 5.308223m, 35452800 },
                    { new Guid("f59f471c-62af-44a3-a394-6dde6661b015"), 10.705000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 10.925000m, 10.315000m, new DateTime(2020, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.412500m, 10.156872m, 51879600 },
                    { new Guid("f5b9d39d-d87e-4141-b3ac-9903d8ea8ce9"), 11.250000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 11.752500m, 10.570000m, new DateTime(2020, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.747500m, 11.459097m, 82114000 },
                    { new Guid("f66ddbee-f2af-40b6-a84a-f878936b17d4"), 5.100000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.179062m, 5.050000m, new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.084375m, 4.946332m, 23929600 },
                    { new Guid("f7bdcd44-b480-4637-97c5-ca35754ab96b"), 11.350000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 11.625000m, 11.330000m, new DateTime(2019, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.462500m, 11.172703m, 51046000 },
                    { new Guid("f81bea9e-89bb-4654-8292-205382f71efa"), 5.496875m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.730625m, 5.431250m, new DateTime(2019, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.650625m, 5.484759m, 54208000 },
                    { new Guid("f8a36b1e-1a00-4ed2-becc-37809c6cb638"), 5.098437m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.217187m, 5.020312m, new DateTime(2019, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.064062m, 4.915414m, 65046400 },
                    { new Guid("f9365767-3088-41de-ad62-fa3e721516c5"), 8.712500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 8.750000m, 8.312500m, new DateTime(2019, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.425000m, 8.196259m, 38613600 },
                    { new Guid("facde6fd-7507-4adb-b655-2e04b4bb5fed"), 6.156250m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 6.212500m, 6.047187m, new DateTime(2019, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.085625m, 5.920397m, 26694400 },
                    { new Guid("fbfc9c72-945a-4907-948d-b0fc2029f917"), 5.546875m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.655625m, 5.427500m, new DateTime(2019, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.595937m, 5.431677m, 30585600 },
                    { new Guid("fc26d157-ed46-40c8-8629-a3e9e1ae2bca"), 8.812500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 8.812500m, 8.603437m, new DateTime(2019, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.625000m, 8.390828m, 59516800 },
                    { new Guid("fd433d89-a8f3-42e1-844b-464d5a5fa391"), 13.500000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 13.762500m, 13.400000m, new DateTime(2020, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.500000m, 13.168572m, 33180800 },
                    { new Guid("fd445aef-682a-485e-89db-196515f8544e"), 9.375000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.447500m, 9.162500m, new DateTime(2019, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.175000m, 8.925894m, 28631600 },
                    { new Guid("fd9e78ae-29a2-4c61-891b-6926bc8f8fd0"), 8.430000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 9.447500m, 8.430000m, new DateTime(2020, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.170000m, 8.944876m, 82749200 },
                    { new Guid("fe75bf0f-b2d1-4846-8087-37efcbf7cb95"), 12.287500m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 12.352500m, 12.037500m, new DateTime(2019, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.182500m, 11.874501m, 23699600 },
                    { new Guid("ff64a68f-eee5-4f32-922f-9404ceace939"), 5.174062m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 5.187500m, 4.944062m, new DateTime(2019, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.040625m, 4.892664m, 38464000 },
                    { new Guid("ff76195f-cdd8-4adf-b502-68a8f213f673"), 10.250000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 10.505000m, 9.950000m, new DateTime(2020, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.400000m, 10.144677m, 75768800 },
                    { new Guid("ff8d23aa-2968-47e6-a75a-7a08f9046ec1"), 8.535000m, new Guid("9418f4af-9c10-4465-8116-51e8a531b715"), 8.795000m, 8.457500m, new DateTime(2019, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.712500m, 8.475951m, 41455600 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cotacoes_AcaoID",
                table: "Cotacoes",
                column: "AcaoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cotacoes");

            migrationBuilder.DropTable(
                name: "Acoes");
        }
    }
}
