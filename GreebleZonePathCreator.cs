using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using PathCreation;
using UnityEngine;

// Token: 0x020001C3 RID: 451
[Token(Token = "0x20001C3")]
[RequireComponent(typeof(GreebleZone))]
[RequireComponent(typeof(PathCreator))]
[ExecuteInEditMode]
public class GreebleZonePathCreator : MonoBehaviour
{
	// Token: 0x1400000B RID: 11
	// (add) Token: 0x06000CBC RID: 3260 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x06000CBD RID: 3261 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1400000B")]
	public event Action onDestroyed
	{
		[Token(Token = "0x6000CBC")]
		[Address(RVA = "0x2F89120", Offset = "0x2F88120", VA = "0x182F89120")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000CBD")]
		[Address(RVA = "0x2F891C0", Offset = "0x2F881C0", VA = "0x182F891C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x06000CBE RID: 3262 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CBE")]
	[Address(RVA = "0x23B3190", Offset = "0x23B2190", VA = "0x1823B3190")]
	private void OnDestroy()
	{
	}

	// Token: 0x17000181 RID: 385
	// (get) Token: 0x06000CBF RID: 3263 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000181")]
	protected VertexPath path
	{
		[Token(Token = "0x6000CBF")]
		[Address(RVA = "0x23B3E90", Offset = "0x23B2E90", VA = "0x1823B3E90")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000CC0 RID: 3264 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CC0")]
	[Address(RVA = "0x2F89100", Offset = "0x2F88100", VA = "0x182F89100")]
	public GreebleZonePathCreator()
	{
	}

	// Token: 0x04000BA6 RID: 2982
	[Token(Token = "0x4000BA6")]
	[FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public PathCreator PathCreator;

	// Token: 0x04000BA7 RID: 2983
	[Token(Token = "0x4000BA7")]
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public GreebleZone GreebleZone;

	// Token: 0x04000BA8 RID: 2984
	[Token(Token = "0x4000BA8")]
	[FieldOffset(Offset = "0x38")]
	public bool AutoUpdate;

	// Token: 0x04000BA9 RID: 2985
	[Token(Token = "0x4000BA9")]
	[FieldOffset(Offset = "0x3C")]
	[Range(5f, 500f)]
	[SerializeField]
	private float _width;

	// Token: 0x04000BAA RID: 2986
	[Token(Token = "0x4000BAA")]
	private const float _minSpacing = 5f;
}
