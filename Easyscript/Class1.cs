using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V_MP.Server.API;
using V_MP_Server;
using System.Timers;
using MySql.Data.MySqlClient;

namespace Gamemode
{
    public class Gamemode: APIScript
    {
        #region links
        // http://royal-rp.net/scripts/vehicles/
        // http://royal-rp.net/scripts/skins/
        // http://gtavmp.org/wiki/index.php?title=API_ru
        // http://www.dev-c.com/nativedb/
        // http://gtavmp.org/forums/index.php
        #endregion

        #region Arrays

        #region Vehicle list
        VehicleHash[] vehicles = new VehicleHash[] { VehicleHash.CarbonRS, VehicleHash.Hotknife, VehicleHash.TipTruck, VehicleHash.Faggio2, VehicleHash.Youga, VehicleHash.Glendale,
  VehicleHash.Dominator, VehicleHash.Kalahari, VehicleHash.Coquette, VehicleHash.BType, VehicleHash.Boxville3, VehicleHash.Baller2,
  VehicleHash.Miljet, VehicleHash.FreightCar, VehicleHash.Speeder, VehicleHash.Buffalo3, VehicleHash.FreightCont2, VehicleHash.Dinghy2,
  VehicleHash.Tropic, VehicleHash.GBurrito2, VehicleHash.Hexer, VehicleHash.Crusader, VehicleHash.CogCabrio, VehicleHash.Vacca,
  VehicleHash.Gauntlet2, VehicleHash.Chino, VehicleHash.Polmav, VehicleHash.PropTrailer, VehicleHash.CargoPlane, VehicleHash.Surano,
  VehicleHash.RakeTrailer, VehicleHash.Squalo, VehicleHash.Turismor, VehicleHash.Kuruma2, VehicleHash.Infernus, VehicleHash.Boxville4,
  VehicleHash.Handler, VehicleHash.Cruiser, VehicleHash.PoliceT, VehicleHash.Tornado, VehicleHash.Lguard, VehicleHash.Mixer2,
  VehicleHash.Huntley, VehicleHash.Fusilade, VehicleHash.Dinghy3, VehicleHash.UtilityTruck, VehicleHash.UtilliTruck, VehicleHash.Voodoo2,
  VehicleHash.BoatTrailer, VehicleHash.Dune2, VehicleHash.Khamelion, VehicleHash.Packer, VehicleHash.TankerCar, VehicleHash.Luxor,
  VehicleHash.Romero, VehicleHash.Barracks3, VehicleHash.Lectro, VehicleHash.FreightGrain, VehicleHash.Surfer, VehicleHash.TrailerSmall,
  VehicleHash.Dukes, VehicleHash.Speedo2, VehicleHash.SlamVan, VehicleHash.Sadler2, VehicleHash.Buffalo2, VehicleHash.Pranger,
  VehicleHash.Sovereign, VehicleHash.Frogger, VehicleHash.Buzzard2, VehicleHash.Ztype, VehicleHash.Alpha, VehicleHash.Submersible,
  VehicleHash.Rhino, VehicleHash.Coquette3, VehicleHash.Sanchez, VehicleHash.Buzzard, VehicleHash.SlamVan2, VehicleHash.Annihilator,
  VehicleHash.Rhapsody, VehicleHash.BJXL, VehicleHash.Biff, VehicleHash.Jetmax, VehicleHash.Sentinel2, VehicleHash.Habanero,
  VehicleHash.Intruder, VehicleHash.UtilityTruck2, VehicleHash.UtilliTruck2, VehicleHash.Burrito4, VehicleHash.Mule, VehicleHash.Mesa,
  VehicleHash.FreightCont1, VehicleHash.Casco, VehicleHash.Pony2, VehicleHash.Duster, VehicleHash.Hydra, VehicleHash.Sultan,
  VehicleHash.Sandking2, VehicleHash.Coquette2, VehicleHash.GrainTrailer, VehicleHash.Freight, VehicleHash.Ninef, VehicleHash.Dinghy,
  VehicleHash.Blista2, VehicleHash.Skylift, VehicleHash.JB700, VehicleHash.Jet, VehicleHash.BobcatXL, VehicleHash.Toro,
  VehicleHash.Barracks2, VehicleHash.Swift2, VehicleHash.Velum2, VehicleHash.Pigalle, VehicleHash.Superd, VehicleHash.BfInjection,
  VehicleHash.FBI, VehicleHash.TriBike, VehicleHash.Bmx, VehicleHash.Burrito5, VehicleHash.Caddy, VehicleHash.Rumpo,
  VehicleHash.Ambulance, VehicleHash.Dubsta, VehicleHash.Seminole, VehicleHash.Marshall, VehicleHash.Hakuchou, VehicleHash.Landstalker,
  VehicleHash.Airbus, VehicleHash.Serrano, VehicleHash.Vestra, VehicleHash.Oracle, VehicleHash.Sentinel, VehicleHash.Flatbed,
  VehicleHash.Warrener, VehicleHash.Cargobob3, VehicleHash.Tractor3, VehicleHash.Paradise, VehicleHash.Forklift, VehicleHash.Picador,
  VehicleHash.Hauler, VehicleHash.Tornado2, VehicleHash.Stinger, VehicleHash.Airtug, VehicleHash.Windsor, VehicleHash.Cargobob2,
  VehicleHash.Tractor, VehicleHash.RancherXL, VehicleHash.T20, VehicleHash.Akuma, VehicleHash.Dilettante2, VehicleHash.Stratum,
  VehicleHash.RapidGT2, VehicleHash.Bison3, VehicleHash.Stockade, VehicleHash.Enduro, VehicleHash.Tornado3, VehicleHash.DLoader,
  VehicleHash.Washington, VehicleHash.Mower, VehicleHash.TR3, VehicleHash.Besra, VehicleHash.Peyote, VehicleHash.Thrust,
  VehicleHash.Camper, VehicleHash.Bulldozer, VehicleHash.Fugitive, VehicleHash.Police3, VehicleHash.Trash, VehicleHash.Sheriff2,
  VehicleHash.Stalion, VehicleHash.RancherXL2, VehicleHash.FireTruck, VehicleHash.Tourbus, VehicleHash.Frogger2, VehicleHash.Taco,
  VehicleHash.Tanker2, VehicleHash.Titan, VehicleHash.Osiris, VehicleHash.Daemon, VehicleHash.Cavalcade, VehicleHash.TrailerLogs,
  VehicleHash.Futo, VehicleHash.Police, VehicleHash.Benson, VehicleHash.Insurgent2, VehicleHash.Bison2, VehicleHash.Carbonizzare,
  VehicleHash.TR2, VehicleHash.TR4, VehicleHash.Pounder, VehicleHash.UtilityTruck3, VehicleHash.UtilliTruck3, VehicleHash.Rocoto,
  VehicleHash.Bagger, VehicleHash.DockTrailer, VehicleHash.Phantom, VehicleHash.Dump, VehicleHash.Blazer, VehicleHash.Manana,
  VehicleHash.Stunt, VehicleHash.Guardian, VehicleHash.StingerGT, VehicleHash.Technical, VehicleHash.Phoenix, VehicleHash.Tractor2,
  VehicleHash.Coach, VehicleHash.Mesa3, VehicleHash.Trailers3, VehicleHash.Mule3, VehicleHash.Rebel2, VehicleHash.Tornado4,
  VehicleHash.PBus, VehicleHash.Feltzer2, VehicleHash.Boxville, VehicleHash.Police4, VehicleHash.Stretch, VehicleHash.RapidGT,
  VehicleHash.Asterope, VehicleHash.Surge, VehicleHash.Premier, VehicleHash.Emperor2, VehicleHash.Insurgent, VehicleHash.Asea,
  VehicleHash.Asea2, VehicleHash.Gauntlet, VehicleHash.PoliceOld2, VehicleHash.Rumpo2, VehicleHash.Granger, VehicleHash.TVTrailer,
  VehicleHash.Mammatus, VehicleHash.GBurrito, VehicleHash.Burrito3, VehicleHash.Rubble, VehicleHash.Scrap, VehicleHash.Bullet,
  VehicleHash.SabreGT, VehicleHash.Sheriff, VehicleHash.Velum, VehicleHash.Double, VehicleHash.Dune, VehicleHash.Maverick,
  VehicleHash.Radi, VehicleHash.FBI2, VehicleHash.ArmyTrailer2, VehicleHash.Police2, VehicleHash.Voltic, VehicleHash.Valkyrie,
  VehicleHash.Trailers2, VehicleHash.Feltzer3, VehicleHash.Gresley, VehicleHash.PoliceOld1, VehicleHash.Brawler, VehicleHash.Stanier,
  VehicleHash.ArmyTrailer, VehicleHash.Ninef2, VehicleHash.Sanchez2, VehicleHash.Prairie, VehicleHash.Bodhi2, VehicleHash.Zentorno,
  VehicleHash.Kuruma, VehicleHash.Vindicator, VehicleHash.TRFlat, VehicleHash.Burrito, VehicleHash.TowTruck, VehicleHash.Surfer2,
  VehicleHash.Cheetah, VehicleHash.Jester, VehicleHash.EntityXF, VehicleHash.Ingot, VehicleHash.Lazer, VehicleHash.Blazer3,
  VehicleHash.Trash2, VehicleHash.Schafter2, VehicleHash.Emperor3, VehicleHash.Dubsta3, VehicleHash.TriBike2, VehicleHash.Adder,
  VehicleHash.Shamal, VehicleHash.Luxor2, VehicleHash.Rebel, VehicleHash.ArmyTanker, VehicleHash.Blade, VehicleHash.Riot,
  VehicleHash.Zion2, VehicleHash.Sandking, VehicleHash.Issi2, VehicleHash.Primo, VehicleHash.Fq2, VehicleHash.Dilettante,
  VehicleHash.Zion, VehicleHash.Jester2, VehicleHash.RentalBus, VehicleHash.Furoregt, VehicleHash.Submersible2, VehicleHash.Mule2,
  VehicleHash.Comet2, VehicleHash.Marquis, VehicleHash.Banshee, VehicleHash.Seashark, VehicleHash.Tailgater, VehicleHash.Cutter,
  VehicleHash.CableCar, VehicleHash.Taxi, VehicleHash.TipTruck2, VehicleHash.Dominator2, VehicleHash.PCJ, VehicleHash.Burrito2,
  VehicleHash.Dodo, VehicleHash.Ruffian, VehicleHash.Bati2, VehicleHash.Docktug, VehicleHash.Trailers, VehicleHash.Ripley,
  VehicleHash.Monster, VehicleHash.Fixter, VehicleHash.Vigero, VehicleHash.Barracks, VehicleHash.Speedo, VehicleHash.Baller,
  VehicleHash.Patriot, VehicleHash.Cavalcade2, VehicleHash.Mixer, VehicleHash.FreightTrailer, VehicleHash.Mesa2, VehicleHash.Schwarzer,
  VehicleHash.Tanker, VehicleHash.Bus, VehicleHash.Emperor, VehicleHash.Buccaneer, VehicleHash.RatLoader, VehicleHash.Cuban800,
  VehicleHash.Nemesis, VehicleHash.Massacro2, VehicleHash.Jackal, VehicleHash.Seashark2, VehicleHash.Blimp2, VehicleHash.Sadler,
  VehicleHash.Blista3, VehicleHash.F620, VehicleHash.RatLoader2, VehicleHash.Elegy2, VehicleHash.Caddy2, VehicleHash.Oracle2,
  VehicleHash.Virgo, VehicleHash.Predator, VehicleHash.TowTruck2, VehicleHash.Monroe, VehicleHash.Panto, VehicleHash.Stalion2,
  VehicleHash.TriBike3, VehicleHash.BaleTrailer, VehicleHash.Dubsta2, VehicleHash.Felon, VehicleHash.Penumbra, VehicleHash.Bifta,
  VehicleHash.Blista, VehicleHash.Swift, VehicleHash.Dukes2, VehicleHash.Minivan, VehicleHash.Buffalo, VehicleHash.Suntrap,
  VehicleHash.Boxville2, VehicleHash.Ruiner, VehicleHash.Stockade3, VehicleHash.Scorcher, VehicleHash.Innovation, VehicleHash.Blimp,
  VehicleHash.Massacro, VehicleHash.Vader, VehicleHash.Journey, VehicleHash.Pony, VehicleHash.Bati, VehicleHash.Felon2,
  VehicleHash.Savage, VehicleHash.Cargobob, VehicleHash.Blazer2, VehicleHash.Policeb, VehicleHash.Bison, VehicleHash.Regina,
  VehicleHash.Exemplar,  };
        #endregion
        #region Skin List
        PedHash[] skins = new PedHash[] { PedHash.Skidrow01AMM, PedHash.Hooker01SFY, PedHash.Hooker03SFY, PedHash.JimmyBostonCutscene, PedHash.SalvaGoon03GMY, PedHash.Autoshop01SMM,
                                            PedHash.Eastsa02AFY, PedHash.Car3Guy1Cutscene, PedHash.Clown01SMY, PedHash.TracyDisantoCutscene, PedHash.FloydCutscene, PedHash.Pigeon,
                                            PedHash.TigerShark, PedHash.Genfat01AMM, PedHash.AnitaCutscene, PedHash.Eastsa02AMM, PedHash.Indian01AFY, PedHash.MaryannCutscene,
                                            PedHash.Westy, PedHash.Zimbor, PedHash.Baywatch01SMY, PedHash.PestContGunman, PedHash.Socenlat01AMM, PedHash.DaleCutscene,
                                            PedHash.Janet, PedHash.Michael, PedHash.Tanisha, PedHash.Corpse02, PedHash.StrPunk02GMY, PedHash.AmmuCountrySMM,
                                            PedHash.Soucent03AMO, PedHash.Jewelass, PedHash.GuadalopeCutscene, PedHash.Chef01SMY, PedHash.ChiCold01GMM, PedHash.MountainLion,
                                            PedHash.Latino01AMY, PedHash.Car3Guy2Cutscene, PedHash.Genfat02AMM, PedHash.Fitness02AFY, PedHash.Hippie01AFY, PedHash.Hooker02SFY,
                                            PedHash.Hipster02AMY, PedHash.Dockwork01SMM, PedHash.Chop, PedHash.Ktown01AMO, PedHash.Ballas01GFY, PedHash.DaveNorton,
                                            PedHash.Cop01SFY, PedHash.FemBarberSFM, PedHash.Eastsa02AMY, PedHash.PrologueHostage01AFM, PedHash.Tramp01AMO, PedHash.Crow,
                                            PedHash.GentransportSMM, PedHash.Marnie, PedHash.ShopKeep01, PedHash.Hipster04AFY, PedHash.Vinewood01AFY, PedHash.Cntrybar01SMM,
                                            PedHash.Snowcop01SMM, PedHash.Ktown01AMY, PedHash.FosRepCutscene, PedHash.Strpreach01SMM, PedHash.Markfost, PedHash.MrsThornhill,
                                            PedHash.PrologueSec02Cutscene, PedHash.Tramp01AMM, PedHash.OldMan1aCutscene, PedHash.Business02AFM, PedHash.Vinewood03AMY, PedHash.Salton01AMO,
                                            PedHash.Bevhills03AFY, PedHash.RampHipsterCutscene, PedHash.Doorman01SMY, PedHash.MovPrem01SFY, PedHash.Hipster01AMY, PedHash.BallaOrig01GMY,
                                            PedHash.BallaSout01GMY, PedHash.Beach02AMY, PedHash.Poppymich, PedHash.Stwhi01AMY, PedHash.Chip, PedHash.Korean01GMY,
                                            PedHash.Runner01AMY, PedHash.Ortega, PedHash.AshleyCutscene, PedHash.MexGoon01GMY, PedHash.FibOffice02SMM, PedHash.SalvaGoon01GMY,
                                            PedHash.Business01AFY, PedHash.PrologueSec02, PedHash.Lifeinvad02, PedHash.CrisFormage, PedHash.Highsec02SMM, PedHash.StripperLite,
                                            PedHash.Ktown02AMY, PedHash.Indian01AMY, PedHash.Soucent01AMO, PedHash.FilmDirector, PedHash.Soucent01AFY, PedHash.Cyclist01,
                                            PedHash.Downtown01AMY, PedHash.Jetski01AMY, PedHash.ONeil, PedHash.Corpse01, PedHash.ReporterCutscene, PedHash.ChemSec01SMM,
                                            PedHash.DevinCutscene, PedHash.Genhot01AFY, PedHash.PornDudesCutscene, PedHash.Barry, PedHash.Fish, PedHash.Malibu01AMM,
                                            PedHash.JanetCutscene, PedHash.Beach01AFM, PedHash.MexThug01AMY, PedHash.Hiker01AFY, PedHash.Grip01SMY, PedHash.WeiChengCutscene,
                                            PedHash.Sweatshop01SFM, PedHash.Business02AFY, PedHash.MexGoon02GMY, PedHash.Vinewood04AMY, PedHash.SalvaGoon02GMY, PedHash.Lost03GMY,
                                            PedHash.Famdd01, PedHash.FibArchitect, PedHash.Imporage, PedHash.Retriever, PedHash.Genstreet02AMY, PedHash.KorBoss01GMM,
                                            PedHash.MovieStar, PedHash.Stretch, PedHash.Stwhi02AMY, PedHash.Bevhills04AFY, PedHash.Party01, PedHash.Vinewood03AFY,
                                            PedHash.Breakdance01AMY, PedHash.SteveHains, PedHash.Marston01, PedHash.MrsPhillips, PedHash.LazlowCutscene, PedHash.FatWhite01AFM,
                                            PedHash.TerryCutscene, PedHash.FbiSuit01, PedHash.PestContDriver, PedHash.Valet01SMY, PedHash.Rurmeth01AMM, PedHash.Bodybuild01AFM,
                                            PedHash.Maude, PedHash.RsRanger01AMO, PedHash.DreyfussCutscene, PedHash.HammerShark, PedHash.MimeSMY, PedHash.RussianDrunk,
                                            PedHash.Lost02GMY, PedHash.Soucent01AFO, PedHash.ShopMidSFY, PedHash.Rurmeth01AFY, PedHash.Bevhills02AMM, PedHash.Abigail,
                                            PedHash.Beach01AMM, PedHash.Soucent02AMO, PedHash.Ktown02AFM, PedHash.Scientist01SMM, PedHash.Stingray, PedHash.Miranda,
                                            PedHash.Sheriff01SFY, PedHash.Factory01SMY, PedHash.Hairdress01SMM, PedHash.TanishaCutscene, PedHash.Poodle, PedHash.Shepherd,
                                            PedHash.MartinMadrazoCutscene, PedHash.Xmech01SMY, PedHash.JewelassCutscene, PedHash.Bevhills01AFY, PedHash.JoshCutscene, PedHash.ExArmy01,
                                            PedHash.LamarDavisCutscene, PedHash.RampHic, PedHash.Fitness01AFY, PedHash.MollyCutscene, PedHash.JosefCutscene, PedHash.Glenstank01,
                                            PedHash.RussianDrunkCutscene, PedHash.Dale, PedHash.Finguru01, PedHash.FabienCutscene, PedHash.MilitaryBum, PedHash.Humpback,
                                            PedHash.DomCutscene, PedHash.Ktown01AFO, PedHash.Andreas, PedHash.PestCont01SMY, PedHash.Tramp01AFM, PedHash.MexBoss02GMM,
                                            PedHash.Gardener01SMM, PedHash.Chef, PedHash.Baywatch01SFY, PedHash.Vinewood01AMY, PedHash.Musclbeac01AMY, PedHash.Acult02AMO,
                                            PedHash.MoviePremFemaleCutscene, PedHash.SiemonYetarian, PedHash.PriestCutscene, PedHash.LesterCrest, PedHash.Families01GFY, PedHash.Hipster03AMY,
                                            PedHash.Husky, PedHash.NataliaCutscene, PedHash.Salton01AMM, PedHash.PoloGoon01GMY, PedHash.Lost01GMY, PedHash.MrsThornhillCutscene,
                                            PedHash.Paparazzi, PedHash.Tourist01AFM, PedHash.Hiker01AMY, PedHash.Eastsa03AFY, PedHash.Baygor, PedHash.Stripper01SFY,
                                            PedHash.TylerDixon, PedHash.Ktown01AFM, PedHash.TaosTranslatorCutscene, PedHash.Lifeinvad01, PedHash.TrampBeac01AMM, PedHash.Acult01AMM,
                                            PedHash.Tennis01AMM, PedHash.Bevhills01AMM, PedHash.Tennis01AFY, PedHash.WinClean01SMY, PedHash.Acult01AMO, PedHash.Tourist01AFY,
                                            PedHash.Prisguard01SMM, PedHash.Cormorant, PedHash.JimmyDisanto, PedHash.TrafficWarden, PedHash.Cat, PedHash.Bestmen,
                                            PedHash.MarnieCutscene, PedHash.MexBoss01GMM, PedHash.MagentaCutscene, PedHash.FbiSuit01Cutscene, PedHash.Marine02SMY, PedHash.Trucker01SMM,
                                            PedHash.Soucent02AFY, PedHash.Vagos01GFY, PedHash.KerryMcintosh, PedHash.HunterCutscene, PedHash.SpyActress, PedHash.StripperLiteSFY,
                                            PedHash.TennisCoachCutscene, PedHash.Bevhills02AFY, PedHash.FibSec01, PedHash.Vinewood02AMY, PedHash.Airhostess01SFY, PedHash.Mistress,
                                            PedHash.Cop01SMY, PedHash.PrisMuscl01SMY, PedHash.RivalPaparazzi, PedHash.Omega, PedHash.Salton02AMM, PedHash.MerryWeatherCutscene,
                                            PedHash.Bride, PedHash.RampMarineCutscene, PedHash.Genstreet01AFO, PedHash.Fatlatin01AMM, PedHash.Orleans, PedHash.AirworkerSMY,
                                            PedHash.Postal01SMM, PedHash.CiaSec01SMM, PedHash.Armymech01SMY, PedHash.TonyaCutscene, PedHash.Armoured02SMM, PedHash.Eastsa02AFM,
                                            PedHash.Priest, PedHash.Coyote, PedHash.MovAlien01, PedHash.Motox01AMY, PedHash.Downtown01AFM, PedHash.Marine01SMY,
                                            PedHash.Hao, PedHash.LamarDavis, PedHash.Bevhills02AMY, PedHash.Terry, PedHash.OgBoss01AMM, PedHash.Soucent01AMM,
                                            PedHash.Azteca01GMY, PedHash.Epsilon01AFY, PedHash.BarryCutscene, PedHash.Skater01AFY, PedHash.Methhead01AMY, PedHash.TomCutscene,
                                            PedHash.Factory01SFY, PedHash.Tramp01, PedHash.SbikeAMO, PedHash.Hen, PedHash.PaperCutscene, PedHash.Hasjew01AMM,
                                            PedHash.Hillbilly01AMM, PedHash.MPros01, PedHash.Clay, PedHash.AmandaTownley, PedHash.Pug, PedHash.Stripper02SFY,
                                            PedHash.ShopMaskSMY, PedHash.HughCutscene, PedHash.DeniseCutscene, PedHash.FreemodeMale01, PedHash.PrologueSec01, PedHash.MichelleCutscene,
                                            PedHash.OldMan1a, PedHash.BradCadaverCutscene, PedHash.Lifeinvad01Cutscene, PedHash.Marine03SMY, PedHash.Postal02SMM, PedHash.Hwaycop01SMY,
                                            PedHash.DeadHooker, PedHash.Soucent01AFM, PedHash.Devin, PedHash.Car3Guy2, PedHash.DwService01SMY, PedHash.Bevhills01AMY,
                                            PedHash.BikeHire01, PedHash.Lsmetro01SMM, PedHash.Motox02AMY, PedHash.Epsilon01AMY, PedHash.Bartender01SFY, PedHash.Beach02AMM,
                                            PedHash.NervousRonCutscene, PedHash.Strperf01SMM, PedHash.Josh, PedHash.Blackops02SMY, PedHash.JayNorris, PedHash.GroomCutscene,
                                            PedHash.Hillbilly02AMM, PedHash.Prisoner01, PedHash.TaosTranslator, PedHash.KorLieut01GMY, PedHash.Hippy01AMY, PedHash.Justin,
                                            PedHash.Golfer01AFY, PedHash.Beachvesp01AMY, PedHash.ChiGoon01GMM, PedHash.Business01AMM, PedHash.Mariachi01SMM, PedHash.Ashley,
                                            PedHash.PrologueSec01Cutscene, PedHash.Acult02AMY, PedHash.Stripper02Cutscene, PedHash.PartyTarget, PedHash.Denise, PedHash.Hipster01AFY,
                                            PedHash.BrideCutscene, PedHash.Polynesian01AMY, PedHash.Beach01AMO, PedHash.Famfor01GMY, PedHash.Runner02AMY, PedHash.Car3Guy1,
                                            PedHash.Sweatshop01SFY, PedHash.PrologueDriver, PedHash.DaveNortonCutscene, PedHash.RampHicCutscene, PedHash.FibMugger01, PedHash.Stlat01AMY,
                                            PedHash.Dockwork01SMY, PedHash.Solomon, PedHash.Soucent03AFY, PedHash.JohnnyKlebitz, PedHash.TaoChengCutscene, PedHash.StretchCutscene,
                                            PedHash.AbigailCutscene, PedHash.Soucent04AMY, PedHash.OmegaCutscene, PedHash.BurgerDrug, PedHash.Dolphin, PedHash.Soucent03AMM,
                                            PedHash.ScreenWriterCutscene, PedHash.TomEpsilonCutscene, PedHash.TrampBeac01AFM, PedHash.CarBuyerCutscene, PedHash.BurgerDrugCutscene, PedHash.MoviePremMaleCutscene,
                                            PedHash.KillerWhale, PedHash.Swat01SMY, PedHash.Korean02GMY, PedHash.SalvaBoss01GMY, PedHash.WillyFist, PedHash.Bankman,
                                            PedHash.Tourist02AFY, PedHash.Staggrm01AMO, PedHash.Juggalo01AMY, PedHash.Strvend01SMY, PedHash.Wade, PedHash.Farmer01AMM,
                                            PedHash.Tattoo01AMO, PedHash.Rottweiler, PedHash.Armoured01SMM, PedHash.AmandaTownleyCutscene, PedHash.Salton04AMM, PedHash.MexGoon03GMY,
                                            PedHash.Hotposh01, PedHash.PrologueHostage01AMM, PedHash.BankmanCutscene, PedHash.Hipster02AFY, PedHash.Genstreet01AMY, PedHash.Stbla02AMY,
                                            PedHash.OldMan2Cutscene, PedHash.Paper, PedHash.Hacker, PedHash.Taphillbilly, PedHash.CopCutscene, PedHash.Busicas01AMY,
                                            PedHash.Franklin, PedHash.Devinsec01SMY, PedHash.Trevor, PedHash.Dom, PedHash.FreemodeFemale01, PedHash.Topless01AFY,
                                            PedHash.Claypain, PedHash.Eastsa01AFM, PedHash.Ammucity01SMY, PedHash.Lathandy01SMM, PedHash.Soucent02AMM, PedHash.Ups01SMM,
                                            PedHash.Ranger01SFY, PedHash.Bouncer01SMM, PedHash.Bevhills02AFM, PedHash.Business03AMY, PedHash.PrologueMournFemale01, PedHash.TennisCoach,
                                            PedHash.GCutscene, PedHash.PoloGoon02GMY, PedHash.ChefCutscene, PedHash.MaryAnn, PedHash.DrFriedlanderCutscene, PedHash.Eastsa01AMY,
                                            PedHash.CustomerCutscene, PedHash.SteveHainsCutscene, PedHash.Soucent02AFO, PedHash.Gay02AMY, PedHash.Hipster03AFY, PedHash.AntonCutscene,
                                            PedHash.Ballasog, PedHash.Chimp, PedHash.ChinGoonCutscene, PedHash.Gaffer01SMM, PedHash.JanitorSMM, PedHash.ShopLowSFY,
                                            PedHash.Polynesian01AMM, PedHash.Golfer01AMM, PedHash.RoccoPelosiCutscene, PedHash.Epsilon02AMY, PedHash.ChickenHawk, PedHash.WeiCheng,
                                            PedHash.Yoga01AMY, PedHash.Pilot01SMY, PedHash.Scrubs01SFY, PedHash.BallasogCutscene, PedHash.SpyActor, PedHash.Zombie01,
                                            PedHash.Soucent02AMY, PedHash.JewelSec01, PedHash.OrleansCutscene, PedHash.Waiter01SMY, PedHash.Genstreet01AMO, PedHash.Busker01SMO,
                                            PedHash.ShopHighSFM, PedHash.Business03AFY, PedHash.Stripper01Cutscene, PedHash.Molly, PedHash.Skater02AMY, PedHash.Skidrow01AFM,
                                            PedHash.Pig, PedHash.Sheriff01SMY, PedHash.Floyd, PedHash.Prisoner01SMY, PedHash.Autopsy01SMY, PedHash.MexLabor01AMM,
                                            PedHash.Salton03AMM, PedHash.GunVend01, PedHash.Paramedic01SMM, PedHash.Business02AMY, PedHash.Blackops01SMY, PedHash.BeverlyCutscene,
                                            PedHash.Acult01AMY, PedHash.DeniseFriendCutscene, PedHash.LesterCrestCutscene, PedHash.FatCult01AFM, PedHash.ComJane, PedHash.Fireman01SMY,
                                            PedHash.Sunbathe01AMY, PedHash.MiltonCutscene, PedHash.Business04AFY, PedHash.JimmyDisantoCutscene, PedHash.ChiBoss01GMM, PedHash.Indian01AFO,
                                            PedHash.MaudeCutscene, PedHash.NervousRon, PedHash.Beverly, PedHash.Brad, PedHash.MexGang01GMY, PedHash.Bevhills01AFM,
                                            PedHash.JoeMinuteman, PedHash.Xmech02SMY, PedHash.Michelle, PedHash.Robber01SMY, PedHash.SiemonYetarianCutscene, PedHash.OrtegaCutscene,
                                            PedHash.Claude01, PedHash.Vindouche01AMY, PedHash.Skater01AMY, PedHash.CrisFormageCutscene, PedHash.JanitorCutscene, PedHash.RampGangCutscene,
                                            PedHash.Stlat02AMM, PedHash.Rhesus, PedHash.Soucent04AMM, PedHash.Bankman01, PedHash.GurkCutscene, PedHash.Rat,
                                            PedHash.MrKCutscene, PedHash.Soucent03AMY, PedHash.Yoga01AFY, PedHash.Griff01, PedHash.PrologueHostage01, PedHash.ArmGoon02GMY,
                                            PedHash.Patricia, PedHash.Construct02SMY, PedHash.Guido01, PedHash.Runner01AFY, PedHash.Beach01AFY, PedHash.Tourist01AMM,
                                            PedHash.Nigel, PedHash.Mani, PedHash.Musclbeac02AMY, PedHash.Business01AMY, PedHash.Uscg01SMY, PedHash.Beachvesp02AMY,
                                            PedHash.Tonya, PedHash.CletusCutscene, PedHash.Milton, PedHash.DrFriedlander, PedHash.MrsPhillipsCutscene, PedHash.Salton01AFO,
                                            PedHash.TomEpsilon, PedHash.Soucentmc01AFM, PedHash.Armoured01, PedHash.Hunter, PedHash.Jesus01, PedHash.Boar,
                                            PedHash.Strvend01SMM, PedHash.PrologueMournMale01, PedHash.Antonb, PedHash.Stbla01AMY, PedHash.Fabien, PedHash.Ups02SMM,
                                            PedHash.Misty01, PedHash.Ktown01AMM, PedHash.AfriAmer01AMM, PedHash.Gay01AMY, PedHash.Beach01AMY, PedHash.WadeCutscene,
                                            PedHash.Princess, PedHash.Seagull, PedHash.Doctor01SMM, PedHash.Migrant01SFY, PedHash.RoccoPelosi, PedHash.Golfer01AMY,
                                            PedHash.Salton01AMY, PedHash.Security01SMM, PedHash.Construct01SMY, PedHash.Movprem01SMM, PedHash.Deer, PedHash.Busboy01SMY,
                                            PedHash.Skater01AMM, PedHash.Babyd, PedHash.Dreyfuss, PedHash.Vinewood02AFY, PedHash.Juggalo01AFY, PedHash.Scdressy01AFY,
                                            PedHash.Famdnf01GMY, PedHash.LinecookSMM, PedHash.ClayCutscene, PedHash.Pogo01, PedHash.TaoCheng, PedHash.MexCntry01AMM,
                                            PedHash.Indian01AMM, PedHash.Lifeinvad01SMM, PedHash.Salton01AFM, PedHash.Natalia, PedHash.TrafficWardenCutscene, PedHash.TracyDisanto,
                                            PedHash.RampHipster, PedHash.PatriciaCutscene, PedHash.Rabbit, PedHash.Lazlow, PedHash.Maid01SFM, PedHash.Tranvest01AMM,
                                            PedHash.Casey, PedHash.Josef, PedHash.NigelCutscene, PedHash.Hasjew01AMY, PedHash.ImranCutscene, PedHash.Dealer01SMY,
                                            PedHash.RampGang, PedHash.Barman01SMY, PedHash.Cletus, PedHash.RampMex, PedHash.JewelThief, PedHash.Soucent01AMY,
                                            PedHash.AndreasCutscene, PedHash.Pilot01SMM, PedHash.ArmLieut01GMM, PedHash.Talina, PedHash.Beach03AMY, PedHash.Movspace01SMM,
                                            PedHash.Famca01GMY, PedHash.GroveStrDlrCutscene, PedHash.CaseyCutscene, PedHash.ZimborCutscene, PedHash.Surfer01AMY, PedHash.HaoCutscene,
                                            PedHash.Paparazzi01AMM, PedHash.DebraCutscene, PedHash.Migrant01SMM, PedHash.JimmyBoston, PedHash.FibOffice01SMM, PedHash.MrK,
                                            PedHash.GarbageSMY, PedHash.Niko01, PedHash.OldMan2, PedHash.Ranger01SMY, PedHash.BradCutscene, PedHash.PrologueDriverCutscene,
                                            PedHash.Marine02SMM, PedHash.Hippie01, PedHash.Autoshop02SMM, PedHash.JoeMinutemanCutscene, PedHash.Abner, PedHash.Jewelass01,
                                            PedHash.AlDiNapoli, PedHash.Highsec01SMM, PedHash.ArmBoss01GMM, PedHash.Marine01SMM, PedHash.Soucent02AFM, PedHash.OscarCutscene,
                                            PedHash.BallaEast01GMY, PedHash.Roadcyc01AMY, PedHash.DwService02SMY, PedHash.Eastsa01AFY, PedHash.ChemWork01GMM, PedHash.Pilot02SMM,
                                            PedHash.RampMexCutscene, PedHash.SolomonCutscene, PedHash.Tranvest02AMM, PedHash.Eastsa01AMM, PedHash.BikerChic, PedHash.JohnnyKlebitzCutscene,
                                            PedHash.FatBla01AFM, PedHash.Vinewood04AFY, PedHash.ManuelCutscene, PedHash.Magenta, PedHash.Cow, PedHash.StrPunk01GMY,
                                            PedHash.Manuel, PedHash.Lost01GFY, PedHash.ArmGoon01GMM, PedHash.Cyclist01AMY, PedHash.Groom, PedHash.Dhill01AMY,
                                            PedHash.ChiGoon02GMM, PedHash.ScreenWriter };
        #endregion

