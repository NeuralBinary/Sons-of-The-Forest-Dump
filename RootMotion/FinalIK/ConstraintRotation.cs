using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	[Serializable]
	public class ConstraintRotation : Constraint
	{
		// Token: 0x06000136 RID: 310 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x28F8B20", Offset = "0x28F7120", VA = "0x1828F8B20", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ConstraintRotation()
		{
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public ConstraintRotation(Transform transform)
		{
		}

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x20")]
		public Quaternion rotation;
	}
}
