using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	[ExecuteAlways]
	[AddComponentMenu("Shapes/Cone")]
	public class Cone : ShapeRenderer
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000001")]
		public float Radius
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x2403EB0", Offset = "0x24024B0", VA = "0x182403EB0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x2A1F960", Offset = "0x2A1DF60", VA = "0x182A1F960")]
			set
			{
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002080 File Offset: 0x00000280
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000002")]
		public float Length
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x728300", Offset = "0x726900", VA = "0x180728300")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x2A1F9E0", Offset = "0x2A1DFE0", VA = "0x182A1F9E0")]
			set
			{
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002098 File Offset: 0x00000298
		// (set) Token: 0x06000008 RID: 8 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000003")]
		[Obsolete("this property is obsolete I'm sorry! this was a typo, please use SizeSpace instead!", true)]
		public ThicknessSpace RadiusSpace
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0xAFF330", Offset = "0xAFD930", VA = "0x180AFF330")]
			get
			{
				return ThicknessSpace.Meters;
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x2A1FA60", Offset = "0x2A1E060", VA = "0x182A1FA60")]
			set
			{
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000020B0 File Offset: 0x000002B0
		// (set) Token: 0x0600000A RID: 10 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000004")]
		public ThicknessSpace SizeSpace
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0xAFF330", Offset = "0xAFD930", VA = "0x180AFF330")]
			get
			{
				return ThicknessSpace.Meters;
			}
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x2A1FA60", Offset = "0x2A1E060", VA = "0x182A1FA60")]
			set
			{
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000020C8 File Offset: 0x000002C8
		// (set) Token: 0x0600000C RID: 12 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000005")]
		public bool FillCap
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x2A1FB00", Offset = "0x2A1E100", VA = "0x182A1FB00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x2A1FB10", Offset = "0x2A1E110", VA = "0x182A1FB10")]
			set
			{
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2A1FB20", Offset = "0x2A1E120", VA = "0x182A1FB20", Slot = "11")]
		private protected override void SetAllMaterialProperties()
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2A1FC00", Offset = "0x2A1E200", VA = "0x182A1FC00", Slot = "12")]
		private protected override void ShapeClampRanges()
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000020E0 File Offset: 0x000002E0
		[Token(Token = "0x17000006")]
		internal override bool HasDetailLevels
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000020F8 File Offset: 0x000002F8
		[Token(Token = "0x17000007")]
		internal override bool HasScaleModes
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2A1FC30", Offset = "0x2A1E230", VA = "0x182A1FC30", Slot = "13")]
		private protected override Material[] GetMaterials()
		{
			return null;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2A1FD20", Offset = "0x2A1E320", VA = "0x182A1FD20", Slot = "15")]
		private protected override Mesh GetInitialMeshAsset()
		{
			return null;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002114 File Offset: 0x00000314
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2A1FD90", Offset = "0x2A1E390", VA = "0x182A1FD90", Slot = "10")]
		private protected override Bounds GetBounds_Internal()
		{
			return default(Bounds);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2A1FEE0", Offset = "0x2A1E4E0", VA = "0x182A1FEE0")]
		public Cone()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float radius;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private float length;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private ThicknessSpace sizeSpace;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private bool fillCap;
	}
}
