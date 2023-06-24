using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Endnight.Types;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Sons.Inventory;
using Sons.Multiplayer;
using Sons.Save;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	[AddComponentMenu("Sons/Construction/RuntimeStructureDatabase")]
	public class RuntimeStructureDatabase : SingletonBehaviour<RuntimeStructureDatabase>, ISaveGameSerializer<RuntimeStructureDatabase.ConstructionSaveData>, IBlobSerializer<RuntimeStructureDatabase.ConstructionBlobData>
	{
		// Token: 0x0600014A RID: 330 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x2D688C0", Offset = "0x2D66EC0", VA = "0x182D688C0")]
		public static void RegisterBlobSyncDeserializeAction(Action onBlobSyncDeserialize)
		{
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x2D68B00", Offset = "0x2D67100", VA = "0x182D68B00")]
		public static void UnregisterBlobSyncDeserializeAction(Action onBlobSyncDeserialize)
		{
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x2D68C30", Offset = "0x2D67230", VA = "0x182D68C30")]
		public static void RegisterStructureCreatedAction(Action<Structure> onStructureCreated)
		{
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x2D68E80", Offset = "0x2D67480", VA = "0x182D68E80")]
		public static void UnregisterStructureCreatedAction(Action<Structure> onStructureCreated)
		{
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x2D68FD0", Offset = "0x2D675D0", VA = "0x182D68FD0")]
		public static void RegisterStructureEditedTransformAction(Action<Structure> onStructureEdited)
		{
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x2D69220", Offset = "0x2D67820", VA = "0x182D69220")]
		public static void UnregisterStructureEditedTransformAction(Action<Structure> onStructureEdited)
		{
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x2D69370", Offset = "0x2D67970", VA = "0x182D69370")]
		public static void RegisterStructureEditedElementsAction(Action<Structure> onStructureEdited)
		{
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x2D695C0", Offset = "0x2D67BC0", VA = "0x182D695C0")]
		public static void UnregisterStructureEditedElementsAction(Action<Structure> onStructureEdited)
		{
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x2D69710", Offset = "0x2D67D10", VA = "0x182D69710")]
		public static void RegisterStructureEditedLinksAction(Action<Structure> onStructureEdited)
		{
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x2D69960", Offset = "0x2D67F60", VA = "0x182D69960")]
		public static void UnregisterStructureEditedLinksAction(Action<Structure> onStructureEdited)
		{
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x2D69AB0", Offset = "0x2D680B0", VA = "0x182D69AB0")]
		public static void RegisterCascadeRepositionSupportedAction(Action<List<Structure>> onCascadeRepositionSupported)
		{
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x2D69D00", Offset = "0x2D68300", VA = "0x182D69D00")]
		public static void UnregisterCascadeRepositionSupportedAction(Action<List<Structure>> onCascadeRepositionSupported)
		{
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x2D69E50", Offset = "0x2D68450", VA = "0x182D69E50")]
		public static void RegisterOnDestroyingStructureAction(Action<Structure> onDestroyingStructure)
		{
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x2D6A0A0", Offset = "0x2D686A0", VA = "0x182D6A0A0")]
		public static void UnregisterOnDestroyingStructureAction(Action<Structure> onDestroyingStructure)
		{
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x2D6A1F0", Offset = "0x2D687F0", VA = "0x182D6A1F0")]
		public static void RegisterOnModifyingStructureIdAction(Action<Structure, uint> onModifyingStructureId)
		{
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x2D6A440", Offset = "0x2D68A40", VA = "0x182D6A440")]
		public static void UnregisterOnModifyingStructureIdAction(Action<Structure, uint> onModifyingStructureId)
		{
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600015A RID: 346 RVA: 0x00002A5C File Offset: 0x00000C5C
		[Token(Token = "0x1700007B")]
		public static int StructureTypeCount
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x9E25D0", Offset = "0x9E0BD0", VA = "0x1809E25D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00002A74 File Offset: 0x00000C74
		// (set) Token: 0x0600015C RID: 348 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700007C")]
		public bool IsLocked
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x5FD5C0", Offset = "0x5FBBC0", VA = "0x1805FD5C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x5FD5D0", Offset = "0x5FBBD0", VA = "0x1805FD5D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00002A8C File Offset: 0x00000C8C
		// (set) Token: 0x0600015E RID: 350 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700007D")]
		public static bool Verbose
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x2D6A590", Offset = "0x2D68B90", VA = "0x182D6A590")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x2D6A5E0", Offset = "0x2D68BE0", VA = "0x182D6A5E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00002AA4 File Offset: 0x00000CA4
		// (set) Token: 0x06000160 RID: 352 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700007E")]
		public static bool IgnoreDestruction
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x2D6A640", Offset = "0x2D68C40", VA = "0x182D6A640")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x2D6A690", Offset = "0x2D68C90", VA = "0x182D6A690")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x2D6A6F0", Offset = "0x2D68CF0", VA = "0x182D6A6F0", Slot = "7")]
		protected override void PostAwake()
		{
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x2D6AB20", Offset = "0x2D69120", VA = "0x182D6AB20")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x2D6ABF0", Offset = "0x2D691F0", VA = "0x182D6ABF0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x2D6ADC0", Offset = "0x2D693C0", VA = "0x182D6ADC0")]
		private void SetLogVersionChanges(bool value)
		{
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x2D6AE50", Offset = "0x2D69450", VA = "0x182D6AE50")]
		public static void Prewarm()
		{
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x2D6AF60", Offset = "0x2D69560", VA = "0x182D6AF60")]
		public static RuntimeStructureDatabase.StructureGenerator GetStructureGenerator(int typeID)
		{
			return null;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x2D6B130", Offset = "0x2D69730", VA = "0x182D6B130")]
		public static void SetIsLocked(bool onOff)
		{
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x2D6B190", Offset = "0x2D69790", VA = "0x182D6B190")]
		public static void SetIgnoreDestruction(bool onOff)
		{
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x2D6B220", Offset = "0x2D69820", VA = "0x182D6B220")]
		public static void RegisterCustomCallbackAction(Action customAction)
		{
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x2D6B3B0", Offset = "0x2D699B0", VA = "0x182D6B3B0")]
		public static void RegisterStructure(Structure structure)
		{
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600016B")]
		[Address(RVA = "0x2D6B520", Offset = "0x2D69B20", VA = "0x182D6B520")]
		public static void CascadeRepositionSupportedStructures(Structure structure)
		{
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x2D6B610", Offset = "0x2D69C10", VA = "0x182D6B610")]
		public static void CascadeRepositionSupportedStructures(List<Structure> structures)
		{
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x2D6B6E0", Offset = "0x2D69CE0", VA = "0x182D6B6E0")]
		public static void EditedStructureTransform(Structure structure)
		{
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x2D6B740", Offset = "0x2D69D40", VA = "0x182D6B740")]
		public static void EditedStructureElements(Structure structure)
		{
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600016F")]
		[Address(RVA = "0x2D6B7A0", Offset = "0x2D69DA0", VA = "0x182D6B7A0")]
		public static void EditedStructureLinks(Structure structure)
		{
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x2D6B800", Offset = "0x2D69E00", VA = "0x182D6B800")]
		public static void DestroyStructure(Structure structure)
		{
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x2D6B8C0", Offset = "0x2D69EC0", VA = "0x182D6B8C0")]
		public static void DestroyAnticipatedStructure(Structure structure)
		{
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x2D6B9A0", Offset = "0x2D69FA0", VA = "0x182D6B9A0")]
		public static Structure GetStructure(int typeID, int instanceID)
		{
			return null;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00002ABC File Offset: 0x00000CBC
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x2D6BA60", Offset = "0x2D6A060", VA = "0x182D6BA60")]
		public static bool TryGetStructure(int typeID, int instanceID, out Structure structure)
		{
			return default(bool);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00002AD4 File Offset: 0x00000CD4
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x2D6BD00", Offset = "0x2D6A300", VA = "0x182D6BD00")]
		public static int GetVersion()
		{
			return 0;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x2D6BD80", Offset = "0x2D6A380", VA = "0x182D6BD80")]
		private void Init()
		{
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x2D6D070", Offset = "0x2D6B670", VA = "0x182D6D070")]
		private void BumpVersion(string action, Structure structure)
		{
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x2D6D400", Offset = "0x2D6BA00", VA = "0x182D6D400")]
		public static void SetVersionController(RuntimeStructureDatabase.IVersionController versionController)
		{
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x2D6D4A0", Offset = "0x2D6BAA0", VA = "0x182D6D4A0")]
		private void ClearAllStructures()
		{
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x2D6D6A0", Offset = "0x2D6BCA0", VA = "0x182D6D6A0")]
		private static void SetStructureDirty(IStructure structure, bool checkAlreadyDirtiedCache = true)
		{
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x2D6D930", Offset = "0x2D6BF30", VA = "0x182D6D930")]
		public static void ClearDirtiedStructuresCache()
		{
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x2D6D9C0", Offset = "0x2D6BFC0", VA = "0x182D6D9C0")]
		public static void RegisterOnStructureDirtyReceiver(IStructureDirtyReceiver receiver)
		{
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600017C")]
		[Address(RVA = "0x2D6DB10", Offset = "0x2D6C110", VA = "0x182D6DB10")]
		public static void UnregisterOnStructureDirtyReceiver(IStructureDirtyReceiver receiver)
		{
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x2D6DB90", Offset = "0x2D6C190", VA = "0x182D6DB90")]
		public static void ExecutePendingActions()
		{
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x2D6DEA0", Offset = "0x2D6C4A0", VA = "0x182D6DEA0")]
		private static void LogRegisteringAction(RuntimeStructureDatabase instance, RuntimeStructureDatabase.IPendingAction actionInstance)
		{
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600017F")]
		private static void RegisterAction<T>(Action callback) where T : class, RuntimeStructureDatabase.ICallbackAction, new()
		{
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x2D6DFF0", Offset = "0x2D6C5F0", VA = "0x182D6DFF0")]
		private static void FlushStructureActions(Structure structure)
		{
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000181")]
		private static void RegisterAction<T>(Structure structure, bool dirtyStructure = true) where T : class, RuntimeStructureDatabase.IPendingStructureAction, new()
		{
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000182")]
		private static void ExecuteAction<T>(Structure structure, bool dirtyStructure = true) where T : class, RuntimeStructureDatabase.IPendingStructureAction, new()
		{
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000183")]
		private static void RegisterAction<T>(Structure structure1, Structure structure2) where T : class, RuntimeStructureDatabase.IPending2StructuresAction, new()
		{
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000184")]
		private static void RegisterAction<T>(List<Structure> structureList) where T : class, RuntimeStructureDatabase.IPendingStructureListAction, new()
		{
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00002AEC File Offset: 0x00000CEC
		// (set) Token: 0x06000186 RID: 390 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700007F")]
		public static bool IsLoadingSave
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x2D6E1E0", Offset = "0x2D6C7E0", VA = "0x182D6E1E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x2D6E230", Offset = "0x2D6C830", VA = "0x182D6E230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000187 RID: 391 RVA: 0x00002B04 File Offset: 0x00000D04
		// (set) Token: 0x06000188 RID: 392 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000080")]
		public static bool IsLoadingPrefab
		{
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x2D6E290", Offset = "0x2D6C890", VA = "0x182D6E290")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x2D6E2E0", Offset = "0x2D6C8E0", VA = "0x182D6E2E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000189 RID: 393 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000081")]
		private string SerializedName
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x2D6E340", Offset = "0x2D6C940", VA = "0x182D6E340", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00002B1C File Offset: 0x00000D1C
		[Token(Token = "0x17000082")]
		private bool UniqueFile
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600018B RID: 395 RVA: 0x00002B34 File Offset: 0x00000D34
		[Token(Token = "0x17000083")]
		private bool ShouldSerialize
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600018C RID: 396 RVA: 0x00002B4C File Offset: 0x00000D4C
		[Token(Token = "0x17000084")]
		private bool IncludeInPlayerSave
		{
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000085")]
		private Func<string, RuntimeStructureDatabase.ConstructionSaveData> DeserializeOverrideAction
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x2D6E370", Offset = "0x2D6C970", VA = "0x182D6E370", Slot = "11")]
		private RuntimeStructureDatabase.ConstructionSaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x2D6E650", Offset = "0x2D6CC50", VA = "0x182D6E650", Slot = "12")]
		private void OnDeserialize(RuntimeStructureDatabase.ConstructionSaveData saveData)
		{
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x2D6E820", Offset = "0x2D6CE20", VA = "0x182D6E820")]
		public static IBlobSerializer<RuntimeStructureDatabase.ConstructionBlobData> GetBlobSerializer()
		{
			return null;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x2D6E870", Offset = "0x2D6CE70", VA = "0x182D6E870", Slot = "17")]
		private RuntimeStructureDatabase.ConstructionBlobData OnSerialize()
		{
			return null;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x2D6EBC0", Offset = "0x2D6D1C0", VA = "0x182D6EBC0", Slot = "18")]
		private void OnDeserialize(RuntimeStructureDatabase.ConstructionBlobData blobData)
		{
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x2D6EDC0", Offset = "0x2D6D3C0", VA = "0x182D6EDC0")]
		public static string ExportToSaveData(List<Structure> structures)
		{
			return null;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x2D6F690", Offset = "0x2D6DC90", VA = "0x182D6F690")]
		public static void ImportFromSaveData(string json)
		{
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00002B64 File Offset: 0x00000D64
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x2D6F7F0", Offset = "0x2D6DDF0", VA = "0x182D6F7F0")]
		public static bool TryImportGhostPrefabFromSaveData(string name, string json, out GameObject prefabGo)
		{
			return default(bool);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00002B7C File Offset: 0x00000D7C
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x2D6FAE0", Offset = "0x2D6E0E0", VA = "0x182D6FAE0")]
		public static bool TryImportPrefabFromSaveData(string name, string json, out GameObject prefabGo)
		{
			return default(bool);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x2D6FDD0", Offset = "0x2D6E3D0", VA = "0x182D6FDD0")]
		public static GameObject GeneratePrefabFromStructures(string name, Structure[][] structuresPerType)
		{
			return null;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x2D6FF80", Offset = "0x2D6E580", VA = "0x182D6FF80")]
		private static void LoadStructuresFromData(List<RuntimeStructureDatabase.StructureData>[] loadingStructures)
		{
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x2D6FFF0", Offset = "0x2D6E5F0", VA = "0x182D6FFF0")]
		private static void LoadStructuresFromData(List<RuntimeStructureDatabase.StructureData>[] loadingStructures, out Structure[][] structuresPerType, bool skipPostLoad = false, bool asGhost = false)
		{
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x2D70C70", Offset = "0x2D6F270", VA = "0x182D70C70")]
		private static void GenerateSerializableStructureData(List<Structure>[] structureLists, out List<RuntimeStructureDatabase.StructureData>[] savingStructures, out int structureCount)
		{
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x2D71CA0", Offset = "0x2D702A0", VA = "0x182D71CA0")]
		public RuntimeStructureDatabase()
		{
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x2D71F20", Offset = "0x2D70520", VA = "0x182D71F20")]
		[CompilerGenerated]
		internal static void <GeneratePrefabFromStructures>g__SetCenterBottomPosFromStructures|127_0(GameObject go, ref RuntimeStructureDatabase.<>c__DisplayClass127_0 A_1)
		{
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x2D72540", Offset = "0x2D70B40", VA = "0x182D72540")]
		[CompilerGenerated]
		internal static void <GeneratePrefabFromStructures>g__IntegrateStructuresInPrefab|127_1(GameObject go, ref RuntimeStructureDatabase.<>c__DisplayClass127_0 A_1)
		{
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x2D72600", Offset = "0x2D70C00", VA = "0x182D72600")]
		[CompilerGenerated]
		internal static void <LoadStructuresFromData>g__ProcessPostLoadForStructureType|129_0(Structure[][] structuresPerType, ushort iStructureType, ref RuntimeStructureDatabase.<>c__DisplayClass129_0 A_2)
		{
		}

		// Token: 0x040001A0 RID: 416
		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x0")]
		private static Action _onBlobSyncDeserializedActions;

		// Token: 0x040001A1 RID: 417
		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x8")]
		private static Action<Structure> _onStructureCreatedActions;

		// Token: 0x040001A2 RID: 418
		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x10")]
		private static Action<Structure> _onStructureEditedTransformActions;

		// Token: 0x040001A3 RID: 419
		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x18")]
		private static Action<Structure> _onStructureEditedElementsActions;

		// Token: 0x040001A4 RID: 420
		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x20")]
		private static Action<Structure> _onStructureEditedLinksActions;

		// Token: 0x040001A5 RID: 421
		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x28")]
		private static Action<List<Structure>> _onCascadeRepositionSupportedActions;

		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x30")]
		private static Action<Structure> _onDestroyingStructureActions;

		// Token: 0x040001A7 RID: 423
		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x38")]
		private static Action<Structure, uint> _onModifyingStructureIdActions;

		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x28")]
		private RuntimeStructureDatabase.IVersionController _versionController;

		// Token: 0x040001A9 RID: 425
		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x30")]
		private List<Structure>[] _structureLists;

		// Token: 0x040001AA RID: 426
		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x40")]
		private static RuntimeStructureDatabase.StructureGenerator[] StructureGenerators;

		// Token: 0x040001AE RID: 430
		[Token(Token = "0x40001AE")]
		private const string LogVersionChangeSettingKey = "RuntimeStructureDbLogVersionChanges";

		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x50")]
		private static readonly List<IStructure> DirtiedStructureCache;

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x58")]
		private static readonly List<IStructureDirtyReceiver> OnStructureDirtyReceivers;

		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x40")]
		private readonly List<RuntimeStructureDatabase.IPendingAction> _pendingActions;

		// Token: 0x040001B2 RID: 434
		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x48")]
		private bool _executingPendingActions;

		// Token: 0x040001B3 RID: 435
		[Token(Token = "0x40001B3")]
		private const int BlobChannel = 1;

		// Token: 0x02000039 RID: 57
		// (Invoke) Token: 0x060001A1 RID: 417
		[Token(Token = "0x2000039")]
		public delegate Structure StructureGenerator(Vector3 position, Quaternion rotation);

		// Token: 0x0200003A RID: 58
		[Token(Token = "0x200003A")]
		public interface IVersionController
		{
			// Token: 0x17000086 RID: 134
			// (get) Token: 0x060001A4 RID: 420
			[Token(Token = "0x17000086")]
			int Version { [Token(Token = "0x60001A4")] get; }

			// Token: 0x060001A5 RID: 421
			[Token(Token = "0x60001A5")]
			void Init(int version);

			// Token: 0x060001A6 RID: 422
			[Token(Token = "0x60001A6")]
			void TryBump();
		}

		// Token: 0x0200003B RID: 59
		[Token(Token = "0x200003B")]
		public class VersionControllerAuto : RuntimeStructureDatabase.IVersionController
		{
			// Token: 0x17000087 RID: 135
			// (get) Token: 0x060001A7 RID: 423 RVA: 0x00002B94 File Offset: 0x00000D94
			// (set) Token: 0x060001A8 RID: 424 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000087")]
			public int Version
			{
				[Token(Token = "0x60001A7")]
				[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x60001A8")]
				[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060001A9 RID: 425 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
			public VersionControllerAuto(int version = 1)
			{
			}

			// Token: 0x060001AA RID: 426 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40", Slot = "5")]
			public void Init(int version)
			{
			}

			// Token: 0x060001AB RID: 427 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x67B900", Offset = "0x679F00", VA = "0x18067B900", Slot = "6")]
			public void TryBump()
			{
			}
		}

		// Token: 0x0200003C RID: 60
		[Token(Token = "0x200003C")]
		public class VersionControllerManual : RuntimeStructureDatabase.IVersionController
		{
			// Token: 0x17000088 RID: 136
			// (get) Token: 0x060001AC RID: 428 RVA: 0x00002BAC File Offset: 0x00000DAC
			// (set) Token: 0x060001AD RID: 429 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000088")]
			public int Version
			{
				[Token(Token = "0x60001AC")]
				[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x60001AD")]
				[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060001AE RID: 430 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
			public VersionControllerManual(int version = 1)
			{
			}

			// Token: 0x060001AF RID: 431 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
			public void Set(int version)
			{
			}

			// Token: 0x060001B0 RID: 432 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40", Slot = "5")]
			public void Init(int version)
			{
			}

			// Token: 0x060001B1 RID: 433 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "6")]
			public void TryBump()
			{
			}
		}

		// Token: 0x0200003D RID: 61
		[Token(Token = "0x200003D")]
		private class CustomCallbackAction : RuntimeStructureDatabase.ICallbackAction, RuntimeStructureDatabase.IPendingAction
		{
			// Token: 0x17000089 RID: 137
			// (get) Token: 0x060001B2 RID: 434 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x060001B3 RID: 435 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000089")]
			public Action Callback
			{
				[Token(Token = "0x60001B2")]
				[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60001B3")]
				[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x060001B4 RID: 436 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			public void Init(Action callback)
			{
			}

			// Token: 0x060001B5 RID: 437 RVA: 0x00002BC4 File Offset: 0x00000DC4
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "6")]
			public bool ShouldFlushFor(Structure structure)
			{
				return default(bool);
			}

			// Token: 0x060001B6 RID: 438 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x282E130", Offset = "0x282C730", VA = "0x18282E130", Slot = "7")]
			public void Execute(RuntimeStructureDatabase instance)
			{
			}

			// Token: 0x060001B7 RID: 439 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x2D72920", Offset = "0x2D70F20", VA = "0x182D72920", Slot = "8")]
			public void Dispose()
			{
			}

			// Token: 0x060001B8 RID: 440 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x2D72980", Offset = "0x2D70F80", VA = "0x182D72980", Slot = "9")]
			public string GetVersionLog()
			{
				return null;
			}

			// Token: 0x060001B9 RID: 441 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public CustomCallbackAction()
			{
			}
		}

		// Token: 0x0200003E RID: 62
		[Token(Token = "0x200003E")]
		private class RegisterStructureAction : RuntimeStructureDatabase.IPendingStructureAction, RuntimeStructureDatabase.IPendingAction
		{
			// Token: 0x1700008A RID: 138
			// (get) Token: 0x060001BA RID: 442 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x060001BB RID: 443 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700008A")]
			public Structure Structure
			{
				[Token(Token = "0x60001BA")]
				[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60001BB")]
				[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x060001BC RID: 444 RVA: 0x00002BDC File Offset: 0x00000DDC
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x2D729B0", Offset = "0x2D70FB0", VA = "0x182D729B0", Slot = "6")]
			public bool ShouldFlushFor(Structure structure)
			{
				return default(bool);
			}

			// Token: 0x060001BD RID: 445 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x2D72AE0", Offset = "0x2D710E0", VA = "0x182D72AE0", Slot = "7")]
			public void Execute(RuntimeStructureDatabase instance)
			{
			}

			// Token: 0x060001BE RID: 446 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x2D72C90", Offset = "0x2D71290", VA = "0x182D72C90", Slot = "8")]
			public void Dispose()
			{
			}

			// Token: 0x060001BF RID: 447 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x2D72CF0", Offset = "0x2D712F0", VA = "0x182D72CF0", Slot = "9")]
			public string GetVersionLog()
			{
				return null;
			}

			// Token: 0x060001C0 RID: 448 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public RegisterStructureAction()
			{
			}
		}

		// Token: 0x0200003F RID: 63
		[Token(Token = "0x200003F")]
		private class RegisterSwapIdAction : RuntimeStructureDatabase.IPending2StructuresAction, RuntimeStructureDatabase.IPendingAction
		{
			// Token: 0x1700008B RID: 139
			// (get) Token: 0x060001C1 RID: 449 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x060001C2 RID: 450 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700008B")]
			public Structure Structure1
			{
				[Token(Token = "0x60001C1")]
				[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60001C2")]
				[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700008C RID: 140
			// (get) Token: 0x060001C3 RID: 451 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x060001C4 RID: 452 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700008C")]
			public Structure Structure2
			{
				[Token(Token = "0x60001C3")]
				[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60001C4")]
				[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680", Slot = "7")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x060001C5 RID: 453 RVA: 0x00002BF4 File Offset: 0x00000DF4
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "8")]
			public bool ShouldFlushFor(Structure structure)
			{
				return default(bool);
			}

			// Token: 0x060001C6 RID: 454 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x2D72D20", Offset = "0x2D71320", VA = "0x182D72D20", Slot = "9")]
			public void Execute(RuntimeStructureDatabase instance)
			{
			}

			// Token: 0x060001C7 RID: 455 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x2D73330", Offset = "0x2D71930", VA = "0x182D73330", Slot = "10")]
			public void Dispose()
			{
			}

			// Token: 0x060001C8 RID: 456 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x2D73390", Offset = "0x2D71990", VA = "0x182D73390", Slot = "11")]
			public string GetVersionLog()
			{
				return null;
			}

			// Token: 0x060001C9 RID: 457 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public RegisterSwapIdAction()
			{
			}
		}

		// Token: 0x02000040 RID: 64
		[Token(Token = "0x2000040")]
		private class CascadeRepositionSupportedStructuresAction : RuntimeStructureDatabase.IPendingStructureListAction, RuntimeStructureDatabase.IPendingAction
		{
			// Token: 0x1700008D RID: 141
			// (get) Token: 0x060001CA RID: 458 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x060001CB RID: 459 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700008D")]
			public List<Structure> StructureList
			{
				[Token(Token = "0x60001CA")]
				[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60001CB")]
				[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x060001CC RID: 460 RVA: 0x00002C0C File Offset: 0x00000E0C
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x2D733C0", Offset = "0x2D719C0", VA = "0x182D733C0", Slot = "6")]
			public bool ShouldFlushFor(Structure structure)
			{
				return default(bool);
			}

			// Token: 0x060001CD RID: 461 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x2D734F0", Offset = "0x2D71AF0", VA = "0x182D734F0", Slot = "7")]
			public void Execute(RuntimeStructureDatabase instance)
			{
			}

			// Token: 0x060001CE RID: 462 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x2D73680", Offset = "0x2D71C80", VA = "0x182D73680", Slot = "8")]
			public void Dispose()
			{
			}

			// Token: 0x060001CF RID: 463 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x2D736E0", Offset = "0x2D71CE0", VA = "0x182D736E0", Slot = "9")]
			public string GetVersionLog()
			{
				return null;
			}

			// Token: 0x060001D0 RID: 464 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public CascadeRepositionSupportedStructuresAction()
			{
			}
		}

		// Token: 0x02000042 RID: 66
		[Token(Token = "0x2000042")]
		private class EditedStructureTransformAction : RuntimeStructureDatabase.IPendingStructureAction, RuntimeStructureDatabase.IPendingAction
		{
			// Token: 0x1700008E RID: 142
			// (get) Token: 0x060001D3 RID: 467 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x060001D4 RID: 468 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700008E")]
			public Structure Structure
			{
				[Token(Token = "0x60001D3")]
				[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60001D4")]
				[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x060001D5 RID: 469 RVA: 0x00002C3C File Offset: 0x00000E3C
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x2D73890", Offset = "0x2D71E90", VA = "0x182D73890", Slot = "6")]
			public bool ShouldFlushFor(Structure structure)
			{
				return default(bool);
			}

			// Token: 0x060001D6 RID: 470 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x2D739C0", Offset = "0x2D71FC0", VA = "0x182D739C0", Slot = "7")]
			public void Execute(RuntimeStructureDatabase instance)
			{
			}

			// Token: 0x060001D7 RID: 471 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x2D73A90", Offset = "0x2D72090", VA = "0x182D73A90", Slot = "8")]
			public void Dispose()
			{
			}

			// Token: 0x060001D8 RID: 472 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x2D73AF0", Offset = "0x2D720F0", VA = "0x182D73AF0", Slot = "9")]
			public string GetVersionLog()
			{
				return null;
			}

			// Token: 0x060001D9 RID: 473 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public EditedStructureTransformAction()
			{
			}
		}

		// Token: 0x02000043 RID: 67
		[Token(Token = "0x2000043")]
		private class EditedStructureElementsAction : RuntimeStructureDatabase.IPendingStructureAction, RuntimeStructureDatabase.IPendingAction
		{
			// Token: 0x1700008F RID: 143
			// (get) Token: 0x060001DA RID: 474 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x060001DB RID: 475 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700008F")]
			public Structure Structure
			{
				[Token(Token = "0x60001DA")]
				[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60001DB")]
				[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x060001DC RID: 476 RVA: 0x00002C54 File Offset: 0x00000E54
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x2D73B20", Offset = "0x2D72120", VA = "0x182D73B20", Slot = "6")]
			public bool ShouldFlushFor(Structure structure)
			{
				return default(bool);
			}

			// Token: 0x060001DD RID: 477 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x2D73C50", Offset = "0x2D72250", VA = "0x182D73C50", Slot = "7")]
			public void Execute(RuntimeStructureDatabase instance)
			{
			}

			// Token: 0x060001DE RID: 478 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x2D73D20", Offset = "0x2D72320", VA = "0x182D73D20", Slot = "8")]
			public void Dispose()
			{
			}

			// Token: 0x060001DF RID: 479 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x2D73D80", Offset = "0x2D72380", VA = "0x182D73D80", Slot = "9")]
			public string GetVersionLog()
			{
				return null;
			}

			// Token: 0x060001E0 RID: 480 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public EditedStructureElementsAction()
			{
			}
		}

		// Token: 0x02000044 RID: 68
		[Token(Token = "0x2000044")]
		private class EditedStructureLinksAction : RuntimeStructureDatabase.IPendingStructureAction, RuntimeStructureDatabase.IPendingAction
		{
			// Token: 0x17000090 RID: 144
			// (get) Token: 0x060001E1 RID: 481 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x060001E2 RID: 482 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000090")]
			public Structure Structure
			{
				[Token(Token = "0x60001E1")]
				[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60001E2")]
				[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x060001E3 RID: 483 RVA: 0x00002C6C File Offset: 0x00000E6C
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x2D73DB0", Offset = "0x2D723B0", VA = "0x182D73DB0", Slot = "6")]
			public bool ShouldFlushFor(Structure structure)
			{
				return default(bool);
			}

			// Token: 0x060001E4 RID: 484 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x2D73EE0", Offset = "0x2D724E0", VA = "0x182D73EE0", Slot = "7")]
			public void Execute(RuntimeStructureDatabase instance)
			{
			}

			// Token: 0x060001E5 RID: 485 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x2D73FB0", Offset = "0x2D725B0", VA = "0x182D73FB0", Slot = "8")]
			public void Dispose()
			{
			}

			// Token: 0x060001E6 RID: 486 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x2D74010", Offset = "0x2D72610", VA = "0x182D74010", Slot = "9")]
			public string GetVersionLog()
			{
				return null;
			}

			// Token: 0x060001E7 RID: 487 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public EditedStructureLinksAction()
			{
			}
		}

		// Token: 0x02000045 RID: 69
		[Token(Token = "0x2000045")]
		private class DestroyStructureAction : RuntimeStructureDatabase.IPendingStructureAction, RuntimeStructureDatabase.IPendingAction
		{
			// Token: 0x17000091 RID: 145
			// (get) Token: 0x060001E8 RID: 488 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x060001E9 RID: 489 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000091")]
			public Structure Structure
			{
				[Token(Token = "0x60001E8")]
				[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60001E9")]
				[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x060001EA RID: 490 RVA: 0x00002C84 File Offset: 0x00000E84
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x2D74040", Offset = "0x2D72640", VA = "0x182D74040", Slot = "6")]
			public bool ShouldFlushFor(Structure structure)
			{
				return default(bool);
			}

			// Token: 0x060001EB RID: 491 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x2D74170", Offset = "0x2D72770", VA = "0x182D74170", Slot = "7")]
			public void Execute(RuntimeStructureDatabase instance)
			{
			}

			// Token: 0x060001EC RID: 492 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x2D74640", Offset = "0x2D72C40", VA = "0x182D74640", Slot = "8")]
			public void Dispose()
			{
			}

			// Token: 0x060001ED RID: 493 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x2D746A0", Offset = "0x2D72CA0", VA = "0x182D746A0", Slot = "9")]
			public string GetVersionLog()
			{
				return null;
			}

			// Token: 0x060001EE RID: 494 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public DestroyStructureAction()
			{
			}
		}

		// Token: 0x02000046 RID: 70
		[Token(Token = "0x2000046")]
		private interface IPendingAction
		{
			// Token: 0x060001EF RID: 495
			[Token(Token = "0x60001EF")]
			bool ShouldFlushFor(Structure structure);

			// Token: 0x060001F0 RID: 496
			[Token(Token = "0x60001F0")]
			void Execute(RuntimeStructureDatabase instance);

			// Token: 0x060001F1 RID: 497
			[Token(Token = "0x60001F1")]
			void Dispose();

			// Token: 0x060001F2 RID: 498
			[Token(Token = "0x60001F2")]
			string GetVersionLog();
		}

		// Token: 0x02000047 RID: 71
		[Token(Token = "0x2000047")]
		private interface ICallbackAction : RuntimeStructureDatabase.IPendingAction
		{
			// Token: 0x17000092 RID: 146
			// (get) Token: 0x060001F3 RID: 499
			// (set) Token: 0x060001F4 RID: 500
			[Token(Token = "0x17000092")]
			Action Callback { [Token(Token = "0x60001F3")] get; [Token(Token = "0x60001F4")] set; }
		}

		// Token: 0x02000048 RID: 72
		[Token(Token = "0x2000048")]
		private interface IPendingStructureAction : RuntimeStructureDatabase.IPendingAction
		{
			// Token: 0x17000093 RID: 147
			// (get) Token: 0x060001F5 RID: 501
			// (set) Token: 0x060001F6 RID: 502
			[Token(Token = "0x17000093")]
			Structure Structure { [Token(Token = "0x60001F5")] get; [Token(Token = "0x60001F6")] set; }
		}

		// Token: 0x02000049 RID: 73
		[Token(Token = "0x2000049")]
		private interface IPending2StructuresAction : RuntimeStructureDatabase.IPendingAction
		{
			// Token: 0x17000094 RID: 148
			// (get) Token: 0x060001F7 RID: 503
			// (set) Token: 0x060001F8 RID: 504
			[Token(Token = "0x17000094")]
			Structure Structure1 { [Token(Token = "0x60001F7")] get; [Token(Token = "0x60001F8")] set; }

			// Token: 0x17000095 RID: 149
			// (get) Token: 0x060001F9 RID: 505
			// (set) Token: 0x060001FA RID: 506
			[Token(Token = "0x17000095")]
			Structure Structure2 { [Token(Token = "0x60001F9")] get; [Token(Token = "0x60001FA")] set; }
		}

		// Token: 0x0200004A RID: 74
		[Token(Token = "0x200004A")]
		private interface IPendingStructureListAction : RuntimeStructureDatabase.IPendingAction
		{
			// Token: 0x17000096 RID: 150
			// (get) Token: 0x060001FB RID: 507
			// (set) Token: 0x060001FC RID: 508
			[Token(Token = "0x17000096")]
			List<Structure> StructureList { [Token(Token = "0x60001FB")] get; [Token(Token = "0x60001FC")] set; }
		}

		// Token: 0x0200004B RID: 75
		[Token(Token = "0x200004B")]
		[Serializable]
		public class ConstructionBlobData
		{
			// Token: 0x060001FD RID: 509 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public ConstructionBlobData()
			{
			}

			// Token: 0x040001C2 RID: 450
			[Token(Token = "0x40001C2")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty]
			public int Version;

			// Token: 0x040001C3 RID: 451
			[Token(Token = "0x40001C3")]
			[FieldOffset(Offset = "0x18")]
			[JsonProperty]
			public List<RuntimeStructureDatabase.StructureData>[] Structures;

			// Token: 0x040001C4 RID: 452
			[Token(Token = "0x40001C4")]
			[FieldOffset(Offset = "0x20")]
			[JsonProperty]
			public List<RuntimeStructureDatabase.LinkedStructureData> DamagedStructures;
		}

		// Token: 0x0200004C RID: 76
		[Token(Token = "0x200004C")]
		[Serializable]
		internal class ConstructionSaveData
		{
			// Token: 0x060001FE RID: 510 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x2D746D0", Offset = "0x2D72CD0", VA = "0x182D746D0")]
			public ConstructionSaveData()
			{
			}

			// Token: 0x040001C5 RID: 453
			[Token(Token = "0x40001C5")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty]
			public string Version;

			// Token: 0x040001C6 RID: 454
			[Token(Token = "0x40001C6")]
			[FieldOffset(Offset = "0x18")]
			[JsonProperty]
			public List<RuntimeStructureDatabase.StructureData>[] Structures;
		}

		// Token: 0x0200004D RID: 77
		[Token(Token = "0x200004D")]
		[Serializable]
		public class StructureData
		{
			// Token: 0x060001FF RID: 511 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public StructureData()
			{
			}

			// Token: 0x040001C7 RID: 455
			[Token(Token = "0x40001C7")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty]
			public ushort TypeID;

			// Token: 0x040001C8 RID: 456
			[Token(Token = "0x40001C8")]
			[FieldOffset(Offset = "0x14")]
			[JsonProperty]
			public Vector3S Position;

			// Token: 0x040001C9 RID: 457
			[Token(Token = "0x40001C9")]
			[FieldOffset(Offset = "0x20")]
			[JsonProperty]
			public Vector4S Rotation;

			// Token: 0x040001CA RID: 458
			[Token(Token = "0x40001CA")]
			[FieldOffset(Offset = "0x30")]
			[JsonProperty]
			public RuntimeStructureDatabase.LinkedStructureData[] LinkedStructures;

			// Token: 0x040001CB RID: 459
			[Token(Token = "0x40001CB")]
			[FieldOffset(Offset = "0x38")]
			[JsonProperty]
			public RuntimeStructureDatabase.ElementData[] Elements;

			// Token: 0x040001CC RID: 460
			[Token(Token = "0x40001CC")]
			[FieldOffset(Offset = "0x40")]
			[JsonProperty]
			public List<ItemInstanceManager.ItemInstanceManagerSaveData> Storages;
		}

		// Token: 0x0200004E RID: 78
		[Token(Token = "0x200004E")]
		[Serializable]
		public class LinkedStructureData
		{
			// Token: 0x06000200 RID: 512 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public LinkedStructureData()
			{
			}

			// Token: 0x040001CD RID: 461
			[Token(Token = "0x40001CD")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty]
			public ushort TypeID;

			// Token: 0x040001CE RID: 462
			[Token(Token = "0x40001CE")]
			[FieldOffset(Offset = "0x14")]
			[JsonProperty]
			public uint InstanceID;
		}

		// Token: 0x0200004F RID: 79
		[Token(Token = "0x200004F")]
		[Serializable]
		public class ElementData
		{
			// Token: 0x06000201 RID: 513 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public ElementData()
			{
			}

			// Token: 0x040001CF RID: 463
			[Token(Token = "0x40001CF")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty]
			public ushort ProfileID;

			// Token: 0x040001D0 RID: 464
			[Token(Token = "0x40001D0")]
			[FieldOffset(Offset = "0x14")]
			[JsonProperty]
			public Vector3S Position;

			// Token: 0x040001D1 RID: 465
			[Token(Token = "0x40001D1")]
			[FieldOffset(Offset = "0x20")]
			[JsonProperty]
			public Vector4S Rotation;

			// Token: 0x040001D2 RID: 466
			[Token(Token = "0x40001D2")]
			[FieldOffset(Offset = "0x30")]
			[JsonProperty]
			public float LengthScale;
		}
	}
}
