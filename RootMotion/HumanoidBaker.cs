using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	public class HumanoidBaker : Baker
	{
		// Token: 0x06000042 RID: 66 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x28E0220", Offset = "0x28DE820", VA = "0x1828E0220")]
		private void Awake()
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x28E0DB0", Offset = "0x28DF3B0", VA = "0x1828E0DB0", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x28E0E10", Offset = "0x28DF410", VA = "0x1828E0E10", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x28E0F40", Offset = "0x28DF540", VA = "0x1828E0F40", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x28E1260", Offset = "0x28DF860", VA = "0x1828E1260", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x28E1520", Offset = "0x28DFB20", VA = "0x1828E1520", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x28E1F30", Offset = "0x28E0530", VA = "0x1828E1F30")]
		private void UpdateHumanPose()
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x28E20F0", Offset = "0x28E06F0", VA = "0x1828E20F0")]
		public HumanoidBaker()
		{
		}

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x80")]
		[Tooltip("Should the hand IK curves be added to the animation? Disable this if the original hand positions are not important when using the clip on another character via Humanoid retargeting.")]
		public bool bakeHandIK;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x84")]
		[Tooltip("Max keyframe reduction error for the Root.Q/T, LeftFoot IK and RightFoot IK channels. Having a larger error value for 'Key Reduction Error' and a smaller one for this enables you to optimize clip data size without the floating feet effect by enabling 'Foot IK' in the Animator.")]
		[Range(0f, 0.1f)]
		public float IKKeyReductionError;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x88")]
		[Range(1f, 9f)]
		[Tooltip("Frame rate divider for the muscle curves. If you have 'Frame Rate' set to 30, and this value set to 3, the muscle curves will be baked at 10 fps. Only the Root Q/T and Hand and Foot IK curves will be baked at 30. This enables you to optimize clip data size without the floating feet effect by enabling 'Foot IK' in the Animator.")]
		public int muscleFrameRateDiv;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x90")]
		private BakerMuscle[] bakerMuscles;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x98")]
		private BakerHumanoidQT rootQT;

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0xA0")]
		private BakerHumanoidQT leftFootQT;

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0xA8")]
		private BakerHumanoidQT rightFootQT;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0xB0")]
		private BakerHumanoidQT leftHandQT;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0xB8")]
		private BakerHumanoidQT rightHandQT;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0xC0")]
		private float[] muscles;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0xC8")]
		private HumanPose pose;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0xF0")]
		private HumanPoseHandler handler;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0xF8")]
		private Vector3 bodyPosition;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x104")]
		private Quaternion bodyRotation;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x114")]
		private int mN;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x118")]
		private Quaternion lastBodyRotation;
	}
}
