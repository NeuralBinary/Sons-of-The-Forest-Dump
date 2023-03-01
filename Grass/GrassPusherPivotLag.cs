using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Grass
{
	// Token: 0x020005AC RID: 1452
	[Token(Token = "0x20005AC")]
	public class GrassPusherPivotLag : MonoBehaviour
	{
		// Token: 0x06002565 RID: 9573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002565")]
		[Address(RVA = "0x2D830B0", Offset = "0x2D820B0", VA = "0x182D830B0")]
		private void OnValidate()
		{
		}

		// Token: 0x06002566 RID: 9574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002566")]
		[Address(RVA = "0x2D83060", Offset = "0x2D82060", VA = "0x182D83060")]
		private void OnEnable()
		{
		}

		// Token: 0x06002567 RID: 9575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002567")]
		[Address(RVA = "0x2D83230", Offset = "0x2D82230", VA = "0x182D83230")]
		private void Update()
		{
		}

		// Token: 0x06002568 RID: 9576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002568")]
		[Address(RVA = "0x2D83710", Offset = "0x2D82710", VA = "0x182D83710")]
		public GrassPusherPivotLag()
		{
		}

		// Token: 0x040021BE RID: 8638
		[Token(Token = "0x40021BE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Rigidbody _rigidbody;

		// Token: 0x040021BF RID: 8639
		[Token(Token = "0x40021BF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _alignSpeed;

		// Token: 0x040021C0 RID: 8640
		[Token(Token = "0x40021C0")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _positionSpeed;

		// Token: 0x040021C1 RID: 8641
		[Token(Token = "0x40021C1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _max;

		// Token: 0x040021C2 RID: 8642
		[Token(Token = "0x40021C2")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Vector3 _offset;

		// Token: 0x040021C3 RID: 8643
		[Token(Token = "0x40021C3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Quaternion _rotateAlignment;

		// Token: 0x040021C4 RID: 8644
		[Token(Token = "0x40021C4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _useFake;

		// Token: 0x040021C5 RID: 8645
		[Token(Token = "0x40021C5")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Vector3 _fakeVelocity;

		// Token: 0x040021C6 RID: 8646
		[Token(Token = "0x40021C6")]
		[FieldOffset(Offset = "0x60")]
		private float _currentOffset;

		// Token: 0x040021C7 RID: 8647
		[Token(Token = "0x40021C7")]
		[FieldOffset(Offset = "0x64")]
		private Vector3 _currentPosition;
	}
}