        #endregion

    


   
            public string Nick { get; set; }
            public bool Logged { get; set; }
            public string pPass { get; set; }
            public byte Exp { get; set; }
            public int pCash { get; set; }
            public int pBank { get; set; }
            public string Fraction { get; set; }
            public byte Rank { get; set; }
            public byte WantedLevel { get; set; }



        #region Uints
        #region MENU
        uint MENU_WELCOME = 1;
        uint MENU_CHOOSE_FRACTION = 2;
        uint MENU_CHOOSE_FRACTION_SKIN_COPS = 3;
        uint MENU_CHOOSE_FRACTION_SKIN_GANGS = 4;
        #endregion
        #endregion
        public override void Start()
        {
            string CommandText = "Наш SQL скрипт";
            string Connect = "Database=localhost;Data Source=ХОСТ;User Id=ПОЛЬЗОВАТЕЛЬ;Password=ПАРОЛЬ";
            //Переменная Connect - это строка подключения в которой:
            //БАЗА - Имя базы в MySQL
            //ХОСТ - Имя или IP-адрес сервера (если локально то можно и localhost)
            //ПОЛЬЗОВАТЕЛЬ - Имя пользователя MySQL
            //ПАРОЛЬ - говорит само за себя - пароль пользователя БД MySQL
            MySqlConnection myConnection = new MySqlConnection(Connect);
            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
            myConnection.Open(); //Устанавливаем соединение с базой данных.
                                 //Что то делаем...
            myConnection.Close(); //Обязательно закрываем соединение!


            Console.WriteLine("GAMEMOD KOTORIY SCRIPT LOADED");
            #region TIMERS
            #region GLOBAL_TIMER_1SEC
            Timer GLOBALTIMER = new Timer();
            GLOBALTIMER.Elapsed += new ElapsedEventHandler(GLOBAL_TIMER1SEC_CHECK);
            GLOBALTIMER.Interval = 1000; //Устанавливаем интервал в 1 сек.
            GLOBALTIMER.Enabled = true; //Вкючаем таймер.
            #endregion

            #region GLOBAL_TIMER1MIN
            Timer GLOBAL_TIMER1MIN = new Timer();
            GLOBAL_TIMER1MIN.Elapsed += new ElapsedEventHandler(GLOBAL_TIMER1MIN_CHECK);
            GLOBAL_TIMER1MIN.Interval = 60000; //Устанавливаем интервал в 1 сек.
            GLOBAL_TIMER1MIN.Enabled = true; //Вкючаем таймер.
            #endregion
            #endregion



        }

