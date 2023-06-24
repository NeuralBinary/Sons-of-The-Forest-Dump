using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	[Serializable]
	public class BakerMuscle
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x28DD510", Offset = "0x28DBB10", VA = "0x1828DD510")]
		public BakerMuscle(int muscleIndex)
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x28DD5F0", Offset = "0x28DBBF0", VA = "0x1828DD5F0")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x28DCBD0", Offset = "0x28DB1D0", VA = "0x1828DCBD0")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x28DE600", Offset = "0x28DCC00", VA = "0x1828DE600")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x28DE870", Offset = "0x28DCE70", VA = "0x1828DE870")]
		public void Reset()
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x28DE950", Offset = "0x28DCF50", VA = "0x1828DE950")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x28DE990", Offset = "0x28DCF90", VA = "0x1828DE990")]
		public void SetLoopFrame(float time)
		{
		}

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x10")]
		public AnimationCurve curve;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x18")]
		private int muscleIndex;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x20")]
		private string propertyName;
	}
}
