using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Endnight.Utilities
{
	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200004A")]
	public class OnDisableUnityEventProxy : MonoBehaviour
	{
		// Token: 0x060001C3 RID: 451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xA88300", Offset = "0xA86900", VA = "0x180A88300")]
		private void OnDisable()
		{
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public OnDisableUnityEventProxy()
		{
		}

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UnityEvent _onDisableEvent;
	}
}
