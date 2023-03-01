using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x02000412 RID: 1042
	[Token(Token = "0x2000412")]
	public class UiIconSlotToken : MonoBehaviour
	{
		// Token: 0x06001B38 RID: 6968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B38")]
		[Address(RVA = "0x2CF3890", Offset = "0x2CF2890", VA = "0x182CF3890")]
		public void Register(UiIconSlot icon, bool priority)
		{
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B39")]
		[Address(RVA = "0x2CF39B0", Offset = "0x2CF29B0", VA = "0x182CF39B0")]
		public void Unregister(UiIconSlot icon)
		{
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B3A")]
		[Address(RVA = "0x2CF36E0", Offset = "0x2CF26E0", VA = "0x182CF36E0")]
		private void RefreshActiveFilters()
		{
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B3B")]
		[Address(RVA = "0x2CF3A40", Offset = "0x2CF2A40", VA = "0x182CF3A40")]
		public UiIconSlotToken()
		{
		}

		// Token: 0x04001A85 RID: 6789
		[Token(Token = "0x4001A85")]
		[FieldOffset(Offset = "0x20")]
		public List<UiIconSlot> _activeIcons;
	}
}
