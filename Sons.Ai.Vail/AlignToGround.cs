using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
[AddComponentMenu("Sons/Ai/Align To Ground")]
public class AlignToGround : MonoBehaviour
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x7AAFD0", Offset = "0x7A95D0", VA = "0x1807AAFD0")]
	public void SetAlignActive(bool active)
	{
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2AE23A0", Offset = "0x2AE09A0", VA = "0x182AE23A0")]
	public void SetSnapActive(bool snapActive)
	{
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2AE23B0", Offset = "0x2AE09B0", VA = "0x182AE23B0")]
	public void SetStateEnabled(bool stateEnabled)
	{
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x270DEF0", Offset = "0x270C4F0", VA = "0x18270DEF0")]
	public void SetApplyLimits(bool limitsActive)
	{
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x270DF00", Offset = "0x270C500", VA = "0x18270DF00")]
	public void SetForcedByAnim(bool forceActiveByAnim)
	{
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000006")]
	[Address(RVA = "0x2AE23C0", Offset = "0x2AE09C0", VA = "0x182AE23C0")]
	public void SetPitchOverride(bool forcePitchActive, float forcedPitch)
	{
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2AE23D0", Offset = "0x2AE09D0", VA = "0x182AE23D0")]
	private void Awake()
	{
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2AE23E0", Offset = "0x2AE09E0", VA = "0x182AE23E0")]
	private void OnValidate()
	{
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2AE2520", Offset = "0x2AE0B20", VA = "0x182AE2520")]
	public void ResetToDefaults()
	{
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2AE2540", Offset = "0x2AE0B40", VA = "0x182AE2540")]
	private void GetTargetAlignment(out float targetPitch, out float targetRoll)
	{
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x2AE30A0", Offset = "0x2AE16A0", VA = "0x182AE30A0")]
	private void UpdateTargetRotation(float distanceToCamera, bool forceInactive)
	{
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000C")]
	[Address(RVA = "0x2AE31B0", Offset = "0x2AE17B0", VA = "0x182AE31B0")]
	public void Tick(float deltaTime, float distanceToCamera, State currentState)
	{
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x2AE3570", Offset = "0x2AE1B70", VA = "0x182AE3570")]
	public AlignToGround()
	{
	}

	// Token: 0x04000001 RID: 1
	[Token(Token = "0x4000001")]
	private const float SampleGroundTickRate = 0.06666667f;

	// Token: 0x04000002 RID: 2
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool _alignActive;

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _onTerrainMargin;

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _maxAlignActiveDistance;

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<Transform> _samplePoints;

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float _pitchRate;

	// Token: 0x04000007 RID: 7
	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float _pitchScale;

	// Token: 0x04000008 RID: 8
	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float _minPitch;

	// Token: 0x04000009 RID: 9
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float _maxPitch;

	// Token: 0x0400000A RID: 10
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private bool _useRoll;

	// Token: 0x0400000B RID: 11
	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float _rollRate;

	// Token: 0x0400000C RID: 12
	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float _rollScale;

	// Token: 0x0400000D RID: 13
	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	private float _minRoll;

	// Token: 0x0400000E RID: 14
	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private float _maxRoll;

	// Token: 0x0400000F RID: 15
	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x5C")]
	private float _currentPitch;

	// Token: 0x04000010 RID: 16
	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x60")]
	private float _currentRoll;

	// Token: 0x04000011 RID: 17
	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x64")]
	private bool _enabledInVailState;

	// Token: 0x04000012 RID: 18
	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x65")]
	private bool _snapActive;

	// Token: 0x04000013 RID: 19
	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x66")]
	private bool _defaultActive;

	// Token: 0x04000014 RID: 20
	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x68")]
	private float _nextSampleGroundTime;

	// Token: 0x04000015 RID: 21
	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x6C")]
	private float _targetPitch;

	// Token: 0x04000016 RID: 22
	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x70")]
	private float _targetRoll;

	// Token: 0x04000017 RID: 23
	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x74")]
	private bool _applyLimits;

	// Token: 0x04000018 RID: 24
	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x75")]
	private bool _forceActiveByAnim;

	// Token: 0x04000019 RID: 25
	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x76")]
	private bool _forcePitchActive;

	// Token: 0x0400001A RID: 26
	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x78")]
	private float _forcedPitch;
}
