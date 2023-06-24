using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Ballistics
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	public class ImpactObject : PoolingObject
	{
		// Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x90A180", Offset = "0x908780", VA = "0x18090A180", Slot = "5")]
		public virtual void Impact(SurfaceImpactInfo surfaceImpactInfo)
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x674030", Offset = "0x672630", VA = "0x180674030")]
		public void SetBulletId(int id)
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x90A1D0", Offset = "0x9087D0", VA = "0x18090A1D0")]
		public ImpactObject()
		{
		}

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Time in seconds.")]
		public float lifeTime;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x2C")]
		public int bulletId;
	}
}
