using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x0200015F RID: 351
	[Token(Token = "0x200015F")]
	public struct Edge : IBounded
	{
		// Token: 0x060006FA RID: 1786 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x27CFD40", Offset = "0x27CE340", VA = "0x1827CFD40")]
		public Edge(int i1, int i2, Vector2 v1, Vector2 v2)
		{
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00004454 File Offset: 0x00002654
		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xF9D4D0", Offset = "0xF9BAD0", VA = "0x180F9D4D0", Slot = "4")]
		public Aabb GetBounds()
		{
			return default(Aabb);
		}

		// Token: 0x040005E1 RID: 1505
		[Token(Token = "0x40005E1")]
		[FieldOffset(Offset = "0x0")]
		public int i1;

		// Token: 0x040005E2 RID: 1506
		[Token(Token = "0x40005E2")]
		[FieldOffset(Offset = "0x4")]
		public int i2;

		// Token: 0x040005E3 RID: 1507
		[Token(Token = "0x40005E3")]
		[FieldOffset(Offset = "0x8")]
		private Aabb b;
	}
}
