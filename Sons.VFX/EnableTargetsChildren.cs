using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000009 RID: 9
[Token(Token = "0x2000009")]
public class EnableTargetsChildren : MonoBehaviour
{
	// Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001F")]
	[Address(RVA = "0x3164370", Offset = "0x3162970", VA = "0x183164370")]
	private void OnValidate()
	{
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000020")]
	[Address(RVA = "0x31646D0", Offset = "0x3162CD0", VA = "0x1831646D0")]
	private void Awake()
	{
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000021")]
	[Address(RVA = "0x31646F0", Offset = "0x3162CF0", VA = "0x1831646F0")]
	private void Update()
	{
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000022")]
	[Address(RVA = "0x3164770", Offset = "0x3162D70", VA = "0x183164770")]
	private void OnDisable()
	{
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000023")]
	[Address(RVA = "0x31648B0", Offset = "0x3162EB0", VA = "0x1831648B0")]
	private static void SetActive(Transform child, bool value)
	{
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000024")]
	[Address(RVA = "0x3164A00", Offset = "0x3163000", VA = "0x183164A00")]
	private void Enable()
	{
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000025")]
	[Address(RVA = "0x3164FD0", Offset = "0x31635D0", VA = "0x183164FD0")]
	private void ActivateTarget(GameObject target)
	{
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000026")]
	[Address(RVA = "0x31652C0", Offset = "0x31638C0", VA = "0x1831652C0")]
	private void SnapToGround(Transform child)
	{
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000027")]
	[Address(RVA = "0x3165A30", Offset = "0x3164030", VA = "0x183165A30")]
	public EnableTargetsChildren()
	{
	}

	// Token: 0x0400003C RID: 60
	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject _target;

	// Token: 0x0400003D RID: 61
	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool _destroyTarget;

	// Token: 0x0400003E RID: 62
	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x29")]
	[SerializeField]
	private bool _instanceMode;

	// Token: 0x0400003F RID: 63
	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x2A")]
	[FormerlySerializedAs("_unparentInstance")]
	[SerializeField]
	private bool _unparent;

	// Token: 0x04000040 RID: 64
	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x2B")]
	[SerializeField]
	private bool _reParent;

	// Token: 0x04000041 RID: 65
	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject _newParent;

	// Token: 0x04000042 RID: 66
	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x38")]
	[FormerlySerializedAs("_instancelife")]
	[SerializeField]
	private float _lifespan;

	// Token: 0x04000043 RID: 67
	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private bool _snapToGround;

	// Token: 0x04000044 RID: 68
	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float _heightOffset;

	// Token: 0x04000045 RID: 69
	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private bool _forceRigidOn;

	// Token: 0x04000046 RID: 70
	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float _delay;

	// Token: 0x04000047 RID: 71
	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x4C")]
	[Range(0f, 1f)]
	[SerializeField]
	private float _chance;

	// Token: 0x04000048 RID: 72
	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private List<Transform> _transforms;

	// Token: 0x04000049 RID: 73
	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x58")]
	private bool _stop;

	// Token: 0x0400004A RID: 74
	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x5C")]
	private float _countdown;
}
