using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002A8 RID: 680
[Token(Token = "0x20002A8")]
public class VRFlareController : MonoBehaviour
{
	// Token: 0x0600120F RID: 4623 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600120F")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void OnEnable()
	{
	}

	// Token: 0x06001210 RID: 4624 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001210")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void OnDisable()
	{
	}

	// Token: 0x06001211 RID: 4625 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001211")]
	[Address(RVA = "0x31D4540", Offset = "0x31D2B40", VA = "0x1831D4540")]
	public void setLit()
	{
	}

	// Token: 0x06001212 RID: 4626 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001212")]
	[Address(RVA = "0x31D4700", Offset = "0x31D2D00", VA = "0x1831D4700")]
	public void setUnlit()
	{
	}

	// Token: 0x06001213 RID: 4627 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001213")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public VRFlareController()
	{
	}

	// Token: 0x040011E1 RID: 4577
	[Token(Token = "0x40011E1")]
	[FieldOffset(Offset = "0x20")]
	public GameObject CapVR;

	// Token: 0x040011E2 RID: 4578
	[Token(Token = "0x40011E2")]
	[FieldOffset(Offset = "0x28")]
	public GameObject CapRegular;

	// Token: 0x040011E3 RID: 4579
	[Token(Token = "0x40011E3")]
	[FieldOffset(Offset = "0x30")]
	public Renderer _flareBody;

	// Token: 0x040011E4 RID: 4580
	[Token(Token = "0x40011E4")]
	[FieldOffset(Offset = "0x38")]
	public Transform restTransform;

	// Token: 0x040011E5 RID: 4581
	[Token(Token = "0x40011E5")]
	[FieldOffset(Offset = "0x40")]
	public GameObject _flareLight;

	// Token: 0x040011E6 RID: 4582
	[Token(Token = "0x40011E6")]
	[FieldOffset(Offset = "0x48")]
	public Material _litMat;

	// Token: 0x040011E7 RID: 4583
	[Token(Token = "0x40011E7")]
	[FieldOffset(Offset = "0x50")]
	public Material _unlitMat;

	// Token: 0x040011E8 RID: 4584
	[Token(Token = "0x40011E8")]
	[FieldOffset(Offset = "0x58")]
	private float prevHoverRadius;
}
