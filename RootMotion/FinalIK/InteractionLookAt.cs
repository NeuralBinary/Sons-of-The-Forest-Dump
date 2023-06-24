using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000083 RID: 131
	[Token(Token = "0x2000083")]
	[Serializable]
	public class InteractionLookAt
	{
		// Token: 0x060004AE RID: 1198 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x2975800", Offset = "0x2973E00", VA = "0x182975800")]
		public void Look(Transform target, float time)
		{
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x2975A80", Offset = "0x2974080", VA = "0x182975A80")]
		public void OnFixTransforms()
		{
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x2975B70", Offset = "0x2974170", VA = "0x182975B70")]
		public void Update()
		{
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x2975FF0", Offset = "0x29745F0", VA = "0x182975FF0")]
		public void SolveSpine()
		{
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x2976170", Offset = "0x2974770", VA = "0x182976170")]
		public void SolveHead()
		{
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x29762A0", Offset = "0x29748A0", VA = "0x1829762A0")]
		public InteractionLookAt()
		{
		}

		// Token: 0x04000448 RID: 1096
		[Token(Token = "0x4000448")]
		[FieldOffset(Offset = "0x10")]
		[Tooltip("(Optional) reference to the LookAtIK component that will be used to make the character look at the objects that it is interacting with.")]
		public LookAtIK ik;

		// Token: 0x04000449 RID: 1097
		[Token(Token = "0x4000449")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("Interpolation speed of the LookAtIK target.")]
		public float lerpSpeed;

		// Token: 0x0400044A RID: 1098
		[Token(Token = "0x400044A")]
		[FieldOffset(Offset = "0x1C")]
		[Tooltip("Interpolation speed of the LookAtIK weight.")]
		public float weightSpeed;

		// Token: 0x0400044B RID: 1099
		[Token(Token = "0x400044B")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		// Token: 0x0400044C RID: 1100
		[Token(Token = "0x400044C")]
		[FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		// Token: 0x0400044D RID: 1101
		[Token(Token = "0x400044D")]
		[FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		// Token: 0x0400044E RID: 1102
		[Token(Token = "0x400044E")]
		[FieldOffset(Offset = "0x34")]
		private float weight;

		// Token: 0x0400044F RID: 1103
		[Token(Token = "0x400044F")]
		[FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;
	}
}
