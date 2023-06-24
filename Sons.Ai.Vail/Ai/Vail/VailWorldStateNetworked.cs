using System;
using Bolt;
using Il2CppDummyDll;
using Sons.Areas;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x020000F9 RID: 249
	[Token(Token = "0x20000F9")]
	[AddComponentMenu("Sons/Ai/VailWorldStateNetworked")]
	public class VailWorldStateNetworked : EntityEventListener<IVailWorldState>
	{
		// Token: 0x0600097E RID: 2430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600097E")]
		[Address(RVA = "0x2B852D0", Offset = "0x2B838D0", VA = "0x182B852D0")]
		private void Start()
		{
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600097F")]
		[Address(RVA = "0x2B85470", Offset = "0x2B83A70", VA = "0x182B85470", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000980")]
		[Address(RVA = "0x2B85750", Offset = "0x2B83D50", VA = "0x182B85750")]
		private void OnSetOpenCaveMask()
		{
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000981")]
		[Address(RVA = "0x2B857E0", Offset = "0x2B83DE0", VA = "0x182B857E0")]
		private void OnSetWorldFlags()
		{
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000982")]
		[Address(RVA = "0x2B85880", Offset = "0x2B83E80", VA = "0x182B85880")]
		private void SetOpenCaveMask(int newValue)
		{
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000983")]
		[Address(RVA = "0x2B85980", Offset = "0x2B83F80", VA = "0x182B85980")]
		public void SetCaveOpen(int areaMask, bool isOpen)
		{
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000984")]
		[Address(RVA = "0x2B859A0", Offset = "0x2B83FA0", VA = "0x182B859A0")]
		private void TestOpenCave(AreaMask areaMask)
		{
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x00006510 File Offset: 0x00004710
		[Token(Token = "0x6000985")]
		[Address(RVA = "0x2B859B0", Offset = "0x2B83FB0", VA = "0x182B859B0")]
		public bool IsCaveOpen(int areaMask)
		{
			return default(bool);
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x00006528 File Offset: 0x00004728
		[Token(Token = "0x6000986")]
		[Address(RVA = "0x2B859C0", Offset = "0x2B83FC0", VA = "0x182B859C0")]
		public bool IsAnyCaveOpen()
		{
			return default(bool);
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000987")]
		[Address(RVA = "0x2B859D0", Offset = "0x2B83FD0", VA = "0x182B859D0")]
		public void SetWorldStateFlag(VailWorldStateNetworked.WorldFlags flags)
		{
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x00006540 File Offset: 0x00004740
		[Token(Token = "0x6000988")]
		[Address(RVA = "0x2B85AC0", Offset = "0x2B840C0", VA = "0x182B85AC0")]
		public bool IsWorldFlagSet(VailWorldStateNetworked.WorldFlags flag)
		{
			return default(bool);
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000989")]
		[Address(RVA = "0x2B85AD0", Offset = "0x2B840D0", VA = "0x182B85AD0")]
		public VailWorldStateNetworked()
		{
		}

		// Token: 0x040007A6 RID: 1958
		[Token(Token = "0x40007A6")]
		[FieldOffset(Offset = "0x28")]
		private int _openCaveAreasMask;

		// Token: 0x040007A7 RID: 1959
		[Token(Token = "0x40007A7")]
		[FieldOffset(Offset = "0x2C")]
		private VailWorldStateNetworked.WorldFlags _worldFlags;

		// Token: 0x020000FA RID: 250
		[Token(Token = "0x20000FA")]
		[Flags]
		public enum WorldFlags
		{
			// Token: 0x040007A9 RID: 1961
			[Token(Token = "0x40007A9")]
			DemonBossDead = 1,
			// Token: 0x040007AA RID: 1962
			[Token(Token = "0x40007AA")]
			DemonBossExitOpen = 2,
			// Token: 0x040007AB RID: 1963
			[Token(Token = "0x40007AB")]
			BossMutantDead = 4
		}
	}
}
