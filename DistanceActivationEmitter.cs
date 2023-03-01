using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TheForest.Utils.WorkSchedulerInterfaces;
using UnityEngine;

// Token: 0x020002F8 RID: 760
[Token(Token = "0x20002F8")]
public class DistanceActivationEmitter : MonoBehaviour, IThreadSafeTask
{
	// Token: 0x0600135B RID: 4955 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600135B")]
	[Address(RVA = "0x2C636D0", Offset = "0x2C626D0", VA = "0x182C636D0")]
	private void OnValidate()
	{
	}

	// Token: 0x0600135C RID: 4956 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600135C")]
	[Address(RVA = "0x2C63650", Offset = "0x2C62650", VA = "0x182C63650")]
	private void OnEnable()
	{
	}

	// Token: 0x0600135D RID: 4957 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600135D")]
	[Address(RVA = "0x2C63610", Offset = "0x2C62610", VA = "0x182C63610")]
	private void OnDisable()
	{
	}

	// Token: 0x17000229 RID: 553
	// (get) Token: 0x0600135E RID: 4958 RVA: 0x00006840 File Offset: 0x00004A40
	// (set) Token: 0x0600135F RID: 4959 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000229")]
	public bool ShouldDoMainThreadRefresh
	{
		[Token(Token = "0x600135E")]
		[Address(RVA = "0x86F2E0", Offset = "0x86E2E0", VA = "0x18086F2E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600135F")]
		[Address(RVA = "0x86F330", Offset = "0x86E330", VA = "0x18086F330", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x06001360 RID: 4960 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001360")]
	[Address(RVA = "0x2C637D0", Offset = "0x2C627D0", VA = "0x182C637D0", Slot = "6")]
	public void ThreadedRefresh()
	{
	}

	// Token: 0x06001361 RID: 4961 RVA: 0x00006858 File Offset: 0x00004A58
	[Token(Token = "0x6001361")]
	[Address(RVA = "0x2C63780", Offset = "0x2C62780", VA = "0x182C63780")]
	private bool ShouldBeActive(float rangeOffset = 0f)
	{
		return default(bool);
	}

	// Token: 0x06001362 RID: 4962 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001362")]
	[Address(RVA = "0x2C63570", Offset = "0x2C62570", VA = "0x182C63570", Slot = "7")]
	public void MainThreadRefresh()
	{
	}

	// Token: 0x06001363 RID: 4963 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001363")]
	[Address(RVA = "0x2C63540", Offset = "0x2C62540", VA = "0x182C63540", Slot = "8")]
	public string GetTaskName()
	{
		return null;
	}

	// Token: 0x06001364 RID: 4964 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001364")]
	[Address(RVA = "0x2B29F50", Offset = "0x2B28F50", VA = "0x182B29F50")]
	public DistanceActivationEmitter()
	{
	}

	// Token: 0x0400133C RID: 4924
	[Token(Token = "0x400133C")]
	private const string TaskName = "DistanceActivationEmitter";

	// Token: 0x0400133D RID: 4925
	[Token(Token = "0x400133D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private SonsFMODEventEmitter _emitterTarget;

	// Token: 0x0400133E RID: 4926
	[Token(Token = "0x400133E")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _radius;

	// Token: 0x0400133F RID: 4927
	[Token(Token = "0x400133F")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float _activeRadius;

	// Token: 0x04001340 RID: 4928
	[Token(Token = "0x4001340")]
	[FieldOffset(Offset = "0x30")]
	private float _distanceToPlayer;

	// Token: 0x04001341 RID: 4929
	[Token(Token = "0x4001341")]
	[FieldOffset(Offset = "0x34")]
	private bool _isActive;

	// Token: 0x04001342 RID: 4930
	[Token(Token = "0x4001342")]
	[FieldOffset(Offset = "0x35")]
	private bool _shouldBeActive;

	// Token: 0x04001343 RID: 4931
	[Token(Token = "0x4001343")]
	[FieldOffset(Offset = "0x38")]
	private int _wsToken;

	// Token: 0x04001344 RID: 4932
	[Token(Token = "0x4001344")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3 _transformPosition;
}
