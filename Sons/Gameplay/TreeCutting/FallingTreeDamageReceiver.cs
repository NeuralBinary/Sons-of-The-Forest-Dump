using System;
using Il2CppDummyDll;
using Sons.Weapon;
using UnityEngine;

namespace Sons.Gameplay.TreeCutting
{
	// Token: 0x02000829 RID: 2089
	[Token(Token = "0x2000829")]
	public class FallingTreeDamageReceiver : MonoBehaviour, IImpactReceiver, IMonoBehaviour
	{
		// Token: 0x06003AD9 RID: 15065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AD9")]
		[Address(RVA = "0x357F440", Offset = "0x357DA40", VA = "0x18357F440", Slot = "4")]
		public void OnImpact(IImpactSender sender, IImpactData impactData)
		{
		}

		// Token: 0x06003ADA RID: 15066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ADA")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public FallingTreeDamageReceiver()
		{
		}

		// Token: 0x06003ADB RID: 15067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ADB")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "5")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06003ADC RID: 15068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ADC")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "6")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06003ADD RID: 15069 RVA: 0x00012030 File Offset: 0x00010230
		[Token(Token = "0x6003ADD")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x0400321D RID: 12829
		[Token(Token = "0x400321D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DamageNode _damageNode;
	}
}
