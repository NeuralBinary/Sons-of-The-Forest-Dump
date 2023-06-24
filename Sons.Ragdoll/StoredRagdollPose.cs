using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ragdoll
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	public class StoredRagdollPose : MonoBehaviour
	{
		// Token: 0x06000041 RID: 65 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x31207F0", Offset = "0x311EDF0", VA = "0x1831207F0")]
		private void CollectRagdollTransforms()
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void CopyThrowPose()
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x31209B0", Offset = "0x311EFB0", VA = "0x1831209B0")]
		private void ApplyStoredPose()
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x3120B50", Offset = "0x311F150", VA = "0x183120B50")]
		private void StorePose(List<Transform> transforms, List<StoredRagdollPose.StoredTransform> storedTransforms)
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x3120D40", Offset = "0x311F340", VA = "0x183120D40")]
		private static StoredRagdollPose.StoredTransform GetMatchTransform(Transform sourceTr, Transform bodyRootTr)
		{
			return null;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x3121170", Offset = "0x311F770", VA = "0x183121170")]
		private void RecordPose(Transform rootTr)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x3121680", Offset = "0x311FC80", VA = "0x183121680")]
		private void RestorePose()
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x3121910", Offset = "0x311FF10", VA = "0x183121910")]
		public void ApplyStoredPose(Vector3 position, Quaternion rotation)
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public StoredRagdollPose()
		{
		}

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Transform> _ragdollTransforms;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<StoredRagdollPose.StoredTransform> _storedTransforms;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimationClip _throwPoseClip;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _throwPoseTime;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _animRoot;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x48")]
		private List<StoredRagdollPose.StoredTransform> _tempPose;

		// Token: 0x0200000B RID: 11
		[Token(Token = "0x200000B")]
		[Serializable]
		private class StoredTransform
		{
			// Token: 0x0600004A RID: 74 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x3121CF0", Offset = "0x31202F0", VA = "0x183121CF0")]
			public StoredTransform()
			{
			}

			// Token: 0x0400003F RID: 63
			[Token(Token = "0x400003F")]
			[FieldOffset(Offset = "0x10")]
			public Transform transform;

			// Token: 0x04000040 RID: 64
			[Token(Token = "0x4000040")]
			[FieldOffset(Offset = "0x18")]
			public Vector3 position;

			// Token: 0x04000041 RID: 65
			[Token(Token = "0x4000041")]
			[FieldOffset(Offset = "0x24")]
			public Quaternion rotation;

			// Token: 0x04000042 RID: 66
			[Token(Token = "0x4000042")]
			[FieldOffset(Offset = "0x34")]
			public Vector3 scale;
		}
	}
}
