using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Save;
using UnityEngine;

namespace Sons.Gameplay.Traps
{
	// Token: 0x020006F2 RID: 1778
	[Token(Token = "0x20006F2")]
	public class TrapSaveManager : MonoBehaviour, ISaveGameSerializer<TrapSaveManager.TrapStructureSaveData>
	{
		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06002DDC RID: 11740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005AA")]
		private string SerializedName
		{
			[Token(Token = "0x6002DDC")]
			[Address(RVA = "0x2E14B30", Offset = "0x2E13B30", VA = "0x182E14B30", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06002DDD RID: 11741 RVA: 0x0000D080 File Offset: 0x0000B280
		[Token(Token = "0x170005AB")]
		private bool UniqueFile
		{
			[Token(Token = "0x6002DDD")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06002DDE RID: 11742 RVA: 0x0000D098 File Offset: 0x0000B298
		[Token(Token = "0x170005AC")]
		private bool ShouldSerialize
		{
			[Token(Token = "0x6002DDE")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06002DDF RID: 11743 RVA: 0x0000D0B0 File Offset: 0x0000B2B0
		[Token(Token = "0x170005AD")]
		private bool IncludeInPlayerSave
		{
			[Token(Token = "0x6002DDF")]
			[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002DE0 RID: 11744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DE0")]
		[Address(RVA = "0x2E14B60", Offset = "0x2E13B60", VA = "0x182E14B60")]
		private void Start()
		{
		}

		// Token: 0x06002DE1 RID: 11745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DE1")]
		[Address(RVA = "0x2E145B0", Offset = "0x2E135B0", VA = "0x182E145B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002DE2 RID: 11746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DE2")]
		[Address(RVA = "0x2E14520", Offset = "0x2E13520", VA = "0x182E14520")]
		private void BeforeLoadCleanUp()
		{
		}

		// Token: 0x06002DE3 RID: 11747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DE3")]
		[Address(RVA = "0x2E14C90", Offset = "0x2E13C90", VA = "0x182E14C90")]
		private void ToggleVerbose()
		{
		}

		// Token: 0x06002DE4 RID: 11748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DE4")]
		[Address(RVA = "0x2E14660", Offset = "0x2E13660", VA = "0x182E14660")]
		public static void Register(BaseTrapController trap)
		{
		}

		// Token: 0x06002DE5 RID: 11749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DE5")]
		[Address(RVA = "0x2E14CE0", Offset = "0x2E13CE0", VA = "0x182E14CE0")]
		public static void Unregister(BaseTrapController trap)
		{
		}

		// Token: 0x06002DE6 RID: 11750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DE6")]
		[Address(RVA = "0x2E148E0", Offset = "0x2E138E0", VA = "0x182E148E0", Slot = "5")]
		private TrapSaveManager.TrapStructureSaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x06002DE7 RID: 11751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DE7")]
		[Address(RVA = "0x2E147B0", Offset = "0x2E137B0", VA = "0x182E147B0", Slot = "6")]
		private void OnDeserialize(TrapSaveManager.TrapStructureSaveData data)
		{
		}

		// Token: 0x06002DE8 RID: 11752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DE8")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public TrapSaveManager()
		{
		}

		// Token: 0x040028E2 RID: 10466
		[Token(Token = "0x40028E2")]
		[FieldOffset(Offset = "0x0")]
		private static bool Verbose;

		// Token: 0x040028E3 RID: 10467
		[Token(Token = "0x40028E3")]
		[FieldOffset(Offset = "0x8")]
		private static readonly List<BaseTrapController> _trapStructures;

		// Token: 0x020006F3 RID: 1779
		[Token(Token = "0x20006F3")]
		[Serializable]
		public class TrapStructureSaveData
		{
			// Token: 0x06002DEA RID: 11754 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002DEA")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public TrapStructureSaveData()
			{
			}

			// Token: 0x040028E4 RID: 10468
			[Token(Token = "0x40028E4")]
			[FieldOffset(Offset = "0x10")]
			public List<BaseTrapController.SaveData> _tarpStructureData;
		}
	}
}
