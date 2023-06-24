using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001E0 RID: 480
	[Token(Token = "0x20001E0")]
	[AddComponentMenu("Sons/Stimuli/SearchPartyStimuli")]
	public abstract class SearchPartyStimuli : MonoBehaviourStimuli
	{
		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000E16 RID: 3606 RVA: 0x00007F98 File Offset: 0x00006198
		[Token(Token = "0x170000CC")]
		public bool FollowPlayer
		{
			[Token(Token = "0x6000E16")]
			[Address(RVA = "0x2BA9EE0", Offset = "0x2BA84E0", VA = "0x182BA9EE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E17")]
		[Address(RVA = "0x2BA9EF0", Offset = "0x2BA84F0", VA = "0x182BA9EF0")]
		public void SetFollowPlayer(bool active)
		{
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E18")]
		[Address(RVA = "0x2BA9F00", Offset = "0x2BA8500", VA = "0x182BA9F00")]
		public void Initialize(int familyId, VailActorTypeId typeId, float timeInHours, float duration = 3f, int totalUses = -1)
		{
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E19")]
		[Address(RVA = "0x728460", Offset = "0x726A60", VA = "0x180728460")]
		public void SetZone(ZoneStimuli zone)
		{
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000E1A")]
		[Address(RVA = "0x2BA9F30", Offset = "0x2BA8530", VA = "0x182BA9F30", Slot = "26")]
		public virtual string GetDebugName()
		{
			return null;
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x00007FB0 File Offset: 0x000061B0
		[Token(Token = "0x6000E1B")]
		[Address(RVA = "0x2BA9F60", Offset = "0x2BA8560", VA = "0x182BA9F60")]
		public bool IsExpired(float timeInHours)
		{
			return default(bool);
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x00007FC8 File Offset: 0x000061C8
		[Token(Token = "0x6000E1C")]
		[Address(RVA = "0x2BA9F80", Offset = "0x2BA8580", VA = "0x182BA9F80")]
		public bool ShouldDestroy(float timeInHours)
		{
			return default(bool);
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x00007FE0 File Offset: 0x000061E0
		[Token(Token = "0x6000E1D")]
		[Address(RVA = "0x2BA9FB0", Offset = "0x2BA85B0", VA = "0x182BA9FB0", Slot = "12")]
		public override bool Validate(VailActor vailActor)
		{
			return default(bool);
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x00007FF8 File Offset: 0x000061F8
		[Token(Token = "0x6000E1E")]
		[Address(RVA = "0x2BA9FF0", Offset = "0x2BA85F0", VA = "0x182BA9FF0", Slot = "13")]
		public override bool Validate(WorldSimActor worldActor)
		{
			return default(bool);
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E1F")]
		[Address(RVA = "0x2BAA040", Offset = "0x2BA8640", VA = "0x182BAA040", Slot = "14")]
		public override void OnActorReachedStimuli(WorldSimActor worldActor, VailActor actor)
		{
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000E20")]
		[Address(RVA = "0x2BAA060", Offset = "0x2BA8660", VA = "0x182BAA060")]
		public string LogTimeSpan()
		{
			return null;
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E21")]
		[Address(RVA = "0x1243280", Offset = "0x1241880", VA = "0x181243280")]
		protected SearchPartyStimuli()
		{
		}

		// Token: 0x040008DD RID: 2269
		[Token(Token = "0x40008DD")]
		[FieldOffset(Offset = "0xA8")]
		private float _spawnTimeInHours;

		// Token: 0x040008DE RID: 2270
		[Token(Token = "0x40008DE")]
		[FieldOffset(Offset = "0xAC")]
		private float _expireTimeInHours;

		// Token: 0x040008DF RID: 2271
		[Token(Token = "0x40008DF")]
		[FieldOffset(Offset = "0xB0")]
		private int _totalUses;

		// Token: 0x040008E0 RID: 2272
		[Token(Token = "0x40008E0")]
		[FieldOffset(Offset = "0xB4")]
		private bool _followPlayer;

		// Token: 0x040008E1 RID: 2273
		[Token(Token = "0x40008E1")]
		[FieldOffset(Offset = "0xB8")]
		protected ZoneStimuli _zone;

		// Token: 0x040008E2 RID: 2274
		[Token(Token = "0x40008E2")]
		[FieldOffset(Offset = "0xC0")]
		private VailActorTypeId _actorTypeId;
	}
}
