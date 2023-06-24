using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Sons.Gui
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	public class OnSelectUi : MonoBehaviour, ISelectHandler, IEventSystemHandler
	{
		// Token: 0x060000C7 RID: 199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xA88300", Offset = "0xA86900", VA = "0x180A88300", Slot = "4")]
		public void OnSelect(BaseEventData eventData)
		{
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public OnSelectUi()
		{
		}

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UnityEvent _onSelect;
	}
}
