using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x02000404 RID: 1028
	[Token(Token = "0x2000404")]
	public class UiIconSlotToken : MonoBehaviour
	{
		// Token: 0x06001B76 RID: 7030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B76")]
		[Address(RVA = "0x32B88A0", Offset = "0x32B6EA0", VA = "0x1832B88A0")]
		public void Register(UiIconSlot icon, bool priority)
		{
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B77")]
		[Address(RVA = "0x32B89A0", Offset = "0x32B6FA0", VA = "0x1832B89A0")]
		public void Unregister(UiIconSlot icon)
		{
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B78")]
		[Address(RVA = "0x32B8A20", Offset = "0x32B7020", VA = "0x1832B8A20")]
		private void RefreshActiveFilters()
		{
		}

		// Token: 0x06001B79 RID: 7033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B79")]
		[Address(RVA = "0x32B8C40", Offset = "0x32B7240", VA = "0x1832B8C40")]
		public UiIconSlotToken()
		{
		}

		// Token: 0x04001AA9 RID: 6825
		[Token(Token = "0x4001AA9")]
		[FieldOffset(Offset = "0x20")]
		public List<UiIconSlot> _activeIcons;
	}
}
