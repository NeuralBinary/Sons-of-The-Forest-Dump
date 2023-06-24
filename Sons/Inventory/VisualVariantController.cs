using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x0200063A RID: 1594
	[Token(Token = "0x200063A")]
	public class VisualVariantController : MonoBehaviour
	{
		// Token: 0x06002955 RID: 10581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002955")]
		[Address(RVA = "0x33EB570", Offset = "0x33E9B70", VA = "0x1833EB570")]
		public void ToggleVariant(uint num)
		{
		}

		// Token: 0x06002956 RID: 10582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002956")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public VisualVariantController()
		{
		}

		// Token: 0x040024E9 RID: 9449
		[Token(Token = "0x40024E9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private VisualVariantController.VisualData[] _visuals;

		// Token: 0x0200063B RID: 1595
		[Token(Token = "0x200063B")]
		[Serializable]
		public class VisualData
		{
			// Token: 0x06002957 RID: 10583 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002957")]
			[Address(RVA = "0x33EB740", Offset = "0x33E9D40", VA = "0x1833EB740")]
			public void ToggleVariant(uint num)
			{
			}

			// Token: 0x06002958 RID: 10584 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002958")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public VisualData()
			{
			}

			// Token: 0x040024EA RID: 9450
			[Token(Token = "0x40024EA")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Renderer _renderer;

			// Token: 0x040024EB RID: 9451
			[Token(Token = "0x40024EB")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private VisualVariantController.VariantData[] _variants;
		}

		// Token: 0x0200063C RID: 1596
		[Token(Token = "0x200063C")]
		[Serializable]
		public class VariantData
		{
			// Token: 0x17000567 RID: 1383
			// (get) Token: 0x06002959 RID: 10585 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000567")]
			public Material Material
			{
				[Token(Token = "0x6002959")]
				[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000568 RID: 1384
			// (get) Token: 0x0600295A RID: 10586 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000568")]
			public Mesh Mesh
			{
				[Token(Token = "0x600295A")]
				[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600295B RID: 10587 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600295B")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public VariantData()
			{
			}

			// Token: 0x040024EC RID: 9452
			[Token(Token = "0x40024EC")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Material _material;

			// Token: 0x040024ED RID: 9453
			[Token(Token = "0x40024ED")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Mesh _mesh;
		}
	}
}
