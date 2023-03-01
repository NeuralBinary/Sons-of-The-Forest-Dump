using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002DC RID: 732
[Token(Token = "0x20002DC")]
[ExecuteInEditMode]
public class GrassCut5 : MonoBehaviour
{
	// Token: 0x060012CD RID: 4813 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012CD")]
	[Address(RVA = "0x2B84480", Offset = "0x2B83480", VA = "0x182B84480")]
	private void Start()
	{
	}

	// Token: 0x060012CE RID: 4814 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012CE")]
	[Address(RVA = "0x2B847D0", Offset = "0x2B837D0", VA = "0x182B847D0")]
	public void Update()
	{
	}

	// Token: 0x060012CF RID: 4815 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012CF")]
	[Address(RVA = "0x2B84CD0", Offset = "0x2B83CD0", VA = "0x182B84CD0")]
	public GrassCut5()
	{
	}

	// Token: 0x040012CA RID: 4810
	[Token(Token = "0x40012CA")]
	[FieldOffset(Offset = "0x0")]
	private static Vector2 patch;

	// Token: 0x040012CB RID: 4811
	[Token(Token = "0x40012CB")]
	[FieldOffset(Offset = "0x8")]
	private static Vector3 size;

	// Token: 0x040012CC RID: 4812
	[Token(Token = "0x40012CC")]
	[FieldOffset(Offset = "0x14")]
	private static Vector3 on;

	// Token: 0x040012CD RID: 4813
	[Token(Token = "0x40012CD")]
	[FieldOffset(Offset = "0x20")]
	private static Vector3 inside;

	// Token: 0x040012CE RID: 4814
	[Token(Token = "0x40012CE")]
	[FieldOffset(Offset = "0x20")]
	private GrassCut5.Layer[] layers;

	// Token: 0x040012CF RID: 4815
	[Token(Token = "0x40012CF")]
	[FieldOffset(Offset = "0x28")]
	private int detailRes;

	// Token: 0x040012D0 RID: 4816
	[Token(Token = "0x40012D0")]
	[FieldOffset(Offset = "0x2C")]
	private int radio;

	// Token: 0x040012D1 RID: 4817
	[Token(Token = "0x40012D1")]
	[FieldOffset(Offset = "0x30")]
	private int numDetails;

	// Token: 0x040012D2 RID: 4818
	[Token(Token = "0x40012D2")]
	[FieldOffset(Offset = "0x34")]
	private int ammount;

	// Token: 0x020002DD RID: 733
	[Token(Token = "0x20002DD")]
	protected class Layer
	{
		// Token: 0x060012D1 RID: 4817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012D1")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public Layer()
		{
		}

		// Token: 0x040012D3 RID: 4819
		[Token(Token = "0x40012D3")]
		[FieldOffset(Offset = "0x10")]
		public int[,] detailLayer;
	}
}
