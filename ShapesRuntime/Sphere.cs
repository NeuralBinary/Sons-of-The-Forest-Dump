using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	[AddComponentMenu("Shapes/Sphere")]
	[ExecuteAlways]
	public class Sphere : ShapeRenderer
	{
		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600021A RID: 538 RVA: 0x0000368C File Offset: 0x0000188C
		// (set) Token: 0x0600021B RID: 539 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000D6")]
		public float Radius
		{
			[Token(Token = "0x600021A")]
			[Address(RVA = "0x2403EB0", Offset = "0x24024B0", VA = "0x182403EB0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600021B")]
			[Address(RVA = "0x2A30BF0", Offset = "0x2A2F1F0", VA = "0x182A30BF0")]
			set
			{
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600021C RID: 540 RVA: 0x000036A4 File Offset: 0x000018A4
		// (set) Token: 0x0600021D RID: 541 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000D7")]
		public ThicknessSpace RadiusSpace
		{
			[Token(Token = "0x600021C")]
			[Address(RVA = "0xAFF310", Offset = "0xAFD910", VA = "0x180AFF310")]
			get
			{
				return ThicknessSpace.Meters;
			}
			[Token(Token = "0x600021D")]
			[Address(RVA = "0x2A30C70", Offset = "0x2A2F270", VA = "0x182A30C70")]
			set
			{
			}
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x2A30D10", Offset = "0x2A2F310", VA = "0x182A30D10", Slot = "11")]
		private protected override void SetAllMaterialProperties()
		{
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600021F RID: 543 RVA: 0x000036BC File Offset: 0x000018BC
		[Token(Token = "0x170000D8")]
		internal override bool HasDetailLevels
		{
			[Token(Token = "0x600021F")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000220 RID: 544 RVA: 0x000036D4 File Offset: 0x000018D4
		[Token(Token = "0x170000D9")]
		internal override bool HasScaleModes
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x2A30DD0", Offset = "0x2A2F3D0", VA = "0x182A30DD0", Slot = "12")]
		private protected override void ShapeClampRanges()
		{
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x2A30DF0", Offset = "0x2A2F3F0", VA = "0x182A30DF0", Slot = "13")]
		private protected override Material[] GetMaterials()
		{
			return null;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x2A30EE0", Offset = "0x2A2F4E0", VA = "0x182A30EE0", Slot = "15")]
		private protected override Mesh GetInitialMeshAsset()
		{
			return null;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x000036EC File Offset: 0x000018EC
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x2A30F20", Offset = "0x2A2F520", VA = "0x182A30F20", Slot = "10")]
		private protected override Bounds GetBounds_Internal()
		{
			return default(Bounds);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x2A310D0", Offset = "0x2A2F6D0", VA = "0x182A310D0")]
		public Sphere()
		{
		}

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float radius;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private ThicknessSpace radiusSpace;
	}
}
