using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200002C")]
	[Serializable]
	public class ConstraintPosition : Constraint
	{
		// Token: 0x0600012F RID: 303 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x28F84A0", Offset = "0x28F6AA0", VA = "0x1828F84A0", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ConstraintPosition()
		{
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public ConstraintPosition(Transform transform)
		{
		}

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 position;
	}
}
