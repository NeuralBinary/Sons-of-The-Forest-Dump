using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001E6 RID: 486
[Token(Token = "0x20001E6")]
[RequireComponent(typeof(Light))]
[ExecuteInEditMode]
public class DeferredLight : MonoBehaviour
{
	// Token: 0x1700018F RID: 399
	// (get) Token: 0x06000D78 RID: 3448 RVA: 0x00005418 File Offset: 0x00003618
	[Token(Token = "0x1700018F")]
	public float fakerefl
	{
		[Token(Token = "0x6000D78")]
		[Address(RVA = "0x8A27B0", Offset = "0x8A17B0", VA = "0x1808A27B0")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x17000190 RID: 400
	// (get) Token: 0x06000D79 RID: 3449 RVA: 0x00005430 File Offset: 0x00003630
	[Token(Token = "0x17000190")]
	public Vector3 position
	{
		[Token(Token = "0x6000D79")]
		[Address(RVA = "0x2F84AC0", Offset = "0x2F83AC0", VA = "0x182F84AC0")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x17000191 RID: 401
	// (get) Token: 0x06000D7A RID: 3450 RVA: 0x00005448 File Offset: 0x00003648
	[Token(Token = "0x17000191")]
	public float intensity
	{
		[Token(Token = "0x6000D7A")]
		[Address(RVA = "0x2F84A80", Offset = "0x2F83A80", VA = "0x182F84A80")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x17000192 RID: 402
	// (get) Token: 0x06000D7B RID: 3451 RVA: 0x00005460 File Offset: 0x00003660
	[Token(Token = "0x17000192")]
	public Color color
	{
		[Token(Token = "0x6000D7B")]
		[Address(RVA = "0x2F84A40", Offset = "0x2F83A40", VA = "0x182F84A40")]
		get
		{
			return default(Color);
		}
	}

	// Token: 0x17000193 RID: 403
	// (get) Token: 0x06000D7C RID: 3452 RVA: 0x00005478 File Offset: 0x00003678
	[Token(Token = "0x17000193")]
	public float range
	{
		[Token(Token = "0x6000D7C")]
		[Address(RVA = "0x2F84B00", Offset = "0x2F83B00", VA = "0x182F84B00")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x17000194 RID: 404
	// (get) Token: 0x06000D7D RID: 3453 RVA: 0x00005490 File Offset: 0x00003690
	[Token(Token = "0x17000194")]
	public LightType type
	{
		[Token(Token = "0x6000D7D")]
		[Address(RVA = "0x2F84BB0", Offset = "0x2F83BB0", VA = "0x182F84BB0")]
		get
		{
			return default(LightType);
		}
	}

	// Token: 0x17000195 RID: 405
	// (get) Token: 0x06000D7E RID: 3454 RVA: 0x000054A8 File Offset: 0x000036A8
	[Token(Token = "0x17000195")]
	public float spotAngle
	{
		[Token(Token = "0x6000D7E")]
		[Address(RVA = "0x2F84B20", Offset = "0x2F83B20", VA = "0x182F84B20")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x17000196 RID: 406
	// (get) Token: 0x06000D7F RID: 3455 RVA: 0x000054C0 File Offset: 0x000036C0
	[Token(Token = "0x17000196")]
	public Vector3 spotDirection
	{
		[Token(Token = "0x6000D7F")]
		[Address(RVA = "0x2F84B50", Offset = "0x2F83B50", VA = "0x182F84B50")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x06000D80 RID: 3456 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D80")]
	[Address(RVA = "0x2F849C0", Offset = "0x2F839C0", VA = "0x182F849C0")]
	private void Start()
	{
	}

	// Token: 0x06000D81 RID: 3457 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D81")]
	[Address(RVA = "0x2F84800", Offset = "0x2F83800", VA = "0x182F84800")]
	private void OnEnable()
	{
	}

	// Token: 0x06000D82 RID: 3458 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D82")]
	[Address(RVA = "0x2F84710", Offset = "0x2F83710", VA = "0x182F84710")]
	private void OnDisable()
	{
	}

	// Token: 0x06000D83 RID: 3459 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D83")]
	[Address(RVA = "0x2F84A30", Offset = "0x2F83A30", VA = "0x182F84A30")]
	public DeferredLight()
	{
	}

	// Token: 0x04000C96 RID: 3222
	[Token(Token = "0x4000C96")]
	[FieldOffset(Offset = "0x20")]
	private Transform t;

	// Token: 0x04000C97 RID: 3223
	[Token(Token = "0x4000C97")]
	[FieldOffset(Offset = "0x28")]
	private Light l;

	// Token: 0x04000C98 RID: 3224
	[Token(Token = "0x4000C98")]
	[FieldOffset(Offset = "0x30")]
	[Range(0f, 1f)]
	public float fakeReflectedLight;

	// Token: 0x04000C99 RID: 3225
	[Token(Token = "0x4000C99")]
	[FieldOffset(Offset = "0x38")]
	public Texture2D spotlightProjectTexture;
}
