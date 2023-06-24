using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000214 RID: 532
[Token(Token = "0x2000214")]
public class LoadIcon : MonoBehaviour
{
	// Token: 0x170001A4 RID: 420
	// (get) Token: 0x06000E77 RID: 3703 RVA: 0x00005778 File Offset: 0x00003978
	[Token(Token = "0x170001A4")]
	private float wm
	{
		[Token(Token = "0x6000E77")]
		[Address(RVA = "0x37195B0", Offset = "0x3717BB0", VA = "0x1837195B0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170001A5 RID: 421
	// (get) Token: 0x06000E78 RID: 3704 RVA: 0x00005790 File Offset: 0x00003990
	[Token(Token = "0x170001A5")]
	private float hm
	{
		[Token(Token = "0x6000E78")]
		[Address(RVA = "0x3719610", Offset = "0x3717C10", VA = "0x183719610")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06000E79 RID: 3705 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E79")]
	[Address(RVA = "0x3719670", Offset = "0x3717C70", VA = "0x183719670")]
	private void OnGUI()
	{
	}

	// Token: 0x06000E7A RID: 3706 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E7A")]
	[Address(RVA = "0x3719680", Offset = "0x3717C80", VA = "0x183719680")]
	private void DrawLoader()
	{
	}

	// Token: 0x06000E7B RID: 3707 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E7B")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public LoadIcon()
	{
	}

	// Token: 0x04000D64 RID: 3428
	[Token(Token = "0x4000D64")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Texture2D texture_Loader;
}
