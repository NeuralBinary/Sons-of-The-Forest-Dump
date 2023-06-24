using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000244 RID: 580
[Token(Token = "0x2000244")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class PreClamp : MonoBehaviour
{
	// Token: 0x06001065 RID: 4197 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001065")]
	[Address(RVA = "0x37379E0", Offset = "0x3735FE0", VA = "0x1837379E0")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	// Token: 0x06001066 RID: 4198 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001066")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public PreClamp()
	{
	}

	// Token: 0x04000F50 RID: 3920
	[Token(Token = "0x4000F50")]
	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public Shader shader;

	// Token: 0x04000F51 RID: 3921
	[Token(Token = "0x4000F51")]
	[FieldOffset(Offset = "0x28")]
	private Material material;
}
