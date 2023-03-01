using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Multiplayer.Gui
{
	// Token: 0x02000561 RID: 1377
	[Token(Token = "0x2000561")]
	public class SecondOrderDynamicsTester : MonoBehaviour
	{
		// Token: 0x060023E2 RID: 9186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E2")]
		[Address(RVA = "0x2D8F310", Offset = "0x2D8E310", VA = "0x182D8F310")]
		private void Update()
		{
		}

		// Token: 0x060023E3 RID: 9187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E3")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public SecondOrderDynamicsTester()
		{
		}

		// Token: 0x0400204A RID: 8266
		[Token(Token = "0x400204A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SecondOrderDynamics _secondOrderDynamics;

		// Token: 0x0400204B RID: 8267
		[Token(Token = "0x400204B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _target;

		// Token: 0x0400204C RID: 8268
		[Token(Token = "0x400204C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _goal;
	}
}
