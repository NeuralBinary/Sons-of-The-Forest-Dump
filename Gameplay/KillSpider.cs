using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000669 RID: 1641
	[Token(Token = "0x2000669")]
	[AddComponentMenu("Gameplay/KillSpider")]
	public class KillSpider : MonoBehaviour, IImpactReceiver, IMonoBehaviour
	{
		// Token: 0x060029F4 RID: 10740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029F4")]
		[Address(RVA = "0x2DD15D0", Offset = "0x2DD05D0", VA = "0x182DD15D0")]
		private void OnValidate()
		{
		}

		// Token: 0x060029F5 RID: 10741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029F5")]
		[Address(RVA = "0x2DD1310", Offset = "0x2DD0310", VA = "0x182DD1310", Slot = "4")]
		private void OnImpact(IImpactSender sender, IImpactData impactData)
		{
		}

		// Token: 0x060029F6 RID: 10742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029F6")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public KillSpider()
		{
		}

		// Token: 0x060029F7 RID: 10743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029F7")]
		[Address(RVA = "0x288E5E0", Offset = "0x288D5E0", VA = "0x18288E5E0", Slot = "5")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x060029F8 RID: 10744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029F8")]
		[Address(RVA = "0x5E9620", Offset = "0x5E8620", VA = "0x1805E9620", Slot = "6")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x060029F9 RID: 10745 RVA: 0x0000C1B0 File Offset: 0x0000A3B0
		[Token(Token = "0x60029F9")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x04002581 RID: 9601
		[Token(Token = "0x4002581")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x04002582 RID: 9602
		[Token(Token = "0x4002582")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Rigidbody _rigidbody;
	}
}
