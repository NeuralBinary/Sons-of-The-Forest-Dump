using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000788 RID: 1928
	[Token(Token = "0x2000788")]
	[AddComponentMenu("Gameplay/KillSpider")]
	public class KillSpider : MonoBehaviour, IImpactReceiver, IMonoBehaviour
	{
		// Token: 0x060033F1 RID: 13297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033F1")]
		[Address(RVA = "0x34C2400", Offset = "0x34C0A00", VA = "0x1834C2400")]
		private void OnValidate()
		{
		}

		// Token: 0x060033F2 RID: 13298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033F2")]
		[Address(RVA = "0x34C2640", Offset = "0x34C0C40", VA = "0x1834C2640", Slot = "4")]
		private void OnImpact(IImpactSender sender, IImpactData impactData)
		{
		}

		// Token: 0x060033F3 RID: 13299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033F3")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public KillSpider()
		{
		}

		// Token: 0x060033F4 RID: 13300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033F4")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "5")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x060033F5 RID: 13301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033F5")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "6")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x060033F6 RID: 13302 RVA: 0x0000F900 File Offset: 0x0000DB00
		[Token(Token = "0x60033F6")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x04002CDE RID: 11486
		[Token(Token = "0x4002CDE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x04002CDF RID: 11487
		[Token(Token = "0x4002CDF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Rigidbody _rigidbody;
	}
}
