using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Ballistics
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	public struct BulletImpact
	{
		// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x906120", Offset = "0x904720", VA = "0x180906120")]
		public BulletImpact(Transform transform, Vector3 entryVelocity, Vector3 entryPosition, BallisticMaterial ballisticMaterial, BallisticObject ballisticObject)
		{
		}

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x0")]
		public Transform transform;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x8")]
		public Vector3 entryVelocity;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 entryPosition;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x20")]
		public BallisticMaterial ballisticMaterial;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x28")]
		public BallisticObject ballisticObject;
	}
}
