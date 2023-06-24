using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Ballistics
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	public struct BulletData
	{
		// Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x905CD0", Offset = "0x9042D0", VA = "0x180905CD0")]
		public BulletData(BulletInfo info, Vector3 position, Vector3 direction, float lifeTime, Bullet visualBullet, Weapon weapon)
		{
		}

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x0")]
		public BulletInfo info;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x8")]
		public Vector3 position;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 velocity;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x20")]
		public List<BulletImpact> bulletImpacts;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x28")]
		public float flyTime;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x2C")]
		public float lifeTime;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x30")]
		public Bullet visualBullet;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 visualOffset;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x48")]
		public Weapon weapon;
	}
}
