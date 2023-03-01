using System;
using System.Collections.Generic;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

// Token: 0x0200000B RID: 11
[Token(Token = "0x200000B")]
public class FingersSpittleSpawner : MonoBehaviour
{
	// Token: 0x06000026 RID: 38 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000026")]
	[Address(RVA = "0x29A5C00", Offset = "0x29A4C00", VA = "0x1829A5C00")]
	private void OnValidate()
	{
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000027")]
	[Address(RVA = "0x29A60C0", Offset = "0x29A50C0", VA = "0x1829A60C0")]
	private void Update()
	{
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000028")]
	[Address(RVA = "0x29A5D70", Offset = "0x29A4D70", VA = "0x1829A5D70")]
	private void Repool()
	{
	}

	// Token: 0x06000029 RID: 41 RVA: 0x000020B8 File Offset: 0x000002B8
	[Token(Token = "0x6000029")]
	[Address(RVA = "0x29A5940", Offset = "0x29A4940", VA = "0x1829A5940")]
	private bool GetAnimatorStateSpit()
	{
		return default(bool);
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600002A")]
	[Address(RVA = "0x29A5CA0", Offset = "0x29A4CA0", VA = "0x1829A5CA0")]
	private void PlayDeathSound()
	{
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600002B")]
	[Address(RVA = "0x29A65A0", Offset = "0x29A55A0", VA = "0x1829A65A0")]
	public FingersSpittleSpawner()
	{
	}

	// Token: 0x04000028 RID: 40
	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool _Enable;

	// Token: 0x04000029 RID: 41
	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x21")]
	[SerializeField]
	private bool _Parent;

	// Token: 0x0400002A RID: 42
	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _ScaleVar;

	// Token: 0x0400002B RID: 43
	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _activeDistance;

	// Token: 0x0400002C RID: 44
	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject[] _SpittleFX;

	// Token: 0x0400002D RID: 45
	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private FingersSpittleLocation[] _SpittleLocations;

	// Token: 0x0400002E RID: 46
	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Animator _animatorTarget;

	// Token: 0x0400002F RID: 47
	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private VailActor _vailActor;

	// Token: 0x04000030 RID: 48
	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private List<string> _spitOnStates;

	// Token: 0x04000031 RID: 49
	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private float _spittleOnDeathDuration;

	// Token: 0x04000032 RID: 50
	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x60")]
	[EventRef]
	[SerializeField]
	private string _spittleOnDeathEvent;

	// Token: 0x04000033 RID: 51
	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private float _spittleDeathEventDelay;

	// Token: 0x04000034 RID: 52
	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private float _DestroyDelay;

	// Token: 0x04000035 RID: 53
	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private int _maxPool;

	// Token: 0x04000036 RID: 54
	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Queue<GameObject> _pool;

	// Token: 0x04000037 RID: 55
	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x80")]
	private readonly Dictionary<GameObject, float> _repoolTimers;

	// Token: 0x04000038 RID: 56
	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x88")]
	private readonly List<GameObject> _keysToRemove;

	// Token: 0x04000039 RID: 57
	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x90")]
	private float _timeOfDeath;
}
