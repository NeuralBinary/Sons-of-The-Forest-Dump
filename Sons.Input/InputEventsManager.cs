using System;
using System.Runtime.CompilerServices;
using Endnight.Types;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Input
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	[AddComponentMenu("Sons/Gui/InputEventsManager")]
	public class InputEventsManager : SingletonBehaviour<InputEventsManager>
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000026 RID: 38 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x06000027 RID: 39 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000001")]
		public static event Action OnPreviousPage
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x3064D60", Offset = "0x3063360", VA = "0x183064D60")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x3064E70", Offset = "0x3063470", VA = "0x183064E70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000028 RID: 40 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x06000029 RID: 41 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000002")]
		public static event Action OnNextPage
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x3064F80", Offset = "0x3063580", VA = "0x183064F80")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x3065090", Offset = "0x3063690", VA = "0x183065090")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600002A RID: 42 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x0600002B RID: 43 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000003")]
		public static event Action OnPreviousChapter
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x30651A0", Offset = "0x30637A0", VA = "0x1830651A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x30652B0", Offset = "0x30638B0", VA = "0x1830652B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600002C RID: 44 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x0600002D RID: 45 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000004")]
		public static event Action OnNextChapter
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x30653C0", Offset = "0x30639C0", VA = "0x1830653C0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x30654D0", Offset = "0x3063AD0", VA = "0x1830654D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600002E RID: 46 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x0600002F RID: 47 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000005")]
		public static event Action OnBack
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x30655E0", Offset = "0x3063BE0", VA = "0x1830655E0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x30656F0", Offset = "0x3063CF0", VA = "0x1830656F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000030 RID: 48 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x06000031 RID: 49 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000006")]
		public static event Action OnEsc
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x3065800", Offset = "0x3063E00", VA = "0x183065800")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x3065910", Offset = "0x3063F10", VA = "0x183065910")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000032 RID: 50 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x06000033 RID: 51 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000007")]
		public static event Action OnCycleBack
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x3065A20", Offset = "0x3064020", VA = "0x183065A20")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x3065B30", Offset = "0x3064130", VA = "0x183065B30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000034 RID: 52 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x06000035 RID: 53 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000008")]
		public static event Action OnCycleForward
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x3065C40", Offset = "0x3064240", VA = "0x183065C40")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x3065D50", Offset = "0x3064350", VA = "0x183065D50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000036 RID: 54 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x06000037 RID: 55 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000009")]
		public static event Action OnApply
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x3065E60", Offset = "0x3064460", VA = "0x183065E60")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x3065F70", Offset = "0x3064570", VA = "0x183065F70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000038 RID: 56 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x06000039 RID: 57 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1400000A")]
		public static event Action OnConfirm
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x3066080", Offset = "0x3064680", VA = "0x183066080")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x3066190", Offset = "0x3064790", VA = "0x183066190")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x0600003A RID: 58 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x0600003B RID: 59 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1400000B")]
		public static event Action OnReset
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x30662A0", Offset = "0x30648A0", VA = "0x1830662A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x30663B0", Offset = "0x30649B0", VA = "0x1830663B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x30664C0", Offset = "0x3064AC0", VA = "0x1830664C0")]
		private void Update()
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x3066AC0", Offset = "0x30650C0", VA = "0x183066AC0")]
		private void EvaluateAction(InputSystem.Action eventAction, Action eventTarget)
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x3066B40", Offset = "0x3065140", VA = "0x183066B40")]
		public InputEventsManager()
		{
		}
	}
}