        public override void OnPlayerConnect(User player)
        {

            Nick = player.PlayerName;

            

            //NativeToPlayer(player, Hash.SET_PLAYER_CONTROL, false);
            NativeToPlayer(player, Hash.SET_MAX_WANTED_LEVEL, 0);            

            #region MENU_WELCOME
            CreateMenu(player, MENU_WELCOME, "Welcome", "Choose your fraction", 700, 300, "", "");
            AddMenuItem(player, MENU_WELCOME, "Choose Fraction", "Cops/Gangs");
            OpenMenu(player, MENU_WELCOME);           
            #endregion

            #region MENU_CHOOSE_FRACTION
            CreateMenu(player, MENU_CHOOSE_FRACTION, "Choose Fraction", "Cops/Gangs", 700, 300, "", "");
            AddMenuItem(player, MENU_CHOOSE_FRACTION, "Cops", "Press ENTER to choose this skin");
            AddMenuItem(player, MENU_CHOOSE_FRACTION, "Gangs", "Press ENTER to choose this skin");
            #endregion

            #region MENU_CHOOSE_FRACTION_SKIN_COPS
            CreateMenu(player, MENU_CHOOSE_FRACTION_SKIN_COPS, "Choose skin", "Cops skins", 700, 300, "", "");
            AddMenuItem(player, MENU_CHOOSE_FRACTION_SKIN_COPS, "Lady Cop", "Press ENTER to choose this skin");
            AddMenuItem(player, MENU_CHOOSE_FRACTION_SKIN_COPS, "Snow Cop", "Press ENTER to choose this skin");
            AddMenuItem(player, MENU_CHOOSE_FRACTION_SKIN_COPS, "Bald Cop", "Press ENTER to choose this skin");
            AddMenuItem(player, MENU_CHOOSE_FRACTION_SKIN_COPS, "Hway Cop", "Press ENTER to choose this skin");
            AddMenuItem(player, MENU_CHOOSE_FRACTION_SKIN_COPS, "Normal Cop", "Press ENTER to choose this skin");
            #endregion

            #region MENU_CHOOSE_FRACTION_SKIN_GANGS
            CreateMenu(player, MENU_CHOOSE_FRACTION_SKIN_GANGS, "Choose skin", "Gangs skins", 700, 300, "", "");
            AddMenuItem(player, MENU_CHOOSE_FRACTION_SKIN_GANGS, "Ballas 1", "Press ENTER to choose this skin");
            AddMenuItem(player, MENU_CHOOSE_FRACTION_SKIN_GANGS, "Ballas 2", "Press ENTER to choose this skin");
            AddMenuItem(player, MENU_CHOOSE_FRACTION_SKIN_GANGS, "Ballas 3", "Press ENTER to choose this skin");
            AddMenuItem(player, MENU_CHOOSE_FRACTION_SKIN_GANGS, "Ballas girl", "Press ENTER to choose this skin");
            #endregion
           
        }

