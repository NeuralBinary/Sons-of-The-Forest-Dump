using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Animation
{
	// Token: 0x020000C9 RID: 201
	[Token(Token = "0x20000C9")]
	public class AnimatorPose : MonoBehaviour
	{
		// Token: 0x060004BC RID: 1212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xAAED20", Offset = "0xAAD320", VA = "0x180AAED20")]
		private void Store()
		{
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xAAEE50", Offset = "0xAAD450", VA = "0x180AAEE50")]
		private void Apply()
		{
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004BE")]
		[Address(RVA = "0xAAEF90", Offset = "0xAAD590", VA = "0x180AAEF90")]
		private void Store(List<Transform> sourceTransforms, List<AnimatorPose.PoseData> poseData)
		{
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xAAF0D0", Offset = "0xAAD6D0", VA = "0x180AAF0D0")]
		private void Store(List<SkinnedMeshRenderer> sourceRenderers, List<AnimatorPose.PoseData> poseData)
		{
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xAAF210", Offset = "0xAAD810", VA = "0x180AAF210")]
		private void Store(SkinnedMeshRenderer sourceRenderer, List<AnimatorPose.PoseData> poseData)
		{
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xAAF420", Offset = "0xAADA20", VA = "0x180AAF420")]
		private void Store(Transform sourceTransform, List<AnimatorPose.PoseData> poseData)
		{
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public AnimatorPose()
		{
		}

		// Token: 0x04000302 RID: 770
		[Token(Token = "0x4000302")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<SkinnedMeshRenderer> _sourceRenderers;

		// Token: 0x04000303 RID: 771
		[Token(Token = "0x4000303")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Transform> _sourceTransforms;

		// Token: 0x04000304 RID: 772
		[Token(Token = "0x4000304")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<AnimatorPose.PoseData> _data;

		// Token: 0x020000CA RID: 202
		[Token(Token = "0x20000CA")]
		[Serializable]
		public class PoseData
		{
			// Token: 0x060004C3 RID: 1219 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60004C3")]
			[Address(RVA = "0xAAF4F0", Offset = "0xAADAF0", VA = "0x180AAF4F0")]
			public PoseData(Transform source)
			{
			}

			// Token: 0x060004C4 RID: 1220 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60004C4")]
			[Address(RVA = "0xAAF720", Offset = "0xAADD20", VA = "0x180AAF720")]
			public void ApplyPose()
			{
			}

			// Token: 0x04000305 RID: 773
			[Token(Token = "0x4000305")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Transform _target;

			// Token: 0x04000306 RID: 774
			[Token(Token = "0x4000306")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private string _name;

			// Token: 0x04000307 RID: 775
			[Token(Token = "0x4000307")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Vector3 _localPosition;

			// Token: 0x04000308 RID: 776
			[Token(Token = "0x4000308")]
			[FieldOffset(Offset = "0x2C")]
			[SerializeField]
			private Quaternion _localRotation;

			// Token: 0x04000309 RID: 777
			[Token(Token = "0x4000309")]
			[FieldOffset(Offset = "0x3C")]
			[SerializeField]
			private Vector3 _localScale;
		}
	}
}
