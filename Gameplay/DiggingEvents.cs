using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x0200063B RID: 1595
	[Token(Token = "0x200063B")]
	[AddComponentMenu("Sons/Gameplay/DiggingEvents")]
	public class DiggingEvents : MonoBehaviour
	{
		// Token: 0x1400001A RID: 26
		// (add) Token: 0x060028F6 RID: 10486 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060028F7 RID: 10487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400001A")]
		public event Action OnShowMudOnShovel
		{
			[Token(Token = "0x60028F6")]
			[Address(RVA = "0x2DB5D00", Offset = "0x2DB4D00", VA = "0x182DB5D00")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60028F7")]
			[Address(RVA = "0x2DB60C0", Offset = "0x2DB50C0", VA = "0x182DB60C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x060028F8 RID: 10488 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060028F9 RID: 10489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400001B")]
		public event Action OnHideMudOnShovel
		{
			[Token(Token = "0x60028F8")]
			[Address(RVA = "0x2DB5C60", Offset = "0x2DB4C60", VA = "0x182DB5C60")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60028F9")]
			[Address(RVA = "0x2DB6020", Offset = "0x2DB5020", VA = "0x182DB6020")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x060028FA RID: 10490 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060028FB RID: 10491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400001C")]
		public event Action OnDiggingFillStart
		{
			[Token(Token = "0x60028FA")]
			[Address(RVA = "0x2DB5B20", Offset = "0x2DB4B20", VA = "0x182DB5B20")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60028FB")]
			[Address(RVA = "0x2DB5EE0", Offset = "0x2DB4EE0", VA = "0x182DB5EE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x060028FC RID: 10492 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060028FD RID: 10493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400001D")]
		public event Action OnDiggingFillEnd
		{
			[Token(Token = "0x60028FC")]
			[Address(RVA = "0x2DB5A80", Offset = "0x2DB4A80", VA = "0x182DB5A80")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60028FD")]
			[Address(RVA = "0x2DB5E40", Offset = "0x2DB4E40", VA = "0x182DB5E40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x060028FE RID: 10494 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060028FF RID: 10495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400001E")]
		public event Action OnDiggingStart
		{
			[Token(Token = "0x60028FE")]
			[Address(RVA = "0x2DB5BC0", Offset = "0x2DB4BC0", VA = "0x182DB5BC0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60028FF")]
			[Address(RVA = "0x2DB5F80", Offset = "0x2DB4F80", VA = "0x182DB5F80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x06002900 RID: 10496 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002901 RID: 10497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400001F")]
		public event Action OnDiggingEnd
		{
			[Token(Token = "0x6002900")]
			[Address(RVA = "0x2DB59E0", Offset = "0x2DB49E0", VA = "0x182DB59E0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002901")]
			[Address(RVA = "0x2DB5DA0", Offset = "0x2DB4DA0", VA = "0x182DB5DA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06002902 RID: 10498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002902")]
		[Address(RVA = "0x23B3190", Offset = "0x23B2190", VA = "0x1823B3190")]
		public void ShowMudOnShovel()
		{
		}

		// Token: 0x06002903 RID: 10499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002903")]
		[Address(RVA = "0x2A0D0A0", Offset = "0x2A0C0A0", VA = "0x182A0D0A0")]
		public void HideMudOnShovel()
		{
		}

		// Token: 0x06002904 RID: 10500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002904")]
		[Address(RVA = "0x2A0D0C0", Offset = "0x2A0C0C0", VA = "0x182A0D0C0")]
		public void DiggingFillStart()
		{
		}

		// Token: 0x06002905 RID: 10501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002905")]
		[Address(RVA = "0x2DB59A0", Offset = "0x2DB49A0", VA = "0x182DB59A0")]
		public void DiggingFillEnd()
		{
		}

		// Token: 0x06002906 RID: 10502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002906")]
		[Address(RVA = "0x2DB59C0", Offset = "0x2DB49C0", VA = "0x182DB59C0")]
		public void DiggingStart()
		{
		}

		// Token: 0x06002907 RID: 10503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002907")]
		[Address(RVA = "0x2DB5980", Offset = "0x2DB4980", VA = "0x182DB5980")]
		public void DiggingEnd()
		{
		}

		// Token: 0x06002908 RID: 10504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002908")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public DiggingEvents()
		{
		}
	}
}
