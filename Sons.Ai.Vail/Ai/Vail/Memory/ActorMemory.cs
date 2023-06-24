using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Ai.Vail.Influences;
using Sons.StatSystem;
using UnityEngine;

namespace Sons.Ai.Vail.Memory
{
	// Token: 0x02000208 RID: 520
	[Token(Token = "0x2000208")]
	[AddComponentMenu("Sons/Ai/Actor Memory")]
	public class ActorMemory : MonoBehaviour
	{
		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000EE1 RID: 3809 RVA: 0x00008430 File Offset: 0x00006630
		[Token(Token = "0x170000CD")]
		public float MaxEventDistanceSqr
		{
			[Token(Token = "0x6000EE1")]
			[Address(RVA = "0x2B9D6C0", Offset = "0x2B9BCC0", VA = "0x182B9D6C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000EE2 RID: 3810 RVA: 0x00008448 File Offset: 0x00006648
		[Token(Token = "0x170000CE")]
		public int UniqueId
		{
			[Token(Token = "0x6000EE2")]
			[Address(RVA = "0x65D0F0", Offset = "0x65B6F0", VA = "0x18065D0F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EE3")]
		[Address(RVA = "0x2BB09F0", Offset = "0x2BAEFF0", VA = "0x182BB09F0")]
		public void SetWorldSimActor(WorldSimActor worldActor)
		{
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EE4")]
		[Address(RVA = "0x2BB0A70", Offset = "0x2BAF070", VA = "0x182BB0A70")]
		private void OnEnable()
		{
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EE5")]
		[Address(RVA = "0x2BB0AE0", Offset = "0x2BAF0E0", VA = "0x182BB0AE0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x00008460 File Offset: 0x00006660
		[Token(Token = "0x6000EE6")]
		[Address(RVA = "0x2BB0BA0", Offset = "0x2BAF1A0", VA = "0x182BB0BA0")]
		public float Sample(MemoryEvent type)
		{
			return 0f;
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x00008478 File Offset: 0x00006678
		[Token(Token = "0x6000EE7")]
		[Address(RVA = "0x2BB0C00", Offset = "0x2BAF200", VA = "0x182BB0C00")]
		public float SampleShouldFight(VailActor actor)
		{
			return 0f;
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EE8")]
		[Address(RVA = "0x2BB0D50", Offset = "0x2BAF350", VA = "0x182BB0D50")]
		public void OnHitByActor(VailActor actor)
		{
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EE9")]
		[Address(RVA = "0x2BB0EE0", Offset = "0x2BAF4E0", VA = "0x182BB0EE0")]
		public void ClearMemory()
		{
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EEA")]
		[Address(RVA = "0x2BB1060", Offset = "0x2BAF660", VA = "0x182BB1060")]
		public void Apply(IReadOnlyList<StatAdjustment> adjustments, MonoBehaviourStimuli source, float factor = 1f)
		{
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EEB")]
		public void Adjust<T>(MonoBehaviourStimuli stimuli, float amount) where T : Influence
		{
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000EEC")]
		[Address(RVA = "0x2BB14A0", Offset = "0x2BAFAA0", VA = "0x182BB14A0")]
		public StimuliInfluenceValues Evaluate(MonoBehaviourStimuli stimuli)
		{
			return null;
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000EED")]
		[Address(RVA = "0x2BB15D0", Offset = "0x2BAFBD0", VA = "0x182BB15D0")]
		public string DebugString(out int numLines)
		{
			return null;
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EEE")]
		[Address(RVA = "0x2BB1840", Offset = "0x2BAFE40", VA = "0x182BB1840")]
		public ActorMemory()
		{
		}

		// Token: 0x04000902 RID: 2306
		[Token(Token = "0x4000902")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _maxEventDistance;

		// Token: 0x04000903 RID: 2307
		[Token(Token = "0x4000903")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private StimuliInfluenceDefaults _defaultInfluences;

		// Token: 0x04000904 RID: 2308
		[Token(Token = "0x4000904")]
		[FieldOffset(Offset = "0x30")]
		private int _actorUniqueId;

		// Token: 0x04000905 RID: 2309
		[Token(Token = "0x4000905")]
		[FieldOffset(Offset = "0x34")]
		private int _familyUniqueId;
	}
}
