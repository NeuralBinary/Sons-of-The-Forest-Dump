using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x020003EE RID: 1006
	[Token(Token = "0x20003EE")]
	public class ConstructionIcons : MonoBehaviour
	{
		// Token: 0x06001AAA RID: 6826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AAA")]
		[Address(RVA = "0x2CDF600", Offset = "0x2CDE600", VA = "0x182CDF600")]
		public void Show(bool showManualfillLockIcon, bool canToggleAutofill, bool showAutofillPlace, bool showManualPlace, bool canLock, bool canUnlock, bool showAltPlace = false)
		{
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AAB")]
		[Address(RVA = "0x2CDF8D0", Offset = "0x2CDE8D0", VA = "0x182CDF8D0")]
		public void Shutdown()
		{
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AAC")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public ConstructionIcons()
		{
		}

		// Token: 0x040019E9 RID: 6633
		[Token(Token = "0x40019E9")]
		[FieldOffset(Offset = "0x20")]
		public GameObject _toggleAutofill;

		// Token: 0x040019EA RID: 6634
		[Token(Token = "0x40019EA")]
		[FieldOffset(Offset = "0x28")]
		public GameObject _manualfillLock;

		// Token: 0x040019EB RID: 6635
		[Token(Token = "0x40019EB")]
		[FieldOffset(Offset = "0x30")]
		public GameObject _autofillPlace;

		// Token: 0x040019EC RID: 6636
		[Token(Token = "0x40019EC")]
		[FieldOffset(Offset = "0x38")]
		public GameObject _manualfillPlace;

		// Token: 0x040019ED RID: 6637
		[Token(Token = "0x40019ED")]
		[FieldOffset(Offset = "0x40")]
		public GameObject _altPlace;

		// Token: 0x040019EE RID: 6638
		[Token(Token = "0x40019EE")]
		[FieldOffset(Offset = "0x48")]
		public GameObject _lockPoint;

		// Token: 0x040019EF RID: 6639
		[Token(Token = "0x40019EF")]
		[FieldOffset(Offset = "0x50")]
		public GameObject _unlockPoint;
	}
}
