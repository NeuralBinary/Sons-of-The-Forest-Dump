using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001CD RID: 461
	[Token(Token = "0x20001CD")]
	public struct Box3f
	{
		// Token: 0x06000D75 RID: 3445 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D75")]
		[Address(RVA = "0x203A070", Offset = "0x2038670", VA = "0x18203A070")]
		public Box3f(Vector3f center)
		{
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D76")]
		[Address(RVA = "0x203A150", Offset = "0x2038750", VA = "0x18203A150")]
		public Box3f(Vector3f center, Vector3f x, Vector3f y, Vector3f z, Vector3f extent)
		{
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D77")]
		[Address(RVA = "0x203A1B0", Offset = "0x20387B0", VA = "0x18203A1B0")]
		public Box3f(Vector3f center, Vector3f extent)
		{
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D78")]
		[Address(RVA = "0x203A290", Offset = "0x2038890", VA = "0x18203A290")]
		public Box3f(AxisAlignedBox3f aaBox)
		{
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x00009B3C File Offset: 0x00007D3C
		[Token(Token = "0x6000D79")]
		[Address(RVA = "0x203A410", Offset = "0x2038A10", VA = "0x18203A410")]
		public Vector3f Axis(int i)
		{
			return default(Vector3f);
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000D7A")]
		[Address(RVA = "0x203A460", Offset = "0x2038A60", VA = "0x18203A460")]
		public Vector3f[] ComputeVertices()
		{
			return null;
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D7B")]
		[Address(RVA = "0x203A4C0", Offset = "0x2038AC0", VA = "0x18203A4C0")]
		public void ComputeVertices(Vector3f[] vertex)
		{
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000D7C")]
		[Address(RVA = "0x203A9A0", Offset = "0x2038FA0", VA = "0x18203A9A0")]
		public IEnumerable<Vector3f> VerticesItr()
		{
			return null;
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x00009B54 File Offset: 0x00007D54
		[Token(Token = "0x6000D7D")]
		[Address(RVA = "0x203AA30", Offset = "0x2039030", VA = "0x18203AA30")]
		public AxisAlignedBox3f ToAABB()
		{
			return default(AxisAlignedBox3f);
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000D7E RID: 3454 RVA: 0x00009B6C File Offset: 0x00007D6C
		[Token(Token = "0x1700025A")]
		public double MaxExtent
		{
			[Token(Token = "0x6000D7E")]
			[Address(RVA = "0x203AF10", Offset = "0x2039510", VA = "0x18203AF10")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000D7F RID: 3455 RVA: 0x00009B84 File Offset: 0x00007D84
		[Token(Token = "0x1700025B")]
		public double MinExtent
		{
			[Token(Token = "0x6000D7F")]
			[Address(RVA = "0x203AFD0", Offset = "0x20395D0", VA = "0x18203AFD0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000D80 RID: 3456 RVA: 0x00009B9C File Offset: 0x00007D9C
		[Token(Token = "0x1700025C")]
		public Vector3f Diagonal
		{
			[Token(Token = "0x6000D80")]
			[Address(RVA = "0x203B090", Offset = "0x2039690", VA = "0x18203B090")]
			get
			{
				return default(Vector3f);
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000D81 RID: 3457 RVA: 0x00009BB4 File Offset: 0x00007DB4
		[Token(Token = "0x1700025D")]
		public double Volume
		{
			[Token(Token = "0x6000D81")]
			[Address(RVA = "0x203B280", Offset = "0x2039880", VA = "0x18203B280")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D82")]
		[Address(RVA = "0x203B2A0", Offset = "0x20398A0", VA = "0x18203B2A0")]
		public void Contain(Vector3f v)
		{
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D83")]
		[Address(RVA = "0x203B5C0", Offset = "0x2039BC0", VA = "0x18203B5C0")]
		public void Contain(Box3f o)
		{
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x00009BCC File Offset: 0x00007DCC
		[Token(Token = "0x6000D84")]
		[Address(RVA = "0x203B670", Offset = "0x2039C70", VA = "0x18203B670")]
		public bool Contains(Vector3f v)
		{
			return default(bool);
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D85")]
		[Address(RVA = "0x203B850", Offset = "0x2039E50", VA = "0x18203B850")]
		public void Expand(float f)
		{
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D86")]
		[Address(RVA = "0x203B8F0", Offset = "0x2039EF0", VA = "0x18203B8F0")]
		public void Translate(Vector3f v)
		{
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D87")]
		[Address(RVA = "0x203B9A0", Offset = "0x2039FA0", VA = "0x18203B9A0")]
		public void Scale(Vector3f s)
		{
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D88")]
		[Address(RVA = "0x203BBB0", Offset = "0x203A1B0", VA = "0x18203BBB0")]
		public void ScaleExtents(Vector3f s)
		{
		}

		// Token: 0x04000759 RID: 1881
		[Token(Token = "0x4000759")]
		[FieldOffset(Offset = "0x0")]
		public Vector3f Center;

		// Token: 0x0400075A RID: 1882
		[Token(Token = "0x400075A")]
		[FieldOffset(Offset = "0xC")]
		public Vector3f AxisX;

		// Token: 0x0400075B RID: 1883
		[Token(Token = "0x400075B")]
		[FieldOffset(Offset = "0x18")]
		public Vector3f AxisY;

		// Token: 0x0400075C RID: 1884
		[Token(Token = "0x400075C")]
		[FieldOffset(Offset = "0x24")]
		public Vector3f AxisZ;

		// Token: 0x0400075D RID: 1885
		[Token(Token = "0x400075D")]
		[FieldOffset(Offset = "0x30")]
		public Vector3f Extent;

		// Token: 0x0400075E RID: 1886
		[Token(Token = "0x400075E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Box3f Empty;
	}
}
