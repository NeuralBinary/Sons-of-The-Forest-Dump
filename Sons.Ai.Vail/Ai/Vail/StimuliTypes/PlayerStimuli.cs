using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001CA RID: 458
	[Token(Token = "0x20001CA")]
	[AddComponentMenu("Sons/Stimuli/Player Stimuli")]
	public class PlayerStimuli : MonoBehaviourStimuli
	{
		// Token: 0x06000D8A RID: 3466 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000D8A")]
		[Address(RVA = "0x2BA4C90", Offset = "0x2BA3290", VA = "0x182BA4C90")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00007BA8 File Offset: 0x00005DA8
		[Token(Token = "0x6000D8B")]
		[Address(RVA = "0x15FFA90", Offset = "0x15FE090", VA = "0x1815FFA90")]
		public static int GridType()
		{
			return 0;
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D8C")]
		[Address(RVA = "0x2BA4CC0", Offset = "0x2BA32C0", VA = "0x182BA4CC0")]
		private void SetFlag(PlayerStimuli.Flags flag, bool value = true)
		{
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x00007BC0 File Offset: 0x00005DC0
		[Token(Token = "0x6000D8D")]
		[Address(RVA = "0x2BA4CE0", Offset = "0x2BA32E0", VA = "0x182BA4CE0")]
		private bool HasFlag(PlayerStimuli.Flags flag)
		{
			return default(bool);
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D8E")]
		[Address(RVA = "0x2BA4CF0", Offset = "0x2BA32F0", VA = "0x182BA4CF0")]
		public void SetFlagsFromNetwork(int value)
		{
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x00007BD8 File Offset: 0x00005DD8
		[Token(Token = "0x6000D8F")]
		[Address(RVA = "0xAFF400", Offset = "0xAFDA00", VA = "0x180AFF400")]
		public int GetFlags()
		{
			return 0;
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x00007BF0 File Offset: 0x00005DF0
		[Token(Token = "0x6000D90")]
		[Address(RVA = "0xA03DA0", Offset = "0xA023A0", VA = "0x180A03DA0")]
		public bool IsLocalPlayer()
		{
			return default(bool);
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D91")]
		[Address(RVA = "0x2BA4D20", Offset = "0x2BA3320", VA = "0x182BA4D20", Slot = "9")]
		internal override void OnEnable()
		{
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D92")]
		[Address(RVA = "0x2BA4D50", Offset = "0x2BA3350", VA = "0x182BA4D50")]
		public void SetAlive(bool alive)
		{
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D93")]
		[Address(RVA = "0x2BA4EA0", Offset = "0x2BA34A0", VA = "0x182BA4EA0")]
		public void SetDowned(bool downed)
		{
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D94")]
		[Address(RVA = "0x2BA4EC0", Offset = "0x2BA34C0", VA = "0x182BA4EC0")]
		public void SetInvisible(bool invisible)
		{
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D95")]
		[Address(RVA = "0x2BA4EF0", Offset = "0x2BA34F0", VA = "0x182BA4EF0")]
		public void SetCrouched(bool value)
		{
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x00007C08 File Offset: 0x00005E08
		[Token(Token = "0x6000D96")]
		[Address(RVA = "0x2BA4F10", Offset = "0x2BA3510", VA = "0x182BA4F10")]
		public bool IsCrouched()
		{
			return default(bool);
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D97")]
		[Address(RVA = "0x2BA4F20", Offset = "0x2BA3520", VA = "0x182BA4F20")]
		public void SetKnockedDown(bool value)
		{
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x00007C20 File Offset: 0x00005E20
		[Token(Token = "0x6000D98")]
		[Address(RVA = "0x2BA4F50", Offset = "0x2BA3550", VA = "0x182BA4F50")]
		public bool IsKnockedDown()
		{
			return default(bool);
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D99")]
		[Address(RVA = "0x2BA4F60", Offset = "0x2BA3560", VA = "0x182BA4F60")]
		public void SetSwimming(bool value)
		{
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x00007C38 File Offset: 0x00005E38
		[Token(Token = "0x6000D9A")]
		[Address(RVA = "0x2BA4F80", Offset = "0x2BA3580", VA = "0x182BA4F80")]
		public bool IsSwimming()
		{
			return default(bool);
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x00007C50 File Offset: 0x00005E50
		[Token(Token = "0x6000D9B")]
		[Address(RVA = "0x2BA4F90", Offset = "0x2BA3590", VA = "0x182BA4F90")]
		public bool HasMeleeWeapon()
		{
			return default(bool);
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D9C")]
		[Address(RVA = "0x2BA4FA0", Offset = "0x2BA35A0", VA = "0x182BA4FA0")]
		public void SetHasMeleeWeapon(bool value)
		{
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D9D")]
		[Address(RVA = "0x2BA4FC0", Offset = "0x2BA35C0", VA = "0x182BA4FC0")]
		public void SetRedMask(bool value)
		{
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x00007C68 File Offset: 0x00005E68
		[Token(Token = "0x6000D9E")]
		[Address(RVA = "0x2BA4FF0", Offset = "0x2BA35F0", VA = "0x182BA4FF0")]
		public bool HasRedMask()
		{
			return default(bool);
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D9F")]
		[Address(RVA = "0x2BA5000", Offset = "0x2BA3600", VA = "0x182BA5000")]
		public void SetBoundCutscene(bool value)
		{
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DA0")]
		[Address(RVA = "0x2BA5360", Offset = "0x2BA3960", VA = "0x182BA5360")]
		private void ClientSendActorInteractEvent(VailActor actor)
		{
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DA1")]
		[Address(RVA = "0x2BA5510", Offset = "0x2BA3B10", VA = "0x182BA5510")]
		public void StartActorInteract(VailActor actor)
		{
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DA2")]
		[Address(RVA = "0x2BA5770", Offset = "0x2BA3D70", VA = "0x182BA5770")]
		public void EndActorInteract()
		{
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x00007C80 File Offset: 0x00005E80
		[Token(Token = "0x6000DA3")]
		[Address(RVA = "0x2BA5950", Offset = "0x2BA3F50", VA = "0x182BA5950", Slot = "11")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x00007C98 File Offset: 0x00005E98
		[Token(Token = "0x6000DA4")]
		[Address(RVA = "0x2BA5A00", Offset = "0x2BA4000", VA = "0x182BA5A00", Slot = "12")]
		public override bool Validate(VailActor vailActor)
		{
			return default(bool);
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x00007CB0 File Offset: 0x00005EB0
		[Token(Token = "0x6000DA5")]
		[Address(RVA = "0x2BA5A80", Offset = "0x2BA4080", VA = "0x182BA5A80")]
		public bool VirginiaLikesPlayer(int level)
		{
			return default(bool);
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x00007CC8 File Offset: 0x00005EC8
		[Token(Token = "0x6000DA6")]
		[Address(RVA = "0x2BA5B70", Offset = "0x2BA4170", VA = "0x182BA5B70")]
		private int GetVirginiaSentimentLevel()
		{
			return 0;
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DA7")]
		[Address(RVA = "0x2BA5CA0", Offset = "0x2BA42A0", VA = "0x182BA5CA0")]
		public void DisableAimStimuli()
		{
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000DA8")]
		[Address(RVA = "0x2BA5DC0", Offset = "0x2BA43C0", VA = "0x182BA5DC0")]
		public GameObject GetAimStimuli()
		{
			return null;
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000DA9")]
		[Address(RVA = "0x2BA5F90", Offset = "0x2BA4590", VA = "0x182BA5F90")]
		public string GetStimuliFlagsDebug()
		{
			return null;
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DAA")]
		[Address(RVA = "0x2BA5FF0", Offset = "0x2BA45F0", VA = "0x182BA5FF0")]
		public PlayerStimuli()
		{
		}

		// Token: 0x040008B1 RID: 2225
		[Token(Token = "0x40008B1")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private MonoBehaviourStimuli _boundStimuli;

		// Token: 0x040008B2 RID: 2226
		[Token(Token = "0x40008B2")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private PlayerInteractStimuli _interactStimuli;

		// Token: 0x040008B3 RID: 2227
		[Token(Token = "0x40008B3")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private MonoBehaviourStimuli _deadStimuli;

		// Token: 0x040008B4 RID: 2228
		[Token(Token = "0x40008B4")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private bool _localPlayer;

		// Token: 0x040008B5 RID: 2229
		[Token(Token = "0x40008B5")]
		[FieldOffset(Offset = "0xC4")]
		private PlayerStimuli.Flags _stimuliFlags;

		// Token: 0x040008B6 RID: 2230
		[Token(Token = "0x40008B6")]
		[FieldOffset(Offset = "0xC8")]
		private GameObject _playerAimStimuli;

		// Token: 0x020001CB RID: 459
		[Token(Token = "0x20001CB")]
		[Flags]
		private enum Flags
		{
			// Token: 0x040008B8 RID: 2232
			[Token(Token = "0x40008B8")]
			None = 0,
			// Token: 0x040008B9 RID: 2233
			[Token(Token = "0x40008B9")]
			Bound = 2,
			// Token: 0x040008BA RID: 2234
			[Token(Token = "0x40008BA")]
			Downed = 4,
			// Token: 0x040008BB RID: 2235
			[Token(Token = "0x40008BB")]
			Alive = 8,
			// Token: 0x040008BC RID: 2236
			[Token(Token = "0x40008BC")]
			HasMeleeWeapon = 16,
			// Token: 0x040008BD RID: 2237
			[Token(Token = "0x40008BD")]
			Swimming = 32,
			// Token: 0x040008BE RID: 2238
			[Token(Token = "0x40008BE")]
			Crouched = 64,
			// Token: 0x040008BF RID: 2239
			[Token(Token = "0x40008BF")]
			RedMask = 128,
			// Token: 0x040008C0 RID: 2240
			[Token(Token = "0x40008C0")]
			Invisible = 256,
			// Token: 0x040008C1 RID: 2241
			[Token(Token = "0x40008C1")]
			KnockedDown = 512
		}
	}
}
