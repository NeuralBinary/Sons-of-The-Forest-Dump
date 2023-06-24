using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000194 RID: 404
	[Token(Token = "0x2000194")]
	public class OBJMaterial : GenericMaterial
	{
		// Token: 0x06000B14 RID: 2836 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B14")]
		[Address(RVA = "0x200AA30", Offset = "0x2009030", VA = "0x18200AA30")]
		public OBJMaterial()
		{
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x000082AC File Offset: 0x000064AC
		// (set) Token: 0x06000B16 RID: 2838 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001F8")]
		public override Vector3f DiffuseColor
		{
			[Token(Token = "0x6000B15")]
			[Address(RVA = "0x200AB40", Offset = "0x2009140", VA = "0x18200AB40", Slot = "4")]
			get
			{
				return default(Vector3f);
			}
			[Token(Token = "0x6000B16")]
			[Address(RVA = "0x200AC50", Offset = "0x2009250", VA = "0x18200AC50", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x000082C4 File Offset: 0x000064C4
		// (set) Token: 0x06000B18 RID: 2840 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001F9")]
		public override float Alpha
		{
			[Token(Token = "0x6000B17")]
			[Address(RVA = "0x200AC60", Offset = "0x2009260", VA = "0x18200AC60", Slot = "6")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000B18")]
			[Address(RVA = "0x200ACE0", Offset = "0x20092E0", VA = "0x18200ACE0", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x04000644 RID: 1604
		[Token(Token = "0x4000644")]
		[FieldOffset(Offset = "0x20")]
		public Vector3f Ka;

		// Token: 0x04000645 RID: 1605
		[Token(Token = "0x4000645")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3f Kd;

		// Token: 0x04000646 RID: 1606
		[Token(Token = "0x4000646")]
		[FieldOffset(Offset = "0x38")]
		public Vector3f Ks;

		// Token: 0x04000647 RID: 1607
		[Token(Token = "0x4000647")]
		[FieldOffset(Offset = "0x44")]
		public Vector3f Ke;

		// Token: 0x04000648 RID: 1608
		[Token(Token = "0x4000648")]
		[FieldOffset(Offset = "0x50")]
		public Vector3f Tf;

		// Token: 0x04000649 RID: 1609
		[Token(Token = "0x4000649")]
		[FieldOffset(Offset = "0x5C")]
		public int illum;

		// Token: 0x0400064A RID: 1610
		[Token(Token = "0x400064A")]
		[FieldOffset(Offset = "0x60")]
		public float d;

		// Token: 0x0400064B RID: 1611
		[Token(Token = "0x400064B")]
		[FieldOffset(Offset = "0x64")]
		public float Ns;

		// Token: 0x0400064C RID: 1612
		[Token(Token = "0x400064C")]
		[FieldOffset(Offset = "0x68")]
		public float sharpness;

		// Token: 0x0400064D RID: 1613
		[Token(Token = "0x400064D")]
		[FieldOffset(Offset = "0x6C")]
		public float Ni;

		// Token: 0x0400064E RID: 1614
		[Token(Token = "0x400064E")]
		[FieldOffset(Offset = "0x70")]
		public string map_Ka;

		// Token: 0x0400064F RID: 1615
		[Token(Token = "0x400064F")]
		[FieldOffset(Offset = "0x78")]
		public string map_Kd;

		// Token: 0x04000650 RID: 1616
		[Token(Token = "0x4000650")]
		[FieldOffset(Offset = "0x80")]
		public string map_Ks;

		// Token: 0x04000651 RID: 1617
		[Token(Token = "0x4000651")]
		[FieldOffset(Offset = "0x88")]
		public string map_Ke;

		// Token: 0x04000652 RID: 1618
		[Token(Token = "0x4000652")]
		[FieldOffset(Offset = "0x90")]
		public string map_d;

		// Token: 0x04000653 RID: 1619
		[Token(Token = "0x4000653")]
		[FieldOffset(Offset = "0x98")]
		public string map_Ns;

		// Token: 0x04000654 RID: 1620
		[Token(Token = "0x4000654")]
		[FieldOffset(Offset = "0xA0")]
		public string bump;

		// Token: 0x04000655 RID: 1621
		[Token(Token = "0x4000655")]
		[FieldOffset(Offset = "0xA8")]
		public string disp;

		// Token: 0x04000656 RID: 1622
		[Token(Token = "0x4000656")]
		[FieldOffset(Offset = "0xB0")]
		public string decal;

		// Token: 0x04000657 RID: 1623
		[Token(Token = "0x4000657")]
		[FieldOffset(Offset = "0xB8")]
		public string refl;
	}
}
