using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Multiplayer.Gui
{
	// Token: 0x02000570 RID: 1392
	[Token(Token = "0x2000570")]
	public class SecondOrderDynamicsTester : MonoBehaviour
	{
		// Token: 0x060024DE RID: 9438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024DE")]
		[Address(RVA = "0x3391110", Offset = "0x338F710", VA = "0x183391110")]
		private void Update()
		{
		}

		// Token: 0x060024DF RID: 9439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024DF")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SecondOrderDynamicsTester()
		{
		}

		// Token: 0x0400211A RID: 8474
		[Token(Token = "0x400211A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SecondOrderDynamics _secondOrderDynamics;

		// Token: 0x0400211B RID: 8475
		[Token(Token = "0x400211B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _target;

		// Token: 0x0400211C RID: 8476
		[Token(Token = "0x400211C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _goal;
	}
}
