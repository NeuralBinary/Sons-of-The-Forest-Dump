using System;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000065 RID: 101
	[Token(Token = "0x2000065")]
	[Serializable]
	public class ItemTypeModuleProfile
	{
		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600027E RID: 638 RVA: 0x0000311C File Offset: 0x0000131C
		[Token(Token = "0x170000DD")]
		public Types ItemType
		{
			[Token(Token = "0x600027E")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
			get
			{
				return (Types)0;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600027F RID: 639 RVA: 0x00003134 File Offset: 0x00001334
		[Token(Token = "0x170000DE")]
		public Types ExcludingItemType
		{
			[Token(Token = "0x600027F")]
			[Address(RVA = "0x66F500", Offset = "0x66DB00", VA = "0x18066F500")]
			get
			{
				return (Types)0;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000280 RID: 640 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000DF")]
		public ModuleProfile Profile
		{
			[Token(Token = "0x6000280")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ItemTypeModuleProfile()
		{
		}

		// Token: 0x04000287 RID: 647
		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Types _itemType;

		// Token: 0x04000288 RID: 648
		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Types _excludingItemType;

		// Token: 0x04000289 RID: 649
		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ModuleProfile _profile;
	}
}
