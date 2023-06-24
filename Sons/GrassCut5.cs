using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002D0 RID: 720
[Token(Token = "0x20002D0")]
[ExecuteInEditMode]
public class GrassCut5 : MonoBehaviour
{
	// Token: 0x06001303 RID: 4867 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001303")]
	[Address(RVA = "0x31EAB60", Offset = "0x31E9160", VA = "0x1831EAB60")]
	private void Start()
	{
	}

	// Token: 0x06001304 RID: 4868 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001304")]
	[Address(RVA = "0x31EB330", Offset = "0x31E9930", VA = "0x1831EB330")]
	public void Update()
	{
	}

	// Token: 0x06001305 RID: 4869 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001305")]
	[Address(RVA = "0x31EBB20", Offset = "0x31EA120", VA = "0x1831EBB20")]
	public GrassCut5()
	{
	}

	// Token: 0x040012F2 RID: 4850
	[Token(Token = "0x40012F2")]
	[FieldOffset(Offset = "0x0")]
	private static Vector2 patch;

	// Token: 0x040012F3 RID: 4851
	[Token(Token = "0x40012F3")]
	[FieldOffset(Offset = "0x8")]
	private static Vector3 size;

	// Token: 0x040012F4 RID: 4852
	[Token(Token = "0x40012F4")]
	[FieldOffset(Offset = "0x14")]
	private static Vector3 on;

	// Token: 0x040012F5 RID: 4853
	[Token(Token = "0x40012F5")]
	[FieldOffset(Offset = "0x20")]
	private static Vector3 inside;

	// Token: 0x040012F6 RID: 4854
	[Token(Token = "0x40012F6")]
	[FieldOffset(Offset = "0x20")]
	private GrassCut5.Layer[] layers;

	// Token: 0x040012F7 RID: 4855
	[Token(Token = "0x40012F7")]
	[FieldOffset(Offset = "0x28")]
	private int detailRes;

	// Token: 0x040012F8 RID: 4856
	[Token(Token = "0x40012F8")]
	[FieldOffset(Offset = "0x2C")]
	private int radio;

	// Token: 0x040012F9 RID: 4857
	[Token(Token = "0x40012F9")]
	[FieldOffset(Offset = "0x30")]
	private int numDetails;

	// Token: 0x040012FA RID: 4858
	[Token(Token = "0x40012FA")]
	[FieldOffset(Offset = "0x34")]
	private int ammount;

	// Token: 0x020002D1 RID: 721
	[Token(Token = "0x20002D1")]
	protected class Layer
	{
		// Token: 0x06001307 RID: 4871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001307")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public Layer()
		{
		}

		// Token: 0x040012FB RID: 4859
		[Token(Token = "0x40012FB")]
		[FieldOffset(Offset = "0x10")]
		public int[,] detailLayer;
	}
}
