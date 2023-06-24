using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x0200017C RID: 380
	[Token(Token = "0x200017C")]
	public struct CollisionMaterial
	{
		// Token: 0x0600074B RID: 1867 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600074B")]
		[Address(RVA = "0x27D8FE0", Offset = "0x27D75E0", VA = "0x1827D8FE0")]
		public void FromObiCollisionMaterial(ObiCollisionMaterial material)
		{
		}

		// Token: 0x04000651 RID: 1617
		[Token(Token = "0x4000651")]
		[FieldOffset(Offset = "0x0")]
		public float dynamicFriction;

		// Token: 0x04000652 RID: 1618
		[Token(Token = "0x4000652")]
		[FieldOffset(Offset = "0x4")]
		public float staticFriction;

		// Token: 0x04000653 RID: 1619
		[Token(Token = "0x4000653")]
		[FieldOffset(Offset = "0x8")]
		public float rollingFriction;

		// Token: 0x04000654 RID: 1620
		[Token(Token = "0x4000654")]
		[FieldOffset(Offset = "0xC")]
		public float stickiness;

		// Token: 0x04000655 RID: 1621
		[Token(Token = "0x4000655")]
		[FieldOffset(Offset = "0x10")]
		public float stickDistance;

		// Token: 0x04000656 RID: 1622
		[Token(Token = "0x4000656")]
		[FieldOffset(Offset = "0x14")]
		public Oni.MaterialCombineMode frictionCombine;

		// Token: 0x04000657 RID: 1623
		[Token(Token = "0x4000657")]
		[FieldOffset(Offset = "0x18")]
		public Oni.MaterialCombineMode stickinessCombine;

		// Token: 0x04000658 RID: 1624
		[Token(Token = "0x4000658")]
		[FieldOffset(Offset = "0x1C")]
		public int rollingContacts;
	}
}
