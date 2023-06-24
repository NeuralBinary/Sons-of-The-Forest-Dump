using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x020003E0 RID: 992
	[Token(Token = "0x20003E0")]
	public class ConstructionIcons : MonoBehaviour
	{
		// Token: 0x06001AE8 RID: 6888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AE8")]
		[Address(RVA = "0x32A9A00", Offset = "0x32A8000", VA = "0x1832A9A00")]
		public void Show(bool showManualfillLockIcon, bool canToggleAutofill, bool showAutofillPlace, bool showManualPlace, bool canLock, bool canUnlock, bool showAltPlace = false)
		{
		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AE9")]
		[Address(RVA = "0x32AA120", Offset = "0x32A8720", VA = "0x1832AA120")]
		public void Shutdown()
		{
		}

		// Token: 0x06001AEA RID: 6890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AEA")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ConstructionIcons()
		{
		}

		// Token: 0x04001A0D RID: 6669
		[Token(Token = "0x4001A0D")]
		[FieldOffset(Offset = "0x20")]
		public GameObject _toggleAutofill;

		// Token: 0x04001A0E RID: 6670
		[Token(Token = "0x4001A0E")]
		[FieldOffset(Offset = "0x28")]
		public GameObject _manualfillLock;

		// Token: 0x04001A0F RID: 6671
		[Token(Token = "0x4001A0F")]
		[FieldOffset(Offset = "0x30")]
		public GameObject _autofillPlace;

		// Token: 0x04001A10 RID: 6672
		[Token(Token = "0x4001A10")]
		[FieldOffset(Offset = "0x38")]
		public GameObject _manualfillPlace;

		// Token: 0x04001A11 RID: 6673
		[Token(Token = "0x4001A11")]
		[FieldOffset(Offset = "0x40")]
		public GameObject _altPlace;

		// Token: 0x04001A12 RID: 6674
		[Token(Token = "0x4001A12")]
		[FieldOffset(Offset = "0x48")]
		public GameObject _lockPoint;

		// Token: 0x04001A13 RID: 6675
		[Token(Token = "0x4001A13")]
		[FieldOffset(Offset = "0x50")]
		public GameObject _unlockPoint;
	}
}
