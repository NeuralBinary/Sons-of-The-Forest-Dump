using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	[Serializable]
	public class BakerHumanoidQT
	{
		// Token: 0x06000029 RID: 41 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x28DB9D0", Offset = "0x28D9FD0", VA = "0x1828DB9D0")]
		public BakerHumanoidQT(string name)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x28DBD20", Offset = "0x28DA320", VA = "0x1828DBD20")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x28DC0C0", Offset = "0x28DA6C0", VA = "0x1828DC0C0")]
		public void Reset()
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x28DC5E0", Offset = "0x28DABE0", VA = "0x1828DC5E0")]
		public void SetIKKeyframes(float time, Avatar avatar, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x28DC8C0", Offset = "0x28DAEC0", VA = "0x1828DC8C0")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x28DC9C0", Offset = "0x28DAFC0", VA = "0x1828DC9C0")]
		public void MoveLastKeyframes(float time)
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x28DCA60", Offset = "0x28DB060", VA = "0x1828DCA60")]
		public void SetLoopFrame(float time)
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x28DCAF0", Offset = "0x28DB0F0", VA = "0x1828DCAF0")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x28DCBD0", Offset = "0x28DB1D0", VA = "0x1828DCBD0")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x28DCCD0", Offset = "0x28DB2D0", VA = "0x1828DCCD0")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x10")]
		private Transform transform;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x18")]
		private string Qx;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x20")]
		private string Qy;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x28")]
		private string Qz;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x30")]
		private string Qw;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x38")]
		private string Tx;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x40")]
		private string Ty;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x48")]
		private string Tz;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x50")]
		public AnimationCurve rotX;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x58")]
		public AnimationCurve rotY;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x60")]
		public AnimationCurve rotZ;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x68")]
		public AnimationCurve rotW;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x70")]
		public AnimationCurve posX;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x78")]
		public AnimationCurve posY;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x80")]
		public AnimationCurve posZ;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x88")]
		private AvatarIKGoal goal;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x8C")]
		private Quaternion lastQ;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x9C")]
		private bool lastQSet;
	}
}
