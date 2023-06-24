using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000020 RID: 32
[Token(Token = "0x2000020")]
public class DriftParticles : MonoBehaviour
{
	// Token: 0x0600007D RID: 125 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600007D")]
	[Address(RVA = "0x5D6C20", Offset = "0x5D5220", VA = "0x1805D6C20")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600007E RID: 126 RVA: 0x000020B8 File Offset: 0x000002B8
	[Token(Token = "0x600007E")]
	[Address(RVA = "0x5D6E60", Offset = "0x5D5460", VA = "0x1805D6E60")]
	private bool Initialize()
	{
		return default(bool);
	}

	// Token: 0x0600007F RID: 127 RVA: 0x000020D0 File Offset: 0x000002D0
	[Token(Token = "0x600007F")]
	[Address(RVA = "0x5D7140", Offset = "0x5D5740", VA = "0x1805D7140")]
	private bool InitializeTerrainData()
	{
		return default(bool);
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000080")]
	[Address(RVA = "0x5D7400", Offset = "0x5D5A00", VA = "0x1805D7400")]
	public DriftParticles()
	{
	}

	// Token: 0x040000F7 RID: 247
	[Token(Token = "0x40000F7")]
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("driftSpeed")]
	[SerializeField]
	private float _driftSpeed;

	// Token: 0x040000F8 RID: 248
	[Token(Token = "0x40000F8")]
	[FieldOffset(Offset = "0x24")]
	[FormerlySerializedAs("sampleShift")]
	[Tooltip("Offset the sample position a bit along the velocity vector so particles do not immediately stop when the terrain gets flat.")]
	[Range(0f, 2f)]
	[SerializeField]
	private float _sampleShift;

	// Token: 0x040000F9 RID: 249
	[Token(Token = "0x40000F9")]
	[FieldOffset(Offset = "0x28")]
	private bool _initialized;

	// Token: 0x040000FA RID: 250
	[Token(Token = "0x40000FA")]
	[FieldOffset(Offset = "0x30")]
	private ParticleSystem _particleSystem;

	// Token: 0x040000FB RID: 251
	[Token(Token = "0x40000FB")]
	[FieldOffset(Offset = "0x38")]
	private ParticleSystem.Particle[] _particles;

	// Token: 0x040000FC RID: 252
	[Token(Token = "0x40000FC")]
	[FieldOffset(Offset = "0x40")]
	private TerrainData _terData;

	// Token: 0x040000FD RID: 253
	[Token(Token = "0x40000FD")]
	[FieldOffset(Offset = "0x48")]
	private float _terSize;

	// Token: 0x040000FE RID: 254
	[Token(Token = "0x40000FE")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 _terrainPosition;

	// Token: 0x040000FF RID: 255
	[Token(Token = "0x40000FF")]
	[FieldOffset(Offset = "0x58")]
	private float _oneOverTerrainSize;

	// Token: 0x04000100 RID: 256
	[Token(Token = "0x4000100")]
	[FieldOffset(Offset = "0x5C")]
	private float _terrainSize;

	// Token: 0x04000101 RID: 257
	[Token(Token = "0x4000101")]
	[FieldOffset(Offset = "0x60")]
	private Terrain _terrain;
}
