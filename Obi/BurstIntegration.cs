using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x0200004B RID: 75
	[Token(Token = "0x200004B")]
	public static class BurstIntegration
	{
		// Token: 0x0600024B RID: 587 RVA: 0x000029FC File Offset: 0x00000BFC
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x2765680", Offset = "0x2763C80", VA = "0x182765680")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 IntegrateLinear(float4 position, float4 velocity, float dt)
		{
			return default(float4);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00002A14 File Offset: 0x00000C14
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x2765700", Offset = "0x2763D00", VA = "0x182765700")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 DifferentiateLinear(float4 position, float4 prevPosition, float dt)
		{
			return default(float4);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00002A2C File Offset: 0x00000C2C
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x2765790", Offset = "0x2763D90", VA = "0x182765790")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion AngularVelocityToSpinQuaternion(quaternion rotation, float4 angularVelocity, float dt)
		{
			return default(quaternion);
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00002A44 File Offset: 0x00000C44
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x2765870", Offset = "0x2763E70", VA = "0x182765870")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion IntegrateAngular(quaternion rotation, float4 angularVelocity, float dt)
		{
			return default(quaternion);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00002A5C File Offset: 0x00000C5C
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x2765A00", Offset = "0x2764000", VA = "0x182765A00")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 DifferentiateAngular(quaternion rotation, quaternion prevRotation, float dt)
		{
			return default(float4);
		}
	}
}
