using System;
using System.Runtime.CompilerServices;
using Assemblies.Sons.Cinematics;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Cutscenes
{
	// Token: 0x020006AA RID: 1706
	[Token(Token = "0x20006AA")]
	[AddComponentMenu("Sons/Cutscenes/SleepingCutscene")]
	public class SleepingCutscene : Cutscene
	{
		// Token: 0x1400001F RID: 31
		// (add) Token: 0x06002D25 RID: 11557 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002D26 RID: 11558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400001F")]
		public event Action OnFadeToBlackComplete
		{
			[Token(Token = "0x6002D25")]
			[Address(RVA = "0x3431400", Offset = "0x342FA00", VA = "0x183431400")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002D26")]
			[Address(RVA = "0x34314F0", Offset = "0x342FAF0", VA = "0x1834314F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06002D27 RID: 11559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D27")]
		[Address(RVA = "0x34315E0", Offset = "0x342FBE0", VA = "0x1834315E0", Slot = "7")]
		protected override void PostStartHook()
		{
		}

		// Token: 0x06002D28 RID: 11560 RVA: 0x0000D518 File Offset: 0x0000B718
		[Token(Token = "0x6002D28")]
		[Address(RVA = "0x3431730", Offset = "0x342FD30", VA = "0x183431730", Slot = "9")]
		public override bool Play()
		{
			return default(bool);
		}

		// Token: 0x06002D29 RID: 11561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D29")]
		[Address(RVA = "0x3431890", Offset = "0x342FE90", VA = "0x183431890")]
		private void Update()
		{
		}

		// Token: 0x06002D2A RID: 11562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D2A")]
		[Address(RVA = "0x340F5D0", Offset = "0x340DBD0", VA = "0x18340F5D0")]
		public SleepingCutscene()
		{
		}

		// Token: 0x04002791 RID: 10129
		[Token(Token = "0x4002791")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private FadeToBlack _fadeToBlack;

		// Token: 0x04002792 RID: 10130
		[Token(Token = "0x4002792")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private float _timeToHudReveal;

		// Token: 0x04002793 RID: 10131
		[Token(Token = "0x4002793")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private float _cutsceneDuration;

		// Token: 0x04002794 RID: 10132
		[Token(Token = "0x4002794")]
		[FieldOffset(Offset = "0xC0")]
		private float _startTime;

		// Token: 0x04002795 RID: 10133
		[Token(Token = "0x4002795")]
		[FieldOffset(Offset = "0xC4")]
		private bool _cutsceneHasStarted;

		// Token: 0x04002796 RID: 10134
		[Token(Token = "0x4002796")]
		[FieldOffset(Offset = "0xC5")]
		private bool _doingFadeToBlack;

		// Token: 0x04002797 RID: 10135
		[Token(Token = "0x4002797")]
		[FieldOffset(Offset = "0xC6")]
		private bool _doingFadeFromBlack;
	}
}
