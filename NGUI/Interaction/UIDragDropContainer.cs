using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x020000AA RID: 170
	[Token(Token = "0x20000AA")]
	[AddComponentMenu("NGUI/Interaction/Drag and Drop Container")]
	public class UIDragDropContainer : MonoBehaviour
	{
		// Token: 0x0600063E RID: 1598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063E")]
		[Address(RVA = "0x26B2CD0", Offset = "0x26B12D0", VA = "0x1826B2CD0", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063F")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public UIDragDropContainer()
		{
		}

		// Token: 0x04000447 RID: 1095
		[Token(Token = "0x4000447")]
		[FieldOffset(Offset = "0x20")]
		public Transform reparentTarget;
	}
}
