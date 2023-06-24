using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200002F RID: 47
	[Token(Token = "0x200002F")]
	[Serializable]
	public class ConstraintRotationOffset : Constraint
	{
		// Token: 0x06000139 RID: 313 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x28F8C90", Offset = "0x28F7290", VA = "0x1828F8C90", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ConstraintRotationOffset()
		{
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public ConstraintRotationOffset(Transform transform)
		{
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600013C RID: 316 RVA: 0x00002C9C File Offset: 0x00000E9C
		[Token(Token = "0x17000014")]
		private bool rotationChanged
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x28F90A0", Offset = "0x28F76A0", VA = "0x1828F90A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x20")]
		public Quaternion offset;

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x30")]
		private Quaternion defaultRotation;

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x40")]
		private Quaternion defaultLocalRotation;

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x50")]
		private Quaternion lastLocalRotation;

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x60")]
		private Quaternion defaultTargetLocalRotation;

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x70")]
		private bool initiated;
	}
}
