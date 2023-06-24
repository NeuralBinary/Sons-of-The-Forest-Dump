using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Physics
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	public class SetMaxDepenetrationVelocity : MonoBehaviour
	{
		// Token: 0x060000A9 RID: 169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x3107040", Offset = "0x3105640", VA = "0x183107040")]
		private void Update()
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x3107080", Offset = "0x3105680", VA = "0x183107080")]
		private void Awake()
		{
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x3107090", Offset = "0x3105690", VA = "0x183107090")]
		private void Apply()
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x3107170", Offset = "0x3105770", VA = "0x183107170")]
		private void Reset()
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x31072F0", Offset = "0x31058F0", VA = "0x1831072F0")]
		private void OnValidate()
		{
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x5C7240", Offset = "0x5C5840", VA = "0x1805C7240")]
		public SetMaxDepenetrationVelocity()
		{
		}

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Rigidbody _rigidbody;

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _maxDepenetrationVelocity;

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x2C")]
		private float _appliedValue;
	}
}
