using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Physics
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	public class AddExplosionForce : MonoBehaviour
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000020E4 File Offset: 0x000002E4
		[Token(Token = "0x17000001")]
		private Vector3 WorldCenter
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x2716C30", Offset = "0x2715230", VA = "0x182716C30")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x30F99A0", Offset = "0x30F7FA0", VA = "0x1830F99A0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x30F9B50", Offset = "0x30F8150", VA = "0x1830F9B50")]
		private void ApplyForce()
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x30F9C80", Offset = "0x30F8280", VA = "0x1830F9C80")]
		private void CollectChildren()
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x30F9D10", Offset = "0x30F8310", VA = "0x1830F9D10")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x30F9DF0", Offset = "0x30F83F0", VA = "0x1830F9DF0")]
		public AddExplosionForce()
		{
		}

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 _center;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _radius;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _force;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _upForce;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _autoCollectChildren;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Rigidbody[] _rigidbodies;
	}
}
