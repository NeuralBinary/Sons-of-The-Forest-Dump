using System;
using Assemblies.Sons.Cinematics;
using Endnight.Utilities.Timer;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Cutscenes
{
	// Token: 0x0200067A RID: 1658
	[Token(Token = "0x200067A")]
	[AddComponentMenu("Sons/Cutscenes/FadeFromBlackCutscene")]
	public class FadeFromBlackCutscene : Cutscene
	{
		// Token: 0x06002B70 RID: 11120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B70")]
		[Address(RVA = "0x340ED30", Offset = "0x340D330", VA = "0x18340ED30", Slot = "7")]
		protected override void PostStartHook()
		{
		}

		// Token: 0x06002B71 RID: 11121 RVA: 0x0000CD68 File Offset: 0x0000AF68
		[Token(Token = "0x6002B71")]
		[Address(RVA = "0x340EEF0", Offset = "0x340D4F0", VA = "0x18340EEF0", Slot = "9")]
		public override bool Play()
		{
			return default(bool);
		}

		// Token: 0x06002B72 RID: 11122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B72")]
		[Address(RVA = "0x340F1C0", Offset = "0x340D7C0", VA = "0x18340F1C0")]
		private void Update()
		{
		}

		// Token: 0x06002B73 RID: 11123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B73")]
		[Address(RVA = "0x340F550", Offset = "0x340DB50", VA = "0x18340F550")]
		private void SetEnded()
		{
		}

		// Token: 0x06002B74 RID: 11124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B74")]
		[Address(RVA = "0x340F570", Offset = "0x340DB70", VA = "0x18340F570")]
		private static void RevealHud()
		{
		}

		// Token: 0x06002B75 RID: 11125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B75")]
		[Address(RVA = "0x340F5D0", Offset = "0x340DBD0", VA = "0x18340F5D0")]
		public FadeFromBlackCutscene()
		{
		}

		// Token: 0x0400266A RID: 9834
		[Token(Token = "0x400266A")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private FadeToBlack _fadeToBlack;

		// Token: 0x0400266B RID: 9835
		[Token(Token = "0x400266B")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private float _timeToHudReveal;

		// Token: 0x0400266C RID: 9836
		[Token(Token = "0x400266C")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private float _cutsceneDuration;

		// Token: 0x0400266D RID: 9837
		[Token(Token = "0x400266D")]
		[FieldOffset(Offset = "0xC0")]
		private float _startTime;

		// Token: 0x0400266E RID: 9838
		[Token(Token = "0x400266E")]
		[FieldOffset(Offset = "0xC4")]
		private bool _cutsceneHasStarted;

		// Token: 0x0400266F RID: 9839
		[Token(Token = "0x400266F")]
		[FieldOffset(Offset = "0xC8")]
		private AutoTimer _hudRevealTimer;

		// Token: 0x04002670 RID: 9840
		[Token(Token = "0x4002670")]
		[FieldOffset(Offset = "0xD0")]
		private AutoTimer _durationTimer;
	}
}
