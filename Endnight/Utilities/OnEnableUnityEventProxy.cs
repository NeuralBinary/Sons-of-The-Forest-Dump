using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Endnight.Utilities
{
	// Token: 0x0200004B RID: 75
	[Token(Token = "0x200004B")]
	public class OnEnableUnityEventProxy : MonoBehaviour
	{
		// Token: 0x060001C5 RID: 453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xA88300", Offset = "0xA86900", VA = "0x180A88300")]
		private void OnEnable()
		{
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public OnEnableUnityEventProxy()
		{
		}

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UnityEvent _onEnableEvent;
	}
}
