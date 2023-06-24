using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000035 RID: 53
[Token(Token = "0x2000035")]
[BoltExecutionOrder(-2500)]
[ExecuteInEditMode]
[Documentation]
public class BoltEntity : MonoBehaviour, IBoltListNode
{
	// Token: 0x17000073 RID: 115
	// (get) Token: 0x060001FE RID: 510 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000073")]
	internal Entity Entity
	{
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x79BF10", Offset = "0x79A510", VA = "0x18079BF10")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000074 RID: 116
	// (get) Token: 0x060001FF RID: 511 RVA: 0x00002A60 File Offset: 0x00000C60
	// (set) Token: 0x06000200 RID: 512 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000074")]
	internal UniqueId sceneGuid
	{
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x79BF80", Offset = "0x79A580", VA = "0x18079BF80")]
		get
		{
			return default(UniqueId);
		}
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x79BFB0", Offset = "0x79A5B0", VA = "0x18079BFB0")]
		set
		{
		}
	}

	// Token: 0x17000075 RID: 117
	// (get) Token: 0x06000201 RID: 513 RVA: 0x00002A78 File Offset: 0x00000C78
	// (set) Token: 0x06000202 RID: 514 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000075")]
	internal UniqueId serializerGuid
	{
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x79C050", Offset = "0x79A650", VA = "0x18079C050")]
		get
		{
			return default(UniqueId);
		}
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x79C080", Offset = "0x79A680", VA = "0x18079C080")]
		set
		{
		}
	}

	// Token: 0x17000076 RID: 118
	// (get) Token: 0x06000203 RID: 515 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000204 RID: 516 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000076")]
	private object prev
	{
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x620F20", Offset = "0x61F520", VA = "0x180620F20", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000077 RID: 119
	// (get) Token: 0x06000205 RID: 517 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000206 RID: 518 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000077")]
	private object next
	{
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x675FA0", Offset = "0x6745A0", VA = "0x180675FA0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x675FB0", Offset = "0x6745B0", VA = "0x180675FB0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000078 RID: 120
	// (get) Token: 0x06000207 RID: 519 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000208 RID: 520 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000078")]
	private object list
	{
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x6F1D00", Offset = "0x6F0300", VA = "0x1806F1D00", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x6F1D10", Offset = "0x6F0310", VA = "0x1806F1D10", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000079 RID: 121
	// (get) Token: 0x06000209 RID: 521 RVA: 0x00002A90 File Offset: 0x00000C90
	[Token(Token = "0x17000079")]
	public PrefabId prefabId
	{
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x6E6C40", Offset = "0x6E5240", VA = "0x1806E6C40")]
		get
		{
			return default(PrefabId);
		}
	}

	// Token: 0x1700007A RID: 122
	// (get) Token: 0x0600020A RID: 522 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700007A")]
	public BoltConnection source
	{
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x79C120", Offset = "0x79A720", VA = "0x18079C120")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700007B RID: 123
	// (get) Token: 0x0600020B RID: 523 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700007B")]
	public IProtocolToken attachToken
	{
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x79C190", Offset = "0x79A790", VA = "0x18079C190")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700007C RID: 124
	// (get) Token: 0x0600020C RID: 524 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700007C")]
	public IProtocolToken detachToken
	{
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x79C200", Offset = "0x79A800", VA = "0x18079C200")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700007D RID: 125
	// (get) Token: 0x0600020D RID: 525 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700007D")]
	public IProtocolToken controlGainedToken
	{
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x79C270", Offset = "0x79A870", VA = "0x18079C270")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700007E RID: 126
	// (get) Token: 0x0600020E RID: 526 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700007E")]
	public IProtocolToken controlLostToken
	{
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x79C2E0", Offset = "0x79A8E0", VA = "0x18079C2E0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700007F RID: 127
	// (get) Token: 0x0600020F RID: 527 RVA: 0x00002AA8 File Offset: 0x00000CA8
	[Token(Token = "0x1700007F")]
	public NetworkId networkId
	{
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x79C350", Offset = "0x79A950", VA = "0x18079C350")]
		get
		{
			return default(NetworkId);
		}
	}

	// Token: 0x17000080 RID: 128
	// (get) Token: 0x06000210 RID: 528 RVA: 0x00002AC0 File Offset: 0x00000CC0
	// (set) Token: 0x06000211 RID: 529 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000080")]
	public bool canFreeze
	{
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x79C3C0", Offset = "0x79A9C0", VA = "0x18079C3C0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x79C430", Offset = "0x79AA30", VA = "0x18079C430")]
		set
		{
		}
	}

	// Token: 0x17000081 RID: 129
	// (get) Token: 0x06000212 RID: 530 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000081")]
	public BoltConnection controller
	{
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x79C4A0", Offset = "0x79AAA0", VA = "0x18079C4A0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000082 RID: 130
	// (get) Token: 0x06000213 RID: 531 RVA: 0x00002AD8 File Offset: 0x00000CD8
	[Token(Token = "0x17000082")]
	public bool isAttached
	{
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x79C510", Offset = "0x79AB10", VA = "0x18079C510")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000083 RID: 131
	// (get) Token: 0x06000214 RID: 532 RVA: 0x00002AF0 File Offset: 0x00000CF0
	[Token(Token = "0x17000083")]
	public bool isFrozen
	{
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x79C580", Offset = "0x79AB80", VA = "0x18079C580")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000084 RID: 132
	// (get) Token: 0x06000215 RID: 533 RVA: 0x00002B08 File Offset: 0x00000D08
	[Token(Token = "0x17000084")]
	public bool isSceneObject
	{
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x79C5C0", Offset = "0x79ABC0", VA = "0x18079C5C0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000085 RID: 133
	// (get) Token: 0x06000216 RID: 534 RVA: 0x00002B20 File Offset: 0x00000D20
	[Token(Token = "0x17000085")]
	public bool isOwner
	{
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x79C670", Offset = "0x79AC70", VA = "0x18079C670")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000086 RID: 134
	// (get) Token: 0x06000217 RID: 535 RVA: 0x00002B38 File Offset: 0x00000D38
	[Token(Token = "0x17000086")]
	public bool hasControl
	{
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x79C6E0", Offset = "0x79ACE0", VA = "0x18079C6E0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000087 RID: 135
	// (get) Token: 0x06000218 RID: 536 RVA: 0x00002B50 File Offset: 0x00000D50
	[Token(Token = "0x17000087")]
	public bool hasControlWithPrediction
	{
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x79C790", Offset = "0x79AD90", VA = "0x18079C790")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000088 RID: 136
	// (get) Token: 0x06000219 RID: 537 RVA: 0x00002B68 File Offset: 0x00000D68
	[Token(Token = "0x17000088")]
	public bool persistsOnSceneLoad
	{
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x79C800", Offset = "0x79AE00", VA = "0x18079C800")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600021A RID: 538 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600021A")]
	[Address(RVA = "0x79C8B0", Offset = "0x79AEB0", VA = "0x18079C8B0")]
	public BoltEntitySettingsModifier ModifySettings()
	{
		return null;
	}

	// Token: 0x0600021B RID: 539 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600021B")]
	[Address(RVA = "0x79C950", Offset = "0x79AF50", VA = "0x18079C950")]
	public void SetScopeAll(bool inScope)
	{
	}

	// Token: 0x0600021C RID: 540 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600021C")]
	[Address(RVA = "0x79CB20", Offset = "0x79B120", VA = "0x18079CB20")]
	public void SetScope(BoltConnection connection, bool inScope)
	{
	}

	// Token: 0x0600021D RID: 541 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600021D")]
	[Address(RVA = "0x79CBB0", Offset = "0x79B1B0", VA = "0x18079CBB0")]
	public void SetParent(BoltEntity parent)
	{
	}

	// Token: 0x0600021E RID: 542 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600021E")]
	[Address(RVA = "0x79CD10", Offset = "0x79B310", VA = "0x18079CD10")]
	public void TakeControl()
	{
	}

	// Token: 0x0600021F RID: 543 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600021F")]
	[Address(RVA = "0x79CD80", Offset = "0x79B380", VA = "0x18079CD80")]
	public void TakeControl(IProtocolToken token)
	{
	}

	// Token: 0x06000220 RID: 544 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000220")]
	[Address(RVA = "0x79CDF0", Offset = "0x79B3F0", VA = "0x18079CDF0")]
	public void ReleaseControl()
	{
	}

	// Token: 0x06000221 RID: 545 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000221")]
	[Address(RVA = "0x79CE60", Offset = "0x79B460", VA = "0x18079CE60")]
	public void ReleaseControl(IProtocolToken token)
	{
	}

	// Token: 0x06000222 RID: 546 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000222")]
	[Address(RVA = "0x79CED0", Offset = "0x79B4D0", VA = "0x18079CED0")]
	public void AssignControl(BoltConnection connection)
	{
	}

	// Token: 0x06000223 RID: 547 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000223")]
	[Address(RVA = "0x79CF40", Offset = "0x79B540", VA = "0x18079CF40")]
	public void AssignControl(BoltConnection connection, IProtocolToken token)
	{
	}

	// Token: 0x06000224 RID: 548 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000224")]
	[Address(RVA = "0x79CFB0", Offset = "0x79B5B0", VA = "0x18079CFB0")]
	public void RevokeControl()
	{
	}

	// Token: 0x06000225 RID: 549 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000225")]
	[Address(RVA = "0x79D020", Offset = "0x79B620", VA = "0x18079D020")]
	public void RevokeControl(IProtocolToken token)
	{
	}

	// Token: 0x06000226 RID: 550 RVA: 0x00002B80 File Offset: 0x00000D80
	[Token(Token = "0x6000226")]
	[Address(RVA = "0x79D090", Offset = "0x79B690", VA = "0x18079D090")]
	public bool IsController(BoltConnection connection)
	{
		return default(bool);
	}

	// Token: 0x06000227 RID: 551 RVA: 0x00002B98 File Offset: 0x00000D98
	[Token(Token = "0x6000227")]
	[Address(RVA = "0x79D100", Offset = "0x79B700", VA = "0x18079D100")]
	public bool QueueInput(INetworkCommandData data)
	{
		return default(bool);
	}

	// Token: 0x06000228 RID: 552 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000228")]
	[Address(RVA = "0x79D330", Offset = "0x79B930", VA = "0x18079D330")]
	public void Idle(BoltConnection connection, bool idle)
	{
	}

	// Token: 0x06000229 RID: 553 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000229")]
	[Address(RVA = "0x79D4E0", Offset = "0x79BAE0", VA = "0x18079D4E0")]
	public void Freeze(bool pause)
	{
	}

	// Token: 0x0600022A RID: 554 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600022A")]
	[Address(RVA = "0x79D550", Offset = "0x79BB50", VA = "0x18079D550")]
	public void AddEventListener(MonoBehaviour behaviour)
	{
	}

	// Token: 0x0600022B RID: 555 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600022B")]
	[Address(RVA = "0x79D5D0", Offset = "0x79BBD0", VA = "0x18079D5D0")]
	public void RemoveEventListener(MonoBehaviour behaviour)
	{
	}

	// Token: 0x0600022C RID: 556 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600022C")]
	public TState GetState<TState>()
	{
		return null;
	}

	// Token: 0x0600022D RID: 557 RVA: 0x00002BB0 File Offset: 0x00000DB0
	[Token(Token = "0x600022D")]
	public bool TryFindState<TState>(out TState state)
	{
		return default(bool);
	}

	// Token: 0x0600022E RID: 558 RVA: 0x00002BC8 File Offset: 0x00000DC8
	[Token(Token = "0x600022E")]
	public bool StateIs<TState>()
	{
		return default(bool);
	}

	// Token: 0x0600022F RID: 559 RVA: 0x00002BE0 File Offset: 0x00000DE0
	[Token(Token = "0x600022F")]
	[Address(RVA = "0x79D650", Offset = "0x79BC50", VA = "0x18079D650")]
	public bool StateIs(Type t)
	{
		return default(bool);
	}

	// Token: 0x06000230 RID: 560 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000230")]
	[Address(RVA = "0x79D6F0", Offset = "0x79BCF0", VA = "0x18079D6F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000231 RID: 561 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000231")]
	[Address(RVA = "0x79D990", Offset = "0x79BF90", VA = "0x18079D990")]
	public void DestroyDelayed(float time)
	{
	}

	// Token: 0x06000232 RID: 562 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000232")]
	[Address(RVA = "0x79DA50", Offset = "0x79C050", VA = "0x18079DA50")]
	public void InvokeOnce(Command cmd, int delay, CommandCallback callback)
	{
	}

	// Token: 0x06000233 RID: 563 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000233")]
	[Address(RVA = "0x79DA50", Offset = "0x79C050", VA = "0x18079DA50")]
	public void InvokeMany(Command cmd, int duration, CommandCallback callback)
	{
	}

	// Token: 0x06000234 RID: 564 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000234")]
	[Address(RVA = "0x79DAC0", Offset = "0x79C0C0", VA = "0x18079DAC0")]
	internal void VerifyNotAttached()
	{
	}

	// Token: 0x06000235 RID: 565 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000235")]
	[Address(RVA = "0x79DB30", Offset = "0x79C130", VA = "0x18079DB30")]
	private IEnumerator DestroyDelayedInternal(float time)
	{
		return null;
	}

	// Token: 0x06000236 RID: 566 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000236")]
	[Address(RVA = "0x79DBF0", Offset = "0x79C1F0", VA = "0x18079DBF0")]
	private void OnDisable()
	{
	}

	// Token: 0x06000237 RID: 567 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000237")]
	[Address(RVA = "0x79DD80", Offset = "0x79C380", VA = "0x18079DD80")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000238 RID: 568 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000238")]
	[Address(RVA = "0x79DE90", Offset = "0x79C490", VA = "0x18079DE90")]
	private void OnDrawGizmos()
	{
	}

	// Token: 0x06000239 RID: 569 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000239")]
	[Address(RVA = "0x79DFE0", Offset = "0x79C5E0", VA = "0x18079DFE0")]
	public static implicit operator GameObject(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x0600023A RID: 570 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600023A")]
	[Address(RVA = "0x79E0E0", Offset = "0x79C6E0", VA = "0x18079E0E0")]
	public BoltEntity()
	{
	}

	// Token: 0x04000107 RID: 263
	[Token(Token = "0x4000107")]
	[FieldOffset(Offset = "0x20")]
	internal Entity _entity;

	// Token: 0x04000108 RID: 264
	[Token(Token = "0x4000108")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	internal string _sceneGuid;

	// Token: 0x04000109 RID: 265
	[Token(Token = "0x4000109")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	internal string _serializerGuid;

	// Token: 0x0400010A RID: 266
	[Token(Token = "0x400010A")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	internal int _prefabId;

	// Token: 0x0400010B RID: 267
	[Token(Token = "0x400010B")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	internal int _updateRate;

	// Token: 0x0400010C RID: 268
	[Token(Token = "0x400010C")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	internal int _autoFreezeProxyFrames;

	// Token: 0x0400010D RID: 269
	[Token(Token = "0x400010D")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	internal bool _clientPredicted;

	// Token: 0x0400010E RID: 270
	[Token(Token = "0x400010E")]
	[FieldOffset(Offset = "0x45")]
	[SerializeField]
	internal bool _allowInstantiateOnClient;

	// Token: 0x0400010F RID: 271
	[Token(Token = "0x400010F")]
	[FieldOffset(Offset = "0x46")]
	[SerializeField]
	internal bool _persistThroughSceneLoads;

	// Token: 0x04000110 RID: 272
	[Token(Token = "0x4000110")]
	[FieldOffset(Offset = "0x47")]
	[SerializeField]
	internal bool _sceneObjectDestroyOnDetach;

	// Token: 0x04000111 RID: 273
	[Token(Token = "0x4000111")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	internal bool _sceneObjectAutoAttach;

	// Token: 0x04000112 RID: 274
	[Token(Token = "0x4000112")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	internal QueryOptions _queryOptionIEntityBehaviour;

	// Token: 0x04000113 RID: 275
	[Token(Token = "0x4000113")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	internal QueryOptions _queryOptionIPriorityCalculator;

	// Token: 0x04000114 RID: 276
	[Token(Token = "0x4000114")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	internal QueryOptions _queryOptionIEntityReplicationFilter;

	// Token: 0x04000115 RID: 277
	[Token(Token = "0x4000115")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	internal bool _alwaysProxy;

	// Token: 0x04000116 RID: 278
	[Token(Token = "0x4000116")]
	[FieldOffset(Offset = "0x59")]
	[SerializeField]
	internal bool _detachOnDisable;

	// Token: 0x04000117 RID: 279
	[Token(Token = "0x4000117")]
	[FieldOffset(Offset = "0x5A")]
	[SerializeField]
	internal bool _allowFirstReplicationWhenFrozen;

	// Token: 0x04000118 RID: 280
	[Token(Token = "0x4000118")]
	[FieldOffset(Offset = "0x5B")]
	[SerializeField]
	internal bool _autoRemoveChildEntities;
}
