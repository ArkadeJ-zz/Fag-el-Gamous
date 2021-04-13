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

        public virtual DbSet<Carbon2> Carbon2 { get; set; }
        public virtual DbSet<MasterBurial2> MasterBurial2 { get; set; }
        public virtual DbSet<Samples2> Samples2 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=aa1ealgxnrs2ipk.cehgg64lqejx.us-east-1.rds.amazonaws.com;Database=waterbuffalo;user Id=sqlserver;Password=profgreg;MultipleActiveResultSets=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Carbon2>(entity =>
            {
                entity.HasKey(e => e.CarbonId);

                entity.ToTable("carbon2");

                entity.Property(e => e.CarbonId)
                    .HasColumnName("carbon_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasMaxLength(50);

                entity.Property(e => e.BurialId).HasColumnName("burial_id");

                entity.Property(e => e.BurialNum)
                    .HasColumnName("burial_num")
                    .HasMaxLength(50);

                entity.Property(e => e.BurialSubplot)
                    .HasColumnName("burial_subplot")
                    .HasMaxLength(50);

                entity.Property(e => e.C14Sample2017)
                    .HasColumnName("C14_Sample_2017")
                    .HasMaxLength(50);

                entity.Property(e => e.CCalendarDate)
                    .HasColumnName("C_Calendar_Date")
                    .HasMaxLength(50);

                entity.Property(e => e.Calibrated95PercentCalendarDateAvg)
                    .HasColumnName("Calibrated_95_Percent_Calendar_Date_AVG")
                    .HasMaxLength(50);

                entity.Property(e => e.Calibrated95PercentCalendarDateMax)
                    .HasColumnName("Calibrated_95_Percent_Calendar_Date_MAX")
                    .HasMaxLength(50);

                entity.Property(e => e.Calibrated95PercentCalendarDateMin)
                    .HasColumnName("Calibrated_95_Percent_Calendar_Date_MIN")
                    .HasMaxLength(50);

                entity.Property(e => e.Calibrated95PercentCalendarDateSpan)
                    .HasColumnName("Calibrated_95_Percent_Calendar_Date_SPAN")
                    .HasMaxLength(50);

                entity.Property(e => e.Category).HasMaxLength(50);

                entity.Property(e => e.Conventional14cAgeBp)
                    .HasColumnName("Conventional_14C_age_BP")
                    .HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Ew)
                    .HasColumnName("EW")
                    .HasMaxLength(50);

                entity.Property(e => e.Foci).HasMaxLength(50);

                entity.Property(e => e.LocConcat)
                    .HasColumnName("loc_concat")
                    .HasMaxLength(50);

                entity.Property(e => e.Location).HasMaxLength(100);

                entity.Property(e => e.LocationEw)
                    .HasColumnName("location_EW")
                    .HasMaxLength(50);

                entity.Property(e => e.LocationNs)
                    .HasColumnName("location_NS")
                    .HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(50);

                entity.Property(e => e.Ns)
                    .HasColumnName("NS")
                    .HasMaxLength(50);

                entity.Property(e => e.Num)
                    .HasColumnName("num")
                    .HasMaxLength(50);

                entity.Property(e => e.Questions).HasMaxLength(150);

                entity.Property(e => e.RackAlt)
                    .HasColumnName("Rack_alt")
                    .HasMaxLength(50);

                entity.Property(e => e.RackNum)
                    .HasColumnName("rack_num")
                    .HasMaxLength(50);

                entity.Property(e => e.SizeMl)
                    .HasColumnName("Size_ml")
                    .HasMaxLength(50);

                entity.Property(e => e.TubeNum)
                    .HasColumnName("tube_num")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MasterBurial2>(entity =>
            {
                entity.HasKey(e => e.BurialId);

                entity.ToTable("masterBurial2");

                entity.Property(e => e.BurialId)
                    .HasColumnName("burial_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AgeCodeSingle)
                    .HasColumnName("Age_Code_SINGLE")
                    .HasMaxLength(50);

                entity.Property(e => e.AgeSkull)
                    .HasColumnName("Age_Skull")
                    .HasMaxLength(50);

                entity.Property(e => e.Ageatdeath)
                    .HasColumnName("AGEATDEATH")
                    .HasMaxLength(50);

                entity.Property(e => e.Agemethod)
                    .HasColumnName("AGEMETHOD")
                    .HasMaxLength(50);

                entity.Property(e => e.AreaHillBurials)
                    .HasColumnName("Area_Hill_burials")
                    .HasMaxLength(50);

                entity.Property(e => e.ArtifactFoundTf)
                    .HasColumnName("artifact_found_tf")
                    .HasMaxLength(50);

                entity.Property(e => e.ArtifactsDescription)
                    .HasColumnName("artifacts_description")
                    .HasMaxLength(150);

                entity.Property(e => e.BasilarSuture)
                    .HasColumnName("basilar_suture")
                    .HasMaxLength(50);

                entity.Property(e => e.BasionBregmaHeight)
                    .HasColumnName("basion_bregma_height")
                    .HasMaxLength(50);

                entity.Property(e => e.BasionNasion)
                    .HasColumnName("basion_nasion")
                    .HasMaxLength(50);

                entity.Property(e => e.BasionProsthionLength)
                    .HasColumnName("basion_prosthion_length")
                    .HasMaxLength(50);

                entity.Property(e => e.BizygomaticDiameter)
                    .HasColumnName("bizygomatic_diameter")
                    .HasMaxLength(50);

                entity.Property(e => e.BodyAnalysis)
                    .HasColumnName("Body_Analysis")
                    .HasMaxLength(50);

                entity.Property(e => e.BoneLength)
                    .HasColumnName("bone_length")
                    .HasMaxLength(50);

                entity.Property(e => e.BoneTakenTf)
                    .HasColumnName("bone_taken_tf")
                    .HasMaxLength(50);

                entity.Property(e => e.BurialAdultChild)
                    .HasColumnName("burial_adult_child")
                    .HasMaxLength(100);

                entity.Property(e => e.BurialDepth)
                    .HasColumnName("burial_depth")
                    .HasMaxLength(50);

                entity.Property(e => e.BurialDirection)
                    .HasColumnName("burial_direction")
                    .HasMaxLength(50);

                entity.Property(e => e.BurialLocationEw)
                    .HasColumnName("burial_location_EW")
                    .HasMaxLength(50);

                entity.Property(e => e.BurialLocationNs)
                    .HasColumnName("burial_location_NS")
                    .HasMaxLength(50);

                entity.Property(e => e.BurialNumber)
                    .HasColumnName("burial_number")
                    .HasMaxLength(50);

                entity.Property(e => e.BurialPreservation)
                    .HasColumnName("burial_preservation")
                    .HasMaxLength(50);

                entity.Property(e => e.BurialSituation)
                    .HasColumnName("burial_situation")
                    .HasMaxLength(1100);

                entity.Property(e => e.BurialSubNumber)
                    .HasColumnName("Burial_Sub_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.BurialSubplot)
                    .HasColumnName("burial_subplot")
                    .HasMaxLength(50);

                entity.Property(e => e.BurialWrapping)
                    .HasColumnName("burial_wrapping")
                    .HasMaxLength(100);

                entity.Property(e => e.Burialageatdeath)
                    .HasColumnName("burialageatdeath")
                    .HasMaxLength(50);

                entity.Property(e => e.Burialagemethod)
                    .HasColumnName("burialagemethod")
                    .HasMaxLength(50);

                entity.Property(e => e.Burialgendermethod)
                    .HasColumnName("burialgendermethod")
                    .HasMaxLength(50);

                entity.Property(e => e.Burialhaircolor)
                    .HasColumnName("burialhaircolor")
                    .HasMaxLength(50);

                entity.Property(e => e.Burialicon)
                    .HasColumnName("BURIALICON")
                    .HasMaxLength(50);

                entity.Property(e => e.Burialicon2)
                    .HasColumnName("BURIALICON2")
                    .HasMaxLength(50);

                entity.Property(e => e.Burialsampletaken)
                    .HasColumnName("burialsampletaken")
                    .HasMaxLength(50);

                entity.Property(e => e.ButtonOsteoma)
                    .HasColumnName("Button_Osteoma")
                    .HasMaxLength(50);

                entity.Property(e => e.ByuSample)
                    .HasColumnName("BYU_Sample")
                    .HasMaxLength(50);

                entity.Property(e => e.Clstr).HasMaxLength(50);

                entity.Property(e => e.CranialSuture)
                    .HasColumnName("cranial_suture")
                    .HasMaxLength(50);

                entity.Property(e => e.CribraOrbitala)
                    .HasColumnName("Cribra_Orbitala")
                    .HasMaxLength(50);

                entity.Property(e => e.DateExcavated)
                    .HasColumnName("Date_Excavated")
                    .HasMaxLength(50);

                entity.Property(e => e.DateOnSkull)
                    .HasColumnName("Date_on_Skull")
                    .HasMaxLength(50);

                entity.Property(e => e.DayFound)
                    .HasColumnName("day_found")
                    .HasMaxLength(50);

                entity.Property(e => e.DescriptionOfTaken)
                    .HasColumnName("description_of_taken")
                    .HasMaxLength(100);

                entity.Property(e => e.DorsalPitting)
                    .HasColumnName("dorsal_pitting")
                    .HasMaxLength(50);

                entity.Property(e => e.EpiphysealUnion)
                    .HasColumnName("epiphyseal_union")
                    .HasMaxLength(50);

                entity.Property(e => e.EstimateAge)
                    .HasColumnName("estimate_age")
                    .HasMaxLength(50);

                entity.Property(e => e.EstimateLivingStature)
                    .HasColumnName("estimate_living_stature")
                    .HasMaxLength(50);

                entity.Property(e => e.FaceBundle)
                    .HasColumnName("Face_Bundle")
                    .HasMaxLength(50);

                entity.Property(e => e.FemurDiameter)
                    .HasColumnName("femur_diameter")
                    .HasMaxLength(50);

                entity.Property(e => e.FemurHead)
                    .HasColumnName("femur_head")
                    .HasMaxLength(50);

                entity.Property(e => e.FemurLength)
                    .HasColumnName("femur_length")
                    .HasMaxLength(50);

                entity.Property(e => e.FieldBook)
                    .HasColumnName("Field_Book")
                    .HasMaxLength(50);

                entity.Property(e => e.FieldBookPageNumber)
                    .HasColumnName("Field_Book_Page_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.ForemanMagnum)
                    .HasColumnName("foreman_magnum")
                    .HasMaxLength(1);

                entity.Property(e => e.GeFunctionTotal)
                    .HasColumnName("GE_function_total")
                    .HasMaxLength(50);

                entity.Property(e => e.GenderBodyCol)
                    .HasColumnName("gender_body_col")
                    .HasMaxLength(50);

                entity.Property(e => e.GenderCode)
                    .HasColumnName("Gender_Code")
                    .HasMaxLength(100);

                entity.Property(e => e.GenderGe)
                    .HasColumnName("gender_GE")
                    .HasMaxLength(50);

                entity.Property(e => e.Gonian)
                    .HasColumnName("gonian")
                    .HasMaxLength(50);

                entity.Property(e => e.Goods).HasMaxLength(50);

                entity.Property(e => e.HairColor)
                    .HasColumnName("hair_color")
                    .HasMaxLength(50);

                entity.Property(e => e.HairColorCode)
                    .HasColumnName("Hair_Color_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.HairTakenTf)
                    .HasColumnName("hair_taken_tf")
                    .HasMaxLength(50);

                entity.Property(e => e.Haircolor1)
                    .HasColumnName("HAIRCOLOR")
                    .HasMaxLength(50);

                entity.Property(e => e.HeadDirection)
                    .HasColumnName("head_direction")
                    .HasMaxLength(50);

                entity.Property(e => e.HighPairEw)
                    .HasColumnName("high_pair_EW")
                    .HasMaxLength(50);

                entity.Property(e => e.HighPairNs)
                    .HasColumnName("high_pair_NS")
                    .HasMaxLength(50);

                entity.Property(e => e.Humerus)
                    .HasColumnName("humerus")
                    .HasMaxLength(50);

                entity.Property(e => e.HumerusHead)
                    .HasColumnName("humerus_head")
                    .HasMaxLength(50);

                entity.Property(e => e.HumerusLength)
                    .HasColumnName("humerus_length")
                    .HasMaxLength(50);

                entity.Property(e => e.IliacCrest)
                    .HasColumnName("iliac_crest")
                    .HasMaxLength(50);

                entity.Property(e => e.InitialsOfDataEntryChecker)
                    .HasColumnName("Initials_of_Data_Entry_Checker")
                    .HasMaxLength(50);

                entity.Property(e => e.InitialsOfDataEntryExpert)
                    .HasColumnName("Initials_of_Data_Entry_Expert")
                    .HasMaxLength(50);

                entity.Property(e => e.InterorbitalBreadth)
                    .HasColumnName("interorbital_breadth")
                    .HasMaxLength(50);

                entity.Property(e => e.LengthCm)
                    .HasColumnName("length_cm")
                    .HasMaxLength(50);

                entity.Property(e => e.LengthM)
                    .HasColumnName("length_m")
                    .HasMaxLength(50);

                entity.Property(e => e.LengthOfRemains)
                    .HasColumnName("length_of_remains")
                    .HasMaxLength(50);

                entity.Property(e => e.LinearHypoplasiaEnamel)
                    .HasColumnName("Linear_Hypoplasia_Enamel")
                    .HasMaxLength(50);

                entity.Property(e => e.LocConcat)
                    .HasColumnName("loc_concat")
                    .HasMaxLength(50);

                entity.Property(e => e.LowPairEw)
                    .HasColumnName("low_pair_EW")
                    .HasMaxLength(50);

                entity.Property(e => e.LowPairNs)
                    .HasColumnName("low_pair_NS")
                    .HasMaxLength(50);

                entity.Property(e => e.MaximumCranialBreadth)
                    .HasColumnName("maximum_cranial_breadth")
                    .HasMaxLength(50);

                entity.Property(e => e.MaximumCranialLength)
                    .HasColumnName("maximum_cranial_length")
                    .HasMaxLength(50);

                entity.Property(e => e.MaximumNasalBreadth)
                    .HasColumnName("maximum_nasal_breadth")
                    .HasMaxLength(50);

                entity.Property(e => e.MedialClavicle)
                    .HasColumnName("medial_clavicle")
                    .HasMaxLength(50);

                entity.Property(e => e.MedialIpRamus)
                    .HasColumnName("medial_IP_ramus")
                    .HasMaxLength(50);

                entity.Property(e => e.MetopicSuture)
                    .HasColumnName("Metopic_Suture")
                    .HasMaxLength(50);

                entity.Property(e => e.MonthExcavated)
                    .HasColumnName("Month_Excavated")
                    .HasMaxLength(50);

                entity.Property(e => e.MonthFound)
                    .HasColumnName("month_found")
                    .HasMaxLength(50);

                entity.Property(e => e.MonthOnSkull)
                    .HasColumnName("Month_on_skull")
                    .HasMaxLength(50);

                entity.Property(e => e.NasionProsthion)
                    .HasColumnName("nasion_prosthion")
                    .HasMaxLength(50);

                entity.Property(e => e.NuchalCrest)
                    .HasColumnName("nuchal_crest")
                    .HasMaxLength(50);

                entity.Property(e => e.OrbitEdge)
                    .HasColumnName("orbit_edge")
                    .HasMaxLength(50);

                entity.Property(e => e.OsteologyNotes)
                    .HasColumnName("Osteology_Notes")
                    .HasMaxLength(700);

                entity.Property(e => e.OsteologyUnknownComment)
                    .HasColumnName("Osteology_unknown_comment")
                    .HasMaxLength(50);

                entity.Property(e => e.Osteophytosis)
                    .HasColumnName("osteophytosis")
                    .HasMaxLength(50);

                entity.Property(e => e.ParietalBossing)
                    .HasColumnName("parietal_bossing")
                    .HasMaxLength(50);

                entity.Property(e => e.PathologyAnomalies)
                    .HasColumnName("pathology_anomalies")
                    .HasMaxLength(200);

                entity.Property(e => e.PoroticHyperostosis)
                    .HasColumnName("Porotic_Hyperostosis")
                    .HasMaxLength(50);

                entity.Property(e => e.PoroticHyperostosisLocations)
                    .HasColumnName("Porotic_Hyperostosis_LOCATIONS")
                    .HasMaxLength(50);

                entity.Property(e => e.PostcraniaAtMagazine)
                    .HasColumnName("Postcrania_at_Magazine")
                    .HasMaxLength(50);

                entity.Property(e => e.PostcraniaTrauma)
                    .HasColumnName("Postcrania_Trauma")
                    .HasMaxLength(50);

                entity.Property(e => e.PreaurSulcus)
                    .HasColumnName("preaur_sulcus")
                    .HasMaxLength(50);

                entity.Property(e => e.Preservation)
                    .HasColumnName("PRESERVATION")
                    .HasMaxLength(50);

                entity.Property(e => e.PreservationIndex)
                    .HasColumnName("preservation_index")
                    .HasMaxLength(50);

                entity.Property(e => e.PubicBone)
                    .HasColumnName("pubic_bone")
                    .HasMaxLength(50);

                entity.Property(e => e.PubicSymphysis)
                    .HasColumnName("pubic_symphysis")
                    .HasMaxLength(50);

                entity.Property(e => e.RackAndShelf)
                    .HasColumnName("Rack_and_Shelf")
                    .HasMaxLength(50);

                entity.Property(e => e.Robust)
                    .HasColumnName("robust")
                    .HasMaxLength(50);

                entity.Property(e => e.Sample)
                    .HasColumnName("SAMPLE")
                    .HasMaxLength(50);

                entity.Property(e => e.SampleNumber)
                    .HasColumnName("sample_number")
                    .HasMaxLength(50);

                entity.Property(e => e.SciaticNotch)
                    .HasColumnName("sciatic_notch")
                    .HasMaxLength(50);

                entity.Property(e => e.Sex)
                    .HasColumnName("SEX")
                    .HasMaxLength(50);

                entity.Property(e => e.SexSkull)
                    .HasColumnName("Sex_Skull")
                    .HasMaxLength(50);

                entity.Property(e => e.Sexmethod)
                    .HasColumnName("SEXMETHOD")
                    .HasMaxLength(50);

                entity.Property(e => e.SkullAtMagazine)
                    .HasColumnName("Skull_at_Magazine")
                    .HasMaxLength(50);

                entity.Property(e => e.SkullTrauma)
                    .HasColumnName("Skull_Trauma")
                    .HasMaxLength(50);

                entity.Property(e => e.SoftTissueTakenTf)
                    .HasColumnName("soft_tissue_taken_tf")
                    .HasMaxLength(50);

                entity.Property(e => e.SouthToFeet)
                    .HasColumnName("south_to_feet")
                    .HasMaxLength(50);

                entity.Property(e => e.SouthToHead)
                    .HasColumnName("south_to_head")
                    .HasMaxLength(50);

                entity.Property(e => e.SubpubicAngle)
                    .HasColumnName("subpubic_angle")
                    .HasMaxLength(50);

                entity.Property(e => e.SupraorbitalRidges)
                    .HasColumnName("supraorbital_ridges")
                    .HasMaxLength(50);

                entity.Property(e => e.TemporalMandibularJointOsteoarthritisTmjOa)
                    .HasColumnName("Temporal_Mandibular_Joint_Osteoarthritis_TMJ_OA")
                    .HasMaxLength(50);

                entity.Property(e => e.TextileTakenTf)
                    .HasColumnName("textile_taken_tf")
                    .HasMaxLength(50);

                entity.Property(e => e.TibiaLength)
                    .HasColumnName("tibia_length")
                    .HasMaxLength(50);

                entity.Property(e => e.ToBeConfirmed)
                    .HasColumnName("TO_BE_CONFIRMED")
                    .HasMaxLength(50);

                entity.Property(e => e.Tomb).HasMaxLength(50);

                entity.Property(e => e.ToothAttrition)
                    .HasColumnName("tooth_attrition")
                    .HasMaxLength(50);

                entity.Property(e => e.ToothEruption)
                    .HasColumnName("tooth_eruption")
                    .HasMaxLength(50);

                entity.Property(e => e.ToothTakenTf)
                    .HasColumnName("tooth_taken_tf")
                    .HasMaxLength(50);

                entity.Property(e => e.VentralArc)
                    .HasColumnName("ventral_arc")
                    .HasMaxLength(50);

                entity.Property(e => e.WestToFeet)
                    .HasColumnName("west_to_feet")
                    .HasMaxLength(50);

                entity.Property(e => e.WestToHead)
                    .HasColumnName("west_to_head")
                    .HasMaxLength(50);

                entity.Property(e => e.YearExcav)
                    .HasColumnName("year_excav")
                    .HasMaxLength(50);

                entity.Property(e => e.YearFound)
                    .HasColumnName("year_found")
                    .HasMaxLength(50);

                entity.Property(e => e.YearOnSkull)
                    .HasColumnName("Year_on_skull")
                    .HasMaxLength(50);

                entity.Property(e => e.ZygomaticCrest)
                    .HasColumnName("zygomatic_crest")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Samples2>(entity =>
            {
                entity.HasKey(e => e.SampleId);

                entity.ToTable("samples2");

                entity.Property(e => e.SampleId)
                    .HasColumnName("sample_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasMaxLength(50);

                entity.Property(e => e.BagNum)
                    .HasColumnName("bag_num")
                    .HasMaxLength(50);

                entity.Property(e => e.BurialId).HasColumnName("burial_id");

                entity.Property(e => e.BurialNum)
                    .HasColumnName("burial_num")
                    .HasMaxLength(50);

                entity.Property(e => e.ClusterNum)
                    .HasColumnName("cluster_num")
                    .HasMaxLength(50);

                entity.Property(e => e.DateDay)
                    .HasColumnName("date_day")
                    .HasMaxLength(50);

                entity.Property(e => e.DateMonth)
                    .HasColumnName("date_month")
                    .HasMaxLength(50);

                entity.Property(e => e.DateYear).HasColumnName("date_year");

                entity.Property(e => e.EW)
                    .HasColumnName("e_w")
                    .HasMaxLength(50);

                entity.Property(e => e.HighEw)
                    .HasColumnName("high_ew")
                    .HasMaxLength(50);

                entity.Property(e => e.HighNs)
                    .HasColumnName("high_ns")
                    .HasMaxLength(50);

                entity.Property(e => e.Initials)
                    .HasColumnName("initials")
                    .HasMaxLength(50);

                entity.Property(e => e.LocConcat)
                    .HasColumnName("loc_concat")
                    .HasMaxLength(50);

                entity.Property(e => e.LowEw)
                    .HasColumnName("low_ew")
                    .HasMaxLength(50);

                entity.Property(e => e.LowNs)
                    .HasColumnName("low_ns")
                    .HasMaxLength(50);

                entity.Property(e => e.NS)
                    .HasColumnName("n_s")
                    .HasMaxLength(50);

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .IsUnicode(false);

                entity.Property(e => e.PreviouslySampled)
                    .HasColumnName("previously_sampled")
                    .HasMaxLength(50);

                entity.Property(e => e.RackNum).HasColumnName("rack_num");

                entity.Property(e => e.SubBurialNum)
                    .HasColumnName("sub_burial_num")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
