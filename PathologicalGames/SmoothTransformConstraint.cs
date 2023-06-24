using System;
using Il2CppDummyDll;
using UnityEngine;

namespace PathologicalGames
{
	// Token: 0x02000062 RID: 98
	[Token(Token = "0x2000062")]
	[AddComponentMenu("Path-o-logical/UnityConstraints/Constraint - Transform - Smooth")]
	public class SmoothTransformConstraint : TransformConstraint
	{
		// Token: 0x0600029C RID: 668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x28D3DE0", Offset = "0x28D23E0", VA = "0x1828D3DE0", Slot = "9")]
		protected override void OnConstraintUpdate()
		{
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x28D3FA0", Offset = "0x28D25A0", VA = "0x1828D3FA0", Slot = "11")]
		protected override void NoTargetDefault()
		{
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x28D4170", Offset = "0x28D2770", VA = "0x1828D4170")]
		private void OutputPositionTowards(Vector3 destPos)
		{
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x28D4660", Offset = "0x28D2C60", VA = "0x1828D4660")]
		private void OutputRotationTowards(Quaternion destRot)
		{
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x28D46C0", Offset = "0x28D2CC0", VA = "0x1828D46C0", Slot = "12")]
		public override void SetWorldScale(Transform sourceXform)
		{
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x28D4840", Offset = "0x28D2E40", VA = "0x1828D4840")]
		public SmoothTransformConstraint()
		{
		}

		// Token: 0x04000173 RID: 371
		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x80")]
		public float positionSpeed;

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x84")]
		public float rotationSpeed;

		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x88")]
		public float scaleSpeed;

		// Token: 0x04000176 RID: 374
		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x8C")]
		public UnityConstraints.INTERP_OPTIONS interpolation;

		// Token: 0x04000177 RID: 375
		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x90")]
		public float positionMaxSpeed;

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x94")]
		public SmoothTransformConstraint.INTERP_OPTIONS_POS position_interpolation;

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x98")]
		private Vector3 curDampVelocity;

		// Token: 0x02000063 RID: 99
		[Token(Token = "0x2000063")]
		public enum INTERP_OPTIONS_POS
		{
			// Token: 0x0400017B RID: 379
			[Token(Token = "0x400017B")]
			Linear,
			// Token: 0x0400017C RID: 380
			[Token(Token = "0x400017C")]
			Damp,
			// Token: 0x0400017D RID: 381
			[Token(Token = "0x400017D")]
			DampLimited
		}
	}
}
