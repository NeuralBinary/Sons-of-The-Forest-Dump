using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Save;
using UnityEngine;

namespace Sons.Gameplay.Traps
{
	// Token: 0x02000840 RID: 2112
	[Token(Token = "0x2000840")]
	public class TrapSaveManager : MonoBehaviour, ISaveGameSerializer<TrapSaveManager.TrapStructureSaveData>
	{
		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06003BD0 RID: 15312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007AD")]
		private string SerializedName
		{
			[Token(Token = "0x6003BD0")]
			[Address(RVA = "0x3596240", Offset = "0x3594840", VA = "0x183596240", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06003BD1 RID: 15313 RVA: 0x00012318 File Offset: 0x00010518
		[Token(Token = "0x170007AE")]
		private bool UniqueFile
		{
			[Token(Token = "0x6003BD1")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06003BD2 RID: 15314 RVA: 0x00012330 File Offset: 0x00010530
		[Token(Token = "0x170007AF")]
		private bool ShouldSerialize
		{
			[Token(Token = "0x6003BD2")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06003BD3 RID: 15315 RVA: 0x00012348 File Offset: 0x00010548
		[Token(Token = "0x170007B0")]
		private bool IncludeInPlayerSave
		{
			[Token(Token = "0x6003BD3")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003BD4 RID: 15316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BD4")]
		[Address(RVA = "0x3596270", Offset = "0x3594870", VA = "0x183596270")]
		private void Start()
		{
		}

		// Token: 0x06003BD5 RID: 15317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BD5")]
		[Address(RVA = "0x35963A0", Offset = "0x35949A0", VA = "0x1835963A0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003BD6 RID: 15318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BD6")]
		[Address(RVA = "0x3596450", Offset = "0x3594A50", VA = "0x183596450")]
		private void BeforeLoadCleanUp()
		{
		}

		// Token: 0x06003BD7 RID: 15319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BD7")]
		[Address(RVA = "0x35964E0", Offset = "0x3594AE0", VA = "0x1835964E0")]
		private void ToggleVerbose()
		{
		}

		// Token: 0x06003BD8 RID: 15320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BD8")]
		[Address(RVA = "0x3596530", Offset = "0x3594B30", VA = "0x183596530")]
		public static void Register(BaseTrapController trap)
		{
		}

		// Token: 0x06003BD9 RID: 15321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BD9")]
		[Address(RVA = "0x3596660", Offset = "0x3594C60", VA = "0x183596660")]
		public static void Unregister(BaseTrapController trap)
		{
		}

		// Token: 0x06003BDA RID: 15322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BDA")]
		[Address(RVA = "0x3596750", Offset = "0x3594D50", VA = "0x183596750", Slot = "5")]
		private TrapSaveManager.TrapStructureSaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x06003BDB RID: 15323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BDB")]
		[Address(RVA = "0x3596A00", Offset = "0x3595000", VA = "0x183596A00", Slot = "6")]
		private void OnDeserialize(TrapSaveManager.TrapStructureSaveData data)
		{
		}

		// Token: 0x06003BDC RID: 15324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BDC")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public TrapSaveManager()
		{
		}

		// Token: 0x040032C7 RID: 12999
		[Token(Token = "0x40032C7")]
		[FieldOffset(Offset = "0x0")]
		private static bool Verbose;

		// Token: 0x040032C8 RID: 13000
		[Token(Token = "0x40032C8")]
		[FieldOffset(Offset = "0x8")]
		private static readonly List<BaseTrapController> _trapStructures;

		// Token: 0x02000841 RID: 2113
		[Token(Token = "0x2000841")]
		[Serializable]
		public class TrapStructureSaveData
		{
			// Token: 0x06003BDE RID: 15326 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003BDE")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public TrapStructureSaveData()
			{
			}

			// Token: 0x040032C9 RID: 13001
			[Token(Token = "0x40032C9")]
			[FieldOffset(Offset = "0x10")]
			public List<BaseTrapController.SaveData> _tarpStructureData;
		}
	}
}
