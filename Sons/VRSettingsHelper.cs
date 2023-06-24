using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002B1 RID: 689
[Token(Token = "0x20002B1")]
public class VRSettingsHelper : MonoBehaviour
{
	// Token: 0x0600123B RID: 4667 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600123B")]
	[Address(RVA = "0x31D6760", Offset = "0x31D4D60", VA = "0x1831D6760")]
	private void OnValidate()
	{
	}

	// Token: 0x0600123C RID: 4668 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600123C")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void Update()
	{
	}

	// Token: 0x0600123D RID: 4669 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600123D")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void RefreshValues()
	{
	}

	// Token: 0x0600123E RID: 4670 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600123E")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public VRSettingsHelper()
	{
	}

	// Token: 0x04001212 RID: 4626
	[Token(Token = "0x4001212")]
	[FieldOffset(Offset = "0x20")]
	public bool AllowEdits;

	// Token: 0x04001213 RID: 4627
	[Token(Token = "0x4001213")]
	[FieldOffset(Offset = "0x21")]
	public bool VREnabled;

	// Token: 0x04001214 RID: 4628
	[Token(Token = "0x4001214")]
	[FieldOffset(Offset = "0x24")]
	public int EyeTextureHeight;

	// Token: 0x04001215 RID: 4629
	[Token(Token = "0x4001215")]
	[FieldOffset(Offset = "0x28")]
	public int EyeTextureWidth;

	// Token: 0x04001216 RID: 4630
	[Token(Token = "0x4001216")]
	[FieldOffset(Offset = "0x2C")]
	public bool IsDeviceActive;

	// Token: 0x04001217 RID: 4631
	[Token(Token = "0x4001217")]
	[FieldOffset(Offset = "0x30")]
	public string LoadedDeviceName;

	// Token: 0x04001218 RID: 4632
	[Token(Token = "0x4001218")]
	[FieldOffset(Offset = "0x38")]
	public float RenderScale;

	// Token: 0x04001219 RID: 4633
	[Token(Token = "0x4001219")]
	[FieldOffset(Offset = "0x3C")]
	public float RenderViewportScale;

	// Token: 0x0400121A RID: 4634
	[Token(Token = "0x400121A")]
	[FieldOffset(Offset = "0x40")]
	public bool ShowDeviceView;

	// Token: 0x0400121B RID: 4635
	[Token(Token = "0x400121B")]
	[FieldOffset(Offset = "0x48")]
	public string[] SupportedDevices;
}
