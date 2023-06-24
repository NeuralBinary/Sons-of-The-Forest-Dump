using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000174 RID: 372
	[Token(Token = "0x2000174")]
	[Serializable]
	public struct DFNode
	{
		// Token: 0x0600073B RID: 1851 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600073B")]
		[Address(RVA = "0x27D6350", Offset = "0x27D4950", VA = "0x1827D6350")]
		public DFNode(Vector4 center)
		{
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x0000452C File Offset: 0x0000272C
		[Token(Token = "0x600073C")]
		[Address(RVA = "0x27D63F0", Offset = "0x27D49F0", VA = "0x1827D63F0")]
		public float Sample(Vector3 position)
		{
			return 0f;
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00004544 File Offset: 0x00002744
		[Token(Token = "0x600073D")]
		[Address(RVA = "0x27D6520", Offset = "0x27D4B20", VA = "0x1827D6520")]
		public Vector3 GetNormalizedPos(Vector3 position)
		{
			return default(Vector3);
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x0000455C File Offset: 0x0000275C
		[Token(Token = "0x600073E")]
		[Address(RVA = "0x27D6590", Offset = "0x27D4B90", VA = "0x1827D6590")]
		public int GetOctant(Vector3 position)
		{
			return 0;
		}

		// Token: 0x04000628 RID: 1576
		[Token(Token = "0x4000628")]
		[FieldOffset(Offset = "0x0")]
		public Vector4 distancesA;

		// Token: 0x04000629 RID: 1577
		[Token(Token = "0x4000629")]
		[FieldOffset(Offset = "0x10")]
		public Vector4 distancesB;

		// Token: 0x0400062A RID: 1578
		[Token(Token = "0x400062A")]
		[FieldOffset(Offset = "0x20")]
		public Vector4 center;

		// Token: 0x0400062B RID: 1579
		[Token(Token = "0x400062B")]
		[FieldOffset(Offset = "0x30")]
		public int firstChild;

		// Token: 0x0400062C RID: 1580
		[Token(Token = "0x400062C")]
		[FieldOffset(Offset = "0x34")]
		private int pad0;

		// Token: 0x0400062D RID: 1581
		[Token(Token = "0x400062D")]
		[FieldOffset(Offset = "0x38")]
		private int pad1;

		// Token: 0x0400062E RID: 1582
		[Token(Token = "0x400062E")]
		[FieldOffset(Offset = "0x3C")]
		private int pad2;
	}
}
