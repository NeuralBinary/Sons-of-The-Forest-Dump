using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020000B9 RID: 185
	[Token(Token = "0x20000B9")]
	public struct BurstCollisionMaterial
	{
		// Token: 0x060003B6 RID: 950 RVA: 0x0000371C File Offset: 0x0000191C
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x279A190", Offset = "0x2798790", VA = "0x18279A190")]
		public static BurstCollisionMaterial CombineWith(BurstCollisionMaterial a, BurstCollisionMaterial b)
		{
			return default(BurstCollisionMaterial);
		}

		// Token: 0x04000416 RID: 1046
		[Token(Token = "0x4000416")]
		[FieldOffset(Offset = "0x0")]
		public float dynamicFriction;

		// Token: 0x04000417 RID: 1047
		[Token(Token = "0x4000417")]
		[FieldOffset(Offset = "0x4")]
		public float staticFriction;

		// Token: 0x04000418 RID: 1048
		[Token(Token = "0x4000418")]
		[FieldOffset(Offset = "0x8")]
		public float rollingFriction;

		// Token: 0x04000419 RID: 1049
		[Token(Token = "0x4000419")]
		[FieldOffset(Offset = "0xC")]
		public float stickiness;

		// Token: 0x0400041A RID: 1050
		[Token(Token = "0x400041A")]
		[FieldOffset(Offset = "0x10")]
		public float stickDistance;

		// Token: 0x0400041B RID: 1051
		[Token(Token = "0x400041B")]
		[FieldOffset(Offset = "0x14")]
		public Oni.MaterialCombineMode frictionCombine;

		// Token: 0x0400041C RID: 1052
		[Token(Token = "0x400041C")]
		[FieldOffset(Offset = "0x18")]
		public Oni.MaterialCombineMode stickinessCombine;

		// Token: 0x0400041D RID: 1053
		[Token(Token = "0x400041D")]
		[FieldOffset(Offset = "0x1C")]
		public int rollingContacts;
	}
}
