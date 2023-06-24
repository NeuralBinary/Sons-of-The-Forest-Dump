using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.StatSystem;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x0200019E RID: 414
	[Token(Token = "0x200019E")]
	[Serializable]
	public class EventDescription
	{
		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x00007620 File Offset: 0x00005820
		[Token(Token = "0x170000C3")]
		public bool HasAdjustments
		{
			[Token(Token = "0x6000CAB")]
			[Address(RVA = "0x2B9D660", Offset = "0x2B9BC60", VA = "0x182B9D660")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x00007638 File Offset: 0x00005838
		[Token(Token = "0x6000CAC")]
		[Address(RVA = "0x2B9D6B0", Offset = "0x2B9BCB0", VA = "0x182B9D6B0")]
		private bool IsCurveFalloff()
		{
			return default(bool);
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x00007650 File Offset: 0x00005850
		[Token(Token = "0x6000CAD")]
		[Address(RVA = "0x5EA820", Offset = "0x5E8E20", VA = "0x1805EA820")]
		public float GetRange()
		{
			return 0f;
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x00007668 File Offset: 0x00005868
		[Token(Token = "0x6000CAE")]
		[Address(RVA = "0x2B9D6C0", Offset = "0x2B9BCC0", VA = "0x182B9D6C0")]
		public float GetRangeSqr()
		{
			return 0f;
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x00007680 File Offset: 0x00005880
		[Token(Token = "0x6000CAF")]
		[Address(RVA = "0x620330", Offset = "0x61E930", VA = "0x180620330")]
		public bool IsInstant()
		{
			return default(bool);
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x00007698 File Offset: 0x00005898
		[Token(Token = "0x6000CB0")]
		[Address(RVA = "0x5EA840", Offset = "0x5E8E40", VA = "0x1805EA840")]
		public float GetActiveAngle()
		{
			return 0f;
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB1")]
		[Address(RVA = "0x2B9D6D0", Offset = "0x2B9BCD0", VA = "0x182B9D6D0")]
		public void SetIsAura()
		{
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB2")]
		[Address(RVA = "0x2B9D6E0", Offset = "0x2B9BCE0", VA = "0x182B9D6E0")]
		public void OnValidate(string name)
		{
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000CB3")]
		[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
		public IReadOnlyList<StatAdjustmentsByClass> GetAdjustmentLists()
		{
			return null;
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x000076B0 File Offset: 0x000058B0
		[Token(Token = "0x6000CB4")]
		[Address(RVA = "0x2B9DAF0", Offset = "0x2B9C0F0", VA = "0x182B9DAF0")]
		public bool TryGetFactor(VailActor actor, Vector3 eventPosition, Vector3 eventForward, float timeDelta, out float factor)
		{
			return default(bool);
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x000076C8 File Offset: 0x000058C8
		[Token(Token = "0x6000CB5")]
		[Address(RVA = "0x2B9DDF0", Offset = "0x2B9C3F0", VA = "0x182B9DDF0")]
		public float EvaluateFalloff(float linearFactor, float timeDelta)
		{
			return 0f;
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x000076E0 File Offset: 0x000058E0
		[Token(Token = "0x6000CB6")]
		[Address(RVA = "0x2B9DEC0", Offset = "0x2B9C4C0", VA = "0x182B9DEC0")]
		private float EvaluateFalloffInternal(float linearFactor)
		{
			return 0f;
		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000CB7")]
		[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
		public MonoBehaviourStimuli GetStimuliSource()
		{
			return null;
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000CB8")]
		[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
		public VailActor GetActorSource()
		{
			return null;
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB9")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public void SetActorSource(VailActor actorSource)
		{
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CBA")]
		[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
		public void SetStimuliSource(MonoBehaviourStimuli stimuliSource)
		{
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x000076F8 File Offset: 0x000058F8
		[Token(Token = "0x6000CBB")]
		[Address(RVA = "0x2B9DFA0", Offset = "0x2B9C5A0", VA = "0x182B9DFA0")]
		public bool AffectsActorType(VailActor actor)
		{
			return default(bool);
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CBC")]
		[Address(RVA = "0x2B9E130", Offset = "0x2B9C730", VA = "0x182B9E130")]
		public EventDescription()
		{
		}

		// Token: 0x0400086F RID: 2159
		[Token(Token = "0x400086F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Header("Owner")]
		private VailActor _actorSource;

		// Token: 0x04000870 RID: 2160
		[Token(Token = "0x4000870")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MonoBehaviourStimuli _stimuliSource;

		// Token: 0x04000871 RID: 2161
		[Token(Token = "0x4000871")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("Affect Options")]
		private float _range;

		// Token: 0x04000872 RID: 2162
		[Token(Token = "0x4000872")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Tooltip("Max degrees from forward direction affected")]
		private float _directionalDegrees;

		// Token: 0x04000873 RID: 2163
		[Token(Token = "0x4000873")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private EventDescription.FalloffType _falloffType;

		// Token: 0x04000874 RID: 2164
		[Token(Token = "0x4000874")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimationCurve _falloff;

		// Token: 0x04000875 RID: 2165
		[Token(Token = "0x4000875")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private EventDescription.ApplyEventType _adjustmentType;

		// Token: 0x04000876 RID: 2166
		[Token(Token = "0x4000876")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<StatAdjustmentsByClass> _adjustmentsByClass;

		// Token: 0x04000877 RID: 2167
		[Token(Token = "0x4000877")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<VailActorClassId> _affectsActorClasses;

		// Token: 0x04000878 RID: 2168
		[Token(Token = "0x4000878")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<VailActorTypeId> _affectsActorTypes;

		// Token: 0x04000879 RID: 2169
		[Token(Token = "0x4000879")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<StatAdjustment> _adjustments;

		// Token: 0x0200019F RID: 415
		[Token(Token = "0x200019F")]
		public enum ApplyEventType
		{
			// Token: 0x0400087B RID: 2171
			[Token(Token = "0x400087B")]
			RatePerSecond,
			// Token: 0x0400087C RID: 2172
			[Token(Token = "0x400087C")]
			Instant
		}

		// Token: 0x020001A0 RID: 416
		[Token(Token = "0x20001A0")]
		public enum FalloffType
		{
			// Token: 0x0400087E RID: 2174
			[Token(Token = "0x400087E")]
			Boolean,
			// Token: 0x0400087F RID: 2175
			[Token(Token = "0x400087F")]
			Linear = 3,
			// Token: 0x04000880 RID: 2176
			[Token(Token = "0x4000880")]
			Squared = 1,
			// Token: 0x04000881 RID: 2177
			[Token(Token = "0x4000881")]
			Cubed = 4,
			// Token: 0x04000882 RID: 2178
			[Token(Token = "0x4000882")]
			Curve = 2
		}
	}
}
