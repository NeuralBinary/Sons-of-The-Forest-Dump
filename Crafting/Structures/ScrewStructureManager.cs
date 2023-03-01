using System;
using System.Collections.Generic;
using Endnight.Types;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Sons.Inventory;
using Sons.Save;
using UnityEngine;

namespace Sons.Crafting.Structures
{
	// Token: 0x020007C7 RID: 1991
	[Token(Token = "0x20007C7")]
	[AddComponentMenu("Sons/Crafting/Structures/ScrewStructureManager")]
	public class ScrewStructureManager : SingletonBehaviour<ScrewStructureManager>, ISaveGameSerializer<ScrewStructureManager.ScrewStructuresData>
	{
		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06003490 RID: 13456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006AF")]
		private string SerializedName
		{
			[Token(Token = "0x6003490")]
			[Address(RVA = "0x2E977C0", Offset = "0x2E967C0", VA = "0x182E977C0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06003491 RID: 13457 RVA: 0x0000F018 File Offset: 0x0000D218
		[Token(Token = "0x170006B0")]
		private bool UniqueFile
		{
			[Token(Token = "0x6003491")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06003492 RID: 13458 RVA: 0x0000F030 File Offset: 0x0000D230
		[Token(Token = "0x170006B1")]
		private bool ShouldSerialize
		{
			[Token(Token = "0x6003492")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06003493 RID: 13459 RVA: 0x0000F048 File Offset: 0x0000D248
		[Token(Token = "0x170006B2")]
		private bool IncludeInPlayerSave
		{
			[Token(Token = "0x6003493")]
			[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003494 RID: 13460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003494")]
		[Address(RVA = "0x2E96C60", Offset = "0x2E95C60", VA = "0x182E96C60", Slot = "7")]
		protected override void PostAwake()
		{
		}

		// Token: 0x06003495 RID: 13461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003495")]
		[Address(RVA = "0x2E96CC0", Offset = "0x2E95CC0", VA = "0x182E96CC0", Slot = "9")]
		protected override void PostOnDestroy()
		{
		}

		// Token: 0x06003496 RID: 13462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003496")]
		[Address(RVA = "0x2E97340", Offset = "0x2E96340", VA = "0x182E97340", Slot = "11")]
		private ScrewStructureManager.ScrewStructuresData OnSerialize()
		{
			return null;
		}

		// Token: 0x06003497 RID: 13463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003497")]
		[Address(RVA = "0x2E96DF0", Offset = "0x2E95DF0", VA = "0x182E96DF0", Slot = "12")]
		private void OnDeserialize(ScrewStructureManager.ScrewStructuresData data)
		{
		}

		// Token: 0x06003498 RID: 13464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003498")]
		[Address(RVA = "0x2E96A20", Offset = "0x2E95A20", VA = "0x182E96A20")]
		private void ClearAll()
		{
		}

		// Token: 0x06003499 RID: 13465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003499")]
		[Address(RVA = "0x2E96D20", Offset = "0x2E95D20", VA = "0x182E96D20")]
		public static void Register(ScrewStructure structure)
		{
		}

		// Token: 0x0600349A RID: 13466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600349A")]
		[Address(RVA = "0x2E977F0", Offset = "0x2E967F0", VA = "0x182E977F0")]
		public static void Unregister(ScrewStructure structure)
		{
		}

		// Token: 0x0600349B RID: 13467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600349B")]
		[Address(RVA = "0x2E97890", Offset = "0x2E96890", VA = "0x182E97890")]
		public ScrewStructureManager()
		{
		}

		// Token: 0x04002D62 RID: 11618
		[Token(Token = "0x4002D62")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private StructureRecipeDatabase _database;

		// Token: 0x04002D63 RID: 11619
		[Token(Token = "0x4002D63")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<ScrewStructure> _structures;

		// Token: 0x04002D64 RID: 11620
		[Token(Token = "0x4002D64")]
		[FieldOffset(Offset = "0x0")]
		private static bool _isClearing;

		// Token: 0x020007C8 RID: 1992
		[Token(Token = "0x20007C8")]
		[Serializable]
		public class ScrewStructuresData
		{
			// Token: 0x0600349C RID: 13468 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600349C")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public ScrewStructuresData()
			{
			}

			// Token: 0x04002D65 RID: 11621
			[Token(Token = "0x4002D65")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty]
			public List<ScrewStructureManager.ScrewStructureData> _structures;
		}

		// Token: 0x020007C9 RID: 1993
		[Token(Token = "0x20007C9")]
		[Serializable]
		public class ScrewStructureData
		{
			// Token: 0x0600349D RID: 13469 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600349D")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public ScrewStructureData()
			{
			}

			// Token: 0x04002D66 RID: 11622
			[Token(Token = "0x4002D66")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty]
			public int Id;

			// Token: 0x04002D67 RID: 11623
			[Token(Token = "0x4002D67")]
			[FieldOffset(Offset = "0x14")]
			[JsonProperty]
			public Vector3S Pos;

			// Token: 0x04002D68 RID: 11624
			[Token(Token = "0x4002D68")]
			[FieldOffset(Offset = "0x20")]
			[JsonProperty]
			public Vector4S Rot;

			// Token: 0x04002D69 RID: 11625
			[Token(Token = "0x4002D69")]
			[FieldOffset(Offset = "0x30")]
			[JsonProperty]
			public List<ItemInstanceManager.ItemInstanceManagerSaveData> Storages;
		}
	}
}
