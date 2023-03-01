using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002DA RID: 730
[Token(Token = "0x20002DA")]
[ExecuteInEditMode]
public class GrassCut4 : MonoBehaviour
{
	// Token: 0x060012C8 RID: 4808 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012C8")]
	[Address(RVA = "0x2B83C40", Offset = "0x2B82C40", VA = "0x182B83C40")]
	private void Start()
	{
	}

	// Token: 0x060012C9 RID: 4809 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012C9")]
	[Address(RVA = "0x2B83F90", Offset = "0x2B82F90", VA = "0x182B83F90")]
	public void Update()
	{
	}

	// Token: 0x060012CA RID: 4810 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012CA")]
	[Address(RVA = "0x2B84460", Offset = "0x2B83460", VA = "0x182B84460")]
	public GrassCut4()
	{
	}

	// Token: 0x040012C0 RID: 4800
	[Token(Token = "0x40012C0")]
	[FieldOffset(Offset = "0x0")]
	private static Vector2 patch;

	// Token: 0x040012C1 RID: 4801
	[Token(Token = "0x40012C1")]
	[FieldOffset(Offset = "0x8")]
	private static Vector3 size;

	// Token: 0x040012C2 RID: 4802
	[Token(Token = "0x40012C2")]
	[FieldOffset(Offset = "0x14")]
	private static Vector3 on;

	// Token: 0x040012C3 RID: 4803
	[Token(Token = "0x40012C3")]
	[FieldOffset(Offset = "0x20")]
	private static Vector3 inside;

	// Token: 0x040012C4 RID: 4804
	[Token(Token = "0x40012C4")]
	[FieldOffset(Offset = "0x20")]
	private GrassCut4.Layer[] layers;

	// Token: 0x040012C5 RID: 4805
	[Token(Token = "0x40012C5")]
	[FieldOffset(Offset = "0x28")]
	private int detailRes;

	// Token: 0x040012C6 RID: 4806
	[Token(Token = "0x40012C6")]
	[FieldOffset(Offset = "0x2C")]
	private int radio;

	// Token: 0x040012C7 RID: 4807
	[Token(Token = "0x40012C7")]
	[FieldOffset(Offset = "0x30")]
	private int numDetails;

	// Token: 0x040012C8 RID: 4808
	[Token(Token = "0x40012C8")]
	[FieldOffset(Offset = "0x34")]
	private int ammount;

	// Token: 0x020002DB RID: 731
	[Token(Token = "0x20002DB")]
	protected class Layer
	{
		// Token: 0x060012CC RID: 4812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012CC")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public Layer()
		{
		}

		// Token: 0x040012C9 RID: 4809
		[Token(Token = "0x40012C9")]
		[FieldOffset(Offset = "0x10")]
		public int[,] detailLayer;
	}
}
