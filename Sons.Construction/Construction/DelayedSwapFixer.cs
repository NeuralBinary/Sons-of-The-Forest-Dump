using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020000D7 RID: 215
	[Token(Token = "0x20000D7")]
	[AddComponentMenu("Sons/Construction/Multiplayer/DelayedSwapFixer")]
	public class DelayedSwapFixer : EntityBehaviour<ILogState>
	{
		// Token: 0x0600065B RID: 1627 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600065B")]
		[Address(RVA = "0x2E2F360", Offset = "0x2E2D960", VA = "0x182E2F360")]
		public static void GameStartReset()
		{
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600065C")]
		[Address(RVA = "0x2E2F420", Offset = "0x2E2DA20", VA = "0x182E2F420")]
		public static IProtocolToken GetToken()
		{
			return null;
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600065D")]
		[Address(RVA = "0x2E2F520", Offset = "0x2E2DB20", VA = "0x182E2F520", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600065E")]
		[Address(RVA = "0x2E2F830", Offset = "0x2E2DE30", VA = "0x182E2F830")]
		private void FinalizeSwap()
		{
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600065F")]
		[Address(RVA = "0x2E2FC70", Offset = "0x2E2E270", VA = "0x182E2FC70", Slot = "17")]
		public override void Detached()
		{
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000660")]
		[Address(RVA = "0x2E30140", Offset = "0x2E2E740", VA = "0x182E30140")]
		private List<DelayedSwapFixer.PendingSwap> GetSwapListFor(BoltEntity fromEntity)
		{
			return null;
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000661")]
		[Address(RVA = "0x2E30290", Offset = "0x2E2E890", VA = "0x182E30290")]
		public DelayedSwapFixer()
		{
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000663")]
		[Address(RVA = "0x2E30490", Offset = "0x2E2EA90", VA = "0x182E30490")]
		[CompilerGenerated]
		private IEnumerator <Attached>g__WaitForTransformPosition|6_0()
		{
			return null;
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000664")]
		[Address(RVA = "0x2E30520", Offset = "0x2E2EB20", VA = "0x182E30520")]
		[CompilerGenerated]
		internal static void <FinalizeSwap>g__LogDoneSwap|7_0(ref DelayedSwapFixer.<>c__DisplayClass7_0 A_0)
		{
		}

		// Token: 0x040004F2 RID: 1266
		[Token(Token = "0x40004F2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Renderer[] _renderers;

		// Token: 0x040004F3 RID: 1267
		[Token(Token = "0x40004F3")]
		[FieldOffset(Offset = "0x0")]
		private static int _tokenNum;

		// Token: 0x040004F4 RID: 1268
		[Token(Token = "0x40004F4")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<BoltEntity, List<DelayedSwapFixer.PendingSwap>> PendingSwaps;

		// Token: 0x040004F5 RID: 1269
		[Token(Token = "0x40004F5")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Dictionary<BoltEntity, int> DoneSwaps;

		// Token: 0x020000D8 RID: 216
		[Token(Token = "0x20000D8")]
		public class PendingSwap
		{
			// Token: 0x17000206 RID: 518
			// (get) Token: 0x06000665 RID: 1637 RVA: 0x00004CC4 File Offset: 0x00002EC4
			// (set) Token: 0x06000666 RID: 1638 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000206")]
			public int Num
			{
				[Token(Token = "0x6000665")]
				[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6000666")]
				[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000207 RID: 519
			// (get) Token: 0x06000667 RID: 1639 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x06000668 RID: 1640 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000207")]
			public Renderer[] Renderers
			{
				[Token(Token = "0x6000667")]
				[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000668")]
				[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06000669 RID: 1641 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000669")]
			[Address(RVA = "0x2E306B0", Offset = "0x2E2ECB0", VA = "0x182E306B0")]
			public void MaintainRenderers()
			{
			}

			// Token: 0x0600066A RID: 1642 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600066A")]
			[Address(RVA = "0x2E30850", Offset = "0x2E2EE50", VA = "0x182E30850")]
			public void ClearRenderers()
			{
			}

			// Token: 0x0600066B RID: 1643 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600066B")]
			[Address(RVA = "0x2E30A20", Offset = "0x2E2F020", VA = "0x182E30A20")]
			public void ClearRenderersNextFrame()
			{
			}

			// Token: 0x0600066C RID: 1644 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600066C")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public PendingSwap()
			{
			}

			// Token: 0x0600066D RID: 1645 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x600066D")]
			[Address(RVA = "0x2E30B10", Offset = "0x2E2F110", VA = "0x182E30B10")]
			[CompilerGenerated]
			private IEnumerator <ClearRenderersNextFrame>g__Routine|10_0()
			{
				return null;
			}
		}
	}
}
