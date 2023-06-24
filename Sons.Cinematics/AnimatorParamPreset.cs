using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
[Serializable]
public class AnimatorParamPreset
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x26000E0", Offset = "0x25FE6E0", VA = "0x1826000E0")]
	public void SetDefaultBool(bool defaultVal)
	{
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002054 File Offset: 0x00000254
	[Token(Token = "0x6000002")]
	[Address(RVA = "0x75A6A0", Offset = "0x758CA0", VA = "0x18075A6A0")]
	public bool GetBool()
	{
		return default(bool);
	}

	// Token: 0x06000003 RID: 3 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
	public string GetParamName()
	{
		return null;
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002070 File Offset: 0x00000270
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2D55300", Offset = "0x2D53900", VA = "0x182D55300")]
	public int GetParamId()
	{
		return 0;
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002088 File Offset: 0x00000288
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x26000D0", Offset = "0x25FE6D0", VA = "0x1826000D0")]
	public bool GetDefaultBool()
	{
		return default(bool);
	}

	// Token: 0x06000006 RID: 6 RVA: 0x000020A0 File Offset: 0x000002A0
	[Token(Token = "0x6000006")]
	[Address(RVA = "0x21FA640", Offset = "0x21F8C40", VA = "0x1821FA640")]
	public bool IsLayer()
	{
		return default(bool);
	}

	// Token: 0x06000007 RID: 7 RVA: 0x000020B8 File Offset: 0x000002B8
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
	public int GetLayerId()
	{
		return 0;
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x9D27D0", Offset = "0x9D0DD0", VA = "0x1809D27D0")]
	public AnimatorParamPreset()
	{
	}

	// Token: 0x04000001 RID: 1
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private string _param;

	// Token: 0x04000002 RID: 2
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool _boolValue;

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x19")]
	private bool _defaultBool;

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x1C")]
	private int _cachedId;

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int _layerIndex;

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private bool _layer;
}
