using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay.Grabber
{
	// Token: 0x020006F4 RID: 1780
	[Token(Token = "0x20006F4")]
	public class GenericGrabberTargetProvider : IGrabberTargetProvider
	{
		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06002DEB RID: 11755 RVA: 0x0000D0C8 File Offset: 0x0000B2C8
		// (set) Token: 0x06002DEC RID: 11756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005AE")]
		public bool HasTarget
		{
			[Token(Token = "0x6002DEB")]
			[Address(RVA = "0x576380", Offset = "0x575380", VA = "0x180576380")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002DEC")]
			[Address(RVA = "0x576790", Offset = "0x575790", VA = "0x180576790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06002DED RID: 11757 RVA: 0x0000D0E0 File Offset: 0x0000B2E0
		// (set) Token: 0x06002DEE RID: 11758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005AF")]
		public bool CleanTargetAfterSelect
		{
			[Token(Token = "0x6002DED")]
			[Address(RVA = "0x5763B0", Offset = "0x5753B0", VA = "0x1805763B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002DEE")]
			[Address(RVA = "0x5767C0", Offset = "0x5757C0", VA = "0x1805767C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06002DEF RID: 11759 RVA: 0x0000D0F8 File Offset: 0x0000B2F8
		// (set) Token: 0x06002DF0 RID: 11760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B0")]
		public float TargetScore
		{
			[Token(Token = "0x6002DEF")]
			[Address(RVA = "0x6849B0", Offset = "0x6839B0", VA = "0x1806849B0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6002DF0")]
			[Address(RVA = "0x8EE4E0", Offset = "0x8ED4E0", VA = "0x1808EE4E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06002DF1 RID: 11761 RVA: 0x0000D110 File Offset: 0x0000B310
		// (set) Token: 0x06002DF2 RID: 11762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B1")]
		public bool IsFocused
		{
			[Token(Token = "0x6002DF1")]
			[Address(RVA = "0x6B3E80", Offset = "0x6B2E80", VA = "0x1806B3E80", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002DF2")]
			[Address(RVA = "0x6B3E90", Offset = "0x6B2E90", VA = "0x1806B3E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06002DF3 RID: 11763 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002DF4 RID: 11764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B2")]
		public Collider FocusedCollider
		{
			[Token(Token = "0x6002DF3")]
			[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002DF4")]
			[Address(RVA = "0x541240", Offset = "0x540240", VA = "0x180541240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06002DF5 RID: 11765 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002DF6 RID: 11766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B3")]
		public GameObject FocusedItemGO
		{
			[Token(Token = "0x6002DF5")]
			[Address(RVA = "0x541230", Offset = "0x540230", VA = "0x180541230", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002DF6")]
			[Address(RVA = "0x541270", Offset = "0x540270", VA = "0x180541270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002DF7 RID: 11767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DF7")]
		[Address(RVA = "0x2E073B0", Offset = "0x2E063B0", VA = "0x182E073B0")]
		public void SetTarget(GameObject go, bool cleanupTargetAfterSelect)
		{
		}

		// Token: 0x06002DF8 RID: 11768 RVA: 0x0000D128 File Offset: 0x0000B328
		[Token(Token = "0x6002DF8")]
		[Address(RVA = "0x2E07470", Offset = "0x2E06470", VA = "0x182E07470", Slot = "4")]
		public bool TryGetTargetScore(out float targetScore)
		{
			return default(bool);
		}

		// Token: 0x06002DF9 RID: 11769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DF9")]
		[Address(RVA = "0x2E07300", Offset = "0x2E06300", VA = "0x182E07300", Slot = "5")]
		public void SelectTarget()
		{
		}

		// Token: 0x06002DFA RID: 11770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DFA")]
		[Address(RVA = "0x10D3900", Offset = "0x10D2900", VA = "0x1810D3900", Slot = "6")]
		public void DeselectTarget()
		{
		}

		// Token: 0x06002DFB RID: 11771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DFB")]
		[Address(RVA = "0x2E07490", Offset = "0x2E06490", VA = "0x182E07490")]
		public GenericGrabberTargetProvider()
		{
		}
	}
}
