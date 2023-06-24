using System;
using System.Collections;
using System.Collections.Generic;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000066 RID: 102
[Token(Token = "0x2000066")]
public class CoopMecanimReplicator : EntityBehaviour<IWorldCharacter>
{
	// Token: 0x060002FD RID: 765 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x31BC320", Offset = "0x31BA920", VA = "0x1831BC320")]
	private void OnValidate()
	{
	}

	// Token: 0x060002FE RID: 766 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x31BC370", Offset = "0x31BA970", VA = "0x1831BC370")]
	private void UpdateOverrideLookupTable()
	{
	}

	// Token: 0x060002FF RID: 767 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x31BC660", Offset = "0x31BAC60", VA = "0x1831BC660")]
	private void Awake()
	{
	}

	// Token: 0x06000300 RID: 768 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000300")]
	[Address(RVA = "0x31BC820", Offset = "0x31BAE20", VA = "0x1831BC820")]
	private void OnDisable()
	{
	}

	// Token: 0x06000301 RID: 769 RVA: 0x00002F88 File Offset: 0x00001188
	[Token(Token = "0x6000301")]
	[Address(RVA = "0x31BC870", Offset = "0x31BAE70", VA = "0x1831BC870")]
	private bool VerifyTargetAnimator()
	{
		return default(bool);
	}

