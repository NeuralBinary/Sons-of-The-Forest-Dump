using System;
using System.Collections;
using System.Collections.Generic;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000069 RID: 105
[Token(Token = "0x2000069")]
public class CoopMecanimReplicator : EntityBehaviour<IWorldCharacter>
{
	// Token: 0x060002FA RID: 762 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x2B65D50", Offset = "0x2B64D50", VA = "0x182B65D50")]
	private void OnValidate()
	{
	}

	// Token: 0x060002FB RID: 763 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x2B669C0", Offset = "0x2B659C0", VA = "0x182B669C0")]
	private void UpdateOverrideLookupTable()
	{
	}

	// Token: 0x060002FC RID: 764 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x2B650E0", Offset = "0x2B640E0", VA = "0x182B650E0")]
	private void Awake()
	{
	}

	// Token: 0x060002FD RID: 765 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x2B65D00", Offset = "0x2B64D00", VA = "0x182B65D00")]
	private void OnDisable()
	{
	}

	// Token: 0x060002FE RID: 766 RVA: 0x00002EE0 File Offset: 0x000010E0
	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x2B67C10", Offset = "0x2B66C10", VA = "0x182B67C10")]
	private bool VerifyTargetAnimator()
	{
		return default(bool);
	}

	// Token: 0x060002FF RID: 767 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x2B64C70", Offset = "0x2B63C70", VA = "0x182B64C70", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x06000300 RID: 768 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000300")]
	[Address(RVA = "0x2B65310", Offset = "0x2B64310", VA = "0x182B65310", Slot = "17")]
	public override void Detached()
	{
	}

	// Token: 0x06000301 RID: 769 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000301")]
	[Address(RVA = "0x2B658F0", Offset = "0x2B648F0", VA = "0x182B658F0")]
	public void ForceMecanimSync()
	{
	}

	// Token: 0x06000302 RID: 770 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000302")]
	[Address(RVA = "0x2B65BC0", Offset = "0x2B64BC0", VA = "0x182B65BC0")]
	public void InitialEventSync()
	{
	}

	// Token: 0x06000303 RID: 771 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000303")]
	[Address(RVA = "0x2B65E80", Offset = "0x2B64E80", VA = "0x182B65E80")]
	public void SendStateEventsForCurrentState(int layerIdx = -1)
	{
	}

	// Token: 0x06000304 RID: 772 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000304")]
	[Address(RVA = "0x2B66740", Offset = "0x2B65740", VA = "0x182B66740")]
	private void UpdateMecanimPropertiesFromState()
	{
	}

	// Token: 0x06000305 RID: 773 RVA: 0x00002EF8 File Offset: 0x000010F8
	[Token(Token = "0x6000305")]
	[Address(RVA = "0x2B67D20", Offset = "0x2B66D20", VA = "0x182B67D20")]
	private bool WithinEventDistance()
	{
		return default(bool);
	}

