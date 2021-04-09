using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Fag_el_Gamous.Models
{
    public partial class waterbuffaloContext : DbContext
    {
        public waterbuffaloContext()
        {
        }

        public waterbuffaloContext(DbContextOptions<waterbuffaloContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Carbon> Carbon { get; set; }
        public virtual DbSet<MasterBurial> MasterBurial { get; set; }
        public virtual DbSet<Samples> Samples { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host = localhost; Database = waterbuffalo; Username=postgres; Password=sn0wb1rd");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Carbon>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("carbon");

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasColumnType("character varying");

                entity.Property(e => e.BurialId)
                    .HasColumnName("burial_id")
                    .HasColumnType("character varying");

                entity.Property(e => e.BurialNum)
                    .HasColumnName("burial_num")
                    .HasColumnType("character varying");

                entity.Property(e => e.BurialSubplot)
                    .HasColumnName("burial_subplot")
                    .HasColumnType("character varying");

                entity.Property(e => e.C14Sample2017)
                    .HasColumnName("c14_sample_2017")
                    .HasColumnType("character varying");

                entity.Property(e => e.CCalendarDate)
                    .HasColumnName("c_calendar_date")
                    .HasColumnType("character varying");

                entity.Property(e => e.Calibrated95PercentCalendarDateAvg)
                    .HasColumnName("calibrated_95_percent_calendar_date_avg")
                    .HasColumnType("character varying");

                entity.Property(e => e.Calibrated95PercentCalendarDateMax)
                    .HasColumnName("calibrated_95_percent_calendar_date_max")
                    .HasColumnType("character varying");

                entity.Property(e => e.Calibrated95PercentCalendarDateMin)
                    .HasColumnName("calibrated_95_percent_calendar_date_min")
                    .HasColumnType("character varying");

                entity.Property(e => e.Calibrated95PercentCalendarDateSpan)
                    .HasColumnName("calibrated_95_percent_calendar_date_span")
                    .HasColumnType("character varying");

                entity.Property(e => e.CarbonId)
                    .HasColumnName("carbon_id")
                    .HasColumnType("character varying");

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasColumnType("character varying");

                entity.Property(e => e.Conventional14cAgeBp)
                    .HasColumnName("conventional_14c_age_bp")
                    .HasColumnType("character varying");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("character varying");

                entity.Property(e => e.Ew)
                    .HasColumnName("ew")
                    .HasColumnType("character varying");

                entity.Property(e => e.Foci)
                    .HasColumnName("foci")
                    .HasColumnType("character varying");

                entity.Property(e => e.LocConcat)
                    .HasColumnName("loc_concat")
                    .HasColumnType("character varying");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasColumnType("character varying");

                entity.Property(e => e.LocationEw)
                    .HasColumnName("location_ew")
                    .HasColumnType("character varying");

                entity.Property(e => e.LocationNs)
                    .HasColumnName("location_ns")
                    .HasColumnType("character varying");

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .HasColumnType("character varying");

                entity.Property(e => e.Ns)
                    .HasColumnName("ns")
                    .HasColumnType("character varying");

                entity.Property(e => e.Num)
                    .HasColumnName("num")
                    .HasColumnType("character varying");

                entity.Property(e => e.Questions)
                    .HasColumnName("questions")
                    .HasColumnType("character varying");

                entity.Property(e => e.RackAlt)
                    .HasColumnName("rack_alt")
                    .HasColumnType("character varying");

                entity.Property(e => e.RackNum)
                    .HasColumnName("rack_num")
                    .HasColumnType("character varying");

                entity.Property(e => e.SizeMl)
                    .HasColumnName("size_ml")
                    .HasColumnType("character varying");

                entity.Property(e => e.TubeNum)
                    .HasColumnName("tube_num")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<MasterBurial>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("master_burial");

                entity.Property(e => e.AgeCodeSingle)
                    .HasColumnName("age_code_single")
                    .HasColumnType("character varying");

                entity.Property(e => e.AgeSkull)
                    .HasColumnName("age_skull")
                    .HasColumnType("character varying");

                entity.Property(e => e.Ageatdeath)
                    .HasColumnName("ageatdeath")
                    .HasColumnType("character varying");

                entity.Property(e => e.Agemethod)
                    .HasColumnName("agemethod")
                    .HasColumnType("character varying");

                entity.Property(e => e.AreaHillBurials).HasColumnName("area_hill_burials");

                entity.Property(e => e.ArtifactFoundTf).HasColumnName("artifact_found_tf");

                entity.Property(e => e.ArtifactsDescription)
                    .HasColumnName("artifacts_description")
                    .HasColumnType("character varying");

                entity.Property(e => e.BasilarSuture)
                    .HasColumnName("basilar_suture")
                    .HasColumnType("character varying");

                entity.Property(e => e.BasionBregmaHeight)
                    .HasColumnName("basion_bregma_height")
                    .HasColumnType("character varying");

                entity.Property(e => e.BasionNasion)
                    .HasColumnName("basion_nasion")
                    .HasColumnType("character varying");

                entity.Property(e => e.BasionProsthionLength)
                    .HasColumnName("basion_prosthion_length")
                    .HasColumnType("character varying");

                entity.Property(e => e.BizygomaticDiameter)
                    .HasColumnName("bizygomatic_diameter")
                    .HasColumnType("character varying");

                entity.Property(e => e.BodyAnalysis).HasColumnName("body_analysis");

                entity.Property(e => e.BoneLength)
                    .HasColumnName("bone_length")
                    .HasColumnType("character varying");

                entity.Property(e => e.BoneTakenTf).HasColumnName("bone_taken_tf");

                entity.Property(e => e.BurialAdultChild)
                    .HasColumnName("burial_adult_child")
                    .HasColumnType("character varying");

                entity.Property(e => e.BurialDepth)
                    .HasColumnName("burial_depth")
                    .HasColumnType("character varying");

                entity.Property(e => e.BurialDirection)
                    .HasColumnName("burial_direction")
                    .HasColumnType("character varying");

                entity.Property(e => e.BurialId)
                    .HasColumnName("burial_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BurialLocationEw)
                    .HasColumnName("burial_location_ew")
                    .HasColumnType("character varying");

                entity.Property(e => e.BurialLocationNs)
                    .HasColumnName("burial_location_ns")
                    .HasColumnType("character varying");

                entity.Property(e => e.BurialNumber).HasColumnName("burial_number");

                entity.Property(e => e.BurialPreservation)
                    .HasColumnName("burial_preservation")
                    .HasColumnType("character varying");

                entity.Property(e => e.BurialSituation)
                    .HasColumnName("burial_situation")
                    .HasColumnType("character varying");

                entity.Property(e => e.BurialSubNumber)
                    .HasColumnName("burial_sub_number")
                    .HasColumnType("character varying");

                entity.Property(e => e.BurialSubplot)
                    .HasColumnName("burial_subplot")
                    .HasColumnType("character varying");

                entity.Property(e => e.BurialWrapping)
                    .HasColumnName("burial_wrapping")
                    .HasColumnType("character varying");

                entity.Property(e => e.Burialageatdeath)
                    .HasColumnName("burialageatdeath")
                    .HasColumnType("character varying");

                entity.Property(e => e.Burialagemethod)
                    .HasColumnName("burialagemethod")
                    .HasColumnType("character varying");

                entity.Property(e => e.Burialgendermethod)
                    .HasColumnName("burialgendermethod")
                    .HasColumnType("character varying");

                entity.Property(e => e.Burialhaircolor)
                    .HasColumnName("burialhaircolor")
                    .HasColumnType("character varying");

                entity.Property(e => e.Burialicon)
                    .HasColumnName("burialicon")
                    .HasColumnType("character varying");

                entity.Property(e => e.Burialicon2)
                    .HasColumnName("burialicon2")
                    .HasColumnType("character varying");

                entity.Property(e => e.Burialsampletaken).HasColumnName("burialsampletaken");

                entity.Property(e => e.ButtonOsteoma)
                    .HasColumnName("button_osteoma")
                    .HasColumnType("character varying");

                entity.Property(e => e.ByuSample)
                    .HasColumnName("byu_sample")
                    .HasColumnType("character varying");

                entity.Property(e => e.Clstr)
                    .HasColumnName("clstr")
                    .HasColumnType("character varying");

                entity.Property(e => e.CranialSuture)
                    .HasColumnName("cranial_suture")
                    .HasColumnType("character varying");

                entity.Property(e => e.CribraOrbitala)
                    .HasColumnName("cribra_orbitala")
                    .HasColumnType("character varying");

                entity.Property(e => e.DateExcavated).HasColumnName("date_excavated");

                entity.Property(e => e.DateOnSkull).HasColumnName("date_on_skull");

                entity.Property(e => e.DayFound).HasColumnName("day_found");

                entity.Property(e => e.DescriptionOfTaken)
                    .HasColumnName("description_of_taken")
                    .HasColumnType("character varying");

                entity.Property(e => e.DorsalPitting).HasColumnName("dorsal_pitting");

                entity.Property(e => e.EastToFeet)
                    .HasColumnName("east_to_feet")
                    .HasColumnType("character varying");

                entity.Property(e => e.EastToHead)
                    .HasColumnName("east_to_head")
                    .HasColumnType("character varying");

                entity.Property(e => e.EpiphysealUnion)
                    .HasColumnName("epiphyseal_union")
                    .HasColumnType("character varying");

                entity.Property(e => e.EstimateAge)
                    .HasColumnName("estimate_age")
                    .HasColumnType("character varying");

                entity.Property(e => e.EstimateLivingStature)
                    .HasColumnName("estimate_living_stature")
                    .HasColumnType("character varying");

                entity.Property(e => e.FaceBundle)
                    .HasColumnName("face_bundle")
                    .HasColumnType("character varying");

                entity.Property(e => e.FemurDiameter)
                    .HasColumnName("femur_diameter")
                    .HasColumnType("character varying");

                entity.Property(e => e.FemurHead)
                    .HasColumnName("femur_head")
                    .HasColumnType("character varying");

                entity.Property(e => e.FemurLength)
                    .HasColumnName("femur_length")
                    .HasColumnType("character varying");

                entity.Property(e => e.FieldBook)
                    .HasColumnName("field_book")
                    .HasColumnType("character varying");

                entity.Property(e => e.FieldBookPageNumber)
                    .HasColumnName("field_book_page_number")
                    .HasColumnType("character varying");

                entity.Property(e => e.ForemanMagnum)
                    .HasColumnName("foreman_magnum")
                    .HasColumnType("character varying");

                entity.Property(e => e.GeFunctionTotal)
                    .HasColumnName("ge_function_total")
                    .HasColumnType("character varying");

                entity.Property(e => e.GenderBodyCol)
                    .HasColumnName("gender_body_col")
                    .HasColumnType("character varying");

                entity.Property(e => e.GenderCode)
                    .HasColumnName("gender_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.GenderGe)
                    .HasColumnName("gender_ge")
                    .HasColumnType("character varying");

                entity.Property(e => e.Gonian).HasColumnName("gonian");

                entity.Property(e => e.Goods)
                    .HasColumnName("goods")
                    .HasColumnType("character varying");

                entity.Property(e => e.HairColor)
                    .HasColumnName("hair_color")
                    .HasColumnType("character varying");

                entity.Property(e => e.HairColorCode)
                    .HasColumnName("hair_color_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.HairTakenTf).HasColumnName("hair_taken_tf");

                entity.Property(e => e.Haircolor1)
                    .HasColumnName("haircolor")
                    .HasColumnType("character varying");

                entity.Property(e => e.HeadDirection)
                    .HasColumnName("head_direction")
                    .HasColumnType("character varying");

                entity.Property(e => e.HighPairEw)
                    .HasColumnName("high_pair_ew")
                    .HasColumnType("character varying");

                entity.Property(e => e.HighPairNs)
                    .HasColumnName("high_pair_ns")
                    .HasColumnType("character varying");

                entity.Property(e => e.Humerus)
                    .HasColumnName("humerus")
                    .HasColumnType("character varying");

                entity.Property(e => e.HumerusHead)
                    .HasColumnName("humerus_head")
                    .HasColumnType("character varying");

                entity.Property(e => e.HumerusLength)
                    .HasColumnName("humerus_length")
                    .HasColumnType("character varying");

                entity.Property(e => e.IliacCrest)
                    .HasColumnName("iliac_crest")
                    .HasColumnType("character varying");

                entity.Property(e => e.InitialsOfDataEntryChecker)
                    .HasColumnName("initials_of_data_entry_checker")
                    .HasColumnType("character varying");

                entity.Property(e => e.InitialsOfDataEntryExpert)
                    .HasColumnName("initials_of_data_entry_expert")
                    .HasColumnType("character varying");

                entity.Property(e => e.InterorbitalBreadth)
                    .HasColumnName("interorbital_breadth")
                    .HasColumnType("character varying");

                entity.Property(e => e.LengthCm)
                    .HasColumnName("length_cm")
                    .HasColumnType("character varying");

                entity.Property(e => e.LengthM)
                    .HasColumnName("length_m")
                    .HasColumnType("character varying");

                entity.Property(e => e.LengthOfRemains)
                    .HasColumnName("length_of_remains")
                    .HasColumnType("character varying");

                entity.Property(e => e.LinearHypoplasiaEnamel)
                    .HasColumnName("linear_hypoplasia_enamel")
                    .HasColumnType("character varying");

                entity.Property(e => e.LocConcat)
                    .HasColumnName("loc_concat")
                    .HasColumnType("character varying");

                entity.Property(e => e.LowPairEw)
                    .HasColumnName("low_pair_ew")
                    .HasColumnType("character varying");

                entity.Property(e => e.LowPairNs)
                    .HasColumnName("low_pair_ns")
                    .HasColumnType("character varying");

                entity.Property(e => e.MaximumCranialBreadth)
                    .HasColumnName("maximum_cranial_breadth")
                    .HasColumnType("character varying");

                entity.Property(e => e.MaximumCranialLength)
                    .HasColumnName("maximum_cranial_length")
                    .HasColumnType("character varying");

                entity.Property(e => e.MaximumNasalBreadth)
                    .HasColumnName("maximum_nasal_breadth")
                    .HasColumnType("character varying");

                entity.Property(e => e.MedialClavicle)
                    .HasColumnName("medial_clavicle")
                    .HasColumnType("character varying");

                entity.Property(e => e.MedialIpRamus).HasColumnName("medial_ip_ramus");

                entity.Property(e => e.MetopicSuture)
                    .HasColumnName("metopic_suture")
                    .HasColumnType("character varying");

                entity.Property(e => e.MonthExcavated)
                    .HasColumnName("month_excavated")
                    .HasColumnType("character varying");

                entity.Property(e => e.MonthFound)
                    .HasColumnName("month_found")
                    .HasColumnType("character varying");

                entity.Property(e => e.MonthOnSkull)
                    .HasColumnName("month_on_skull")
                    .HasColumnType("character varying");

                entity.Property(e => e.NasionProsthion)
                    .HasColumnName("nasion_prosthion")
                    .HasColumnType("character varying");

                entity.Property(e => e.NuchalCrest).HasColumnName("nuchal_crest");

                entity.Property(e => e.OrbitEdge).HasColumnName("orbit_edge");

                entity.Property(e => e.OsteologyNotes)
                    .HasColumnName("osteology_notes")
                    .HasColumnType("character varying");

                entity.Property(e => e.OsteologyUnknownComment)
                    .HasColumnName("osteology_unknown_comment")
                    .HasColumnType("character varying");

                entity.Property(e => e.Osteophytosis)
                    .HasColumnName("osteophytosis")
                    .HasColumnType("character varying");

                entity.Property(e => e.ParietalBossing).HasColumnName("parietal_bossing");

                entity.Property(e => e.PathologyAnomalies)
                    .HasColumnName("pathology_anomalies")
                    .HasColumnType("character varying");

                entity.Property(e => e.PoroticHyperostosis)
                    .HasColumnName("porotic_hyperostosis")
                    .HasColumnType("character varying");

                entity.Property(e => e.PoroticHyperostosisLocations)
                    .HasColumnName("porotic_hyperostosis_locations")
                    .HasColumnType("character varying");

                entity.Property(e => e.PostcraniaAtMagazine)
                    .HasColumnName("postcrania_at_magazine")
                    .HasColumnType("character varying");

                entity.Property(e => e.PostcraniaTrauma)
                    .HasColumnName("postcrania_trauma")
                    .HasColumnType("character varying");

                entity.Property(e => e.PreaurSulcus).HasColumnName("preaur_sulcus");

                entity.Property(e => e.Preservation)
                    .HasColumnName("preservation")
                    .HasColumnType("character varying");

                entity.Property(e => e.PreservationIndex)
                    .HasColumnName("preservation_index")
                    .HasColumnType("character varying");

                entity.Property(e => e.PubicBone).HasColumnName("pubic_bone");

                entity.Property(e => e.PubicSymphysis)
                    .HasColumnName("pubic_symphysis")
                    .HasColumnType("character varying");

                entity.Property(e => e.RackAndShelf)
                    .HasColumnName("rack_and_shelf")
                    .HasColumnType("character varying");

                entity.Property(e => e.Robust).HasColumnName("robust");

                entity.Property(e => e.Sample)
                    .HasColumnName("sample")
                    .HasColumnType("character varying");

                entity.Property(e => e.SampleNumber).HasColumnName("sample_number");

                entity.Property(e => e.SciaticNotch).HasColumnName("sciatic_notch");

                entity.Property(e => e.Sex)
                    .HasColumnName("sex")
                    .HasColumnType("character varying");

                entity.Property(e => e.SexSkull)
                    .HasColumnName("sex_skull")
                    .HasColumnType("character varying");

                entity.Property(e => e.Sexmethod)
                    .HasColumnName("sexmethod")
                    .HasColumnType("character varying");

                entity.Property(e => e.SkullAtMagazine)
                    .HasColumnName("skull_at_magazine")
                    .HasColumnType("character varying");

                entity.Property(e => e.SkullTrauma)
                    .HasColumnName("skull_trauma")
                    .HasColumnType("character varying");

                entity.Property(e => e.SoftTissueTakenTf).HasColumnName("soft_tissue_taken_tf");

                entity.Property(e => e.SouthToFeet)
                    .HasColumnName("south_to_feet")
                    .HasColumnType("character varying");

                entity.Property(e => e.SouthToHead)
                    .HasColumnName("south_to_head")
                    .HasColumnType("character varying");

                entity.Property(e => e.SubpubicAngle).HasColumnName("subpubic_angle");

                entity.Property(e => e.SupraorbitalRidges).HasColumnName("supraorbital_ridges");

                entity.Property(e => e.TemporalMandibularJointOsteoarthritisTmjOa)
                    .HasColumnName("temporal_mandibular_joint_osteoarthritis_tmj_oa")
                    .HasColumnType("character varying");

                entity.Property(e => e.TextileTakenTf).HasColumnName("textile_taken_tf");

                entity.Property(e => e.TibiaLength)
                    .HasColumnName("tibia_length")
                    .HasColumnType("character varying");

                entity.Property(e => e.ToBeConfirmed)
                    .HasColumnName("to_be_confirmed")
                    .HasColumnType("character varying");

                entity.Property(e => e.Tomb).HasColumnName("tomb");

                entity.Property(e => e.ToothAttrition)
                    .HasColumnName("tooth_attrition")
                    .HasColumnType("character varying");

                entity.Property(e => e.ToothEruption)
                    .HasColumnName("tooth_eruption")
                    .HasColumnType("character varying");

                entity.Property(e => e.ToothTakenTf).HasColumnName("tooth_taken_tf");

                entity.Property(e => e.VentralArc).HasColumnName("ventral_arc");

                entity.Property(e => e.YearExcav)
                    .HasColumnName("year_excav")
                    .HasColumnType("character varying");

                entity.Property(e => e.YearFound).HasColumnName("year_found");

                entity.Property(e => e.YearOnSkull)
                    .HasColumnName("year_on_skull")
                    .HasColumnType("character varying");

                entity.Property(e => e.ZygomaticCrest).HasColumnName("zygomatic_crest");
            });

            modelBuilder.Entity<Samples>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("samples");

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasMaxLength(20);

                entity.Property(e => e.BagNum).HasColumnName("bag_num");

                entity.Property(e => e.BurialId)
                    .HasColumnName("burial_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BurialNum)
                    .HasColumnName("burial_num")
                    .HasColumnType("character varying");

                entity.Property(e => e.ClusterNum).HasColumnName("cluster_num");

                entity.Property(e => e.DDate)
                    .HasColumnName("d_date")
                    .HasColumnType("character varying");

                entity.Property(e => e.EW)
                    .HasColumnName("e_w")
                    .HasMaxLength(10);

                entity.Property(e => e.HighEw).HasColumnName("high_ew");

                entity.Property(e => e.HighNs).HasColumnName("high_ns");

                entity.Property(e => e.Initials)
                    .HasColumnName("initials")
                    .HasMaxLength(15);

                entity.Property(e => e.LocConcat)
                    .HasColumnName("loc_concat")
                    .HasMaxLength(50);

                entity.Property(e => e.LowEw).HasColumnName("low_ew");

                entity.Property(e => e.LowNs).HasColumnName("low_ns");

                entity.Property(e => e.NS)
                    .HasColumnName("n_s")
                    .HasMaxLength(10);

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .HasMaxLength(1000);

                entity.Property(e => e.PreviouslySampled)
                    .HasColumnName("previously_sampled")
                    .HasMaxLength(15);

                entity.Property(e => e.RackNum).HasColumnName("rack_num");

                entity.Property(e => e.SampleId)
                    .HasColumnName("sample_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SubBurialNum)
                    .HasColumnName("sub_burial_num")
                    .HasMaxLength(10);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
