using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002BD RID: 701
[Token(Token = "0x20002BD")]
public class VRSettingsHelper : MonoBehaviour
{
	// Token: 0x06001206 RID: 4614 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001206")]
	[Address(RVA = "0x2B8ABD0", Offset = "0x2B89BD0", VA = "0x182B8ABD0")]
	private void OnValidate()
	{
	}

	// Token: 0x06001207 RID: 4615 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001207")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void Update()
	{
	}

	// Token: 0x06001208 RID: 4616 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001208")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void RefreshValues()
	{
	}

	// Token: 0x06001209 RID: 4617 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001209")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public VRSettingsHelper()
	{
	}

	// Token: 0x040011EB RID: 4587
	[Token(Token = "0x40011EB")]
	[FieldOffset(Offset = "0x20")]
	public bool AllowEdits;

	// Token: 0x040011EC RID: 4588
	[Token(Token = "0x40011EC")]
	[FieldOffset(Offset = "0x21")]
	public bool VREnabled;

	// Token: 0x040011ED RID: 4589
	[Token(Token = "0x40011ED")]
	[FieldOffset(Offset = "0x24")]
	public int EyeTextureHeight;

	// Token: 0x040011EE RID: 4590
	[Token(Token = "0x40011EE")]
	[FieldOffset(Offset = "0x28")]
	public int EyeTextureWidth;

	// Token: 0x040011EF RID: 4591
	[Token(Token = "0x40011EF")]
	[FieldOffset(Offset = "0x2C")]
	public bool IsDeviceActive;

	// Token: 0x040011F0 RID: 4592
	[Token(Token = "0x40011F0")]
	[FieldOffset(Offset = "0x30")]
	public string LoadedDeviceName;

	// Token: 0x040011F1 RID: 4593
	[Token(Token = "0x40011F1")]
	[FieldOffset(Offset = "0x38")]
	public float RenderScale;

	// Token: 0x040011F2 RID: 4594
	[Token(Token = "0x40011F2")]
	[FieldOffset(Offset = "0x3C")]
	public float RenderViewportScale;

	// Token: 0x040011F3 RID: 4595
	[Token(Token = "0x40011F3")]
	[FieldOffset(Offset = "0x40")]
	public bool ShowDeviceView;

	// Token: 0x040011F4 RID: 4596
	[Token(Token = "0x40011F4")]
	[FieldOffset(Offset = "0x48")]
	public string[] SupportedDevices;
}
