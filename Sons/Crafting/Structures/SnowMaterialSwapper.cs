using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Crafting.Structures
{
	// Token: 0x020006FB RID: 1787
	[Token(Token = "0x20006FB")]
	public class SnowMaterialSwapper : MonoBehaviour
	{
		// Token: 0x06002F3A RID: 12090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F3A")]
		[Address(RVA = "0x345B870", Offset = "0x3459E70", VA = "0x18345B870")]
		private void Start()
		{
		}

		// Token: 0x06002F3B RID: 12091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F3B")]
		[Address(RVA = "0x345B880", Offset = "0x3459E80", VA = "0x18345B880")]
		private void Initialize()
		{
		}

		// Token: 0x06002F3C RID: 12092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F3C")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SnowMaterialSwapper()
		{
		}

		// Token: 0x040028EA RID: 10474
		[Token(Token = "0x40028EA")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Material, Material> NonSnowMaterials;

		// Token: 0x040028EB RID: 10475
		[Token(Token = "0x40028EB")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int EnableSnow;
	}
}
