using System;
using Il2CppDummyDll;
using UnityEngine;

namespace g3
{
	// Token: 0x020001C4 RID: 452
	[Token(Token = "0x20001C4")]
	public struct AxisAlignedBox3f : IComparable<AxisAlignedBox3f>, IEquatable<AxisAlignedBox3f>
	{
		// Token: 0x06000CAA RID: 3242 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CAA")]
		[Address(RVA = "0x202CEF0", Offset = "0x202B4F0", VA = "0x18202CEF0")]
		public AxisAlignedBox3f(bool bIgnore)
		{
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CAB")]
		[Address(RVA = "0x202CF40", Offset = "0x202B540", VA = "0x18202CF40")]
		public AxisAlignedBox3f(float xmin, float ymin, float zmin, float xmax, float ymax, float zmax)
		{
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CAC")]
		[Address(RVA = "0x202CF90", Offset = "0x202B590", VA = "0x18202CF90")]
		public AxisAlignedBox3f(float fCubeSize)
		{
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CAD")]
		[Address(RVA = "0x202CFD0", Offset = "0x202B5D0", VA = "0x18202CFD0")]
		public AxisAlignedBox3f(float fWidth, float fHeight, float fDepth)
		{
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CAE")]
		[Address(RVA = "0x202D010", Offset = "0x202B610", VA = "0x18202D010")]
		public AxisAlignedBox3f(Vector3f vMin, Vector3f vMax)
		{
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CAF")]
		[Address(RVA = "0x202D1A0", Offset = "0x202B7A0", VA = "0x18202D1A0")]
		public AxisAlignedBox3f(ref Vector3f vMin, ref Vector3f vMax)
		{
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CB0")]
		[Address(RVA = "0x202D330", Offset = "0x202B930", VA = "0x18202D330")]
		public AxisAlignedBox3f(Vector3f vCenter, float fHalfWidth, float fHalfHeight, float fHalfDepth)
		{
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CB1")]
		[Address(RVA = "0x202D3C0", Offset = "0x202B9C0", VA = "0x18202D3C0")]
		public AxisAlignedBox3f(ref Vector3f vCenter, float fHalfWidth, float fHalfHeight, float fHalfDepth)
		{
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CB2")]
		[Address(RVA = "0x202D430", Offset = "0x202BA30", VA = "0x18202D430")]
		public AxisAlignedBox3f(Vector3f vCenter, float fHalfSize)
		{
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CB3")]
		[Address(RVA = "0x202D4A0", Offset = "0x202BAA0", VA = "0x18202D4A0")]
		public AxisAlignedBox3f(Vector3f vCenter)
		{
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x0000920C File Offset: 0x0000740C
		[Token(Token = "0x17000236")]
		public float Width
		{
			[Token(Token = "0x6000CB4")]
			[Address(RVA = "0x202D4C0", Offset = "0x202BAC0", VA = "0x18202D4C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x00009224 File Offset: 0x00007424
		[Token(Token = "0x17000237")]
		public float Height
		{
			[Token(Token = "0x6000CB5")]
			[Address(RVA = "0x202D550", Offset = "0x202BB50", VA = "0x18202D550")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x0000923C File Offset: 0x0000743C
		[Token(Token = "0x17000238")]
		public float Depth
		{
			[Token(Token = "0x6000CB6")]
			[Address(RVA = "0x202D5E0", Offset = "0x202BBE0", VA = "0x18202D5E0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x00009254 File Offset: 0x00007454
		[Token(Token = "0x17000239")]
		public float Volume
		{
			[Token(Token = "0x6000CB7")]
			[Address(RVA = "0x202D670", Offset = "0x202BC70", VA = "0x18202D670")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x0000926C File Offset: 0x0000746C
		[Token(Token = "0x1700023A")]
		public float DiagonalLength
		{
			[Token(Token = "0x6000CB8")]
			[Address(RVA = "0x202D6C0", Offset = "0x202BCC0", VA = "0x18202D6C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x00009284 File Offset: 0x00007484
		[Token(Token = "0x1700023B")]
		public float MaxDim
		{
			[Token(Token = "0x6000CB9")]
			[Address(RVA = "0x202D7D0", Offset = "0x202BDD0", VA = "0x18202D7D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000CBA RID: 3258 RVA: 0x0000929C File Offset: 0x0000749C
		[Token(Token = "0x1700023C")]
		public Vector3f Diagonal
		{
			[Token(Token = "0x6000CBA")]
			[Address(RVA = "0x202D8A0", Offset = "0x202BEA0", VA = "0x18202D8A0")]
			get
			{
				return default(Vector3f);
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000CBB RID: 3259 RVA: 0x000092B4 File Offset: 0x000074B4
		[Token(Token = "0x1700023D")]
		public Vector3f Extents
		{
			[Token(Token = "0x6000CBB")]
			[Address(RVA = "0x202D8D0", Offset = "0x202BED0", VA = "0x18202D8D0")]
			get
			{
				return default(Vector3f);
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000CBC RID: 3260 RVA: 0x000092CC File Offset: 0x000074CC
		[Token(Token = "0x1700023E")]
		public Vector3f Center
		{
			[Token(Token = "0x6000CBC")]
			[Address(RVA = "0x202D930", Offset = "0x202BF30", VA = "0x18202D930")]
			get
			{
				return default(Vector3f);
			}
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x000092E4 File Offset: 0x000074E4
		[Token(Token = "0x6000CBD")]
		[Address(RVA = "0x202D990", Offset = "0x202BF90", VA = "0x18202D990")]
		public static bool operator ==(AxisAlignedBox3f a, AxisAlignedBox3f b)
		{
			return default(bool);
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x000092FC File Offset: 0x000074FC
		[Token(Token = "0x6000CBE")]
		[Address(RVA = "0x202DAB0", Offset = "0x202C0B0", VA = "0x18202DAB0")]
		public static bool operator !=(AxisAlignedBox3f a, AxisAlignedBox3f b)
		{
			return default(bool);
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x00009314 File Offset: 0x00007514
		[Token(Token = "0x6000CBF")]
		[Address(RVA = "0x202DBD0", Offset = "0x202C1D0", VA = "0x18202DBD0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x0000932C File Offset: 0x0000752C
		[Token(Token = "0x6000CC0")]
		[Address(RVA = "0x202DCA0", Offset = "0x202C2A0", VA = "0x18202DCA0", Slot = "5")]
		public bool Equals(AxisAlignedBox3f other)
		{
			return default(bool);
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x00009344 File Offset: 0x00007544
		[Token(Token = "0x6000CC1")]
		[Address(RVA = "0x202DD40", Offset = "0x202C340", VA = "0x18202DD40", Slot = "4")]
		public int CompareTo(AxisAlignedBox3f other)
		{
			return 0;
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x0000935C File Offset: 0x0000755C
		[Token(Token = "0x6000CC2")]
		[Address(RVA = "0x202DE20", Offset = "0x202C420", VA = "0x18202DE20", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x00009374 File Offset: 0x00007574
		[Token(Token = "0x6000CC3")]
		[Address(RVA = "0x202DE60", Offset = "0x202C460", VA = "0x18202DE60")]
		public Vector3f Corner(int i)
		{
			return default(Vector3f);
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x0000938C File Offset: 0x0000758C
		[Token(Token = "0x6000CC4")]
		[Address(RVA = "0x202DEE0", Offset = "0x202C4E0", VA = "0x18202DEE0")]
		public Vector3f Point(int xi, int yi, int zi)
		{
			return default(Vector3f);
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CC5")]
		[Address(RVA = "0x202DF70", Offset = "0x202C570", VA = "0x18202DF70")]
		public void Expand(float fRadius)
		{
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CC6")]
		[Address(RVA = "0x202DFC0", Offset = "0x202C5C0", VA = "0x18202DFC0")]
		public void Contract(float fRadius)
		{
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CC7")]
		[Address(RVA = "0x202E020", Offset = "0x202C620", VA = "0x18202E020")]
		public void Scale(float sx, float sy, float sz)
		{
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CC8")]
		[Address(RVA = "0x202E190", Offset = "0x202C790", VA = "0x18202E190")]
		public void Contain(Vector3f v)
		{
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CC9")]
		[Address(RVA = "0x202E2F0", Offset = "0x202C8F0", VA = "0x18202E2F0")]
		public void Contain(AxisAlignedBox3f box)
		{
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CCA")]
		[Address(RVA = "0x202E470", Offset = "0x202CA70", VA = "0x18202E470")]
		public void Contain(Vector3d v)
		{
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CCB")]
		[Address(RVA = "0x202E610", Offset = "0x202CC10", VA = "0x18202E610")]
		public void Contain(AxisAlignedBox3d box)
		{
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x000093A4 File Offset: 0x000075A4
		[Token(Token = "0x6000CCC")]
		[Address(RVA = "0x202E7B0", Offset = "0x202CDB0", VA = "0x18202E7B0")]
		public AxisAlignedBox3f Intersect(AxisAlignedBox3f box)
		{
			return default(AxisAlignedBox3f);
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x000093BC File Offset: 0x000075BC
		[Token(Token = "0x6000CCD")]
		[Address(RVA = "0x202EB60", Offset = "0x202D160", VA = "0x18202EB60")]
		public bool Contains(Vector3f v)
		{
			return default(bool);
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x000093D4 File Offset: 0x000075D4
		[Token(Token = "0x6000CCE")]
		[Address(RVA = "0x202EBB0", Offset = "0x202D1B0", VA = "0x18202EBB0")]
		public bool Intersects(AxisAlignedBox3f box)
		{
			return default(bool);
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x000093EC File Offset: 0x000075EC
		[Token(Token = "0x6000CCF")]
		[Address(RVA = "0x202EC10", Offset = "0x202D210", VA = "0x18202EC10")]
		public double DistanceSquared(Vector3f v)
		{
			return 0.0;
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x00009404 File Offset: 0x00007604
		[Token(Token = "0x6000CD0")]
		[Address(RVA = "0x202ECB0", Offset = "0x202D2B0", VA = "0x18202ECB0")]
		public float Distance(Vector3f v)
		{
			return 0f;
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x0000941C File Offset: 0x0000761C
		[Token(Token = "0x6000CD1")]
		[Address(RVA = "0x202EDE0", Offset = "0x202D3E0", VA = "0x18202EDE0")]
		public Vector3f NearestPoint(Vector3f v)
		{
			return default(Vector3f);
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CD2")]
		[Address(RVA = "0x202EE50", Offset = "0x202D450", VA = "0x18202EE50")]
		public void Translate(Vector3f vTranslate)
		{
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CD3")]
		[Address(RVA = "0x202EED0", Offset = "0x202D4D0", VA = "0x18202EED0")]
		public void MoveMin(Vector3f vNewMin)
		{
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CD4")]
		[Address(RVA = "0x202EF40", Offset = "0x202D540", VA = "0x18202EF40")]
		public void MoveMin(float fNewX, float fNewY, float fNewZ)
		{
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000CD5")]
		[Address(RVA = "0x202EF90", Offset = "0x202D590", VA = "0x18202EF90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x00009434 File Offset: 0x00007634
		[Token(Token = "0x6000CD6")]
		[Address(RVA = "0x202F240", Offset = "0x202D840", VA = "0x18202F240")]
		public static implicit operator AxisAlignedBox3f(Bounds b)
		{
			return default(AxisAlignedBox3f);
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x0000944C File Offset: 0x0000764C
		[Token(Token = "0x6000CD7")]
		[Address(RVA = "0x202F3A0", Offset = "0x202D9A0", VA = "0x18202F3A0")]
		public static implicit operator Bounds(AxisAlignedBox3f b)
		{
			return default(Bounds);
		}

		// Token: 0x04000723 RID: 1827
		[Token(Token = "0x4000723")]
		[FieldOffset(Offset = "0x0")]
		public Vector3f Min;

		// Token: 0x04000724 RID: 1828
		[Token(Token = "0x4000724")]
		[FieldOffset(Offset = "0xC")]
		public Vector3f Max;

		// Token: 0x04000725 RID: 1829
		[Token(Token = "0x4000725")]
		[FieldOffset(Offset = "0x0")]
		public static readonly AxisAlignedBox3f Empty;

		// Token: 0x04000726 RID: 1830
		[Token(Token = "0x4000726")]
		[FieldOffset(Offset = "0x18")]
		public static readonly AxisAlignedBox3f Zero;

		// Token: 0x04000727 RID: 1831
		[Token(Token = "0x4000727")]
		[FieldOffset(Offset = "0x30")]
		public static readonly AxisAlignedBox3f UnitPositive;

		// Token: 0x04000728 RID: 1832
		[Token(Token = "0x4000728")]
		[FieldOffset(Offset = "0x48")]
		public static readonly AxisAlignedBox3f Infinite;
	}
}
