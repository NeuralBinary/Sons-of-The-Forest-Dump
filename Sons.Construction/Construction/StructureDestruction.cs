using System;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Gameplay;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000083 RID: 131
	[Token(Token = "0x2000083")]
	public class StructureDestruction : MonoBehaviour, IImpactReceiverRemote, IImpactReceiver, IMonoBehaviour, IVailDamageableStructure, IIgnoreThrownLogDamage
	{
		// Token: 0x0600036A RID: 874 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600036A")]
		[Address(RVA = "0x2DC3720", Offset = "0x2DC1D20", VA = "0x182DC3720")]
		private void AttackWithTestWeapon()
		{
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x2DC3990", Offset = "0x2DC1F90", VA = "0x182DC3990", Slot = "4")]
		private void OnImpact(IImpactSender sender, IImpactData impactData)
		{
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600036C")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public StructureDestruction()
		{
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600036D")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "5")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600036E")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "6")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x000037AC File Offset: 0x000019AC
		[Token(Token = "0x600036F")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x0400036D RID: 877
		[Token(Token = "0x400036D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sons.Gameplay.MeleeWeapon _testWeapon;
	}
}
