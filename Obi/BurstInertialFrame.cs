using System;
using Il2CppDummyDll;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x020000BB RID: 187
	[Token(Token = "0x20000BB")]
	public struct BurstInertialFrame
	{
		// Token: 0x060003C6 RID: 966 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x279B710", Offset = "0x2799D10", VA = "0x18279B710")]
		public BurstInertialFrame(float4 position, float4 scale, quaternion rotation)
		{
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x279B800", Offset = "0x2799E00", VA = "0x18279B800")]
		public BurstInertialFrame(BurstAffineTransform frame)
		{
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x279B8C0", Offset = "0x2799EC0", VA = "0x18279B8C0")]
		public void Update(float4 position, float4 scale, quaternion rotation, float dt)
		{
		}

		// Token: 0x04000432 RID: 1074
		[Token(Token = "0x4000432")]
		[FieldOffset(Offset = "0x0")]
		public BurstAffineTransform frame;

		// Token: 0x04000433 RID: 1075
		[Token(Token = "0x4000433")]
		[FieldOffset(Offset = "0x30")]
		public BurstAffineTransform prevFrame;

		// Token: 0x04000434 RID: 1076
		[Token(Token = "0x4000434")]
		[FieldOffset(Offset = "0x60")]
		public float4 velocity;

		// Token: 0x04000435 RID: 1077
		[Token(Token = "0x4000435")]
		[FieldOffset(Offset = "0x70")]
		public float4 angularVelocity;

		// Token: 0x04000436 RID: 1078
		[Token(Token = "0x4000436")]
		[FieldOffset(Offset = "0x80")]
		public float4 acceleration;

		// Token: 0x04000437 RID: 1079
		[Token(Token = "0x4000437")]
		[FieldOffset(Offset = "0x90")]
		public float4 angularAcceleration;
	}
}
