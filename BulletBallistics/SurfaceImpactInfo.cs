using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Ballistics
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	[Serializable]
	public struct SurfaceImpactInfo
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x9046D0", Offset = "0x902CD0", VA = "0x1809046D0")]
		public SurfaceImpactInfo(RaycastHit rayHit, Vector3 impactVelocity, BulletInfo bulletInfo, Weapon weapon, bool isLiquid)
		{
		}

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x0")]
		public RaycastHit rayHit;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 impactVelocity;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x38")]
		public BulletInfo bulletInfo;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x40")]
		public Weapon weapon;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x48")]
		public bool isLiquid;
	}
}
