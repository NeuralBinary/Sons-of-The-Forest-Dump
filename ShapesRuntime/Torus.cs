using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	[AddComponentMenu("Shapes/Torus")]
	[ExecuteAlways]
	public class Torus : ShapeRenderer
	{
		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000226 RID: 550 RVA: 0x00003704 File Offset: 0x00001904
		// (set) Token: 0x06000227 RID: 551 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000DA")]
		public float Radius
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x2403EB0", Offset = "0x24024B0", VA = "0x182403EB0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x2A310F0", Offset = "0x2A2F6F0", VA = "0x182A310F0")]
			set
			{
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000228 RID: 552 RVA: 0x0000371C File Offset: 0x0000191C
		// (set) Token: 0x06000229 RID: 553 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000DB")]
		public float Thickness
		{
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x728300", Offset = "0x726900", VA = "0x180728300")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x2A31170", Offset = "0x2A2F770", VA = "0x182A31170")]
			set
			{
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600022A RID: 554 RVA: 0x00003734 File Offset: 0x00001934
		// (set) Token: 0x0600022B RID: 555 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000DC")]
		public ThicknessSpace ThicknessSpace
		{
			[Token(Token = "0x600022A")]
			[Address(RVA = "0xAFF330", Offset = "0xAFD930", VA = "0x180AFF330")]
			get
			{
				return ThicknessSpace.Meters;
			}
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x2A311F0", Offset = "0x2A2F7F0", VA = "0x182A311F0")]
			set
			{
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600022C RID: 556 RVA: 0x0000374C File Offset: 0x0000194C
		// (set) Token: 0x0600022D RID: 557 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000DD")]
		public ThicknessSpace RadiusSpace
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0xA03D80", Offset = "0xA02380", VA = "0x180A03D80")]
			get
			{
				return ThicknessSpace.Meters;
			}
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x2A31290", Offset = "0x2A2F890", VA = "0x182A31290")]
			set
			{
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600022E RID: 558 RVA: 0x00003764 File Offset: 0x00001964
		// (set) Token: 0x0600022F RID: 559 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000DE")]
		public float AngRadiansStart
		{
			[Token(Token = "0x600022E")]
			[Address(RVA = "0x2403F10", Offset = "0x2402510", VA = "0x182403F10")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x2A31330", Offset = "0x2A2F930", VA = "0x182A31330")]
			set
			{
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000230 RID: 560 RVA: 0x0000377C File Offset: 0x0000197C
		// (set) Token: 0x06000231 RID: 561 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000DF")]
		public float AngRadiansEnd
		{
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x2403F30", Offset = "0x2402530", VA = "0x182403F30")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x2A313B0", Offset = "0x2A2F9B0", VA = "0x182A313B0")]
			set
			{
			}
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x2A31430", Offset = "0x2A2FA30", VA = "0x182A31430", Slot = "11")]
		private protected override void SetAllMaterialProperties()
		{
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x2A1FC00", Offset = "0x2A1E200", VA = "0x182A1FC00", Slot = "12")]
		private protected override void ShapeClampRanges()
		{
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000234 RID: 564 RVA: 0x00003794 File Offset: 0x00001994
		[Token(Token = "0x170000E0")]
		internal override bool HasDetailLevels
		{
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x2A315A0", Offset = "0x2A2FBA0", VA = "0x182A315A0", Slot = "13")]
		private protected override Material[] GetMaterials()
		{
			return null;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x2A31690", Offset = "0x2A2FC90", VA = "0x182A31690", Slot = "15")]
		private protected override Mesh GetInitialMeshAsset()
		{
			return null;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x000037AC File Offset: 0x000019AC
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x2A316D0", Offset = "0x2A2FCD0", VA = "0x182A316D0", Slot = "10")]
		private protected override Bounds GetBounds_Internal()
		{
			return default(Bounds);
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x2A31810", Offset = "0x2A2FE10", VA = "0x182A31810")]
		public Torus()
		{
		}

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float radius;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private float thickness;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private ThicknessSpace thicknessSpace;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private ThicknessSpace radiusSpace;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private AngularUnit angUnitInput;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private float angRadiansStart;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float angRadiansEnd;
	}
}
