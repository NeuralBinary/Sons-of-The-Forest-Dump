using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Physics
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	public class ColliderDepenetration : MonoBehaviour
	{
		// Token: 0x06000067 RID: 103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x3101640", Offset = "0x30FFC40", VA = "0x183101640")]
		private void OnEnable()
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x31017B0", Offset = "0x30FFDB0", VA = "0x1831017B0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x3101B30", Offset = "0x3100130", VA = "0x183101B30")]
		public ColliderDepenetration()
		{
		}

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _heightOffset;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int _timeSlice;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _rayOffset;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x30")]
		private Rigidbody _rigidbody;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x38")]
		private float colliderHeight;

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x3C")]
		private LayerMask _layerMask;

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x40")]
		private int _randomTimeSliceOffset;
	}
}
