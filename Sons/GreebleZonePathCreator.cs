using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using PathCreation;
using UnityEngine;

// Token: 0x020001C2 RID: 450
[Token(Token = "0x20001C2")]
[ExecuteInEditMode]
[RequireComponent(typeof(GreebleZone))]
[RequireComponent(typeof(PathCreator))]
public class GreebleZonePathCreator : MonoBehaviour
{
	// Token: 0x1400000E RID: 14
	// (add) Token: 0x06000D17 RID: 3351 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x06000D18 RID: 3352 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1400000E")]
	public event Action onDestroyed
	{
		[Token(Token = "0x6000D17")]
		[Address(RVA = "0x36F8740", Offset = "0x36F6D40", VA = "0x1836F8740")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000D18")]
		[Address(RVA = "0x36F8830", Offset = "0x36F6E30", VA = "0x1836F8830")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x06000D19 RID: 3353 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D19")]
	[Address(RVA = "0x282D840", Offset = "0x282BE40", VA = "0x18282D840")]
	private void OnDestroy()
	{
	}

	// Token: 0x1700018A RID: 394
	// (get) Token: 0x06000D1A RID: 3354 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700018A")]
	protected VertexPath path
	{
		[Token(Token = "0x6000D1A")]
		[Address(RVA = "0x2830CF0", Offset = "0x282F2F0", VA = "0x182830CF0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000D1B RID: 3355 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D1B")]
	[Address(RVA = "0x36F8920", Offset = "0x36F6F20", VA = "0x1836F8920")]
	public GreebleZonePathCreator()
	{
	}

	// Token: 0x04000BD5 RID: 3029
	[Token(Token = "0x4000BD5")]
	[FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public PathCreator PathCreator;

	// Token: 0x04000BD6 RID: 3030
	[Token(Token = "0x4000BD6")]
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public GreebleZone GreebleZone;

	// Token: 0x04000BD7 RID: 3031
	[Token(Token = "0x4000BD7")]
	[FieldOffset(Offset = "0x38")]
	public bool AutoUpdate;

	// Token: 0x04000BD8 RID: 3032
	[Token(Token = "0x4000BD8")]
	[FieldOffset(Offset = "0x3C")]
	[Range(5f, 500f)]
	[SerializeField]
	private float _width;

	// Token: 0x04000BD9 RID: 3033
	[Token(Token = "0x4000BD9")]
	private const float _minSpacing = 5f;
}
