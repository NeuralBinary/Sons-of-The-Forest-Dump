using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	[Serializable]
	public class BakerTransform
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x28DE9A0", Offset = "0x28DCFA0", VA = "0x1828DE9A0")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x28DEAC0", Offset = "0x28DD0C0", VA = "0x1828DEAC0")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x28DEAE0", Offset = "0x28DD0E0", VA = "0x1828DEAE0")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x28DEF10", Offset = "0x28DD510", VA = "0x1828DEF10")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x28DF300", Offset = "0x28DD900", VA = "0x1828DF300")]
		public void Reset()
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x28DF7E0", Offset = "0x28DDDE0", VA = "0x1828DF7E0")]
		public void ReduceKeyframes(float maxError)
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x28DFB20", Offset = "0x28DE120", VA = "0x1828DFB20")]
		public void SetKeyframes(float time)
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x28DFEA0", Offset = "0x28DE4A0", VA = "0x1828DFEA0")]
		public void AddLoopFrame(float time)
		{
		}

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x10")]
		public Transform transform;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x18")]
		public AnimationCurve posX;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x20")]
		public AnimationCurve posY;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x28")]
		public AnimationCurve posZ;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x30")]
		public AnimationCurve rotX;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x38")]
		public AnimationCurve rotY;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x40")]
		public AnimationCurve rotZ;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x48")]
		public AnimationCurve rotW;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x50")]
		private string relativePath;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x58")]
		private bool recordPosition;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x5C")]
		private Vector3 relativePosition;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x68")]
		private bool isRootNode;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x6C")]
		private Quaternion relativeRotation;
	}
}
