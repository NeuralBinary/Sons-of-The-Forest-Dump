using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	public static class BakerUtilities
	{
		// Token: 0x06000024 RID: 36 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x28DB1A0", Offset = "0x28D97A0", VA = "0x1828DB1A0")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x28DB220", Offset = "0x28D9820", VA = "0x1828DB220")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x28DB5B0", Offset = "0x28D9BB0", VA = "0x1828DB5B0")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002114 File Offset: 0x00000314
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x28DB770", Offset = "0x28D9D70", VA = "0x1828DB770")]
		public static Quaternion EnsureQuaternionContinuity(Quaternion lastQ, Quaternion q)
		{
			return default(Quaternion);
		}
	}
}
