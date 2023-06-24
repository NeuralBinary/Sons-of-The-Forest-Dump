using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000758 RID: 1880
	[Token(Token = "0x2000758")]
	[AddComponentMenu("Sons/Gameplay/DiggingEvents")]
	public class DiggingEvents : MonoBehaviour
	{
		// Token: 0x14000022 RID: 34
		// (add) Token: 0x060032D5 RID: 13013 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060032D6 RID: 13014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000022")]
		public event Action OnShowMudOnShovel
		{
			[Token(Token = "0x60032D5")]
			[Address(RVA = "0x34AC3F0", Offset = "0x34AA9F0", VA = "0x1834AC3F0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60032D6")]
			[Address(RVA = "0x34AC4E0", Offset = "0x34AAAE0", VA = "0x1834AC4E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000023 RID: 35
		// (add) Token: 0x060032D7 RID: 13015 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060032D8 RID: 13016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000023")]
		public event Action OnHideMudOnShovel
		{
			[Token(Token = "0x60032D7")]
			[Address(RVA = "0x34AC5D0", Offset = "0x34AABD0", VA = "0x1834AC5D0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60032D8")]
			[Address(RVA = "0x34AC6C0", Offset = "0x34AACC0", VA = "0x1834AC6C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000024 RID: 36
		// (add) Token: 0x060032D9 RID: 13017 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060032DA RID: 13018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000024")]
		public event Action OnDiggingFillStart
		{
			[Token(Token = "0x60032D9")]
			[Address(RVA = "0x34AC7B0", Offset = "0x34AADB0", VA = "0x1834AC7B0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60032DA")]
			[Address(RVA = "0x34AC8A0", Offset = "0x34AAEA0", VA = "0x1834AC8A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000025 RID: 37
		// (add) Token: 0x060032DB RID: 13019 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060032DC RID: 13020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000025")]
		public event Action OnDiggingFillEnd
		{
			[Token(Token = "0x60032DB")]
			[Address(RVA = "0x34AC990", Offset = "0x34AAF90", VA = "0x1834AC990")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60032DC")]
			[Address(RVA = "0x34ACA80", Offset = "0x34AB080", VA = "0x1834ACA80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000026 RID: 38
		// (add) Token: 0x060032DD RID: 13021 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060032DE RID: 13022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000026")]
		public event Action OnDiggingStart
		{
			[Token(Token = "0x60032DD")]
			[Address(RVA = "0x34ACB70", Offset = "0x34AB170", VA = "0x1834ACB70")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60032DE")]
			[Address(RVA = "0x34ACC60", Offset = "0x34AB260", VA = "0x1834ACC60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000027 RID: 39
		// (add) Token: 0x060032DF RID: 13023 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060032E0 RID: 13024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000027")]
		public event Action OnDiggingEnd
		{
			[Token(Token = "0x60032DF")]
			[Address(RVA = "0x34ACD50", Offset = "0x34AB350", VA = "0x1834ACD50")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60032E0")]
			[Address(RVA = "0x34ACE40", Offset = "0x34AB440", VA = "0x1834ACE40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060032E1 RID: 13025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032E1")]
		[Address(RVA = "0x282D840", Offset = "0x282BE40", VA = "0x18282D840")]
		public void ShowMudOnShovel()
		{
		}

		// Token: 0x060032E2 RID: 13026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032E2")]
		[Address(RVA = "0x2FF7310", Offset = "0x2FF5910", VA = "0x182FF7310")]
		public void HideMudOnShovel()
		{
		}

		// Token: 0x060032E3 RID: 13027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032E3")]
		[Address(RVA = "0x2FF7330", Offset = "0x2FF5930", VA = "0x182FF7330")]
		public void DiggingFillStart()
		{
		}

		// Token: 0x060032E4 RID: 13028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032E4")]
		[Address(RVA = "0x34ACF30", Offset = "0x34AB530", VA = "0x1834ACF30")]
		public void DiggingFillEnd()
		{
		}

		// Token: 0x060032E5 RID: 13029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032E5")]
		[Address(RVA = "0x34ACF50", Offset = "0x34AB550", VA = "0x1834ACF50")]
		public void DiggingStart()
		{
		}

		// Token: 0x060032E6 RID: 13030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032E6")]
		[Address(RVA = "0x34ACF70", Offset = "0x34AB570", VA = "0x1834ACF70")]
		public void DiggingEnd()
		{
		}

		// Token: 0x060032E7 RID: 13031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032E7")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public DiggingEvents()
		{
		}
	}
}
