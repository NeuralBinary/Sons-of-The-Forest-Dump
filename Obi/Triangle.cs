using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x0200016A RID: 362
	[Token(Token = "0x200016A")]
	public struct Triangle : IBounded
	{
		// Token: 0x0600071A RID: 1818 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600071A")]
		[Address(RVA = "0x27D2F90", Offset = "0x27D1590", VA = "0x1827D2F90")]
		public Triangle(int i1, int i2, int i3, Vector3 v1, Vector3 v2, Vector3 v3)
		{
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00004484 File Offset: 0x00002684
		[Token(Token = "0x600071B")]
		[Address(RVA = "0x27D31B0", Offset = "0x27D17B0", VA = "0x1827D31B0", Slot = "4")]
		public Aabb GetBounds()
		{
			return default(Aabb);
		}

		// Token: 0x040005FE RID: 1534
		[Token(Token = "0x40005FE")]
		[FieldOffset(Offset = "0x0")]
		public int i1;

		// Token: 0x040005FF RID: 1535
		[Token(Token = "0x40005FF")]
		[FieldOffset(Offset = "0x4")]
		public int i2;

		// Token: 0x04000600 RID: 1536
		[Token(Token = "0x4000600")]
		[FieldOffset(Offset = "0x8")]
		public int i3;

		// Token: 0x04000601 RID: 1537
		[Token(Token = "0x4000601")]
		[FieldOffset(Offset = "0xC")]
		private Aabb b;
	}
}