	// Token: 0x06000302 RID: 770 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000302")]
	[Address(RVA = "0x31BC9F0", Offset = "0x31BAFF0", VA = "0x1831BC9F0", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x06000303 RID: 771 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000303")]
	[Address(RVA = "0x31BCDF0", Offset = "0x31BB3F0", VA = "0x1831BCDF0", Slot = "17")]
	public override void Detached()
	{
	}

	// Token: 0x06000304 RID: 772 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000304")]
	[Address(RVA = "0x31BCE40", Offset = "0x31BB440", VA = "0x1831BCE40")]
	public void ForceMecanimSync()
	{
	}

	// Token: 0x06000305 RID: 773 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000305")]
	[Address(RVA = "0x31BD020", Offset = "0x31BB620", VA = "0x1831BD020")]
	public void InitialEventSync()
	{
	}

	// Token: 0x06000306 RID: 774 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000306")]
	[Address(RVA = "0x31BD030", Offset = "0x31BB630", VA = "0x1831BD030")]
	public void SendStateEventsForCurrentState(int layerIdx = -1)
	{
	}

	// Token: 0x06000307 RID: 775 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000307")]
	[Address(RVA = "0x31BD280", Offset = "0x31BB880", VA = "0x1831BD280")]
	private void UpdateMecanimPropertiesFromState()
	{
	}

	// Token: 0x06000308 RID: 776 RVA: 0x00002FA0 File Offset: 0x000011A0
	[Token(Token = "0x6000308")]
	[Address(RVA = "0x31BD5B0", Offset = "0x31BBBB0", VA = "0x1831BD5B0")]
	private bool WithinEventDistance()
	{
		return default(bool);
	}

	// Token: 0x06000309 RID: 777 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000309")]
	[Address(RVA = "0x31BD6E0", Offset = "0x31BBCE0", VA = "0x1831BD6E0")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600030A RID: 778 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600030A")]
	[Address(RVA = "0x31BD7A0", Offset = "0x31BBDA0", VA = "0x1831BD7A0")]
	private void SetLayerIndices()
	{
	}

	// Token: 0x0600030B RID: 779 RVA: 0x00002FB8 File Offset: 0x000011B8
	[Token(Token = "0x600030B")]
	[Address(RVA = "0x31BD950", Offset = "0x31BBF50", VA = "0x1831BD950")]
	private AnimatorStateInfo GetNextOrCurrentAnimatorState(int layerIndex)
	{
		return default(AnimatorStateInfo);
	}

	// Token: 0x0600030C RID: 780 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600030C")]
	[Address(RVA = "0x31BDA30", Offset = "0x31BC030", VA = "0x1831BDA30")]
	private void UpdateOwner()
	{
	}

	// Token: 0x0600030D RID: 781 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600030D")]
	[Address(RVA = "0x31BDE30", Offset = "0x31BC430", VA = "0x1831BDE30")]
	private void UpdateOwnerEventSync()
	{
	}

	// Token: 0x0600030E RID: 782 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600030E")]
	[Address(RVA = "0x31BE500", Offset = "0x31BCB00", VA = "0x1831BE500")]
	private IEnumerator SendTransitionEventDelayed(int stateHash, int layerArrayIdx, float normalizedTime, BoltEntity boltEntity, bool anyState, int delay)
	{
		return null;
	}

	// Token: 0x0600030F RID: 783 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600030F")]
	[Address(RVA = "0x31BE640", Offset = "0x31BCC40", VA = "0x1831BE640")]
	private void SendTransitionEvent(int stateHash, int layerArrayIdx, float normalizedTime, BoltEntity boltEntity, bool anyState)
	{
	}

	// Token: 0x06000310 RID: 784 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000310")]
	[Address(RVA = "0x31BEAB0", Offset = "0x31BD0B0", VA = "0x1831BEAB0")]
	public void ApplyHashToRemote(int layerArrayIndex, int hash, bool anyState, float normalizedTime, bool instantTransition)
	{
	}

	// Token: 0x06000311 RID: 785 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000311")]
	[Address(RVA = "0x31BEC10", Offset = "0x31BD210", VA = "0x1831BEC10")]
	private void ApplyTransitionRemote(int layer, int targetStateHash, bool anyState, float stateNormalizedTime, bool instantTransition, float defaultTransitionTime)
	{
	}

	// Token: 0x06000312 RID: 786 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000312")]
	[Address(RVA = "0x31BF450", Offset = "0x31BDA50", VA = "0x1831BF450")]
	private void DoCrossFade(int targetStateHash, int layer, float transitionDuration, float stateNormalizedTime, bool transitionDurationIsFixed)
	{
	}

	// Token: 0x06000313 RID: 787 RVA: 0x00002FD0 File Offset: 0x000011D0
	[Token(Token = "0x6000313")]
	[Address(RVA = "0x31BF980", Offset = "0x31BDF80", VA = "0x1831BF980")]
	private int ParseStateHashOverride(int targetStateHash, int layer)
	{
		return 0;
	}

	// Token: 0x06000314 RID: 788 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000314")]
	[Address(RVA = "0x31BFA70", Offset = "0x31BE070", VA = "0x1831BFA70")]
	private void UpdateRemote(bool updateAnimatorState)
	{
	}

	// Token: 0x06000315 RID: 789 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000315")]
	[Address(RVA = "0x31BFB90", Offset = "0x31BE190", VA = "0x1831BFB90")]
	private void UpdateRemoteTargetAnimatorState(int layerArrayIdx)
	{
	}

	// Token: 0x06000316 RID: 790 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000316")]
	[Address(RVA = "0x31BFF90", Offset = "0x31BE590", VA = "0x1831BFF90")]
	private void UpdateRemoteTargetAnimatorLayerWeight(int layerArrayIdx)
	{
	}

	// Token: 0x06000317 RID: 791 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000317")]
	[Address(RVA = "0x31C0230", Offset = "0x31BE830", VA = "0x1831C0230")]
	private void UpdateLayerWeightNetworkState(int layerArrayIdx)
	{
	}

	// Token: 0x06000318 RID: 792 RVA: 0x00002FE8 File Offset: 0x000011E8
	[Token(Token = "0x6000318")]
	[Address(RVA = "0x31C03B0", Offset = "0x31BE9B0", VA = "0x1831C03B0")]
	private bool FindTransitionData(int sourceStateHash, int targetStateHash, bool anyState)
	{
		return default(bool);
	}

	// Token: 0x06000319 RID: 793 RVA: 0x00003000 File Offset: 0x00001200
	[Token(Token = "0x6000319")]
	[Address(RVA = "0x31C0450", Offset = "0x31BEA50", VA = "0x1831C0450")]
	private bool IsExitTransition(int sourceStateHash, int targetStateHash)
	{
		return default(bool);
	}

	// Token: 0x0600031A RID: 794 RVA: 0x00003018 File Offset: 0x00001218
	[Token(Token = "0x600031A")]
	[Address(RVA = "0x31C04E0", Offset = "0x31BEAE0", VA = "0x1831C04E0")]
	private bool TryGetTransitionData(int sourceStateHash, int targetStateHash, bool anyState, out Dictionary<bool, float> data)
	{
		return default(bool);
	}

	// Token: 0x0600031B RID: 795 RVA: 0x00003030 File Offset: 0x00001230
	[Token(Token = "0x600031B")]
	[Address(RVA = "0x31C0570", Offset = "0x31BEB70", VA = "0x1831C0570")]
	private static int GetTransitionHash(int sourceStateHash, int targetStateHash, bool anyState)
	{
		return 0;
	}

	// Token: 0x0600031C RID: 796 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600031C")]
	[Address(RVA = "0x31C0590", Offset = "0x31BEB90", VA = "0x1831C0590")]
	public void CrossFade(string stateName, float durationSeconds, int layer)
	{
	}

	// Token: 0x0600031D RID: 797 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600031D")]
	[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
	public MecanimLayerConfig[] GetLayersToSync()
	{
		return null;
	}

	// Token: 0x0600031E RID: 798 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600031E")]
	[Address(RVA = "0x31C0720", Offset = "0x31BED20", VA = "0x1831C0720")]
	public Animator GetTargetAnimator()
	{
		return null;
	}

	// Token: 0x0600031F RID: 799 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600031F")]
	[Address(RVA = "0x31C0820", Offset = "0x31BEE20", VA = "0x1831C0820")]
	public CoopMecanimReplicator()
	{
	}

	// Token: 0x040002C8 RID: 712
	[Token(Token = "0x40002C8")]
	public const int AnyHash = 1111;

	// Token: 0x040002C9 RID: 713
	[Token(Token = "0x40002C9")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<int, MecanimTransitionOverride> _transitionOverrideLookup;

	// Token: 0x040002CA RID: 714
	[Token(Token = "0x40002CA")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[FormerlySerializedAs("TargetAnimator")]
	private Animator _targetAnimator;

	// Token: 0x040002CB RID: 715
	[Token(Token = "0x40002CB")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RuntimeAnimatorController _targetAnimatorController;

	// Token: 0x040002CC RID: 716
	[Token(Token = "0x40002CC")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[FormerlySerializedAs("TransitionData")]
	private CoopMecanimReplicatorTransitionData _transitionData;

	// Token: 0x040002CD RID: 717
	[Token(Token = "0x40002CD")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[FormerlySerializedAs("LayersToSync")]
	private MecanimLayerConfig[] _layersToSync;

	// Token: 0x040002CE RID: 718
	[Token(Token = "0x40002CE")]
	[FieldOffset(Offset = "0x50")]
	[FormerlySerializedAs("TransitionOverrides")]
	[SerializeField]
	private MecanimTransitionOverride[] _transitionOverrides;

	// Token: 0x040002CF RID: 719
	[Token(Token = "0x40002CF")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private bool _ignoreStateOverrides;

	// Token: 0x040002D0 RID: 720
	[Token(Token = "0x40002D0")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private MecanimStateOverride[] _stateOverrides;

	// Token: 0x040002D1 RID: 721
	[Token(Token = "0x40002D1")]
	[FieldOffset(Offset = "0x68")]
	[FormerlySerializedAs("CrossFadeMultiplier")]
	[SerializeField]
	[Range(0f, 1f)]
	private float _crossFadeMultiplier;

	// Token: 0x040002D2 RID: 722
	[Token(Token = "0x40002D2")]
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	[FormerlySerializedAs("isPlayer")]
	private bool _isPlayer;

	// Token: 0x040002D3 RID: 723
	[Token(Token = "0x40002D3")]
	[FieldOffset(Offset = "0x6D")]
	[SerializeField]
	[FormerlySerializedAs("isNetPlayer")]
	private bool _isNetPlayer;

	// Token: 0x040002D4 RID: 724
	[Token(Token = "0x40002D4")]
	[FieldOffset(Offset = "0x6E")]
	[FormerlySerializedAs("useEventBasedSync")]
	[SerializeField]
	private bool _useEventBasedSync;

	// Token: 0x040002D5 RID: 725
	[Token(Token = "0x40002D5")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private int _eventDelayFrames;

	// Token: 0x040002D6 RID: 726
	[Token(Token = "0x40002D6")]
	[FieldOffset(Offset = "0x74")]
	[FormerlySerializedAs("eventDistanceThreshold")]
	[SerializeField]
	private float _eventDistanceThreshold;

	// Token: 0x040002D7 RID: 727
	[Token(Token = "0x40002D7")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private bool _logEvents;

	// Token: 0x040002D8 RID: 728
	[Token(Token = "0x40002D8")]
	[FieldOffset(Offset = "0x79")]
	[SerializeField]
	private bool _logCrossFades;

	// Token: 0x040002D9 RID: 729
	[Token(Token = "0x40002D9")]
	[FieldOffset(Offset = "0x7A")]
	private bool _hasSetLayerIndices;

	// Token: 0x040002DA RID: 730
	[Token(Token = "0x40002DA")]
	[FieldOffset(Offset = "0x7C")]
	private float _farUpdateTimer;

	// Token: 0x040002DB RID: 731
	[Token(Token = "0x40002DB")]
	[FieldOffset(Offset = "0x80")]
	private float _playerUpdateTimer;

	// Token: 0x040002DC RID: 732
	[Token(Token = "0x40002DC")]
	[FieldOffset(Offset = "0x88")]
	private readonly Dictionary<int, Dictionary<int, int>> _stateOverrideDictionary;
}