	// Token: 0x06000306 RID: 774 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000306")]
	[Address(RVA = "0x2B65C40", Offset = "0x2B64C40", VA = "0x182B65C40")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000307 RID: 775 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000307")]
	[Address(RVA = "0x2B66450", Offset = "0x2B65450", VA = "0x182B66450")]
	private void SetLayerIndices()
	{
	}

	// Token: 0x06000308 RID: 776 RVA: 0x00002F10 File Offset: 0x00001110
	[Token(Token = "0x6000308")]
	[Address(RVA = "0x2B65A70", Offset = "0x2B64A70", VA = "0x182B65A70")]
	private AnimatorStateInfo GetNextOrCurrentAnimatorState(int layerIndex)
	{
		return default(AnimatorStateInfo);
	}

	// Token: 0x06000309 RID: 777 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000309")]
	[Address(RVA = "0x2B67320", Offset = "0x2B66320", VA = "0x182B67320")]
	private void UpdateOwner()
	{
	}

	// Token: 0x0600030A RID: 778 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600030A")]
	[Address(RVA = "0x2B66BE0", Offset = "0x2B65BE0", VA = "0x182B66BE0")]
	private void UpdateOwnerEventSync()
	{
	}

	// Token: 0x0600030B RID: 779 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600030B")]
	[Address(RVA = "0x2B66130", Offset = "0x2B65130", VA = "0x182B66130")]
	private IEnumerator SendTransitionEventDelayed(int stateHash, int layerArrayIdx, float normalizedTime, BoltEntity entity, bool anyState, int delay)
	{
		return null;
	}

	// Token: 0x0600030C RID: 780 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600030C")]
	[Address(RVA = "0x2B661F0", Offset = "0x2B651F0", VA = "0x182B661F0")]
	private void SendTransitionEvent(int stateHash, int layerArrayIdx, float normalizedTime, BoltEntity entity, bool anyState)
	{
	}

	// Token: 0x0600030D RID: 781 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600030D")]
	[Address(RVA = "0x2B64410", Offset = "0x2B63410", VA = "0x182B64410")]
	public void ApplyHashToRemote(int layerArrayIndex, int hash, bool anyState, float normalizedTime, bool instantTransition)
	{
	}

	// Token: 0x0600030E RID: 782 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600030E")]
	[Address(RVA = "0x2B64580", Offset = "0x2B63580", VA = "0x182B64580")]
	private void ApplyTransitionRemote(int layer, int targetStateHash, bool anyState, float stateNormalizedTime, bool instantTransition, float defaultTransitionTime)
	{
	}

	// Token: 0x0600030F RID: 783 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600030F")]
	[Address(RVA = "0x2B65320", Offset = "0x2B64320", VA = "0x182B65320")]
	private void DoCrossFade(int targetStateHash, int layer, float transitionDuration, float stateNormalizedTime, bool transitionDurationIsFixed)
	{
	}

	// Token: 0x06000310 RID: 784 RVA: 0x00002F28 File Offset: 0x00001128
	[Token(Token = "0x6000310")]
	[Address(RVA = "0x2B65DC0", Offset = "0x2B64DC0", VA = "0x182B65DC0")]
	private int ParseStateHashOverride(int targetStateHash, int layer)
	{
		return default(int);
	}

	// Token: 0x06000311 RID: 785 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000311")]
	[Address(RVA = "0x2B67B20", Offset = "0x2B66B20", VA = "0x182B67B20")]
	private void UpdateRemote(bool updateAnimatorState)
	{
	}

	// Token: 0x06000312 RID: 786 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000312")]
	[Address(RVA = "0x2B677A0", Offset = "0x2B667A0", VA = "0x182B677A0")]
	private void UpdateRemoteTargetAnimatorState(int layerArrayIdx)
	{
	}

	// Token: 0x06000313 RID: 787 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000313")]
	[Address(RVA = "0x2B675D0", Offset = "0x2B665D0", VA = "0x182B675D0")]
	private void UpdateRemoteTargetAnimatorLayerWeight(int layerArrayIdx)
	{
	}

	// Token: 0x06000314 RID: 788 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000314")]
	[Address(RVA = "0x2B66630", Offset = "0x2B65630", VA = "0x182B66630")]
	private void UpdateLayerWeightNetworkState(int layerArrayIdx)
	{
	}

	// Token: 0x06000315 RID: 789 RVA: 0x00002F40 File Offset: 0x00001140
	[Token(Token = "0x6000315")]
	[Address(RVA = "0x2B65850", Offset = "0x2B64850", VA = "0x182B65850")]
	private bool FindTransitionData(int sourceStateHash, int targetStateHash, bool anyState)
	{
		return default(bool);
	}

	// Token: 0x06000316 RID: 790 RVA: 0x00002F58 File Offset: 0x00001158
	[Token(Token = "0x6000316")]
	[Address(RVA = "0x2B65BD0", Offset = "0x2B64BD0", VA = "0x182B65BD0")]
	private bool IsExitTransition(int sourceStateHash, int targetStateHash)
	{
		return default(bool);
	}

	// Token: 0x06000317 RID: 791 RVA: 0x00002F70 File Offset: 0x00001170
	[Token(Token = "0x6000317")]
	[Address(RVA = "0x2B665A0", Offset = "0x2B655A0", VA = "0x182B665A0")]
	private bool TryGetTransitionData(int sourceStateHash, int targetStateHash, bool anyState, out Dictionary<bool, float> data)
	{
		return default(bool);
	}

	// Token: 0x06000318 RID: 792 RVA: 0x00002F88 File Offset: 0x00001188
	[Token(Token = "0x6000318")]
	[Address(RVA = "0x2B65BA0", Offset = "0x2B64BA0", VA = "0x182B65BA0")]
	private static int GetTransitionHash(int sourceStateHash, int targetStateHash, bool anyState)
	{
		return default(int);
	}

	// Token: 0x06000319 RID: 793 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000319")]
	[Address(RVA = "0x2B65210", Offset = "0x2B64210", VA = "0x182B65210")]
	public void CrossFade(string stateName, float durationSeconds, int layer)
	{
	}

	// Token: 0x0600031A RID: 794 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600031A")]
	[Address(RVA = "0x5E65C0", Offset = "0x5E55C0", VA = "0x1805E65C0")]
	public MecanimLayerConfig[] GetLayersToSync()
	{
		return null;
	}

	// Token: 0x0600031B RID: 795 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600031B")]
	[Address(RVA = "0x2B65B00", Offset = "0x2B64B00", VA = "0x182B65B00")]
	public Animator GetTargetAnimator()
	{
		return null;
	}

	// Token: 0x0600031C RID: 796 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600031C")]
	[Address(RVA = "0x2B67DE0", Offset = "0x2B66DE0", VA = "0x182B67DE0")]
	public CoopMecanimReplicator()
	{
	}

	// Token: 0x040002C6 RID: 710
	[Token(Token = "0x40002C6")]
	public const int AnyHash = 1111;

	// Token: 0x040002C7 RID: 711
	[Token(Token = "0x40002C7")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<int, MecanimTransitionOverride> _transitionOverrideLookup;

	// Token: 0x040002C8 RID: 712
	[Token(Token = "0x40002C8")]
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("TargetAnimator")]
	[SerializeField]
	private Animator _targetAnimator;

	// Token: 0x040002C9 RID: 713
	[Token(Token = "0x40002C9")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RuntimeAnimatorController _targetAnimatorController;

	// Token: 0x040002CA RID: 714
	[Token(Token = "0x40002CA")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[FormerlySerializedAs("TransitionData")]
	private CoopMecanimReplicatorTransitionData _transitionData;

	// Token: 0x040002CB RID: 715
	[Token(Token = "0x40002CB")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[FormerlySerializedAs("LayersToSync")]
	private MecanimLayerConfig[] _layersToSync;

	// Token: 0x040002CC RID: 716
	[Token(Token = "0x40002CC")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[FormerlySerializedAs("TransitionOverrides")]
	private MecanimTransitionOverride[] _transitionOverrides;

	// Token: 0x040002CD RID: 717
	[Token(Token = "0x40002CD")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private bool _ignoreStateOverrides;

	// Token: 0x040002CE RID: 718
	[Token(Token = "0x40002CE")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private MecanimStateOverride[] _stateOverrides;

	// Token: 0x040002CF RID: 719
	[Token(Token = "0x40002CF")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Range(0f, 1f)]
	[FormerlySerializedAs("CrossFadeMultiplier")]
	private float _crossFadeMultiplier;

	// Token: 0x040002D0 RID: 720
	[Token(Token = "0x40002D0")]
	[FieldOffset(Offset = "0x6C")]
	[FormerlySerializedAs("isPlayer")]
	[SerializeField]
	private bool _isPlayer;

	// Token: 0x040002D1 RID: 721
	[Token(Token = "0x40002D1")]
	[FieldOffset(Offset = "0x6D")]
	[SerializeField]
	[FormerlySerializedAs("isNetPlayer")]
	private bool _isNetPlayer;

	// Token: 0x040002D2 RID: 722
	[Token(Token = "0x40002D2")]
	[FieldOffset(Offset = "0x6E")]
	[FormerlySerializedAs("useEventBasedSync")]
	[SerializeField]
	private bool _useEventBasedSync;

	// Token: 0x040002D3 RID: 723
	[Token(Token = "0x40002D3")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private int _eventDelayFrames;

	// Token: 0x040002D4 RID: 724
	[Token(Token = "0x40002D4")]
	[FieldOffset(Offset = "0x74")]
	[FormerlySerializedAs("eventDistanceThreshold")]
	[SerializeField]
	private float _eventDistanceThreshold;

	// Token: 0x040002D5 RID: 725
	[Token(Token = "0x40002D5")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private bool _logEvents;

	// Token: 0x040002D6 RID: 726
	[Token(Token = "0x40002D6")]
	[FieldOffset(Offset = "0x79")]
	[SerializeField]
	private bool _logCrossFades;

	// Token: 0x040002D7 RID: 727
	[Token(Token = "0x40002D7")]
	[FieldOffset(Offset = "0x7A")]
	private bool _hasSetLayerIndices;

	// Token: 0x040002D8 RID: 728
	[Token(Token = "0x40002D8")]
	[FieldOffset(Offset = "0x7C")]
	private float _farUpdateTimer;

	// Token: 0x040002D9 RID: 729
	[Token(Token = "0x40002D9")]
	[FieldOffset(Offset = "0x80")]
	private float _playerUpdateTimer;

	// Token: 0x040002DA RID: 730
	[Token(Token = "0x40002DA")]
	[FieldOffset(Offset = "0x88")]
	private readonly Dictionary<int, Dictionary<int, int>> _stateOverrideDictionary;
}
