using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001E5 RID: 485
[Token(Token = "0x20001E5")]
[ExecuteInEditMode]
[RequireComponent(typeof(Light))]
public class DeferredLight : MonoBehaviour
{
	// Token: 0x17000198 RID: 408
	// (get) Token: 0x06000DD3 RID: 3539 RVA: 0x00005658 File Offset: 0x00003858
	[Token(Token = "0x17000198")]
	public float fakerefl
	{
		[Token(Token = "0x6000DD3")]
		[Address(RVA = "0x9D9860", Offset = "0x9D7E60", VA = "0x1809D9860")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000199 RID: 409
	// (get) Token: 0x06000DD4 RID: 3540 RVA: 0x00005670 File Offset: 0x00003870
	[Token(Token = "0x17000199")]
	public Vector3 position
	{
		[Token(Token = "0x6000DD4")]
		[Address(RVA = "0x370B4D0", Offset = "0x3709AD0", VA = "0x18370B4D0")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x1700019A RID: 410
	// (get) Token: 0x06000DD5 RID: 3541 RVA: 0x00005688 File Offset: 0x00003888
	[Token(Token = "0x1700019A")]
	public float intensity
	{
		[Token(Token = "0x6000DD5")]
		[Address(RVA = "0x370B560", Offset = "0x3709B60", VA = "0x18370B560")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700019B RID: 411
	// (get) Token: 0x06000DD6 RID: 3542 RVA: 0x000056A0 File Offset: 0x000038A0
	[Token(Token = "0x1700019B")]
	public Color color
	{
		[Token(Token = "0x6000DD6")]
		[Address(RVA = "0x370B5E0", Offset = "0x3709BE0", VA = "0x18370B5E0")]
		get
		{
			return default(Color);
		}
	}

	// Token: 0x1700019C RID: 412
	// (get) Token: 0x06000DD7 RID: 3543 RVA: 0x000056B8 File Offset: 0x000038B8
	[Token(Token = "0x1700019C")]
	public float range
	{
		[Token(Token = "0x6000DD7")]
		[Address(RVA = "0x370B660", Offset = "0x3709C60", VA = "0x18370B660")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700019D RID: 413
	// (get) Token: 0x06000DD8 RID: 3544 RVA: 0x000056D0 File Offset: 0x000038D0
	[Token(Token = "0x1700019D")]
	public LightType type
	{
		[Token(Token = "0x6000DD8")]
		[Address(RVA = "0x370B6C0", Offset = "0x3709CC0", VA = "0x18370B6C0")]
		get
		{
			return LightType.Spot;
		}
	}

	// Token: 0x1700019E RID: 414
	// (get) Token: 0x06000DD9 RID: 3545 RVA: 0x000056E8 File Offset: 0x000038E8
	[Token(Token = "0x1700019E")]
	public float spotAngle
	{
		[Token(Token = "0x6000DD9")]
		[Address(RVA = "0x370B720", Offset = "0x3709D20", VA = "0x18370B720")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700019F RID: 415
	// (get) Token: 0x06000DDA RID: 3546 RVA: 0x00005700 File Offset: 0x00003900
	[Token(Token = "0x1700019F")]
	public Vector3 spotDirection
	{
		[Token(Token = "0x6000DDA")]
		[Address(RVA = "0x370B790", Offset = "0x3709D90", VA = "0x18370B790")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x06000DDB RID: 3547 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DDB")]
	[Address(RVA = "0x370B870", Offset = "0x3709E70", VA = "0x18370B870")]
	private void Start()
	{
	}

	// Token: 0x06000DDC RID: 3548 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DDC")]
	[Address(RVA = "0x370B9A0", Offset = "0x3709FA0", VA = "0x18370B9A0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000DDD RID: 3549 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DDD")]
	[Address(RVA = "0x370B9B0", Offset = "0x3709FB0", VA = "0x18370B9B0")]
	private void OnDisable()
	{
	}

	// Token: 0x06000DDE RID: 3550 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DDE")]
	[Address(RVA = "0x370BB10", Offset = "0x370A110", VA = "0x18370BB10")]
	public DeferredLight()
	{
	}

	// Token: 0x04000CC5 RID: 3269
	[Token(Token = "0x4000CC5")]
	[FieldOffset(Offset = "0x20")]
	private Transform t;

	// Token: 0x04000CC6 RID: 3270
	[Token(Token = "0x4000CC6")]
	[FieldOffset(Offset = "0x28")]
	private Light l;

	// Token: 0x04000CC7 RID: 3271
	[Token(Token = "0x4000CC7")]
	[FieldOffset(Offset = "0x30")]
	[Range(0f, 1f)]
	public float fakeReflectedLight;

	// Token: 0x04000CC8 RID: 3272
	[Token(Token = "0x4000CC8")]
	[FieldOffset(Offset = "0x38")]
	public Texture2D spotlightProjectTexture;
}
