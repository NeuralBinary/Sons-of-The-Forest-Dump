using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Grass
{
	// Token: 0x020005BC RID: 1468
	[Token(Token = "0x20005BC")]
	public class GrassPusherPivotLag : MonoBehaviour
	{
		// Token: 0x06002664 RID: 9828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002664")]
		[Address(RVA = "0x33AB6F0", Offset = "0x33A9CF0", VA = "0x1833AB6F0")]
		private void OnValidate()
		{
		}

		// Token: 0x06002665 RID: 9829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002665")]
		[Address(RVA = "0x33AB870", Offset = "0x33A9E70", VA = "0x1833AB870")]
		private void OnEnable()
		{
		}

		// Token: 0x06002666 RID: 9830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002666")]
		[Address(RVA = "0x33AB950", Offset = "0x33A9F50", VA = "0x1833AB950")]
		private void Update()
		{
		}

		// Token: 0x06002667 RID: 9831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002667")]
		[Address(RVA = "0x33ABF90", Offset = "0x33AA590", VA = "0x1833ABF90")]
		public GrassPusherPivotLag()
		{
		}

		// Token: 0x04002292 RID: 8850
		[Token(Token = "0x4002292")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Rigidbody _rigidbody;

		// Token: 0x04002293 RID: 8851
		[Token(Token = "0x4002293")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _alignSpeed;

		// Token: 0x04002294 RID: 8852
		[Token(Token = "0x4002294")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _positionSpeed;

		// Token: 0x04002295 RID: 8853
		[Token(Token = "0x4002295")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _max;

		// Token: 0x04002296 RID: 8854
		[Token(Token = "0x4002296")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Vector3 _offset;

		// Token: 0x04002297 RID: 8855
		[Token(Token = "0x4002297")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Quaternion _rotateAlignment;

		// Token: 0x04002298 RID: 8856
		[Token(Token = "0x4002298")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _useFake;

		// Token: 0x04002299 RID: 8857
		[Token(Token = "0x4002299")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Vector3 _fakeVelocity;

		// Token: 0x0400229A RID: 8858
		[Token(Token = "0x400229A")]
		[FieldOffset(Offset = "0x60")]
		private float _currentOffset;

		// Token: 0x0400229B RID: 8859
		[Token(Token = "0x400229B")]
		[FieldOffset(Offset = "0x64")]
		private Vector3 _currentPosition;
	}
}
