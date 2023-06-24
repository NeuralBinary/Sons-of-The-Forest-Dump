using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Endnight.Types;
using Il2CppDummyDll;
using Sons.Construction.Branching;
using UnityEngine;
using UnityEngine.Serialization;

namespace Construction
{
	// Token: 0x0200002F RID: 47
	[Token(Token = "0x200002F")]
	[AddComponentMenu("Sons/Construction/ConstructionSystem")]
	public class ConstructionSystem : SingletonBehaviour<ConstructionSystem>
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060000FA RID: 250 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x060000FB RID: 251 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000001")]
		private static event ConstructionSystem.PlaceActionDelegate OnBeforePlaceActions
		{
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x2D636E0", Offset = "0x2D61CE0", VA = "0x182D636E0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x2D637F0", Offset = "0x2D61DF0", VA = "0x182D637F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060000FC RID: 252 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x060000FD RID: 253 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000002")]
		private static event ConstructionSystem.PlaceActionDelegate OnAfterPlaceActions
		{
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x2D63900", Offset = "0x2D61F00", VA = "0x182D63900")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x2D63A10", Offset = "0x2D62010", VA = "0x182D63A10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060000FE RID: 254 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x060000FF RID: 255 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000003")]
		private static event ConstructionSystem.PlaceActionDelegate OnPlaceActions
		{
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x2D63B20", Offset = "0x2D62120", VA = "0x182D63B20")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x2D63C30", Offset = "0x2D62230", VA = "0x182D63C30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000066")]
		private ConstructionSystem.GameModeModules ActiveGameMode
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x2D63D40", Offset = "0x2D62340", VA = "0x182D63D40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000102 RID: 258 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000067")]
		public IPlacementModeGroup SharedPlacementModeGroup
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x2D63DA0", Offset = "0x2D623A0", VA = "0x182D63DA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x2D63DB0", Offset = "0x2D623B0", VA = "0x182D63DB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000068")]
		public List<IConstructionModule> AllModules
		{
			[Token(Token = "0x6000103")]
			[Address(RVA = "0xA095C0", Offset = "0xA07BC0", VA = "0x180A095C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000069")]
		public List<IOnStructureDynamicSnapPointModule> AllHighPriorityOnStructureElementDynamicModules
		{
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x2D63E10", Offset = "0x2D62410", VA = "0x182D63E10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700006A")]
		public List<IOnStructureDynamicSnapPointModule> AllOnStructureElementDynamicModules
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x2D63E70", Offset = "0x2D62470", VA = "0x182D63E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700006B")]
		public List<INonStructureDynamicSnapPointModule> AllOnOtherTargetModules
		{
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x2D63ED0", Offset = "0x2D624D0", VA = "0x182D63ED0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700006C")]
		public List<ISnapPointPredictingModule> AllOnStructureElementPredictingModules
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x2D63F30", Offset = "0x2D62530", VA = "0x182D63F30")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700006D")]
		public BranchingController BranchingController
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x2D63F90", Offset = "0x2D62590", VA = "0x182D63F90", Slot = "7")]
		protected override void PostAwake()
		{
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x2D65AD0", Offset = "0x2D640D0", VA = "0x182D65AD0", Slot = "9")]
		protected override void PostOnDestroy()
		{
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x2D65C70", Offset = "0x2D64270", VA = "0x182D65C70")]
		private void RegisterModule(IConstructionModule module, bool highPriority = false)
		{
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x2D65DA0", Offset = "0x2D643A0", VA = "0x182D65DA0")]
		private void RegisterModuleForLookups(IConstructionModule module)
		{
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x2D65E80", Offset = "0x2D64480", VA = "0x182D65E80")]
		public static IConstructionModule GetModule(int moduleId)
		{
			return null;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x2D65F40", Offset = "0x2D64540", VA = "0x182D65F40")]
		public void ExecuteOnAllModules(Action<IConstructionModule> executeOnModule)
		{
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x2D66090", Offset = "0x2D64690", VA = "0x182D66090")]
		private static void InitCallbacks()
		{
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x2D66280", Offset = "0x2D64880", VA = "0x182D66280")]
		private static void PlaceAction(IConstructionModule module, TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x2D66390", Offset = "0x2D64990", VA = "0x182D66390")]
		public static void RegisterPlaceAction(ConstructionSystem.PlaceActionDelegate placeAction)
		{
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x2D664A0", Offset = "0x2D64AA0", VA = "0x182D664A0")]
		public static void UnregisterPlaceAction(ConstructionSystem.PlaceActionDelegate placeAction)
		{
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x2D664B0", Offset = "0x2D64AB0", VA = "0x182D664B0")]
		public static void RegisterBeforePlaceAction(ConstructionSystem.PlaceActionDelegate placeAction)
		{
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x2D665C0", Offset = "0x2D64BC0", VA = "0x182D665C0")]
		public static void UnregisterBeforePlaceAction(ConstructionSystem.PlaceActionDelegate placeAction)
		{
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x2D665D0", Offset = "0x2D64BD0", VA = "0x182D665D0")]
		public static void RegisterAfterPlaceAction(ConstructionSystem.PlaceActionDelegate placeAction)
		{
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x2D666E0", Offset = "0x2D64CE0", VA = "0x182D666E0")]
		public static void UnregisterAfterPlaceAction(ConstructionSystem.PlaceActionDelegate placeAction)
		{
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x2D666F0", Offset = "0x2D64CF0", VA = "0x182D666F0")]
		public void Place(IConstructionModule activeModule, TargetInfo currentTarget, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x2D668B0", Offset = "0x2D64EB0", VA = "0x182D668B0")]
		public ConstructionSystem()
		{
		}

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Header("Setup Data")]
		private GridSnapSize.Initializer _gridSnapSize;

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x30")]
		[Header("Subsystems")]
		[SerializeField]
		private BranchingController _branchingController;

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Header("Module Profile DBs")]
		private ModuleProfileDatabase _collectPlacedElementProfileDB;

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ModuleProfileDatabase _cutPilarModuleProfileDB;

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ModuleProfileDatabase _cutDWModuleProfileDB;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ModuleProfileDatabase _cutFloorHoleModuleProfileDB;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ModuleProfileDatabase _cutWindowModuleProfileDB;

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[FormerlySerializedAs("_cutQuarterOnGroundModuleProfileDB")]
		private ModuleProfileDatabase _cutOnGroundProfileDB;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ModuleProfileDatabase _combineItemModuleProfileDB;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ModuleProfileDatabase _pilarProfileDB;

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ModuleProfileDatabase _raftTargetProfileDB;

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private ModuleProfileDatabase _raftProfileDB;

		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private ModuleProfileDatabase _ladderProfileDB;

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private ModuleProfileDatabase _hookProfileDB;

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private ModuleProfileDatabase _trapsProfileDB;

		// Token: 0x04000150 RID: 336
		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private ModuleProfileDatabase _decorationProfileDB;

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private ModuleProfileDatabase _wallProfileDB;

		// Token: 0x04000152 RID: 338
		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private ModuleProfileDatabase _rockWallProfileDB;

		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private ModuleProfileDatabase _doorProfileDB;

		// Token: 0x04000154 RID: 340
		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private ModuleProfileDatabase _shutterProfileDB;

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private ModuleProfileDatabase _apexProfileDB;

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private ModuleProfileDatabase _oneSidedApexProfileDB;

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private ModuleProfileDatabase _onGroundPresetProfileDB;

		// Token: 0x04000158 RID: 344
		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private ModuleProfileDatabase _onGroundAltPresetProfileDB;

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private ModuleProfileDatabase _presetToPresetProfileDB;

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private ModuleProfileDatabase _fireProfileDB;

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private ModuleProfileDatabase _fireFuelDB;

		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private ModuleProfileDatabase _leaningBeamProfileDB;

		// Token: 0x0400015D RID: 349
		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private ModuleProfileDatabase _leaningBeamOnTreeProfileDB;

		// Token: 0x0400015E RID: 350
		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private ModuleProfileDatabase _rockBeamProfileDB;

		// Token: 0x0400015F RID: 351
		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private ModuleProfileDatabase _groundedBeamProfileDB;

		// Token: 0x04000160 RID: 352
		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private ModuleProfileDatabase _groundedFakePilarProfileDB;

		// Token: 0x04000161 RID: 353
		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private ModuleProfileDatabase _waterBorneFakePilarProfileDB;

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private ModuleProfileDatabase _repositionApexPilarProfileDB;

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private ModuleProfileDatabase _repositionSupportPilarProfileDB;

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private ModuleProfileDatabase _repositionLiftPilarProfileDB;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private ModuleProfileDatabase _repositionLevelingPilarProfileDB;

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private ModuleProfileDatabase _strutProfileDB;

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private ModuleProfileDatabase _furnitureEvolutionsProfileDB;

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private ModuleProfileDatabase _onGroundFurnitureProfileDB;

		// Token: 0x04000169 RID: 361
		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private ModuleProfileDatabase _cutFurnitureNotchesProfileDB;

		// Token: 0x0400016A RID: 362
		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private BranchingController _furnitureBranchingController;

		// Token: 0x0400016B RID: 363
		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private ModuleProfileDatabase _fenceDB;

		// Token: 0x0400016C RID: 364
		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private ModuleProfileDatabase _fencePostDB;

		// Token: 0x0400016D RID: 365
		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private ModuleProfileDatabase _fencePostEvolutionsProfileDB;

		// Token: 0x0400016E RID: 366
		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private ModuleProfileDatabase _reinforcementDB;

		// Token: 0x0400016F RID: 367
		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private ModuleProfileDatabase _floorAndWalkwayProfileDB;

		// Token: 0x04000170 RID: 368
		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private ModuleProfileDatabase _halfStairsProfileDB;

		// Token: 0x04000171 RID: 369
		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private ModuleProfileDatabase _singleStepProfileDB;

		// Token: 0x04000172 RID: 370
		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private ModuleProfileDatabase _treeStructureProfileDB;

		// Token: 0x04000173 RID: 371
		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private ModuleProfileDatabase _treeStructureFakePilarProfileDB;

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private ModuleProfileDatabase _treePlatformBeamProfileDB;

		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private ModuleProfileDatabase _sharpenStickIntoDefenseDB;

		// Token: 0x04000176 RID: 374
		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		private ModuleProfileDatabase _bridgeRopeProfileDB;

		// Token: 0x04000177 RID: 375
		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		private ModuleProfileDatabase _bridgeFloorProfileDB;

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		private ModuleProfileDatabase _climbRopeProfileDB;

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		private ModuleProfileDatabase _stackProfileDB;

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x1F0")]
		[SerializeField]
		private ModuleProfileDatabase _defensiveWallProfileDB;

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x1F8")]
		[SerializeField]
		private ModuleProfileDatabase _defensiveWallGateProfileDB;

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x200")]
		[SerializeField]
		private ModuleProfileDatabase _electricWireBeamProfileDB;

		// Token: 0x0400017D RID: 381
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x208")]
		[SerializeField]
		private ModuleProfileDatabase _electricWirePilarProfileDB;

		// Token: 0x0400017E RID: 382
		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x210")]
		[SerializeField]
		private ModuleProfileDatabase _electricDeviceProfileDB;

		// Token: 0x0400017F RID: 383
		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x218")]
		[SerializeField]
		private ModuleProfileDatabase _solarPanelProfileDB;

		// Token: 0x04000180 RID: 384
		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x220")]
		[SerializeField]
		private ModuleProfileDatabase _effigyProfileDB;

		// Token: 0x04000181 RID: 385
		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x228")]
		[SerializeField]
		private ModuleProfileDatabase _grabsPilarProfileDB;

		// Token: 0x04000182 RID: 386
		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x230")]
		[SerializeField]
		private ModuleProfileDatabase _grabsBeamProfileDB;

		// Token: 0x04000183 RID: 387
		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x238")]
		[SerializeField]
		private ModuleProfileDatabase _grabsFloorProfileDB;

		// Token: 0x04000184 RID: 388
		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x240")]
		[SerializeField]
		private ModuleProfileDatabase _grabsWallProfileDB;

		// Token: 0x04000185 RID: 389
		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x248")]
		[SerializeField]
		private ModuleProfileDatabase _tarpProfileDB;

		// Token: 0x04000186 RID: 390
		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x250")]
		[SerializeField]
		private ModuleProfileDatabase _presetTarpProfileDB;

		// Token: 0x04000187 RID: 391
		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x258")]
		[SerializeField]
		private ModuleProfileDatabase _tarpStakeProfileDB;

		// Token: 0x0400018B RID: 395
		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x260")]
		private List<IConstructionModule> _allModules;

		// Token: 0x0400018C RID: 396
		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x268")]
		private ConstructionSystem.WorldGameModeModules _inWorldModules;

		// Token: 0x0400018D RID: 397
		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x270")]
		private ConstructionSystem.CavesGameModeModules _inCavesModules;

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x0600011A RID: 282
		[Token(Token = "0x2000030")]
		public delegate void PlaceActionDelegate(IConstructionModule module, TargetInfo targetInfo, ModuleProfile profile, int placementMode);

		// Token: 0x02000031 RID: 49
		[Token(Token = "0x2000031")]
		private abstract class GameModeModules
		{
			// Token: 0x0600011D RID: 285 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x2D66D30", Offset = "0x2D65330", VA = "0x182D66D30", Slot = "4")]
			public virtual void Register(IConstructionModule module, bool highPriority)
			{
			}

			// Token: 0x0600011E RID: 286 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x2D66F20", Offset = "0x2D65520", VA = "0x182D66F20")]
			protected GameModeModules()
			{
			}

			// Token: 0x0400018F RID: 399
			[Token(Token = "0x400018F")]
			[FieldOffset(Offset = "0x10")]
			public readonly List<IOnStructureDynamicSnapPointModule> _allHighPriorityOnStructureElementDynamicModules;

			// Token: 0x04000190 RID: 400
			[Token(Token = "0x4000190")]
			[FieldOffset(Offset = "0x18")]
			public readonly List<IOnStructureDynamicSnapPointModule> _allOnStructureElementDynamicModules;

			// Token: 0x04000191 RID: 401
			[Token(Token = "0x4000191")]
			[FieldOffset(Offset = "0x20")]
			public readonly List<INonStructureDynamicSnapPointModule> _allOnOtherTargetModules;

			// Token: 0x04000192 RID: 402
			[Token(Token = "0x4000192")]
			[FieldOffset(Offset = "0x28")]
			public readonly List<ISnapPointPredictingModule> _allOnStructureElementPredictingModules;
		}

		// Token: 0x02000032 RID: 50
		[Token(Token = "0x2000032")]
		private class WorldGameModeModules : ConstructionSystem.GameModeModules
		{
			// Token: 0x0600011F RID: 287 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x2D67160", Offset = "0x2D65760", VA = "0x182D67160")]
			public WorldGameModeModules()
			{
			}
		}

		// Token: 0x02000033 RID: 51
		[Token(Token = "0x2000033")]
		private class CavesGameModeModules : ConstructionSystem.GameModeModules
		{
			// Token: 0x06000120 RID: 288 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x2D67170", Offset = "0x2D65770", VA = "0x182D67170", Slot = "4")]
			public override void Register(IConstructionModule module, bool highPriority)
			{
			}

			// Token: 0x06000121 RID: 289 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x2D67160", Offset = "0x2D65760", VA = "0x182D67160")]
			public CavesGameModeModules()
			{
			}
		}
	}
}
