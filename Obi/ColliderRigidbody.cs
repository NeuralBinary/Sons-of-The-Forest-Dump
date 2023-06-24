using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000179 RID: 377
	[Token(Token = "0x2000179")]
	public struct ColliderRigidbody
	{
		// Token: 0x06000749 RID: 1865 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000749")]
		[Address(RVA = "0x27D7A60", Offset = "0x27D6060", VA = "0x1827D7A60")]
		public void FromRigidbody(Rigidbody rb, bool kinematicForParticles)
		{
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600074A")]
		[Address(RVA = "0x27D86C0", Offset = "0x27D6CC0", VA = "0x1827D86C0")]
		public void FromRigidbody(Rigidbody2D rb, bool kinematicForParticles)
		{
		}

		// Token: 0x04000637 RID: 1591
		[Token(Token = "0x4000637")]
		[FieldOffset(Offset = "0x0")]
		public Matrix4x4 inverseInertiaTensor;

		// Token: 0x04000638 RID: 1592
		[Token(Token = "0x4000638")]
		[FieldOffset(Offset = "0x40")]
		public Vector4 velocity;

		// Token: 0x04000639 RID: 1593
		[Token(Token = "0x4000639")]
		[FieldOffset(Offset = "0x50")]
		public Vector4 angularVelocity;

		// Token: 0x0400063A RID: 1594
		[Token(Token = "0x400063A")]
		[FieldOffset(Offset = "0x60")]
		public Vector4 com;

		// Token: 0x0400063B RID: 1595
		[Token(Token = "0x400063B")]
		[FieldOffset(Offset = "0x70")]
		public float inverseMass;

		// Token: 0x0400063C RID: 1596
		[Token(Token = "0x400063C")]
		[FieldOffset(Offset = "0x74")]
		private int pad0;

		// Token: 0x0400063D RID: 1597
		[Token(Token = "0x400063D")]
		[FieldOffset(Offset = "0x78")]
		private int pad1;

		// Token: 0x0400063E RID: 1598
		[Token(Token = "0x400063E")]
		[FieldOffset(Offset = "0x7C")]
		private int pad2;
	}
}
