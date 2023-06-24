using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Sons.Gui.Multiplayer
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	public class SelectFirstServerInfoOrLastSelected : MonoBehaviour, ISelectHandler, IEventSystemHandler
	{
		// Token: 0x060000BE RID: 190 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x3035950", Offset = "0x3033F50", VA = "0x183035950", Slot = "4")]
		public void OnSelect(BaseEventData eventData)
		{
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x3035E00", Offset = "0x3034400", VA = "0x183035E00")]
		public void ResetLastSelectedAfterRefresh()
		{
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x3035E60", Offset = "0x3034460", VA = "0x183035E60")]
		private void Update()
		{
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SelectFirstServerInfoOrLastSelected()
		{
		}

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Selectable _fallback;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x28")]
		[Header("Debug")]
		private GameObject _next;

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x30")]
		private GameObject _lastSelected;

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x38")]
		private GameObject _lastLobbyGuiItemButtonSelected;
	}
}
