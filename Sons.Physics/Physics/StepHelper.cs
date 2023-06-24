using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Physics
{
	// Token: 0x0200001E RID: 30
	[Token(Token = "0x200001E")]
	public class StepHelper : MonoBehaviour
	{
		// Token: 0x060000AF RID: 175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x3107520", Offset = "0x3105B20", VA = "0x183107520")]
		private void OnValidate()
		{
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x3107650", Offset = "0x3105C50", VA = "0x183107650")]
		public void UpdateInputMovement(Vector2 movement)
		{
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x31079C0", Offset = "0x3105FC0", VA = "0x1831079C0")]
		public void SetColliderEnabled(bool newEnabled)
		{
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x3107AE0", Offset = "0x31060E0", VA = "0x183107AE0")]
		public StepHelper()
		{
		}

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CapsuleCollider _targetCollider;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _minRadius;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _maxRadius;

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector3 _movementOffset;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Vector3 _rotationOffset;

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x48")]
		private float _factor;

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x4C")]
		private Vector2 _inputMovement;

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x54")]
		private float _maxMagnitude;
	}
}
