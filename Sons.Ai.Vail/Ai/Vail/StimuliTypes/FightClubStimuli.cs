using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Animation.Mae;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001B3 RID: 435
	[Token(Token = "0x20001B3")]
	[AddComponentMenu("Sons/Stimuli/FightClubStimuli")]
	public class FightClubStimuli : MonoBehaviourStimuli
	{
		// Token: 0x06000D14 RID: 3348 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000D14")]
		[Address(RVA = "0x2BA0870", Offset = "0x2B9EE70", VA = "0x182BA0870")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000D15")]
		[Address(RVA = "0x2BA08A0", Offset = "0x2B9EEA0", VA = "0x182BA08A0")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x00007938 File Offset: 0x00005B38
		[Token(Token = "0x6000D16")]
		[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850")]
		public static int GridType()
		{
			return 0;
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D17")]
		[Address(RVA = "0x2BA0920", Offset = "0x2B9EF20", VA = "0x182BA0920")]
		private FightClubStimuli()
		{
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D18")]
		[Address(RVA = "0x2BA0950", Offset = "0x2B9EF50", VA = "0x182BA0950")]
		private void ResetCooldown()
		{
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x00007950 File Offset: 0x00005B50
		[Token(Token = "0x6000D19")]
		[Address(RVA = "0x2BA0960", Offset = "0x2B9EF60", VA = "0x182BA0960", Slot = "11")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x00007968 File Offset: 0x00005B68
		[Token(Token = "0x6000D1A")]
		[Address(RVA = "0x2BA0A30", Offset = "0x2B9F030", VA = "0x182BA0A30")]
		public bool FighterIsWaiting()
		{
			return default(bool);
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D1B")]
		[Address(RVA = "0x2BA0AF0", Offset = "0x2B9F0F0", VA = "0x182BA0AF0")]
		private void SetAnimParam(VailActor actor, AnimationParameter animParam, bool value)
		{
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000D1C")]
		[Address(RVA = "0x2BA0BE0", Offset = "0x2B9F1E0", VA = "0x182BA0BE0")]
		private IEnumerator PerformFight()
		{
			return null;
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D1D")]
		[Address(RVA = "0x2BA0C70", Offset = "0x2B9F270", VA = "0x182BA0C70", Slot = "20")]
		public override void UnRegister(VailActor actor)
		{
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D1E")]
		[Address(RVA = "0x2BA0FB0", Offset = "0x2B9F5B0", VA = "0x182BA0FB0", Slot = "14")]
		public override void OnActorReachedStimuli(WorldSimActor worldActor, VailActor actor)
		{
		}

		// Token: 0x04000898 RID: 2200
		[Token(Token = "0x4000898")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float _cooldownHours;

		// Token: 0x04000899 RID: 2201
		[Token(Token = "0x4000899")]
		[FieldOffset(Offset = "0xB0")]
		private VailActor _actor1;

		// Token: 0x0400089A RID: 2202
		[Token(Token = "0x400089A")]
		[FieldOffset(Offset = "0xB8")]
		private VailActor _actor2;

		// Token: 0x0400089B RID: 2203
		[Token(Token = "0x400089B")]
		[FieldOffset(Offset = "0xC0")]
		private float _lastFightTimeHours;

		// Token: 0x0400089C RID: 2204
		[Token(Token = "0x400089C")]
		[FieldOffset(Offset = "0xC4")]
		private bool _fightStarted;
	}
}
