using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Crafting.Structures
{
	// Token: 0x020007EE RID: 2030
	[Token(Token = "0x20007EE")]
	public class SnowMaterialSwapper : MonoBehaviour
	{
		// Token: 0x0600359A RID: 13722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600359A")]
		[Address(RVA = "0x2E9D910", Offset = "0x2E9C910", VA = "0x182E9D910")]
		private void Start()
		{
		}

		// Token: 0x0600359B RID: 13723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600359B")]
		[Address(RVA = "0x2E9D710", Offset = "0x2E9C710", VA = "0x182E9D710")]
		private void Initialize()
		{
		}

		// Token: 0x0600359C RID: 13724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600359C")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public SnowMaterialSwapper()
		{
		}

		// Token: 0x04002DFE RID: 11774
		[Token(Token = "0x4002DFE")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Material, Material> NonSnowMaterials;

		// Token: 0x04002DFF RID: 11775
		[Token(Token = "0x4002DFF")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int EnableSnow;
	}
}
