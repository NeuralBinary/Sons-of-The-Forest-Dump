using System;
using System.Collections;
using FMOD.Studio;
using Il2CppDummyDll;
using Sons.Characters;
using Sons.Cutscenes;
using UnityEngine;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x0200092A RID: 2346
	[Token(Token = "0x200092A")]
	[AddComponentMenu("Sons/Animation/BossMutantIntroCutscene")]
	public class BossMutantIntroCutscene : EndGameCutscene
	{
		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06004358 RID: 17240 RVA: 0x000146D0 File Offset: 0x000128D0
		[Token(Token = "0x1700088C")]
		public override int PlayerCutsceneStartHash
		{
			[Token(Token = "0x6004358")]
			[Address(RVA = "0x36444C0", Offset = "0x3642AC0", VA = "0x1836444C0", Slot = "18")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06004359 RID: 17241 RVA: 0x000146E8 File Offset: 0x000128E8
		[Token(Token = "0x1700088D")]
		public override int TrackedAnimatorCutsceneStateHash
		{
			[Token(Token = "0x6004359")]
			[Address(RVA = "0x3644520", Offset = "0x3642B20", VA = "0x183644520", Slot = "19")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x0600435A RID: 17242 RVA: 0x00014700 File Offset: 0x00012900
		[Token(Token = "0x1700088E")]
		public override bool HandlePlayerAnimationMoveEvents
		{
			[Token(Token = "0x600435A")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x0600435B RID: 17243 RVA: 0x00014718 File Offset: 0x00012918
		[Token(Token = "0x1700088F")]
		public override bool ShouldEquipPreviouslyHeldItems
		{
			[Token(Token = "0x600435B")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x0600435C RID: 17244 RVA: 0x00014730 File Offset: 0x00012930
		[Token(Token = "0x17000890")]
		public override bool HideRemotePlayers
		{
			[Token(Token = "0x600435C")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600435D RID: 17245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600435D")]
		[Address(RVA = "0x3644580", Offset = "0x3642B80", VA = "0x183644580", Slot = "6")]
		internal override void InitializeHook()
		{
		}

		// Token: 0x0600435E RID: 17246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600435E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "27")]
		internal override void UpdateHook()
		{
		}

		// Token: 0x0600435F RID: 17247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600435F")]
		[Address(RVA = "0x36447E0", Offset = "0x3642DE0", VA = "0x1836447E0", Slot = "28")]
		internal override void LateUpdate()
		{
		}

		// Token: 0x06004360 RID: 17248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004360")]
		[Address(RVA = "0x3644C20", Offset = "0x3643220", VA = "0x183644C20")]
		private void OnDisable()
		{
		}

		// Token: 0x06004361 RID: 17249 RVA: 0x00014748 File Offset: 0x00012948
		[Token(Token = "0x6004361")]
		[Address(RVA = "0x3644C70", Offset = "0x3643270", VA = "0x183644C70", Slot = "9")]
		public override bool Play()
		{
			return default(bool);
		}

		// Token: 0x06004362 RID: 17250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004362")]
		[Address(RVA = "0x3644D60", Offset = "0x3643360", VA = "0x183644D60")]
		private void UpdateBossBattleMusic()
		{
		}

		// Token: 0x06004363 RID: 17251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004363")]
		[Address(RVA = "0x3645050", Offset = "0x3643650", VA = "0x183645050")]
		private void StartBattleMusic()
		{
		}

		// Token: 0x06004364 RID: 17252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004364")]
		[Address(RVA = "0x3644C20", Offset = "0x3643220", VA = "0x183644C20")]
		private void StopBattleMusic()
		{
		}

		// Token: 0x06004365 RID: 17253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004365")]
		[Address(RVA = "0x3645130", Offset = "0x3643730", VA = "0x183645130")]
		public void TriggerMutantBoss()
		{
		}

		// Token: 0x06004366 RID: 17254 RVA: 0x00014760 File Offset: 0x00012960
		[Token(Token = "0x6004366")]
		[Address(RVA = "0x3645360", Offset = "0x3643960", VA = "0x183645360")]
		private static bool VerifyInstance()
		{
			return default(bool);
		}

		// Token: 0x06004367 RID: 17255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004367")]
		[Address(RVA = "0x31C62B0", Offset = "0x31C48B0", VA = "0x1831C62B0")]
		public static void OnBossCutsceneEvent(BossCutsceneEvent ev)
		{
		}

		// Token: 0x06004368 RID: 17256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004368")]
		[Address(RVA = "0x3472420", Offset = "0x3470A20", VA = "0x183472420")]
		public static void OnHideHelicopterPickup()
		{
		}

		// Token: 0x06004369 RID: 17257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004369")]
		[Address(RVA = "0x3645470", Offset = "0x3643A70", VA = "0x183645470")]
		private IEnumerator OnBossKilled()
		{
			return null;
		}

		// Token: 0x0600436A RID: 17258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600436A")]
		[Address(RVA = "0x3645500", Offset = "0x3643B00", VA = "0x183645500")]
		private void PlayChopperCutscene()
		{
		}

		// Token: 0x0600436B RID: 17259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600436B")]
		[Address(RVA = "0x3645660", Offset = "0x3643C60", VA = "0x183645660")]
		private IEnumerator PlayChopperCutsceneWhenReady()
		{
			return null;
		}

		// Token: 0x0600436C RID: 17260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600436C")]
		[Address(RVA = "0x36456F0", Offset = "0x3643CF0", VA = "0x1836456F0", Slot = "32")]
		internal override void CutsceneEnded(CutsceneState result)
		{
		}

		// Token: 0x0600436D RID: 17261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600436D")]
		[Address(RVA = "0x3645780", Offset = "0x3643D80", VA = "0x183645780")]
		public BossMutantIntroCutscene()
		{
		}

		// Token: 0x0400468C RID: 18060
		[Token(Token = "0x400468C")]
		private const string BossAudioStingEventPath = "event:/SotF_Music/Boss/mx_bossstingmutant_v3";

		// Token: 0x0400468D RID: 18061
		[Token(Token = "0x400468D")]
		private const string BossBattleMusicPath = "event:/SotF_Music/Boss/mx_bossFight";

		// Token: 0x0400468E RID: 18062
		[Token(Token = "0x400468E")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private VailBossSpawner _bossSpawner;

		// Token: 0x0400468F RID: 18063
		[Token(Token = "0x400468F")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private bool _spawnBossOnCutsceneEnd;

		// Token: 0x04004690 RID: 18064
		[Token(Token = "0x4004690")]
		[FieldOffset(Offset = "0x18C")]
		[SerializeField]
		private float _battleMusicStartDistance;

		// Token: 0x04004691 RID: 18065
		[Token(Token = "0x4004691")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private float _battleMusicStopDistance;

		// Token: 0x04004692 RID: 18066
		[Token(Token = "0x4004692")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private GameObject _helicopterPickup;

		// Token: 0x04004693 RID: 18067
		[Token(Token = "0x4004693")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private float _waitTimeWhenKilled;

		// Token: 0x04004694 RID: 18068
		[Token(Token = "0x4004694")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private Cutscene _cutsceneOnBossKilled;

		// Token: 0x04004695 RID: 18069
		[Token(Token = "0x4004695")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private GameObject[] _hideOnBossKilled;

		// Token: 0x04004696 RID: 18070
		[Token(Token = "0x4004696")]
		[FieldOffset(Offset = "0x1B8")]
		private bool _spawnedBoss;

		// Token: 0x04004697 RID: 18071
		[Token(Token = "0x4004697")]
		[FieldOffset(Offset = "0x1B9")]
		private bool _bossKilled;

		// Token: 0x04004698 RID: 18072
		[Token(Token = "0x4004698")]
		[FieldOffset(Offset = "0x1BA")]
		private bool _isPaused;

		// Token: 0x04004699 RID: 18073
		[Token(Token = "0x4004699")]
		[FieldOffset(Offset = "0x1C0")]
		private EventInstance _bossBattleMusicInstance;

		// Token: 0x0400469A RID: 18074
		[Token(Token = "0x400469A")]
		[FieldOffset(Offset = "0x1C8")]
		private bool _musicPlaying;

		// Token: 0x0400469B RID: 18075
		[Token(Token = "0x400469B")]
		[FieldOffset(Offset = "0x0")]
		private static BossMutantIntroCutscene _instance;
	}
}
