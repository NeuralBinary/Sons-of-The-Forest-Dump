using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000008 RID: 8
[Token(Token = "0x2000008")]
public class EnableChildrenDelay : MonoBehaviour
{
	// Token: 0x06000016 RID: 22 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000016")]
	[Address(RVA = "0x3162A70", Offset = "0x3161070", VA = "0x183162A70")]
	private void OnValidate()
	{
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000017")]
	[Address(RVA = "0x3162DC0", Offset = "0x31613C0", VA = "0x183162DC0")]
	private void Awake()
	{
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000018")]
	[Address(RVA = "0x3162E40", Offset = "0x3161440", VA = "0x183162E40")]
	private void Update()
	{
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x3162EC0", Offset = "0x31614C0", VA = "0x183162EC0")]
	private void OnDisable()
	{
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x3163020", Offset = "0x3161620", VA = "0x183163020")]
	private static void SetActive(Transform child, bool value)
	{
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x3163170", Offset = "0x3161770", VA = "0x183163170")]
	private void Enable()
	{
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x3163A80", Offset = "0x3162080", VA = "0x183163A80")]
	private void SnapToGround(Transform child, Vector3 snapPoint, Quaternion snapRotation)
	{
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x3164200", Offset = "0x3162800", VA = "0x183164200")]
	public EnableChildrenDelay()
	{
	}

	// Token: 0x0400002E RID: 46
	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool _instanceMode;

	// Token: 0x0400002F RID: 47
	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x21")]
	[SerializeField]
	private bool _unparentInstance;

	// Token: 0x04000030 RID: 48
	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _instancelife;

	// Token: 0x04000031 RID: 49
	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool _snapToGround;

	// Token: 0x04000032 RID: 50
	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float _heightOffset;

	// Token: 0x04000033 RID: 51
	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Quaternion _rotationOffset;

	// Token: 0x04000034 RID: 52
	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Vector3 _randomRotation;

	// Token: 0x04000035 RID: 53
	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float _delay;

	// Token: 0x04000036 RID: 54
	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float _randomDelayAmount;

	// Token: 0x04000037 RID: 55
	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x0")]
	private static LayerMask _terrainLayerMask;

	// Token: 0x04000038 RID: 56
	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Range(0f, 1f)]
	private float _chance;

	// Token: 0x04000039 RID: 57
	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private List<Transform> _transforms;

	// Token: 0x0400003A RID: 58
	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x60")]
	private bool _stop;

	// Token: 0x0400003B RID: 59
	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x64")]
	private float _countdown;
}
