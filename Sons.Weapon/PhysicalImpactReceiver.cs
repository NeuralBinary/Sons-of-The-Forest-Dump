using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x0200002B RID: 43
	[Token(Token = "0x200002B")]
	public class PhysicalImpactReceiver : MonoBehaviour, IImpactReceiver, IMonoBehaviour
	{
		// Token: 0x06000149 RID: 329 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x31A3340", Offset = "0x31A1940", VA = "0x1831A3340")]
		private void Awake()
		{
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x31A33D0", Offset = "0x31A19D0", VA = "0x1831A33D0", Slot = "4")]
		private void OnImpact(IImpactSender sender, IImpactData impactData)
		{
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x31A36A0", Offset = "0x31A1CA0", VA = "0x1831A36A0")]
		public PhysicalImpactReceiver()
		{
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "5")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "6")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000025F4 File Offset: 0x000007F4
		[Token(Token = "0x600014E")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _maxSpeed;

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _minSpeedY;

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _multiplier;

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x30")]
		private Rigidbody _rigidbody;

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x38")]
		private float _lastHitTime;
	}
}
