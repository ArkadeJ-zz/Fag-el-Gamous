using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Fag_el_Gamous.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "master_burial2",
                columns: table => new
                {
                    burial_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1163', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    loc_concat = table.Column<string>(type: "character varying", nullable: true),
                    burial_location_ns = table.Column<string>(type: "character varying", nullable: true),
                    low_pair_ns = table.Column<string>(type: "character varying", nullable: true),
                    high_pair_ns = table.Column<string>(type: "character varying", nullable: true),
                    burial_location_ew = table.Column<string>(type: "character varying", nullable: true),
                    low_pair_ew = table.Column<string>(type: "character varying", nullable: true),
                    high_pair_ew = table.Column<string>(type: "character varying", nullable: true),
                    burial_subplot = table.Column<string>(type: "character varying", nullable: true),
                    burial_number = table.Column<int>(nullable: true),
                    burial_depth = table.Column<string>(type: "character varying", nullable: true),
                    south_to_head = table.Column<string>(type: "character varying", nullable: true),
                    south_to_feet = table.Column<string>(type: "character varying", nullable: true),
                    west_to_head = table.Column<string>(type: "character varying", nullable: true),
                    west_to_feet = table.Column<string>(type: "character varying", nullable: true),
                    length_of_remains = table.Column<string>(type: "character varying", nullable: true),
                    burial_situation = table.Column<string>(type: "character varying", nullable: true),
                    sample_number = table.Column<int>(nullable: true),
                    gender_ge = table.Column<string>(type: "character varying", nullable: true),
                    ge_function_total = table.Column<string>(type: "character varying", nullable: true),
                    gender_body_col = table.Column<string>(type: "character varying", nullable: true),
                    basilar_suture = table.Column<string>(type: "character varying", nullable: true),
                    ventral_arc = table.Column<int>(nullable: true),
                    subpubic_angle = table.Column<int>(nullable: true),
                    sciatic_notch = table.Column<int>(nullable: true),
                    pubic_bone = table.Column<int>(nullable: true),
                    preaur_sulcus = table.Column<int>(nullable: true),
                    medial_ip_ramus = table.Column<int>(nullable: true),
                    dorsal_pitting = table.Column<int>(nullable: true),
                    foreman_magnum = table.Column<string>(type: "character varying", nullable: true),
                    femur_head = table.Column<string>(type: "character varying", nullable: true),
                    humerus_head = table.Column<string>(type: "character varying", nullable: true),
                    osteophytosis = table.Column<string>(type: "character varying", nullable: true),
                    pubic_symphysis = table.Column<string>(type: "character varying", nullable: true),
                    bone_length = table.Column<string>(type: "character varying", nullable: true),
                    medial_clavicle = table.Column<string>(type: "character varying", nullable: true),
                    iliac_crest = table.Column<string>(type: "character varying", nullable: true),
                    femur_diameter = table.Column<string>(type: "character varying", nullable: true),
                    humerus = table.Column<string>(type: "character varying", nullable: true),
                    femur_length = table.Column<string>(type: "character varying", nullable: true),
                    humerus_length = table.Column<string>(type: "character varying", nullable: true),
                    tibia_length = table.Column<string>(type: "character varying", nullable: true),
                    robust = table.Column<int>(nullable: true),
                    supraorbital_ridges = table.Column<int>(nullable: true),
                    orbit_edge = table.Column<int>(nullable: true),
                    parietal_bossing = table.Column<int>(nullable: true),
                    gonian = table.Column<int>(nullable: true),
                    nuchal_crest = table.Column<int>(nullable: true),
                    zygomatic_crest = table.Column<int>(nullable: true),
                    cranial_suture = table.Column<string>(type: "character varying", nullable: true),
                    maximum_cranial_length = table.Column<string>(type: "character varying", nullable: true),
                    maximum_cranial_breadth = table.Column<string>(type: "character varying", nullable: true),
                    basion_bregma_height = table.Column<string>(type: "character varying", nullable: true),
                    basion_nasion = table.Column<string>(type: "character varying", nullable: true),
                    basion_prosthion_length = table.Column<string>(type: "character varying", nullable: true),
                    bizygomatic_diameter = table.Column<string>(type: "character varying", nullable: true),
                    nasion_prosthion = table.Column<string>(type: "character varying", nullable: true),
                    maximum_nasal_breadth = table.Column<string>(type: "character varying", nullable: true),
                    interorbital_breadth = table.Column<string>(type: "character varying", nullable: true),
                    artifacts_description = table.Column<string>(type: "character varying", nullable: true),
                    hair_color = table.Column<string>(type: "character varying", nullable: true),
                    preservation_index = table.Column<string>(type: "character varying", nullable: true),
                    hair_taken_tf = table.Column<bool>(nullable: true),
                    soft_tissue_taken_tf = table.Column<bool>(nullable: true),
                    bone_taken_tf = table.Column<bool>(nullable: true),
                    tooth_taken_tf = table.Column<bool>(nullable: true),
                    textile_taken_tf = table.Column<bool>(nullable: true),
                    artifact_found_tf = table.Column<bool>(nullable: true),
                    description_of_taken = table.Column<string>(type: "character varying", nullable: true),
                    estimate_age = table.Column<string>(type: "character varying", nullable: true),
                    estimate_living_stature = table.Column<string>(type: "character varying", nullable: true),
                    tooth_attrition = table.Column<string>(type: "character varying", nullable: true),
                    tooth_eruption = table.Column<string>(type: "character varying", nullable: true),
                    pathology_anomalies = table.Column<string>(type: "character varying", nullable: true),
                    epiphyseal_union = table.Column<string>(type: "character varying", nullable: true),
                    year_found = table.Column<int>(nullable: true),
                    month_found = table.Column<string>(type: "character varying", nullable: true),
                    day_found = table.Column<int>(nullable: true),
                    head_direction = table.Column<string>(type: "character varying", nullable: true),
                    preservation = table.Column<string>(type: "character varying", nullable: true),
                    burialicon = table.Column<string>(type: "character varying", nullable: true),
                    burialicon2 = table.Column<string>(type: "character varying", nullable: true),
                    sex = table.Column<string>(type: "character varying", nullable: true),
                    sexmethod = table.Column<string>(type: "character varying", nullable: true),
                    ageatdeath = table.Column<string>(type: "character varying", nullable: true),
                    agemethod = table.Column<string>(type: "character varying", nullable: true),
                    haircolor = table.Column<string>(type: "character varying", nullable: true),
                    sample = table.Column<string>(type: "character varying", nullable: true),
                    year_on_skull = table.Column<string>(type: "character varying", nullable: true),
                    month_on_skull = table.Column<string>(type: "character varying", nullable: true),
                    date_on_skull = table.Column<int>(nullable: true),
                    field_book = table.Column<string>(type: "character varying", nullable: true),
                    field_book_page_number = table.Column<string>(type: "character varying", nullable: true),
                    initials_of_data_entry_expert = table.Column<string>(type: "character varying", nullable: true),
                    initials_of_data_entry_checker = table.Column<string>(type: "character varying", nullable: true),
                    byu_sample = table.Column<string>(type: "character varying", nullable: true),
                    body_analysis = table.Column<int>(nullable: true),
                    skull_at_magazine = table.Column<string>(type: "character varying", nullable: true),
                    postcrania_at_magazine = table.Column<string>(type: "character varying", nullable: true),
                    sex_skull = table.Column<string>(type: "character varying", nullable: true),
                    age_skull = table.Column<string>(type: "character varying", nullable: true),
                    rack_and_shelf = table.Column<string>(type: "character varying", nullable: true),
                    to_be_confirmed = table.Column<string>(type: "character varying", nullable: true),
                    skull_trauma = table.Column<string>(type: "character varying", nullable: true),
                    postcrania_trauma = table.Column<string>(type: "character varying", nullable: true),
                    cribra_orbitala = table.Column<string>(type: "character varying", nullable: true),
                    porotic_hyperostosis = table.Column<string>(type: "character varying", nullable: true),
                    porotic_hyperostosis_locations = table.Column<string>(type: "character varying", nullable: true),
                    metopic_suture = table.Column<string>(type: "character varying", nullable: true),
                    button_osteoma = table.Column<string>(type: "character varying", nullable: true),
                    osteology_unknown_comment = table.Column<string>(type: "character varying", nullable: true),
                    temporal_mandibular_joint_osteoarthritis_tmj_oa = table.Column<string>(type: "character varying", nullable: true),
                    linear_hypoplasia_enamel = table.Column<string>(type: "character varying", nullable: true),
                    area_hill_burials = table.Column<int>(nullable: true),
                    tomb = table.Column<int>(nullable: true),
                    burial_sub_number = table.Column<string>(type: "character varying", nullable: true),
                    year_excav = table.Column<string>(type: "character varying", nullable: true),
                    month_excavated = table.Column<string>(type: "character varying", nullable: true),
                    date_excavated = table.Column<int>(nullable: true),
                    burial_direction = table.Column<string>(type: "character varying", nullable: true),
                    burial_preservation = table.Column<string>(type: "character varying", nullable: true),
                    burial_wrapping = table.Column<string>(type: "character varying", nullable: true),
                    burial_adult_child = table.Column<string>(type: "character varying", nullable: true),
                    gender_code = table.Column<string>(type: "character varying", nullable: true),
                    burialgendermethod = table.Column<string>(type: "character varying", nullable: true),
                    age_code_single = table.Column<string>(type: "character varying", nullable: true),
                    burialageatdeath = table.Column<string>(type: "character varying", nullable: true),
                    burialagemethod = table.Column<string>(type: "character varying", nullable: true),
                    hair_color_code = table.Column<string>(type: "character varying", nullable: true),
                    burialhaircolor = table.Column<string>(type: "character varying", nullable: true),
                    burialsampletaken = table.Column<bool>(nullable: true),
                    length_m = table.Column<string>(type: "character varying", nullable: true),
                    length_cm = table.Column<string>(type: "character varying", nullable: true),
                    goods = table.Column<string>(type: "character varying", nullable: true),
                    clstr = table.Column<string>(type: "character varying", nullable: true),
                    face_bundle = table.Column<string>(type: "character varying", nullable: true),
                    osteology_notes = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("master_burial2_pkey", x => x.burial_id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "carbon2",
                columns: table => new
                {
                    carbon_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'26', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    burial_id = table.Column<int>(nullable: true),
                    loc_concat = table.Column<string>(type: "character varying", nullable: true),
                    rack_num = table.Column<string>(type: "character varying", nullable: true),
                    location_ns = table.Column<string>(type: "character varying", nullable: true),
                    ns = table.Column<string>(type: "character varying", nullable: true),
                    location_ew = table.Column<string>(type: "character varying", nullable: true),
                    ew = table.Column<string>(type: "character varying", nullable: true),
                    burial_subplot = table.Column<string>(type: "character varying", nullable: true),
                    area = table.Column<string>(type: "character varying", nullable: true),
                    burial_num = table.Column<string>(type: "character varying", nullable: true),
                    rack_alt = table.Column<string>(type: "character varying", nullable: true),
                    tube_num = table.Column<string>(type: "character varying", nullable: true),
                    description = table.Column<string>(type: "character varying", nullable: true),
                    size_ml = table.Column<string>(type: "character varying", nullable: true),
                    foci = table.Column<string>(type: "character varying", nullable: true),
                    c14_sample_2017 = table.Column<string>(type: "character varying", nullable: true),
                    location = table.Column<string>(type: "character varying", nullable: true),
                    questions = table.Column<string>(type: "character varying", nullable: true),
                    num = table.Column<string>(type: "character varying", nullable: true),
                    conventional_14c_age_bp = table.Column<string>(type: "character varying", nullable: true),
                    c_calendar_date = table.Column<string>(type: "character varying", nullable: true),
                    calibrated_95_percent_calendar_date_max = table.Column<string>(type: "character varying", nullable: true),
                    calibrated_95_percent_calendar_date_min = table.Column<string>(type: "character varying", nullable: true),
                    calibrated_95_percent_calendar_date_span = table.Column<string>(type: "character varying", nullable: true),
                    calibrated_95_percent_calendar_date_avg = table.Column<string>(type: "character varying", nullable: true),
                    category = table.Column<string>(type: "character varying", nullable: true),
                    notes = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("carbon2_pkey", x => x.carbon_id);
                    table.ForeignKey(
                        name: "burial_id",
                        column: x => x.burial_id,
                        principalTable: "master_burial2",
                        principalColumn: "burial_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "samples2",
                columns: table => new
                {
                    sample_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'2000', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    burial_id = table.Column<int>(nullable: true),
                    loc_concat = table.Column<string>(type: "character varying", nullable: true),
                    rack_num = table.Column<int>(nullable: true),
                    bag_num = table.Column<int>(nullable: true),
                    low_ns = table.Column<int>(nullable: true),
                    high_ns = table.Column<int>(nullable: true),
                    n_s = table.Column<string>(type: "character varying", nullable: true),
                    low_ew = table.Column<int>(nullable: true),
                    high_ew = table.Column<int>(nullable: true),
                    e_w = table.Column<string>(type: "character varying", nullable: true),
                    area = table.Column<string>(type: "character varying", nullable: true),
                    burial_num = table.Column<long>(nullable: true),
                    sub_burial_num = table.Column<string>(type: "character varying", nullable: true),
                    cluster_num = table.Column<int>(nullable: true),
                    date_day = table.Column<int>(nullable: true),
                    date_month = table.Column<int>(nullable: true),
                    date_year = table.Column<int>(nullable: true),
                    previously_sampled = table.Column<string>(type: "character varying", nullable: true),
                    notes = table.Column<string>(nullable: true),
                    initials = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("samples2_pkey", x => x.sample_id);
                    table.ForeignKey(
                        name: "burial_id",
                        column: x => x.burial_id,
                        principalTable: "master_burial2",
                        principalColumn: "burial_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_carbon2_burial_id",
                table: "carbon2",
                column: "burial_id");

            migrationBuilder.CreateIndex(
                name: "IX_samples2_burial_id",
                table: "samples2",
                column: "burial_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "carbon2");

            migrationBuilder.DropTable(
                name: "samples2");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "master_burial2");
        }
    }
}
