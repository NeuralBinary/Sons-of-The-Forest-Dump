using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Ballistics
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	public struct BulletExit
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x906250", Offset = "0x904850", VA = "0x180906250")]
		public BulletExit(BulletImpact entryImpact, RaycastHit exitRaycastHit)
		{
		}

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x0")]
		public BulletImpact entryImpact;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x30")]
		public RaycastHit exitRaycastHit;
	}
}
