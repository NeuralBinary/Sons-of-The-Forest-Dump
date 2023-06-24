using System;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000064 RID: 100
	[Token(Token = "0x2000064")]
	[Serializable]
	public class ItemModuleProfile
	{
		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600027A RID: 634 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000DA")]
		public ItemData Item
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600027B RID: 635 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000DB")]
		public ModuleProfile Profile
		{
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600027C RID: 636 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000DC")]
		private string ProfileName
		{
			[Token(Token = "0x600027C")]
			[Address(RVA = "0x2D77880", Offset = "0x2D75E80", VA = "0x182D77880")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ItemModuleProfile()
		{
		}

		// Token: 0x04000285 RID: 645
		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ItemData _item;

		// Token: 0x04000286 RID: 646
		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ModuleProfile _profile;
	}
}
