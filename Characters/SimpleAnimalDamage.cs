using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x020007F9 RID: 2041
	[Token(Token = "0x20007F9")]
	[AddComponentMenu("Sons/Characters/Simple Animal Damage")]
	public class SimpleAnimalDamage : MonoBehaviour, IImpactReceiver, IMonoBehaviour
	{
		// Token: 0x0600360F RID: 13839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600360F")]
		[Address(RVA = "0x2E988A0", Offset = "0x2E978A0", VA = "0x182E988A0", Slot = "4")]
		public void OnImpact(IImpactSender sender, IImpactData impactData)
		{
		}

		// Token: 0x06003610 RID: 13840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003610")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public SimpleAnimalDamage()
		{
		}

		// Token: 0x06003611 RID: 13841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003611")]
		[Address(RVA = "0x288E5E0", Offset = "0x288D5E0", VA = "0x18288E5E0", Slot = "5")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06003612 RID: 13842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003612")]
		[Address(RVA = "0x5E9620", Offset = "0x5E8620", VA = "0x1805E9620", Slot = "6")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06003613 RID: 13843 RVA: 0x0000FA50 File Offset: 0x0000DC50
		[Token(Token = "0x6003613")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x04002E5E RID: 11870
		[Token(Token = "0x4002E5E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleAnimal _simpleAnimal;
	}
}
