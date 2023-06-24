using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	[ExecuteAlways]
	[AddComponentMenu("Shapes/Cuboid")]
	public class Cuboid : ShapeRenderer
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000015 RID: 21 RVA: 0x0000212C File Offset: 0x0000032C
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000008")]
		public Vector3 Size
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x2A1FF10", Offset = "0x2A1E510", VA = "0x182A1FF10")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x2A1FF30", Offset = "0x2A1E530", VA = "0x182A1FF30")]
			set
			{
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002144 File Offset: 0x00000344
		// (set) Token: 0x06000018 RID: 24 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000009")]
		public ThicknessSpace SizeSpace
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0xA03D80", Offset = "0xA02380", VA = "0x180A03D80")]
			get
			{
				return ThicknessSpace.Meters;
			}
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x2A1FFD0", Offset = "0x2A1E5D0", VA = "0x182A1FFD0")]
			set
			{
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2A20070", Offset = "0x2A1E670", VA = "0x182A20070", Slot = "11")]
		private protected override void SetAllMaterialProperties()
		{
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001A RID: 26 RVA: 0x0000215C File Offset: 0x0000035C
		[Token(Token = "0x1700000A")]
		internal override bool HasDetailLevels
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002174 File Offset: 0x00000374
		[Token(Token = "0x1700000B")]
		internal override bool HasScaleModes
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2A20140", Offset = "0x2A1E740", VA = "0x182A20140", Slot = "12")]
		private protected override void ShapeClampRanges()
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2A201B0", Offset = "0x2A1E7B0", VA = "0x182A201B0", Slot = "13")]
		private protected override Material[] GetMaterials()
		{
			return null;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x2A202A0", Offset = "0x2A1E8A0", VA = "0x182A202A0", Slot = "15")]
		private protected override Mesh GetInitialMeshAsset()
		{
			return null;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2A202E0", Offset = "0x2A1E8E0", VA = "0x182A202E0", Slot = "10")]
		private protected override Bounds GetBounds_Internal()
		{
			return default(Bounds);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2A20400", Offset = "0x2A1EA00", VA = "0x182A20400")]
		public Cuboid()
		{
		}

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Vector3 size;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private ThicknessSpace sizeSpace;
	}
}
