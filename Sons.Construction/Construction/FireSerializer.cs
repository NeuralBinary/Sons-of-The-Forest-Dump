using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Sons.Save;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001F0 RID: 496
	[Token(Token = "0x20001F0")]
	public class FireSerializer : MonoBehaviour, ISaveGameSerializer<FireSerializer.FireSaveData>
	{
		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000EE8 RID: 3816 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700036F")]
		private string SerializedName
		{
			[Token(Token = "0x6000EE8")]
			[Address(RVA = "0x2EF5620", Offset = "0x2EF3C20", VA = "0x182EF5620", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000EE9 RID: 3817 RVA: 0x0000911C File Offset: 0x0000731C
		[Token(Token = "0x17000370")]
		private bool UniqueFile
		{
			[Token(Token = "0x6000EE9")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000EEA RID: 3818 RVA: 0x00009134 File Offset: 0x00007334
		[Token(Token = "0x17000371")]
		private bool ShouldSerialize
		{
			[Token(Token = "0x6000EEA")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000EEB RID: 3819 RVA: 0x0000914C File Offset: 0x0000734C
		[Token(Token = "0x17000372")]
		private bool IncludeInPlayerSave
		{
			[Token(Token = "0x6000EEB")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EEC")]
		[Address(RVA = "0x2EF5650", Offset = "0x2EF3C50", VA = "0x182EF5650")]
		private void Awake()
		{
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EED")]
		[Address(RVA = "0x2EF56F0", Offset = "0x2EF3CF0", VA = "0x182EF56F0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EEE")]
		[Address(RVA = "0x2EF5790", Offset = "0x2EF3D90", VA = "0x182EF5790")]
		private static void ClearAll()
		{
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000EEF")]
		[Address(RVA = "0x2EF5810", Offset = "0x2EF3E10", VA = "0x182EF5810", Slot = "5")]
		private FireSerializer.FireSaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EF0")]
		[Address(RVA = "0x2EF5860", Offset = "0x2EF3E60", VA = "0x182EF5860", Slot = "6")]
		private void OnDeserialize(FireSerializer.FireSaveData saveData)
		{
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EF1")]
		[Address(RVA = "0x2EF5D70", Offset = "0x2EF4370", VA = "0x182EF5D70")]
		public static void Register(CookingFireNew.FireSaveData fireSaveData)
		{
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EF2")]
		[Address(RVA = "0x2EF6080", Offset = "0x2EF4680", VA = "0x182EF6080")]
		public static void Unregister(CookingFireNew.FireSaveData fireSaveData)
		{
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EF3")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public FireSerializer()
		{
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000EF5")]
		[Address(RVA = "0x2EF63A0", Offset = "0x2EF49A0", VA = "0x182EF63A0")]
		[CompilerGenerated]
		internal static List<CookingFireNew.FireSaveData> <Register>g__GetFireList|15_0(CookingFireNew.FireSaveData fireSaveData)
		{
			return null;
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x00009164 File Offset: 0x00007364
		[Token(Token = "0x6000EF6")]
		[Address(RVA = "0x2EF6510", Offset = "0x2EF4B10", VA = "0x182EF6510")]
		[CompilerGenerated]
		internal static bool <Unregister>g__TryGetFireList|16_0(CookingFireNew.FireSaveData fireSaveData, out List<CookingFireNew.FireSaveData> fireList)
		{
			return default(bool);
		}

		// Token: 0x04000819 RID: 2073
		[Token(Token = "0x4000819")]
		[FieldOffset(Offset = "0x0")]
		private static readonly FireSerializer.FireSaveData SaveDataPayload;

		// Token: 0x0400081A RID: 2074
		[Token(Token = "0x400081A")]
		[FieldOffset(Offset = "0x8")]
		private static bool Verbose;

		// Token: 0x020001F1 RID: 497
		[Token(Token = "0x20001F1")]
		[Serializable]
		internal class FireSaveData
		{
			// Token: 0x06000EF7 RID: 3831 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000EF7")]
			[Address(RVA = "0x2EF6810", Offset = "0x2EF4E10", VA = "0x182EF6810")]
			public FireSaveData()
			{
			}

			// Token: 0x0400081B RID: 2075
			[Token(Token = "0x400081B")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty]
			public string Version;

			// Token: 0x0400081C RID: 2076
			[Token(Token = "0x400081C")]
			[FieldOffset(Offset = "0x18")]
			[JsonProperty]
			public Dictionary<int, List<CookingFireNew.FireSaveData>> FiresPerStructureType;
		}
	}
}
