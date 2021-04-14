using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Fag_el_Gamous.Models
{
    //class for burial table in database
    public partial class MasterBurial2
    {
        public MasterBurial2()
        {
            Carbon2 = new HashSet<Carbon2>();
            Photos = new HashSet<Photos>();
            Samples2 = new HashSet<Samples2>();
        }

        public string LocConcat { get; set; }
        public int BurialId { get; set; }
        public string BurialLocationNs { get; set; }
        public string LowPairNs { get; set; }
        public string HighPairNs { get; set; }
        public string BurialLocationEw { get; set; }
        public string LowPairEw { get; set; }
        public string HighPairEw { get; set; }
        public string BurialSubplot { get; set; }
        public int? BurialNumber { get; set; }
        public string BurialDepth { get; set; }
        public string SouthToHead { get; set; }
        public string SouthToFeet { get; set; }
        public string WestToHead { get; set; }
        public string WestToFeet { get; set; }
        public string LengthOfRemains { get; set; }
        public string BurialSituation { get; set; }
        public int? SampleNumber { get; set; }
        public string GenderGe { get; set; }
        public string GeFunctionTotal { get; set; }
        public string GenderBodyCol { get; set; }
        public string BasilarSuture { get; set; }
        public int? VentralArc { get; set; }
        public int? SubpubicAngle { get; set; }
        public int? SciaticNotch { get; set; }
        public int? PubicBone { get; set; }
        public int? PreaurSulcus { get; set; }
        public int? MedialIpRamus { get; set; }
        public int? DorsalPitting { get; set; }
        public string ForemanMagnum { get; set; }
        public string FemurHead { get; set; }
        public string HumerusHead { get; set; }
        public string Osteophytosis { get; set; }
        public string PubicSymphysis { get; set; }
        public string BoneLength { get; set; }
        public string MedialClavicle { get; set; }
        public string IliacCrest { get; set; }
        public string FemurDiameter { get; set; }
        public string Humerus { get; set; }
        public string FemurLength { get; set; }
        public string HumerusLength { get; set; }
        public string TibiaLength { get; set; }
        public int? Robust { get; set; }
        public int? SupraorbitalRidges { get; set; }
        public int? OrbitEdge { get; set; }
        public int? ParietalBossing { get; set; }
        public int? Gonian { get; set; }
        public int? NuchalCrest { get; set; }
        public int? ZygomaticCrest { get; set; }
        public string CranialSuture { get; set; }
        public string MaximumCranialLength { get; set; }
        public string MaximumCranialBreadth { get; set; }
        public string BasionBregmaHeight { get; set; }
        public string BasionNasion { get; set; }
        public string BasionProsthionLength { get; set; }
        public string BizygomaticDiameter { get; set; }
        public string NasionProsthion { get; set; }
        public string MaximumNasalBreadth { get; set; }
        public string InterorbitalBreadth { get; set; }
        public string ArtifactsDescription { get; set; }
        public string HairColor { get; set; }
        public string PreservationIndex { get; set; }
        public bool? HairTakenTf { get; set; }
        public bool? SoftTissueTakenTf { get; set; }
        public bool? BoneTakenTf { get; set; }
        public bool? ToothTakenTf { get; set; }
        public bool? TextileTakenTf { get; set; }
        public bool? ArtifactFoundTf { get; set; }
        public string DescriptionOfTaken { get; set; }
        public string EstimateAge { get; set; }
        public string EstimateLivingStature { get; set; }
        public string ToothAttrition { get; set; }
        public string ToothEruption { get; set; }
        public string PathologyAnomalies { get; set; }
        public string EpiphysealUnion { get; set; }
        public int? YearFound { get; set; }
        public string MonthFound { get; set; }
        public int? DayFound { get; set; }
        public string HeadDirection { get; set; }
        public string Preservation { get; set; }
        public string Burialicon { get; set; }
        public string Burialicon2 { get; set; }
        public string Sex { get; set; }
        public string Sexmethod { get; set; }
        public string Ageatdeath { get; set; }
        public string Agemethod { get; set; }
        public string Haircolor1 { get; set; }
        public string Sample { get; set; }
        public string YearOnSkull { get; set; }
        public string MonthOnSkull { get; set; }
        public int? DateOnSkull { get; set; }
        public string FieldBook { get; set; }
        public string FieldBookPageNumber { get; set; }
        public string InitialsOfDataEntryExpert { get; set; }
        public string InitialsOfDataEntryChecker { get; set; }
        public string ByuSample { get; set; }
        public int? BodyAnalysis { get; set; }
        public string SkullAtMagazine { get; set; }
        public string PostcraniaAtMagazine { get; set; }
        public string SexSkull { get; set; }
        public string AgeSkull { get; set; }
        public string RackAndShelf { get; set; }
        public string ToBeConfirmed { get; set; }
        public string SkullTrauma { get; set; }
        public string PostcraniaTrauma { get; set; }
        public string CribraOrbitala { get; set; }
        public string PoroticHyperostosis { get; set; }
        public string PoroticHyperostosisLocations { get; set; }
        public string MetopicSuture { get; set; }
        public string ButtonOsteoma { get; set; }
        public string OsteologyUnknownComment { get; set; }
        public string TemporalMandibularJointOsteoarthritisTmjOa { get; set; }
        public string LinearHypoplasiaEnamel { get; set; }
        public int? AreaHillBurials { get; set; }
        public int? Tomb { get; set; }
        public string BurialSubNumber { get; set; }
        public string YearExcav { get; set; }
        public string MonthExcavated { get; set; }
        public int? DateExcavated { get; set; }
        public string BurialDirection { get; set; }
        public string BurialPreservation { get; set; }
        public string BurialWrapping { get; set; }
        public string BurialAdultChild { get; set; }
        public string GenderCode { get; set; }
        public string Burialgendermethod { get; set; }
        public string AgeCodeSingle { get; set; }
        public string Burialageatdeath { get; set; }
        public string Burialagemethod { get; set; }
        public string HairColorCode { get; set; }
        public string Burialhaircolor { get; set; }
        public bool? Burialsampletaken { get; set; }
        public string LengthM { get; set; }
        public string LengthCm { get; set; }
        public string Goods { get; set; }
        public string Clstr { get; set; }
        public string FaceBundle { get; set; }
        public string OsteologyNotes { get; set; }

        public virtual ICollection<Carbon2> Carbon2 { get; set; }
        public virtual ICollection<Photos> Photos { get; set; }
        public virtual ICollection<Samples2> Samples2 { get; set; }
    }
}
