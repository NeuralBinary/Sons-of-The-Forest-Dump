using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000006 RID: 6
[Token(Token = "0x2000006")]
public class SimpleUnderwaterTrigger : MonoBehaviour, ISimpleUnderwaterData
{
	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000020 RID: 32 RVA: 0x000020FA File Offset: 0x000002FA
	[Token(Token = "0x17000005")]
	public Material WaterSurfaceMaterial
	{
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00", Slot = "4")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000021 RID: 33 RVA: 0x00002100 File Offset: 0x00000300
	[Token(Token = "0x17000006")]
	public float WaterHeight
	{
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x623B80", Offset = "0x622180", VA = "0x180623B80")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000022 RID: 34 RVA: 0x00002118 File Offset: 0x00000318
	[Token(Token = "0x17000007")]
	public bool UseWaterHeight
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x9DD210", Offset = "0x9DB810", VA = "0x1809DD210", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000023")]
	[Address(RVA = "0x3186C60", Offset = "0x3185260", VA = "0x183186C60")]
	public SimpleUnderwaterTrigger()
	{
	}

	// Token: 0x04000088 RID: 136
	[Token(Token = "0x4000088")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Material _WaterSurfaceMaterial;

	// Token: 0x04000089 RID: 137
	[Token(Token = "0x4000089")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _WaterHeight;

	// Token: 0x0400008A RID: 138
	[Token(Token = "0x400008A")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private bool _UseWaterHeight;
}
