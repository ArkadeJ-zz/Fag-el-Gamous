using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Fag_el_Gamous.Models;
using Fag_el_Gamous.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace Fag_el_Gamous
{
    public class MasterBurial2Controller : Controller
    {
        private readonly waterbuffaloContext _context;

        public MasterBurial2Controller(waterbuffaloContext context)
        {
            _context = context;
        }

        // GET: MasterBurial2
        [Authorize]
        public async Task<IActionResult> Index(int? burialId, int pageNum = 0)
        {
            int pageSize = 50;

            int skip = 0;

            if (pageNum - 1 < 0)
            { skip = 0; }
            else
            {
                skip = (pageNum - 1) * pageSize;
            }

            return View(new PaginationViewModel
            {
                //Carbons = ((IQueryable<Carbon2>)_context.Carbon2.Include(c => c.Burial).ToListAsync()),



                Burials = (_context.MasterBurial2
                    .Where(c => c.BurialId == burialId || burialId == null)
                    .Skip(skip)
                    .Take(pageSize)
                    .ToList()),

                PageNumberingInfo = new PageNumberingInfo
                {
                    NumItemsPerPage = pageSize,
                    CurrentPage = pageNum,

                    TotalNumItems = (burialId == null ? _context.MasterBurial2.Count() :
                        _context.MasterBurial2.Where(x => x.BurialId == burialId).Count())
                }
            });

            //return View(await _context.MasterBurial2.ToListAsync());
        }

        // GET: MasterBurial2/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var masterBurial2 = await _context.MasterBurial2
                .FirstOrDefaultAsync(m => m.BurialId == id);
            if (masterBurial2 == null)
            {
                return NotFound();
            }

            return View(masterBurial2);
        }

        // GET: MasterBurial2/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: MasterBurial2/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LocConcat,BurialId,BurialLocationNs,LowPairNs,HighPairNs,BurialLocationEw,LowPairEw,HighPairEw,BurialSubplot,BurialNumber,BurialDepth,SouthToHead,SouthToFeet,WestToHead,WestToFeet,LengthOfRemains,BurialSituation,SampleNumber,GenderGe,GeFunctionTotal,GenderBodyCol,BasilarSuture,VentralArc,SubpubicAngle,SciaticNotch,PubicBone,PreaurSulcus,MedialIpRamus,DorsalPitting,ForemanMagnum,FemurHead,HumerusHead,Osteophytosis,PubicSymphysis,BoneLength,MedialClavicle,IliacCrest,FemurDiameter,Humerus,FemurLength,HumerusLength,TibiaLength,Robust,SupraorbitalRidges,OrbitEdge,ParietalBossing,Gonian,NuchalCrest,ZygomaticCrest,CranialSuture,MaximumCranialLength,MaximumCranialBreadth,BasionBregmaHeight,BasionNasion,BasionProsthionLength,BizygomaticDiameter,NasionProsthion,MaximumNasalBreadth,InterorbitalBreadth,ArtifactsDescription,HairColor,PreservationIndex,HairTakenTf,SoftTissueTakenTf,BoneTakenTf,ToothTakenTf,TextileTakenTf,ArtifactFoundTf,DescriptionOfTaken,EstimateAge,EstimateLivingStature,ToothAttrition,ToothEruption,PathologyAnomalies,EpiphysealUnion,YearFound,MonthFound,DayFound,HeadDirection,Preservation,Burialicon,Burialicon2,Sex,Sexmethod,Ageatdeath,Agemethod,Haircolor1,Sample,YearOnSkull,MonthOnSkull,DateOnSkull,FieldBook,FieldBookPageNumber,InitialsOfDataEntryExpert,InitialsOfDataEntryChecker,ByuSample,BodyAnalysis,SkullAtMagazine,PostcraniaAtMagazine,SexSkull,AgeSkull,RackAndShelf,ToBeConfirmed,SkullTrauma,PostcraniaTrauma,CribraOrbitala,PoroticHyperostosis,PoroticHyperostosisLocations,MetopicSuture,ButtonOsteoma,OsteologyUnknownComment,TemporalMandibularJointOsteoarthritisTmjOa,LinearHypoplasiaEnamel,AreaHillBurials,Tomb,BurialSubNumber,YearExcav,MonthExcavated,DateExcavated,BurialDirection,BurialPreservation,BurialWrapping,BurialAdultChild,GenderCode,Burialgendermethod,AgeCodeSingle,Burialageatdeath,Burialagemethod,HairColorCode,Burialhaircolor,Burialsampletaken,LengthM,LengthCm,Goods,Clstr,FaceBundle,OsteologyNotes")] MasterBurial2 masterBurial2)
        {
            if (ModelState.IsValid)
            {
                _context.Add(masterBurial2);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(masterBurial2);
        }

        // GET: MasterBurial2/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var masterBurial2 = await _context.MasterBurial2.FindAsync(id);
            if (masterBurial2 == null)
            {
                return NotFound();
            }
            return View(masterBurial2);
        }

        // POST: MasterBurial2/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LocConcat,BurialId,BurialLocationNs,LowPairNs,HighPairNs,BurialLocationEw,LowPairEw,HighPairEw,BurialSubplot,BurialNumber,BurialDepth,SouthToHead,SouthToFeet,WestToHead,WestToFeet,LengthOfRemains,BurialSituation,SampleNumber,GenderGe,GeFunctionTotal,GenderBodyCol,BasilarSuture,VentralArc,SubpubicAngle,SciaticNotch,PubicBone,PreaurSulcus,MedialIpRamus,DorsalPitting,ForemanMagnum,FemurHead,HumerusHead,Osteophytosis,PubicSymphysis,BoneLength,MedialClavicle,IliacCrest,FemurDiameter,Humerus,FemurLength,HumerusLength,TibiaLength,Robust,SupraorbitalRidges,OrbitEdge,ParietalBossing,Gonian,NuchalCrest,ZygomaticCrest,CranialSuture,MaximumCranialLength,MaximumCranialBreadth,BasionBregmaHeight,BasionNasion,BasionProsthionLength,BizygomaticDiameter,NasionProsthion,MaximumNasalBreadth,InterorbitalBreadth,ArtifactsDescription,HairColor,PreservationIndex,HairTakenTf,SoftTissueTakenTf,BoneTakenTf,ToothTakenTf,TextileTakenTf,ArtifactFoundTf,DescriptionOfTaken,EstimateAge,EstimateLivingStature,ToothAttrition,ToothEruption,PathologyAnomalies,EpiphysealUnion,YearFound,MonthFound,DayFound,HeadDirection,Preservation,Burialicon,Burialicon2,Sex,Sexmethod,Ageatdeath,Agemethod,Haircolor1,Sample,YearOnSkull,MonthOnSkull,DateOnSkull,FieldBook,FieldBookPageNumber,InitialsOfDataEntryExpert,InitialsOfDataEntryChecker,ByuSample,BodyAnalysis,SkullAtMagazine,PostcraniaAtMagazine,SexSkull,AgeSkull,RackAndShelf,ToBeConfirmed,SkullTrauma,PostcraniaTrauma,CribraOrbitala,PoroticHyperostosis,PoroticHyperostosisLocations,MetopicSuture,ButtonOsteoma,OsteologyUnknownComment,TemporalMandibularJointOsteoarthritisTmjOa,LinearHypoplasiaEnamel,AreaHillBurials,Tomb,BurialSubNumber,YearExcav,MonthExcavated,DateExcavated,BurialDirection,BurialPreservation,BurialWrapping,BurialAdultChild,GenderCode,Burialgendermethod,AgeCodeSingle,Burialageatdeath,Burialagemethod,HairColorCode,Burialhaircolor,Burialsampletaken,LengthM,LengthCm,Goods,Clstr,FaceBundle,OsteologyNotes")] MasterBurial2 masterBurial2)
        {
            if (id != masterBurial2.BurialId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(masterBurial2);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MasterBurial2Exists(masterBurial2.BurialId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(masterBurial2);
        }

        // GET: MasterBurial2/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var masterBurial2 = await _context.MasterBurial2
                .FirstOrDefaultAsync(m => m.BurialId == id);
            if (masterBurial2 == null)
            {
                return NotFound();
            }

            return View(masterBurial2);
        }

        // POST: MasterBurial2/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var masterBurial2 = await _context.MasterBurial2.FindAsync(id);
            _context.MasterBurial2.Remove(masterBurial2);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MasterBurial2Exists(int id)
        {
            return _context.MasterBurial2.Any(e => e.BurialId == id);
        }
    }
}
