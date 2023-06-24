using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Ballistics
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	[Serializable]
	public struct ImpactInfo
	{
		// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x9047C0", Offset = "0x902DC0", VA = "0x1809047C0")]
		public ImpactInfo(Vector3 entryVelocity, Vector3 entryPosition, Vector3 exitVelocity, Vector3 exitPosition, BulletInfo bulletInfo, Weapon weapon)
		{
		}

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 entryVelocity;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0xC")]
		public Vector3 entryPosition;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 exitVelocity;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 exitPosition;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x30")]
		public BulletInfo bulletInfo;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x38")]
		public Weapon weapon;
	}
}
