using System;
using System.Runtime.CompilerServices;
using Assemblies.Sons.Cinematics;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Cutscenes
{
	// Token: 0x0200079F RID: 1951
	[Token(Token = "0x200079F")]
	[AddComponentMenu("Sons/Cutscenes/SleepingCutscene")]
	public class SleepingCutscene : Cutscene
	{
		// Token: 0x14000026 RID: 38
		// (add) Token: 0x060033AD RID: 13229 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060033AE RID: 13230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000026")]
		public event Action OnFadeToBlackComplete
		{
			[Token(Token = "0x60033AD")]
			[Address(RVA = "0x2E696C0", Offset = "0x2E686C0", VA = "0x182E696C0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60033AE")]
			[Address(RVA = "0x2E69760", Offset = "0x2E68760", VA = "0x182E69760")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060033AF RID: 13231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033AF")]
		[Address(RVA = "0x2E69580", Offset = "0x2E68580", VA = "0x182E69580", Slot = "7")]
		protected override void PostStartHook()
		{
		}

		// Token: 0x060033B0 RID: 13232 RVA: 0x0000EC40 File Offset: 0x0000CE40
		[Token(Token = "0x60033B0")]
		[Address(RVA = "0x2E694E0", Offset = "0x2E684E0", VA = "0x182E694E0", Slot = "9")]
		public override bool Play()
		{
			return default(bool);
		}

		// Token: 0x060033B1 RID: 13233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033B1")]
		[Address(RVA = "0x2E69600", Offset = "0x2E68600", VA = "0x182E69600")]
		private void Update()
		{
		}

		// Token: 0x060033B2 RID: 13234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033B2")]
		[Address(RVA = "0x2E45D40", Offset = "0x2E44D40", VA = "0x182E45D40")]
		public SleepingCutscene()
		{
		}

		// Token: 0x04002CBE RID: 11454
		[Token(Token = "0x4002CBE")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private FadeToBlack _fadeToBlack;

		// Token: 0x04002CBF RID: 11455
		[Token(Token = "0x4002CBF")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private float _timeToHudReveal;

		// Token: 0x04002CC0 RID: 11456
		[Token(Token = "0x4002CC0")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private float _cutsceneDuration;

		// Token: 0x04002CC1 RID: 11457
		[Token(Token = "0x4002CC1")]
		[FieldOffset(Offset = "0xC0")]
		private float _startTime;

		// Token: 0x04002CC2 RID: 11458
		[Token(Token = "0x4002CC2")]
		[FieldOffset(Offset = "0xC4")]
		private bool _cutsceneHasStarted;

		// Token: 0x04002CC3 RID: 11459
		[Token(Token = "0x4002CC3")]
		[FieldOffset(Offset = "0xC5")]
		private bool _doingFadeToBlack;

		// Token: 0x04002CC4 RID: 11460
		[Token(Token = "0x4002CC4")]
		[FieldOffset(Offset = "0xC6")]
		private bool _doingFadeFromBlack;
	}
}
