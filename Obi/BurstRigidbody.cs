using System;
using Il2CppDummyDll;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x020000BC RID: 188
	[Token(Token = "0x20000BC")]
	public struct BurstRigidbody
	{
		// Token: 0x04000438 RID: 1080
		[Token(Token = "0x4000438")]
		[FieldOffset(Offset = "0x0")]
		public float4x4 inverseInertiaTensor;

		// Token: 0x04000439 RID: 1081
		[Token(Token = "0x4000439")]
		[FieldOffset(Offset = "0x40")]
		public float4 velocity;

		// Token: 0x0400043A RID: 1082
		[Token(Token = "0x400043A")]
		[FieldOffset(Offset = "0x50")]
		public float4 angularVelocity;

		// Token: 0x0400043B RID: 1083
		[Token(Token = "0x400043B")]
		[FieldOffset(Offset = "0x60")]
		public float4 com;

		// Token: 0x0400043C RID: 1084
		[Token(Token = "0x400043C")]
		[FieldOffset(Offset = "0x70")]
		public float inverseMass;

		// Token: 0x0400043D RID: 1085
		[Token(Token = "0x400043D")]
		[FieldOffset(Offset = "0x74")]
		private int pad0;

		// Token: 0x0400043E RID: 1086
		[Token(Token = "0x400043E")]
		[FieldOffset(Offset = "0x78")]
		private int pad1;

		// Token: 0x0400043F RID: 1087
		[Token(Token = "0x400043F")]
		[FieldOffset(Offset = "0x7C")]
		private int pad2;
	}
}
