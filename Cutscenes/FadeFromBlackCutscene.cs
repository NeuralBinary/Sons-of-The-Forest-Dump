using System;
using Assemblies.Sons.Cinematics;
using Endnight.Utilities.Timer;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Cutscenes
{
	// Token: 0x0200076F RID: 1903
	[Token(Token = "0x200076F")]
	[AddComponentMenu("Sons/Cutscenes/FadeFromBlackCutscene")]
	public class FadeFromBlackCutscene : Cutscene
	{
		// Token: 0x060031F9 RID: 12793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031F9")]
		[Address(RVA = "0x2E45860", Offset = "0x2E44860", VA = "0x182E45860", Slot = "7")]
		protected override void PostStartHook()
		{
		}

		// Token: 0x060031FA RID: 12794 RVA: 0x0000E490 File Offset: 0x0000C690
		[Token(Token = "0x60031FA")]
		[Address(RVA = "0x2E45640", Offset = "0x2E44640", VA = "0x182E45640", Slot = "9")]
		public override bool Play()
		{
			return default(bool);
		}

		// Token: 0x060031FB RID: 12795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031FB")]
		[Address(RVA = "0x2E45AF0", Offset = "0x2E44AF0", VA = "0x182E45AF0")]
		private void Update()
		{
		}

		// Token: 0x060031FC RID: 12796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031FC")]
		[Address(RVA = "0x2E45920", Offset = "0x2E44920", VA = "0x182E45920")]
		private void SetEnded()
		{
		}

		// Token: 0x060031FD RID: 12797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031FD")]
		[Address(RVA = "0x2E45900", Offset = "0x2E44900", VA = "0x182E45900")]
		private static void RevealHud()
		{
		}

		// Token: 0x060031FE RID: 12798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031FE")]
		[Address(RVA = "0x2E45D40", Offset = "0x2E44D40", VA = "0x182E45D40")]
		public FadeFromBlackCutscene()
		{
		}

		// Token: 0x04002B97 RID: 11159
		[Token(Token = "0x4002B97")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private FadeToBlack _fadeToBlack;

		// Token: 0x04002B98 RID: 11160
		[Token(Token = "0x4002B98")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private float _timeToHudReveal;

		// Token: 0x04002B99 RID: 11161
		[Token(Token = "0x4002B99")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private float _cutsceneDuration;

		// Token: 0x04002B9A RID: 11162
		[Token(Token = "0x4002B9A")]
		[FieldOffset(Offset = "0xC0")]
		private float _startTime;

		// Token: 0x04002B9B RID: 11163
		[Token(Token = "0x4002B9B")]
		[FieldOffset(Offset = "0xC4")]
		private bool _cutsceneHasStarted;

		// Token: 0x04002B9C RID: 11164
		[Token(Token = "0x4002B9C")]
		[FieldOffset(Offset = "0xC8")]
		private AutoTimer _hudRevealTimer;

		// Token: 0x04002B9D RID: 11165
		[Token(Token = "0x4002B9D")]
		[FieldOffset(Offset = "0xD0")]
		private AutoTimer _durationTimer;
	}
}
