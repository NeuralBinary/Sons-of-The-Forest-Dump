using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x02000623 RID: 1571
	[Token(Token = "0x2000623")]
	public class VisualVariantController : MonoBehaviour
	{
		// Token: 0x06002829 RID: 10281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002829")]
		[Address(RVA = "0x2DC4F50", Offset = "0x2DC3F50", VA = "0x182DC4F50")]
		public void ToggleVariant(uint num)
		{
		}

		// Token: 0x0600282A RID: 10282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600282A")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public VisualVariantController()
		{
		}

		// Token: 0x040023F2 RID: 9202
		[Token(Token = "0x40023F2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private VisualVariantController.VisualData[] _visuals;

		// Token: 0x02000624 RID: 1572
		[Token(Token = "0x2000624")]
		[Serializable]
		public class VisualData
		{
			// Token: 0x0600282B RID: 10283 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600282B")]
			[Address(RVA = "0x2DC4E80", Offset = "0x2DC3E80", VA = "0x182DC4E80")]
			public void ToggleVariant(uint num)
			{
			}

			// Token: 0x0600282C RID: 10284 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600282C")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public VisualData()
			{
			}

			// Token: 0x040023F3 RID: 9203
			[Token(Token = "0x40023F3")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Renderer _renderer;

			// Token: 0x040023F4 RID: 9204
			[Token(Token = "0x40023F4")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private VisualVariantController.VariantData[] _variants;
		}

		// Token: 0x02000625 RID: 1573
		[Token(Token = "0x2000625")]
		[Serializable]
		public class VariantData
		{
			// Token: 0x1700054F RID: 1359
			// (get) Token: 0x0600282D RID: 10285 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700054F")]
			public Material Material
			{
				[Token(Token = "0x600282D")]
				[Address(RVA = "0x5430A0", Offset = "0x5420A0", VA = "0x1805430A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000550 RID: 1360
			// (get) Token: 0x0600282E RID: 10286 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000550")]
			public Mesh Mesh
			{
				[Token(Token = "0x600282E")]
				[Address(RVA = "0x57B1D0", Offset = "0x57A1D0", VA = "0x18057B1D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600282F RID: 10287 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600282F")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public VariantData()
			{
			}

			// Token: 0x040023F5 RID: 9205
			[Token(Token = "0x40023F5")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Material _material;

			// Token: 0x040023F6 RID: 9206
			[Token(Token = "0x40023F6")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Mesh _mesh;
		}
	}
}
