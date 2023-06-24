using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Animation
{
	// Token: 0x020000C3 RID: 195
	[Token(Token = "0x20000C3")]
	[AddComponentMenu("Endnight/Animation/AnimationFixup")]
	public class AnimationFixup : MonoBehaviour
	{
		// Token: 0x06000497 RID: 1175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000497")]
		[Address(RVA = "0xAAC030", Offset = "0xAAA630", VA = "0x180AAC030")]
		private void OnValidate()
		{
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000498")]
		[Address(RVA = "0xAAC160", Offset = "0xAAA760", VA = "0x180AAC160")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000499")]
		[Address(RVA = "0xAAC370", Offset = "0xAAA970", VA = "0x180AAC370")]
		public AnimationFixup()
		{
		}

		// Token: 0x040002E7 RID: 743
		[Token(Token = "0x40002E7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x040002E8 RID: 744
		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<AnimationFixup.FixupBone> _fixupBones;

		// Token: 0x020000C4 RID: 196
		[Token(Token = "0x20000C4")]
		[Serializable]
		private class FixupBone
		{
			// Token: 0x0600049A RID: 1178 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600049A")]
			[Address(RVA = "0xAAC450", Offset = "0xAAAA50", VA = "0x180AAC450")]
			public void FixupJoint()
			{
			}

			// Token: 0x0600049B RID: 1179 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public FixupBone()
			{
			}

			// Token: 0x040002E9 RID: 745
			[Token(Token = "0x40002E9")]
			[FieldOffset(Offset = "0x10")]
			public Transform _transform;

			// Token: 0x040002EA RID: 746
			[Token(Token = "0x40002EA")]
			[FieldOffset(Offset = "0x18")]
			public bool _adjustPosition;

			// Token: 0x040002EB RID: 747
			[Token(Token = "0x40002EB")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3 _localOffset;

			// Token: 0x040002EC RID: 748
			[Token(Token = "0x40002EC")]
			[FieldOffset(Offset = "0x28")]
			public bool _adjustRotation;

			// Token: 0x040002ED RID: 749
			[Token(Token = "0x40002ED")]
			[FieldOffset(Offset = "0x2C")]
			public Quaternion _rotationOffset;
		}
	}
}
