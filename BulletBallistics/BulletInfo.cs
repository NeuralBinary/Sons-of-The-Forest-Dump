using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Ballistics
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	[Serializable]
	public class BulletInfo : ICloneable
	{
		// Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x905AF0", Offset = "0x9040F0", VA = "0x180905AF0")]
		public BulletInfo(float muzzleDamage, float maxSpeed, float weight, float diameter, float dragCoefficient, LayerMask hitMask, ImpactObject impactObject, float ricochetProbabilityMultiplier)
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x905BA0", Offset = "0x9041A0", VA = "0x180905BA0")]
		public void precalculateDrag()
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x905BD0", Offset = "0x9041D0", VA = "0x180905BD0", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x10")]
		public float muzzleDamage;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x14")]
		public float maxSpeed;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x18")]
		public float weight;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x1C")]
		public float diameter;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x20")]
		public float dragCoefficient;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x24")]
		public LayerMask hitMask;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x28")]
		public bool skipImpactObject;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x29")]
		public bool floatsInLiquid;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x30")]
		public ImpactObject impactObject;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x38")]
		public float ricochetProbabilityMultiplier;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x3C")]
		public float precalculatedDrag;
	}
}
