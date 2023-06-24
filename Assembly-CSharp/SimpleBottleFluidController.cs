using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000009 RID: 9
[Token(Token = "0x2000009")]
[AddComponentMenu("Sons/Rendering/Simple Bottle Fluid Controller")]
public class SimpleBottleFluidController : MonoBehaviour
{
	// Token: 0x06000016 RID: 22 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000016")]
	[Address(RVA = "0x5C94D0", Offset = "0x5C7AD0", VA = "0x1805C94D0")]
	private void Awake()
	{
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000017")]
	[Address(RVA = "0x5C95E0", Offset = "0x5C7BE0", VA = "0x1805C95E0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000018")]
	[Address(RVA = "0x5C95F0", Offset = "0x5C7BF0", VA = "0x1805C95F0")]
	private void OnPreRender()
	{
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x5C98F0", Offset = "0x5C7EF0", VA = "0x1805C98F0")]
	private void Update()
	{
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x5C9FE0", Offset = "0x5C85E0", VA = "0x1805C9FE0")]
	private void RefreshMaterials()
	{
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x5CAB90", Offset = "0x5C9190", VA = "0x1805CAB90")]
	public SimpleBottleFluidController()
	{
	}

	// Token: 0x04000036 RID: 54
	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int SimpleFluidVelocityPID;

	// Token: 0x04000037 RID: 55
	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int _fluidBackMatIndex;

	// Token: 0x04000038 RID: 56
	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x24")]
	[FormerlySerializedAs("_update0")]
	[SerializeField]
	private bool _updateBack;

	// Token: 0x04000039 RID: 57
	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private int _fluidFrontMatIndex;

	// Token: 0x0400003A RID: 58
	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[FormerlySerializedAs("_update1")]
	private bool _updateFront;

	// Token: 0x0400003B RID: 59
	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x30")]
	private Material _backMat;

	// Token: 0x0400003C RID: 60
	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x38")]
	private Material _frontMat;

	// Token: 0x0400003D RID: 61
	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x40")]
	private float _lerpedOverallVelocity;

	// Token: 0x0400003E RID: 62
	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x44")]
	private float _maxVelocity;

	// Token: 0x0400003F RID: 63
	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 _prevPos;

	// Token: 0x04000040 RID: 64
	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x54")]
	private Quaternion _prevRot;

	// Token: 0x04000041 RID: 65
	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x68")]
	private Renderer _renderer;

	// Token: 0x04000042 RID: 66
	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x70")]
	private Material[] _sharedMaterials;

	// Token: 0x04000043 RID: 67
	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x78")]
	private Material[] _sharedMaterialsBackup;

	// Token: 0x04000044 RID: 68
	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x80")]
	private Transform _transform;
}
