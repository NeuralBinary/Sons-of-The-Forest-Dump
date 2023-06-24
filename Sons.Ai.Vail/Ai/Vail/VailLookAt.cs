using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Ai.Vail
{
	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000050")]
	public class VailLookAt : MonoBehaviour
	{
		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x00003C18 File Offset: 0x00001E18
		[Token(Token = "0x1700004B")]
		public bool LookAtWorldStimuli
		{
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x5FD5C0", Offset = "0x5FBBC0", VA = "0x1805FD5C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000423")]
		[Address(RVA = "0x2B0F720", Offset = "0x2B0DD20", VA = "0x182B0F720")]
		private void Awake()
		{
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000424")]
		[Address(RVA = "0x2B0F920", Offset = "0x2B0DF20", VA = "0x182B0F920")]
		public void Tick(VailActor actor, State actorState, float curAnimSpeed)
		{
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000425")]
		[Address(RVA = "0x2B10350", Offset = "0x2B0E950", VA = "0x182B10350")]
		public void SetEnabled(bool newEnabled)
		{
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00003C30 File Offset: 0x00001E30
		[Token(Token = "0x6000426")]
		[Address(RVA = "0x2B104A0", Offset = "0x2B0EAA0", VA = "0x182B104A0")]
		private float GetTargetWeight(Vector3 eyePos)
		{
			return 0f;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x2B10730", Offset = "0x2B0ED30", VA = "0x182B10730")]
		private void UpdateLookAtWeights(float targetWeight)
		{
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x2B10850", Offset = "0x2B0EE50", VA = "0x182B10850")]
		public void SetTargetStimuli(MonoBehaviourStimuli newTarget)
		{
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x728330", Offset = "0x726930", VA = "0x180728330")]
		public void SetTargetWeight(float targetWeight)
		{
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600042A")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0")]
		private IEnumerable GetStateTreeView()
		{
			return null;
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600042B")]
		[Address(RVA = "0x2B10A60", Offset = "0x2B0F060", VA = "0x182B10A60")]
		public VailLookAt()
		{
		}

		// Token: 0x04000341 RID: 833
		[Token(Token = "0x4000341")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LookAtIK _lookAtIk;

		// Token: 0x04000342 RID: 834
		[Token(Token = "0x4000342")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _lookAtIkTarget;

		// Token: 0x04000343 RID: 835
		[Token(Token = "0x4000343")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<LookAtState> _lookAtStates;

		// Token: 0x04000344 RID: 836
		[Token(Token = "0x4000344")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _lookAtWorldStimuli;

		// Token: 0x04000345 RID: 837
		[Token(Token = "0x4000345")]
		[FieldOffset(Offset = "0x3C")]
		[Tooltip("In Degrees per Second")]
		[SerializeField]
		private float _maxRotationRate;

		// Token: 0x04000346 RID: 838
		[Token(Token = "0x4000346")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[FormerlySerializedAs("_speed")]
		private float _onSpeed;

		// Token: 0x04000347 RID: 839
		[Token(Token = "0x4000347")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _offSpeed;

		// Token: 0x04000348 RID: 840
		[Token(Token = "0x4000348")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _swapStimuliCooldown;

		// Token: 0x04000349 RID: 841
		[Token(Token = "0x4000349")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private State _currentState;

		// Token: 0x0400034A RID: 842
		[Token(Token = "0x400034A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Range(0f, 180f)]
		private float _angleThreshold;

		// Token: 0x0400034B RID: 843
		[Token(Token = "0x400034B")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _animatorSpeedThreshold;

		// Token: 0x0400034C RID: 844
		[Token(Token = "0x400034C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private List<string> _disableAnimationTags;

		// Token: 0x0400034D RID: 845
		[Token(Token = "0x400034D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private bool _alwaysDisable;

		// Token: 0x0400034E RID: 846
		[Token(Token = "0x400034E")]
		[FieldOffset(Offset = "0x84")]
		private Vector3 _lookAtPosition;

		// Token: 0x0400034F RID: 847
		[Token(Token = "0x400034F")]
		[FieldOffset(Offset = "0x90")]
		private float _localLookYaw;

		// Token: 0x04000350 RID: 848
		[Token(Token = "0x4000350")]
		[FieldOffset(Offset = "0x94")]
		private float _localLookPitch;

		// Token: 0x04000351 RID: 849
		[Token(Token = "0x4000351")]
		[FieldOffset(Offset = "0x98")]
		private float _targetWeight;

		// Token: 0x04000352 RID: 850
		[Token(Token = "0x4000352")]
		[FieldOffset(Offset = "0xA0")]
		private readonly List<int> _disableAnimTagHashes;

		// Token: 0x04000353 RID: 851
		[Token(Token = "0x4000353")]
		[FieldOffset(Offset = "0xA8")]
		private MonoBehaviourStimuli _targetStimuli;

		// Token: 0x04000354 RID: 852
		[Token(Token = "0x4000354")]
		[FieldOffset(Offset = "0xB0")]
		private float _lastTargetChangeTime;
	}
}
