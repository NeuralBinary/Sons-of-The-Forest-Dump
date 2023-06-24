using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Utilities
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	[AddComponentMenu("Sons/Utilities/FollowTargetLateUpdate")]
	public class FollowTargetLateUpdate : MonoBehaviour
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x315F5A0", Offset = "0x315DBA0", VA = "0x18315F5A0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
		public void SetTarget(Transform target)
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x781530", Offset = "0x77FB30", VA = "0x180781530")]
		public void SetOffset(Vector3 offset)
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2084CC0", Offset = "0x20832C0", VA = "0x182084CC0")]
		public void SetAlignRotation(bool value)
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x315F8E0", Offset = "0x315DEE0", VA = "0x18315F8E0")]
		public FollowTargetLateUpdate()
		{
		}

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("target")]
		[SerializeField]
		private Transform _target;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("offset")]
		private Vector3 _offset;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x34")]
		[FormerlySerializedAs("followRotation")]
		[SerializeField]
		private bool _alignRotation;
	}
}
