using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000247 RID: 583
[Token(Token = "0x2000247")]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class PreClamp : MonoBehaviour
{
	// Token: 0x0600100F RID: 4111 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600100F")]
	[Address(RVA = "0x2FB5910", Offset = "0x2FB4910", VA = "0x182FB5910")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	// Token: 0x06001010 RID: 4112 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001010")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public PreClamp()
	{
	}

	// Token: 0x04000F25 RID: 3877
	[Token(Token = "0x4000F25")]
	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public Shader shader;

	// Token: 0x04000F26 RID: 3878
	[Token(Token = "0x4000F26")]
	[FieldOffset(Offset = "0x28")]
	private Material material;
}
