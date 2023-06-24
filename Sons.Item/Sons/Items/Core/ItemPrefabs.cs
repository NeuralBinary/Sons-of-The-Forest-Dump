using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Items.Core
{
	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000026")]
	[Serializable]
	public class ItemPrefabs
	{
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700004C")]
		public Transform Default
		{
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public void SetDefault(Transform t)
		{
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ItemPrefabs()
		{
		}

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Transform _default;
	}
}
