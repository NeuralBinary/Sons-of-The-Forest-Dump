using System;
using System.ComponentModel;
using Il2CppDummyDll;
using UnityEngine.Localization.PropertyVariants;
using UnityEngine.Localization.PropertyVariants.TrackedObjects;

namespace Sons.UiElements
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	[DisplayName("UI Sons Dropdown")]
	[CustomTrackedObject(typeof(SonsDropdown), true)]
	[Serializable]
	public class TrackedSonsDropdown : JsonSerializerTrackedObject
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x315E610", Offset = "0x315CC10", VA = "0x18315E610", Slot = "12")]
		protected override void PostApplyTrackedProperties()
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x315E690", Offset = "0x315CC90", VA = "0x18315E690")]
		public TrackedSonsDropdown()
		{
		}
	}
}
