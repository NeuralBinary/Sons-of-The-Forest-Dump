using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200002D")]
	[Serializable]
	public class ConstraintPositionOffset : Constraint
	{
		// Token: 0x06000132 RID: 306 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x28F8620", Offset = "0x28F6C20", VA = "0x1828F8620", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ConstraintPositionOffset()
		{
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public ConstraintPositionOffset(Transform transform)
		{
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00002C84 File Offset: 0x00000E84
		[Token(Token = "0x17000013")]
		private bool positionChanged
		{
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x28F8A50", Offset = "0x28F7050", VA = "0x1828F8A50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 offset;

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3 defaultLocalPosition;

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 lastLocalPosition;

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x44")]
		private bool initiated;
	}
}
