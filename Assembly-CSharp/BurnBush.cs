using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200000C RID: 12
[Token(Token = "0x200000C")]
public class BurnBush : MonoBehaviour
{
	// Token: 0x06000024 RID: 36 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000024")]
	[Address(RVA = "0x5CB350", Offset = "0x5C9950", VA = "0x1805CB350")]
	private void OnEnable()
	{
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000025")]
	[Address(RVA = "0x5CB5F0", Offset = "0x5C9BF0", VA = "0x1805CB5F0")]
	private void Update()
	{
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000026")]
	[Address(RVA = "0x5CBE70", Offset = "0x5CA470", VA = "0x1805CBE70")]
	public BurnBush()
	{
	}

	// Token: 0x0400004D RID: 77
	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0x20")]
	public bool _startBurning;

	// Token: 0x0400004E RID: 78
	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Header("Components")]
	private GameObject _particlesysGameObject;

	// Token: 0x0400004F RID: 79
	[Token(Token = "0x400004F")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ParticleSystem _particlesystem;

	// Token: 0x04000050 RID: 80
	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Renderer[] _renderers;

	// Token: 0x04000051 RID: 81
	[Token(Token = "0x4000051")]
	[FieldOffset(Offset = "0x40")]
	[Header("Global Settings")]
	[SerializeField]
	private float _burnDuration;

	// Token: 0x04000052 RID: 82
	[Token(Token = "0x4000052")]
	[FieldOffset(Offset = "0x44")]
	private float _burnSpeed;

	// Token: 0x04000053 RID: 83
	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Range(0f, 1f)]
	private float _burn;

	// Token: 0x04000054 RID: 84
	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0x4C")]
	[Header("Particle Settings")]
	[SerializeField]
	private float _maxParticleEmission;

	// Token: 0x04000055 RID: 85
	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private AnimationCurve _burnToParticleEmission;

	// Token: 0x04000056 RID: 86
	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private float _minEmitterShapeScale;

	// Token: 0x04000057 RID: 87
	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x5C")]
	private float _startEmitterShapeScale;

	// Token: 0x04000058 RID: 88
	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0x60")]
	private float _targetParticleShapeHeight;

	// Token: 0x04000059 RID: 89
	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x68")]
	[Header("Material Settings")]
	[SerializeField]
	private AnimationCurve _burnToBushFire;

	// Token: 0x0400005A RID: 90
	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x70")]
	private bool _isBurning;

	// Token: 0x0400005B RID: 91
	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x78")]
	private MaterialPropertyBlock _mblock;

	// Token: 0x0400005C RID: 92
	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x80")]
	private int numberOfRenderers;

	// Token: 0x0400005D RID: 93
	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0x84")]
	private float time;

	// Token: 0x0400005E RID: 94
	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int _BurnPID;
}
