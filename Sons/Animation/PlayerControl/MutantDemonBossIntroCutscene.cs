using System;
using System.Collections;
using System.Collections.Generic;
using FMOD.Studio;
using Il2CppDummyDll;
using Sons.Characters;
using Sons.Cutscenes;
using UnityEngine;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x02000953 RID: 2387
	[Token(Token = "0x2000953")]
	[AddComponentMenu("Sons/Animation/MutantDemonBossIntroCutscene")]
	public class MutantDemonBossIntroCutscene : EndGameTriggeredCutscene
	{
		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x0600451B RID: 17691 RVA: 0x00015168 File Offset: 0x00013368
		[Token(Token = "0x170008FA")]
		public override int PlayerCutsceneStartHash
		{
			[Token(Token = "0x600451B")]
			[Address(RVA = "0x365EFD0", Offset = "0x365D5D0", VA = "0x18365EFD0", Slot = "18")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x0600451C RID: 17692 RVA: 0x00015180 File Offset: 0x00013380
		[Token(Token = "0x170008FB")]
		public override int TrackedAnimatorCutsceneStateHash
		{
			[Token(Token = "0x600451C")]
			[Address(RVA = "0x365F030", Offset = "0x365D630", VA = "0x18365F030", Slot = "19")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x0600451D RID: 17693 RVA: 0x00015198 File Offset: 0x00013398
		[Token(Token = "0x170008FC")]
		public override bool ShouldStashHeldItems
		{
			[Token(Token = "0x600451D")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x0600451E RID: 17694 RVA: 0x000151B0 File Offset: 0x000133B0
		[Token(Token = "0x170008FD")]
		public override bool ShouldAlignPlayer
		{
			[Token(Token = "0x600451E")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x0600451F RID: 17695 RVA: 0x000151C8 File Offset: 0x000133C8
		[Token(Token = "0x170008FE")]
		public override bool HandlePlayerAnimationMoveEvents
		{
			[Token(Token = "0x600451F")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004520 RID: 17696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004520")]
		[Address(RVA = "0x365F090", Offset = "0x365D690", VA = "0x18365F090", Slot = "33")]
		protected override void OnTriggerEnterPassed(Collider other)
		{
		}

		// Token: 0x06004521 RID: 17697 RVA: 0x000151E0 File Offset: 0x000133E0
		[Token(Token = "0x6004521")]
		[Address(RVA = "0x365F2C0", Offset = "0x365D8C0", VA = "0x18365F2C0", Slot = "9")]
		public override bool Play()
		{
			return default(bool);
		}

		// Token: 0x06004522 RID: 17698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004522")]
		[Address(RVA = "0x365F440", Offset = "0x365DA40", VA = "0x18365F440", Slot = "28")]
		internal override void LateUpdate()
		{
		}

		// Token: 0x06004523 RID: 17699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004523")]
		[Address(RVA = "0x365F790", Offset = "0x365DD90", VA = "0x18365F790")]
		private void TriggerMutantBoss()
		{
		}

		// Token: 0x06004524 RID: 17700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004524")]
		[Address(RVA = "0x365F8F0", Offset = "0x365DEF0", VA = "0x18365F8F0")]
		private void PauseAnimators(bool isPaused)
		{
		}

		// Token: 0x06004525 RID: 17701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004525")]
		[Address(RVA = "0x365FB00", Offset = "0x365E100", VA = "0x18365FB00", Slot = "32")]
		internal override void CutsceneEnded(CutsceneState obj)
		{
		}

		// Token: 0x06004526 RID: 17702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004526")]
		[Address(RVA = "0x365FB30", Offset = "0x365E130", VA = "0x18365FB30")]
		private IEnumerator OnBossKilled()
		{
			return null;
		}

		// Token: 0x06004527 RID: 17703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004527")]
		[Address(RVA = "0x365FBC0", Offset = "0x365E1C0", VA = "0x18365FBC0")]
		public void HideTimmy()
		{
		}

		// Token: 0x06004528 RID: 17704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004528")]
		[Address(RVA = "0x365FC00", Offset = "0x365E200", VA = "0x18365FC00")]
		private IEnumerator HideTimmyObjects()
		{
			return null;
		}

		// Token: 0x06004529 RID: 17705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004529")]
		[Address(RVA = "0x365FC90", Offset = "0x365E290", VA = "0x18365FC90")]
		public MutantDemonBossIntroCutscene()
		{
		}

		// Token: 0x040047C6 RID: 18374
		[Token(Token = "0x40047C6")]
		private const string DemonBossAudioStingEventPath = "event:/SotF_Music/Stings/Demon_Boss_Appears";

		// Token: 0x040047C7 RID: 18375
		[Token(Token = "0x40047C7")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private List<Animator> _cutsceneAnimators;

		// Token: 0x040047C8 RID: 18376
		[Token(Token = "0x40047C8")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private VailBossSpawner _bossSpawner;

		// Token: 0x040047C9 RID: 18377
		[Token(Token = "0x40047C9")]
		[FieldOffset(Offset = "0x198")]
		private bool _bossKilled;

		// Token: 0x040047CA RID: 18378
		[Token(Token = "0x40047CA")]
		[FieldOffset(Offset = "0x199")]
		private bool _isPaused;

		// Token: 0x040047CB RID: 18379
		[Token(Token = "0x40047CB")]
		[FieldOffset(Offset = "0x1A0")]
		private EventInstance _musicInstance;

		// Token: 0x040047CC RID: 18380
		[Token(Token = "0x40047CC")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private GameObject[] _timmyObjects;
	}
}