        public override void OnPlayerDisconnect(User player)
        {
            
        }

        public override void OnChatCommand(User player, string command)
        {
            string[] cmd = command.Split(' ');
            if (cmd[0] == "/set")
            {
                if (cmd.Length == 2)
                {
                    switch (cmd[1])
                    {
                        case "frac":
                            OpenMenu(player, MENU_CHOOSE_FRACTION);
                            break;
                        case "skin":
                            OpenMenu(player, MENU_CHOOSE_FRACTION_SKIN_GANGS);                           
                            break;
                        default:
                            SendMessageToPlayer(player, "Use: /set [frac, skin]");
                            break;
                    }
                }else { SendMessageToPlayer(player, "Use: /set [frac, skin]");  }
            }
          

        }

        public override void OnMenuItemClick(User player, uint menuid, int selecteditemindex)
        {
            #region MENU_WELCOME
            if (menuid == MENU_WELCOME)
            {
                if (selecteditemindex == 0)
                {

                    OpenMenu(player, MENU_CHOOSE_FRACTION);
                    CloseMenu(player, MENU_WELCOME);
                }
            }
            #endregion

            #region MENU_CHOOSE_FRACTION
            if (menuid == MENU_CHOOSE_FRACTION)
            {
                if (selecteditemindex == 0)
                {

                    OpenMenu(player, MENU_CHOOSE_FRACTION_SKIN_COPS);
                    CloseMenu(player, MENU_CHOOSE_FRACTION);
                }
                if (selecteditemindex == 1)
                {

                    OpenMenu(player, MENU_CHOOSE_FRACTION_SKIN_GANGS);
                    CloseMenu(player, MENU_CHOOSE_FRACTION);
                }
            }
            #endregion

            #region MENU_CHOOSE_FRACTION_SKIN_COPS
            if (menuid == MENU_CHOOSE_FRACTION_SKIN_COPS)
            {
                if (selecteditemindex == 0)
                {
                    SetPlayerSkin(player, skins[48]);
                    CloseMenu(player, MENU_CHOOSE_FRACTION_SKIN_COPS);
                    Spawn(player);

                }
                if (selecteditemindex == 1)
                {
                    SetPlayerSkin(player, skins[60]);
                    CloseMenu(player, MENU_CHOOSE_FRACTION_SKIN_COPS);
                    Spawn(player);
                }
                if (selecteditemindex == 2)
                {
                    SetPlayerSkin(player, skins[258]);
                    CloseMenu(player, MENU_CHOOSE_FRACTION_SKIN_COPS);
                    Spawn(player);
                }
                if (selecteditemindex == 3)
                {
                    SetPlayerSkin(player, skins[317]);
                    CloseMenu(player, MENU_CHOOSE_FRACTION_SKIN_COPS);
                   Spawn(player);
                }
                if (selecteditemindex == 4)
                {
                    SetPlayerSkin(player, skins[412]);
                    CloseMenu(player, MENU_CHOOSE_FRACTION_SKIN_COPS);
                    Spawn(player);
                }
            }
            #endregion

            #region MENU_CHOOSE_FRACTION_SKIN_GANGS
            if (menuid == MENU_CHOOSE_FRACTION_SKIN_GANGS)
            {
                if (selecteditemindex == 0)
                {
                    SetPlayerSkin(player, skins[78]);
                    CloseMenu(player, MENU_CHOOSE_FRACTION_SKIN_GANGS);
                    Spawn(player);
                }
                if (selecteditemindex == 1)
                {
                    SetPlayerSkin(player, skins[444]);
                    CloseMenu(player, MENU_CHOOSE_FRACTION_SKIN_GANGS);
                    Spawn(player);
                }
                if (selecteditemindex == 2)
                {
                    SetPlayerSkin(player, skins[459]);
                    CloseMenu(player, MENU_CHOOSE_FRACTION_SKIN_GANGS);
                    Spawn(player);
                }
                if (selecteditemindex == 3)
                {
                    SetPlayerSkin(player, skins[46]);
                    CloseMenu(player, MENU_CHOOSE_FRACTION_SKIN_GANGS);
                    Spawn(player);
                }
            }
            #endregion
        }

        public void Spawn(User player)
        {
            GivePlayerWeapon(player, WeaponHash.AssaultShotgun, 10);
            GivePlayerWeapon(player, WeaponHash.Pistol50, 30);           
            NativeToPlayer(player, Hash.SET_PLAYER_CONTROL, true);
            return;       
        } 

    

        public void GLOBAL_TIMER1SEC_CHECK(object source, ElapsedEventArgs e)
        {

            ;

        }

        public void GLOBAL_TIMER1MIN_CHECK(object source, ElapsedEventArgs e)
        {

            ;
               
        }



    }

}
