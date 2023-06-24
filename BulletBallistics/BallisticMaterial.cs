using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Ballistics
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	[CreateAssetMenu(fileName = "NewBallisticMaterial", menuName = "Ballistics/Material", order = 0)]
	public class BallisticMaterial : ScriptableObject
	{
		// Token: 0x06000050 RID: 80 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x90D530", Offset = "0x90BB30", VA = "0x18090D530")]
		public float evaluateRicochetProbability(float impactAngle)
		{
			return 0f;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x90D570", Offset = "0x90BB70", VA = "0x18090D570")]
		public BallisticMaterial()
		{
		}

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x18")]
		public bool doNotTriggerSpawningOfProjectileImpactObjects;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x1C")]
		public float energyLossPerUnit;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x20")]
		public bool stopOnImpact;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x24")]
		public float spread;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x28")]
		public ImpactObject impactObject;

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x30")]
		public float spreadRicochet;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		public float ricochetProbabilityMin;

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float ricochetProbabilityMax;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float bounciness;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x40")]
		public bool isLiquid;
	}
}
