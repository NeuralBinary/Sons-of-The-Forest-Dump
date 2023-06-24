using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001A1 RID: 417
	[Token(Token = "0x20001A1")]
	public abstract class EventStimuli : MonoBehaviourStimuliValue<EventDescription>
	{
		// Token: 0x06000CBD RID: 3261 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000CBD")]
		[Address(RVA = "0x751010", Offset = "0x74F610", VA = "0x180751010")]
		public EventDescription GetDescription()
		{
			return null;
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000CBE")]
		[Address(RVA = "0x2B9E140", Offset = "0x2B9C740", VA = "0x182B9E140")]
		public IReadOnlyList<StatAdjustmentsByClass> GetAdjustmentLists()
		{
			return null;
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CBF")]
		[Address(RVA = "0x2B9E160", Offset = "0x2B9C760", VA = "0x182B9E160", Slot = "9")]
		internal override void OnEnable()
		{
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CC0")]
		[Address(RVA = "0x2B9E1A0", Offset = "0x2B9C7A0", VA = "0x182B9E1A0", Slot = "10")]
		internal override void OnDisable()
		{
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CC1")]
		[Address(RVA = "0x2B9E210", Offset = "0x2B9C810", VA = "0x182B9E210")]
		private void OnValidate()
		{
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CC2")]
		[Address(RVA = "0x2B9E250", Offset = "0x2B9C850", VA = "0x182B9E250")]
		public void Initialize(VailActor actorSource, MonoBehaviourStimuli stimuliSource)
		{
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CC3")]
		[Address(RVA = "0x2B9E340", Offset = "0x2B9C940", VA = "0x182B9E340")]
		public void ResetPooledEvent()
		{
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CC4")]
		[Address(RVA = "0x2B9E400", Offset = "0x2B9CA00", VA = "0x182B9E400", Slot = "26")]
		public virtual void Fire()
		{
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CC5")]
		[Address(RVA = "0x2B9E570", Offset = "0x2B9CB70", VA = "0x182B9E570")]
		public void PostApply()
		{
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CC6")]
		[Address(RVA = "0x2B9E580", Offset = "0x2B9CB80", VA = "0x182B9E580")]
		private void DoStop()
		{
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x00007710 File Offset: 0x00005910
		[Token(Token = "0x6000CC7")]
		[Address(RVA = "0x2B9E740", Offset = "0x2B9CD40", VA = "0x182B9E740")]
		private bool HasExpired()
		{
			return default(bool);
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CC8")]
		[Address(RVA = "0x2B9E7A0", Offset = "0x2B9CDA0", VA = "0x182B9E7A0")]
		private void Update()
		{
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CC9")]
		[Address(RVA = "0x2B9E920", Offset = "0x2B9CF20", VA = "0x182B9E920")]
		private void CheckAutoDisable()
		{
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CCA")]
		[Address(RVA = "0x2B9E940", Offset = "0x2B9CF40", VA = "0x182B9E940")]
		private void CheckAutoDestruct()
		{
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CCB")]
		[Address(RVA = "0x2B9EA30", Offset = "0x2B9D030", VA = "0x182B9EA30")]
		private void DoAutoDestruct()
		{
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x00007728 File Offset: 0x00005928
		[Token(Token = "0x6000CCC")]
		[Address(RVA = "0x2B9EB00", Offset = "0x2B9D100", VA = "0x182B9EB00")]
		public float GetRange()
		{
			return 0f;
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x00007740 File Offset: 0x00005940
		[Token(Token = "0x6000CCD")]
		[Address(RVA = "0x2B9EB20", Offset = "0x2B9D120", VA = "0x182B9EB20")]
		public bool AffectsActor(VailActor actor)
		{
			return default(bool);
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x00007758 File Offset: 0x00005958
		[Token(Token = "0x6000CCE")]
		[Address(RVA = "0x2B9EB50", Offset = "0x2B9D150", VA = "0x182B9EB50")]
		public bool TryGetFactor(VailActor actor, float timeDelta, out float factor)
		{
			return default(bool);
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x00007770 File Offset: 0x00005970
		[Token(Token = "0x6000CCF")]
		[Address(RVA = "0x2B9ECA0", Offset = "0x2B9D2A0", VA = "0x182B9ECA0")]
		public bool ReserveMoveTo(VailActor requester)
		{
			return default(bool);
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x00007788 File Offset: 0x00005988
		[Token(Token = "0x6000CD0")]
		[Address(RVA = "0x2B9EEB0", Offset = "0x2B9D4B0", VA = "0x182B9EEB0")]
		public bool ShouldIgnore(VailActor actor)
		{
			return default(bool);
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x000077A0 File Offset: 0x000059A0
		[Token(Token = "0x6000CD1")]
		[Address(RVA = "0x2B9F190", Offset = "0x2B9D790", VA = "0x182B9F190", Slot = "12")]
		public override bool Validate(VailActor actor)
		{
			return default(bool);
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000CD2 RID: 3282 RVA: 0x000077B8 File Offset: 0x000059B8
		[Token(Token = "0x170000C4")]
		public bool HasAdjustments
		{
			[Token(Token = "0x6000CD2")]
			[Address(RVA = "0x2B9F4A0", Offset = "0x2B9DAA0", VA = "0x182B9F4A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000CD3")]
		[Address(RVA = "0x2B9F500", Offset = "0x2B9DB00", VA = "0x182B9F500")]
		public MonoBehaviourStimuli GetStimuliSource()
		{
			return null;
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000CD4")]
		[Address(RVA = "0x2B9F520", Offset = "0x2B9DB20", VA = "0x182B9F520")]
		public VailActor GetActorSource()
		{
			return null;
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000CD5 RID: 3285 RVA: 0x000077D0 File Offset: 0x000059D0
		[Token(Token = "0x170000C5")]
		public bool UseSourceStimuliAsTarget
		{
			[Token(Token = "0x6000CD5")]
			[Address(RVA = "0x2B9F540", Offset = "0x2B9DB40", VA = "0x182B9F540")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000CD6 RID: 3286 RVA: 0x000077E8 File Offset: 0x000059E8
		[Token(Token = "0x170000C6")]
		public float BurnDemonTime
		{
			[Token(Token = "0x6000CD6")]
			[Address(RVA = "0x27399D0", Offset = "0x2737FD0", VA = "0x1827399D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000CD7")]
		[Address(RVA = "0x8ECC80", Offset = "0x8EB280", VA = "0x1808ECC80")]
		public MonoBehaviourStimuli GetProxyTarget()
		{
			return null;
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CD8")]
		[Address(RVA = "0x8ECC90", Offset = "0x8EB290", VA = "0x1808ECC90")]
		public void SetProxyTarget(MonoBehaviourStimuli monoBehaviourStimuli)
		{
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x00007800 File Offset: 0x00005A00
		[Token(Token = "0x6000CD9")]
		[Address(RVA = "0x2B9F550", Offset = "0x2B9DB50", VA = "0x182B9F550", Slot = "22")]
		public override float TimeAlive()
		{
			return 0f;
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CDA")]
		[Address(RVA = "0x2B9F5B0", Offset = "0x2B9DBB0", VA = "0x182B9F5B0")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CDB")]
		[Address(RVA = "0x2B9F620", Offset = "0x2B9DC20", VA = "0x182B9F620", Slot = "24")]
		protected override void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CDC")]
		[Address(RVA = "0x2B9F660", Offset = "0x2B9DC60", VA = "0x182B9F660")]
		private void DrawGizmos(Color color)
		{
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CDD")]
		[Address(RVA = "0x2B9CE20", Offset = "0x2B9B420", VA = "0x182B9CE20")]
		protected EventStimuli()
		{
		}

		// Token: 0x04000883 RID: 2179
		[Token(Token = "0x4000883")]
		[FieldOffset(Offset = "0xB0")]
		[Tooltip("If the stats adjustments are filtered, only validate stimuli for the types in filter.")]
		[SerializeField]
		private bool _onlyValidateAffectedActors;

		// Token: 0x04000884 RID: 2180
		[Token(Token = "0x4000884")]
		[FieldOffset(Offset = "0xB1")]
		[SerializeField]
		[Tooltip("If a vail actor generates this, all other actors of the same class will ignore it.")]
		private bool _ignoreFromOwnClass;

		// Token: 0x04000885 RID: 2181
		[Token(Token = "0x4000885")]
		[FieldOffset(Offset = "0xB2")]
		[SerializeField]
		[Tooltip("If a player generates this, will ignore if actor is friendly with player")]
		private bool _ignoreFromFriendlyPlayer;

		// Token: 0x04000886 RID: 2182
		[Token(Token = "0x4000886")]
		[FieldOffset(Offset = "0xB3")]
		[SerializeField]
		[Tooltip("If true, vail actions will target the source of this event instead of the event position.")]
		private bool _useSourceStimuliAsTarget;

		// Token: 0x04000887 RID: 2183
		[Token(Token = "0x4000887")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private bool _reserveOnMoveTo;

		// Token: 0x04000888 RID: 2184
		[Token(Token = "0x4000888")]
		[FieldOffset(Offset = "0xB5")]
		[SerializeField]
		private bool _autoFire;

		// Token: 0x04000889 RID: 2185
		[Token(Token = "0x4000889")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private float _lifeTime;

		// Token: 0x0400088A RID: 2186
		[Token(Token = "0x400088A")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private bool _autoDisable;

		// Token: 0x0400088B RID: 2187
		[Token(Token = "0x400088B")]
		[FieldOffset(Offset = "0xBD")]
		[SerializeField]
		private bool _autoDestruct;

		// Token: 0x0400088C RID: 2188
		[Token(Token = "0x400088C")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private MonoBehaviourStimuli _proxyTarget;

		// Token: 0x0400088D RID: 2189
		[Token(Token = "0x400088D")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private float _maxBurnDemonSeconds;

		// Token: 0x0400088E RID: 2190
		[Token(Token = "0x400088E")]
		[FieldOffset(Offset = "0xCC")]
		private bool _hasFired;

		// Token: 0x0400088F RID: 2191
		[Token(Token = "0x400088F")]
		[FieldOffset(Offset = "0xCD")]
		private bool _hasApplied;

		// Token: 0x04000890 RID: 2192
		[Token(Token = "0x4000890")]
		[FieldOffset(Offset = "0xD0")]
		private float _startTime;

		// Token: 0x04000891 RID: 2193
		[Token(Token = "0x4000891")]
		[FieldOffset(Offset = "0xD8")]
		private VailActor _reservedActor;
	}
}
