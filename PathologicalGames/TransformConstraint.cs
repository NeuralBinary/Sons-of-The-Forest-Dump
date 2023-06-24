using System;
using Il2CppDummyDll;
using UnityEngine;

namespace PathologicalGames
{
	// Token: 0x02000064 RID: 100
	[Token(Token = "0x2000064")]
	[AddComponentMenu("Path-o-logical/UnityConstraints/Constraint - Transform (Postion, Rotation, Scale)")]
	public class TransformConstraint : ConstraintBaseClass
	{
		// Token: 0x060002A2 RID: 674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x28D4910", Offset = "0x28D2F10", VA = "0x1828D4910", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x28D49D0", Offset = "0x28D2FD0", VA = "0x1828D49D0", Slot = "9")]
		protected override void OnConstraintUpdate()
		{
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x28D4DD0", Offset = "0x28D33D0", VA = "0x1828D4DD0", Slot = "11")]
		protected override void NoTargetDefault()
		{
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x28D4FB0", Offset = "0x28D35B0", VA = "0x1828D4FB0", Slot = "12")]
		public virtual void SetWorldScale(Transform sourceXform)
		{
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00002B08 File Offset: 0x00000D08
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x28D5040", Offset = "0x28D3640", VA = "0x1828D5040")]
		internal Vector3 GetTargetLocalScale(Transform sourceXform)
		{
			return default(Vector3);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x28D5570", Offset = "0x28D3B70", VA = "0x1828D5570")]
		public TransformConstraint()
		{
		}

		// Token: 0x0400017E RID: 382
		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x68")]
		public bool constrainPosition;

		// Token: 0x0400017F RID: 383
		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x69")]
		public bool outputPosX;

		// Token: 0x04000180 RID: 384
		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x6A")]
		public bool outputPosY;

		// Token: 0x04000181 RID: 385
		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x6B")]
		public bool outputPosZ;

		// Token: 0x04000182 RID: 386
		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x6C")]
		public bool constrainRotation;

		// Token: 0x04000183 RID: 387
		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x70")]
		public UnityConstraints.OUTPUT_ROT_OPTIONS output;

		// Token: 0x04000184 RID: 388
		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x74")]
		public bool constrainScale;

		// Token: 0x04000185 RID: 389
		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x78")]
		internal Transform parXform;

		// Token: 0x04000186 RID: 390
		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x0")]
		internal static Transform scaleCalculator;
	}
}
