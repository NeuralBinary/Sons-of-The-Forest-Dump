using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200000F RID: 15
[Token(Token = "0x200000F")]
[AddComponentMenu("Sons/Gameplay/SpiderWeb")]
public class SpiderWeb : MonoBehaviour
{
	// Token: 0x06000045 RID: 69 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000045")]
	[Address(RVA = "0x5B2560", Offset = "0x5B0B60", VA = "0x1805B2560")]
	public void SetMaterials(List<Material> materials)
	{
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000046")]
	[Address(RVA = "0x5EA850", Offset = "0x5E8E50", VA = "0x1805EA850")]
	public void SetReach(float reach)
	{
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000047")]
	[Address(RVA = "0x670F30", Offset = "0x66F530", VA = "0x180670F30")]
	public void SetLayers(LayerMask layers)
	{
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000048")]
	[Address(RVA = "0x3167D80", Offset = "0x3166380", VA = "0x183167D80")]
	public void SetBaseHeightOffsetRange(Vector2 value)
	{
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000049")]
	[Address(RVA = "0x3167D90", Offset = "0x3166390", VA = "0x183167D90")]
	public void SetWebHeightRange(Vector2 value)
	{
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004A")]
	[Address(RVA = "0x3167DA0", Offset = "0x31663A0", VA = "0x183167DA0")]
	public void SetSpiderSettings(float chance, Vector2 sizeRange, GameObject spiderPrefab)
	{
	}

	// Token: 0x0600004B RID: 75 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004B")]
	[Address(RVA = "0x3167E00", Offset = "0x3166400", VA = "0x183167E00")]
	private void Start()
	{
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004C")]
	[Address(RVA = "0x3167F10", Offset = "0x3166510", VA = "0x183167F10")]
	private void OnEnable()
	{
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004D")]
	[Address(RVA = "0x3167F20", Offset = "0x3166520", VA = "0x183167F20")]
	private void OnDisable()
	{
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004E")]
	[Address(RVA = "0x31682D0", Offset = "0x31668D0", VA = "0x1831682D0")]
	public void UpdateWetness(float wetnessCurrent)
	{
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x0600004F RID: 79 RVA: 0x0000206C File Offset: 0x0000026C
	[Token(Token = "0x17000002")]
	public bool CanBeAttached
	{
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x31683F0", Offset = "0x31669F0", VA = "0x1831683F0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000050 RID: 80 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000050")]
	[Address(RVA = "0x31684B0", Offset = "0x3166AB0", VA = "0x1831684B0")]
	public void SetAttachedObject(GameObject attachedObject)
	{
	}

	// Token: 0x06000051 RID: 81 RVA: 0x00002084 File Offset: 0x00000284
	[Token(Token = "0x6000051")]
	[Address(RVA = "0x3168700", Offset = "0x3166D00", VA = "0x183168700")]
	private bool TryCreateWeb()
	{
		return default(bool);
	}

	// Token: 0x06000052 RID: 82 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000052")]
	[Address(RVA = "0x3169D80", Offset = "0x3168380", VA = "0x183169D80")]
	public SpiderWeb()
	{
	}

	// Token: 0x04000060 RID: 96
	[Token(Token = "0x4000060")]
	private const string TreeTag = "Tree";

	// Token: 0x04000061 RID: 97
	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int _dropsShaderID;

	// Token: 0x04000062 RID: 98
	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0x20")]
	[Range(0f, 1f)]
	[SerializeField]
	private float _spawnChance;

	// Token: 0x04000063 RID: 99
	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _webRange;

	// Token: 0x04000064 RID: 100
	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private LayerMask _layers;

	// Token: 0x04000065 RID: 101
	[Token(Token = "0x4000065")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private Vector2 _baseHeightOffsetRange;

	// Token: 0x04000066 RID: 102
	[Token(Token = "0x4000066")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private Vector2 _webHeightRange;

	// Token: 0x04000067 RID: 103
	[Token(Token = "0x4000067")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private List<Material> _materialChoices;

	// Token: 0x04000068 RID: 104
	[Token(Token = "0x4000068")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float _spiderSpawnChance;

	// Token: 0x04000069 RID: 105
	[Token(Token = "0x4000069")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private Vector2 _spiderSizeRange;

	// Token: 0x0400006A RID: 106
	[Token(Token = "0x400006A")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject _spiderPrefab;

	// Token: 0x0400006B RID: 107
	[Token(Token = "0x400006B")]
	[FieldOffset(Offset = "0x60")]
	private MeshFilter _meshFilter;

	// Token: 0x0400006C RID: 108
	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0x68")]
	private MeshRenderer _meshRenderer;

	// Token: 0x0400006D RID: 109
	[Token(Token = "0x400006D")]
	[FieldOffset(Offset = "0x70")]
	private Mesh _mesh;

	// Token: 0x0400006E RID: 110
	[Token(Token = "0x400006E")]
	[FieldOffset(Offset = "0x78")]
	private Material _material;

	// Token: 0x0400006F RID: 111
	[Token(Token = "0x400006F")]
	[FieldOffset(Offset = "0x80")]
	private Transform _spawnedSpider;

	// Token: 0x04000070 RID: 112
	[Token(Token = "0x4000070")]
	[FieldOffset(Offset = "0x88")]
	private GameObject _attachedObject;

	// Token: 0x04000071 RID: 113
	[Token(Token = "0x4000071")]
	[FieldOffset(Offset = "0x8")]
	private static Collider[] _hitColliders;

	// Token: 0x04000072 RID: 114
	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0x90")]
	private Vector3[] _webVertices;

	// Token: 0x04000073 RID: 115
	[Token(Token = "0x4000073")]
	[FieldOffset(Offset = "0x10")]
	private static Vector2[] _webUvs;

	// Token: 0x04000074 RID: 116
	[Token(Token = "0x4000074")]
	[FieldOffset(Offset = "0x18")]
	private static int[] _webTriangles;
}
