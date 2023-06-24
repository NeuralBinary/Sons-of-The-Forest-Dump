using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002CE RID: 718
[Token(Token = "0x20002CE")]
[ExecuteInEditMode]
public class GrassCut4 : MonoBehaviour
{
	// Token: 0x060012FE RID: 4862 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012FE")]
	[Address(RVA = "0x31E9BE0", Offset = "0x31E81E0", VA = "0x1831E9BE0")]
	private void Start()
	{
	}

	// Token: 0x060012FF RID: 4863 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012FF")]
	[Address(RVA = "0x31EA3B0", Offset = "0x31E89B0", VA = "0x1831EA3B0")]
	public void Update()
	{
	}

	// Token: 0x06001300 RID: 4864 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001300")]
	[Address(RVA = "0x31EAB10", Offset = "0x31E9110", VA = "0x1831EAB10")]
	public GrassCut4()
	{
	}

	// Token: 0x040012E8 RID: 4840
	[Token(Token = "0x40012E8")]
	[FieldOffset(Offset = "0x0")]
	private static Vector2 patch;

	// Token: 0x040012E9 RID: 4841
	[Token(Token = "0x40012E9")]
	[FieldOffset(Offset = "0x8")]
	private static Vector3 size;

	// Token: 0x040012EA RID: 4842
	[Token(Token = "0x40012EA")]
	[FieldOffset(Offset = "0x14")]
	private static Vector3 on;

	// Token: 0x040012EB RID: 4843
	[Token(Token = "0x40012EB")]
	[FieldOffset(Offset = "0x20")]
	private static Vector3 inside;

	// Token: 0x040012EC RID: 4844
	[Token(Token = "0x40012EC")]
	[FieldOffset(Offset = "0x20")]
	private GrassCut4.Layer[] layers;

	// Token: 0x040012ED RID: 4845
	[Token(Token = "0x40012ED")]
	[FieldOffset(Offset = "0x28")]
	private int detailRes;

	// Token: 0x040012EE RID: 4846
	[Token(Token = "0x40012EE")]
	[FieldOffset(Offset = "0x2C")]
	private int radio;

	// Token: 0x040012EF RID: 4847
	[Token(Token = "0x40012EF")]
	[FieldOffset(Offset = "0x30")]
	private int numDetails;

	// Token: 0x040012F0 RID: 4848
	[Token(Token = "0x40012F0")]
	[FieldOffset(Offset = "0x34")]
	private int ammount;

	// Token: 0x020002CF RID: 719
	[Token(Token = "0x20002CF")]
	protected class Layer
	{
		// Token: 0x06001302 RID: 4866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001302")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public Layer()
		{
		}

		// Token: 0x040012F1 RID: 4849
		[Token(Token = "0x40012F1")]
		[FieldOffset(Offset = "0x10")]
		public int[,] detailLayer;
	}
}
