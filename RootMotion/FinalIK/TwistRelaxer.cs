using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000081 RID: 129
	[Token(Token = "0x2000081")]
	public class TwistRelaxer : MonoBehaviour
	{
		// Token: 0x06000494 RID: 1172 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000494")]
		[Address(RVA = "0x2971070", Offset = "0x296F670", VA = "0x182971070")]
		public void Relax()
		{
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000495")]
		[Address(RVA = "0x2971790", Offset = "0x296FD90", VA = "0x182971790")]
		private void Start()
		{
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000496")]
		[Address(RVA = "0x29723D0", Offset = "0x29709D0", VA = "0x1829723D0")]
		private void OnPostUpdate()
		{
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000497")]
		[Address(RVA = "0x29724A0", Offset = "0x2970AA0", VA = "0x1829724A0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000498")]
		[Address(RVA = "0x2972570", Offset = "0x2970B70", VA = "0x182972570")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x2972760", Offset = "0x2970D60", VA = "0x182972760")]
		public TwistRelaxer()
		{
		}

		// Token: 0x0400041A RID: 1050
		[Token(Token = "0x400041A")]
		[FieldOffset(Offset = "0x20")]
		public IK ik;

		// Token: 0x0400041B RID: 1051
		[Token(Token = "0x400041B")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("If this is the forearm roll bone, the parent should be the forearm bone. If null, will be found automatically.")]
		public Transform parent;

		// Token: 0x0400041C RID: 1052
		[Token(Token = "0x400041C")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("If this is the forearm roll bone, the child should be the hand bone. If null, will attempt to find automatically. Assign the hand manually if the hand bone is not a child of the roll bone.")]
		public Transform child;

		// Token: 0x0400041D RID: 1053
		[Token(Token = "0x400041D")]
		[FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		[Tooltip("The weight of relaxing the twist of this Transform")]
		public float weight;

		// Token: 0x0400041E RID: 1054
		[Token(Token = "0x400041E")]
		[FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		[Tooltip("If 0.5, this Transform will be twisted half way from parent to child. If 1, the twist angle will be locked to the child and will rotate with along with it.")]
		public float parentChildCrossfade;

		// Token: 0x0400041F RID: 1055
		[Token(Token = "0x400041F")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Rotation offset around the twist axis.")]
		[Range(-180f, 180f)]
		public float twistAngleOffset;

		// Token: 0x04000420 RID: 1056
		[Token(Token = "0x4000420")]
		[FieldOffset(Offset = "0x44")]
		private Vector3 twistAxis;

		// Token: 0x04000421 RID: 1057
		[Token(Token = "0x4000421")]
		[FieldOffset(Offset = "0x50")]
		private Vector3 axis;

		// Token: 0x04000422 RID: 1058
		[Token(Token = "0x4000422")]
		[FieldOffset(Offset = "0x5C")]
		private Vector3 axisRelativeToParentDefault;

		// Token: 0x04000423 RID: 1059
		[Token(Token = "0x4000423")]
		[FieldOffset(Offset = "0x68")]
		private Vector3 axisRelativeToChildDefault;
	}
}
