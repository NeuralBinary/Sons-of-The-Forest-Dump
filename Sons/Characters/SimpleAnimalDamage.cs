using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x02000707 RID: 1799
	[Token(Token = "0x2000707")]
	[AddComponentMenu("Sons/Characters/Simple Animal Damage")]
	public class SimpleAnimalDamage : MonoBehaviour, IImpactReceiver, IMonoBehaviour
	{
		// Token: 0x06002FB6 RID: 12214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FB6")]
		[Address(RVA = "0x3466260", Offset = "0x3464860", VA = "0x183466260", Slot = "4")]
		public void OnImpact(IImpactSender sender, IImpactData impactData)
		{
		}

		// Token: 0x06002FB7 RID: 12215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FB7")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SimpleAnimalDamage()
		{
		}

		// Token: 0x06002FB8 RID: 12216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FB8")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "5")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06002FB9 RID: 12217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FB9")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "6")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06002FBA RID: 12218 RVA: 0x0000E508 File Offset: 0x0000C708
		[Token(Token = "0x6002FBA")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x0400294F RID: 10575
		[Token(Token = "0x400294F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleAnimal _simpleAnimal;

		// Token: 0x04002950 RID: 10576
		[Token(Token = "0x4002950")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleFrog _simpleFrog;
	}
}
